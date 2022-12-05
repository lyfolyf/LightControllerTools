using GL.Kit.Log;
using GL.Kit.Net;
using GL.Kit.Net.Sockets;
using GL.Kit.Serialization;
using LightControllerSDK;
using LightControllerSDK.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace LightControllerTools
{
    public partial class Form1 : Form
    {
        readonly string configfilename = PathUtils.CurrentDirectory + "controller.config";
        LightControllerFactory fac;
        ComLightControllerInfo controllerInfo;
        List<UcLightSettings> settings;

        IGLogger log;
        readonly ISerializerToFile serializer;

        ILightController controller;

        public Form1()
        {
            InitializeComponent();

            InitLog();

            serializer = new XmlSerializer();
        }

        readonly Color DebugColor = Color.FromArgb(192, 192, 192);
        readonly Color InfoColor = SystemColors.WindowText;
        readonly Color WarnColor = Color.FromArgb(192, 192, 0);
        readonly Color ErrorColor = Color.Red;

        void InitLog()
        {
            DisplayAdapter displayAdapter = new DisplayAdapter(200, LogFormat.General);
            displayAdapter.ClearCurrent += () =>
            {
                rtbLog.AsyncAction((c) =>
                {
                    (c as RichTextBox).Clear();
                });
            };
            displayAdapter.NewLog += logInfo =>
            {
                AppendLog(logInfo, GetLogColor(logInfo.Level));
            };

            log = GLogger.CreateLog("log1", LogLevel.All, displayAdapter);

            Color GetLogColor(LogLevel level)
            {
                switch (level)
                {
                    case LogLevel.Debug: return DebugColor;
                    case LogLevel.Info: return InfoColor;
                    case LogLevel.Warn: return WarnColor;
                    case LogLevel.Error: return ErrorColor;
                    default: return InfoColor;
                }
            }

            void AppendLog(LogInfo log, Color color)
            {
                rtbLog.AsyncAction((c) =>
                {
                    RichTextBox rtb = c as RichTextBox;
                    rtb.AppendLine(log.ToString(LogFormat.General), color);
                    rtb.ScrollToCaret();
                });
            }
        }

        void InitUC()
        {
            settings = new List<UcLightSettings>();
            splitContainer1.Panel1.Controls.Clear();

            for (int i = 1, count = (int)nudChannelCount.Value; i <= count; i++)
            {
                UcLightSettings uc = new UcLightSettings
                {
                    Index = i,
                    Value = 0,
                    Dock = DockStyle.Top,
                    Enabled = false,
                    Text = "CH" + i.ToString(),
                };
                uc.ValueChanged += ucLightSettings_ValueChanged;

                splitContainer1.Panel1.Controls.Add(uc);
                uc.BringToFront();

                settings.Add(uc);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLightControllerBrand();

            LoadCom();
            LoadBaudRate();
            LoadDataBits();
            LoadParity();
            LoadStopBits();

            LoadConfig();
        }

        private void nudChannelCount_ValueChanged(object sender, EventArgs e)
        {
            InitUC();
        }

        #region 加载下拉框选项

        void LoadLightControllerBrand()
        {
            foreach (LightControllerBrand brand in Enum.GetValues(typeof(LightControllerBrand)))
            {
                cmbLightControllerBrand.Items.Add(brand);
            }
        }

        void LoadCom()
        {
            cmbCom.Items.Add("COM1");
            cmbCom.Items.Add("COM2");
            cmbCom.Items.Add("COM3");
            cmbCom.Items.Add("COM4");
        }

        void LoadBaudRate()
        {
            cmbBaudRate.Items.AddRange(new object[]
            {
                9600,
                19200,
                38400,
                115200
            });
        }

        void LoadDataBits()
        {
            cmbDataBits.Items.AddRange(new object[]
            {
                5,
                6,
                7,
                8
            });
        }

        void LoadParity()
        {
            foreach (Parity parity in Enum.GetValues(typeof(Parity)))
            {
                cmbParity.Items.Add(parity);
            }
        }

        void LoadStopBits()
        {
            cmbStopBits.Items.AddRange(new object[]
            {
                1,
                1.5,
                2
            });
        }

        StopBits getStopBits()
        {
            if (cmbStopBits.SelectedIndex == 0)
                return StopBits.One;
            else if (cmbStopBits.SelectedIndex == 1)
                return StopBits.OnePointFive;
            else if (cmbStopBits.SelectedIndex == 2)
                return StopBits.Two;
            else
                return StopBits.None;
        }

        void setStopBits(StopBits stopBits)
        {
            if (stopBits == StopBits.One)
                cmbStopBits.SelectedIndex = 0;
            else if (stopBits == StopBits.OnePointFive)
                cmbStopBits.SelectedIndex = 1;
            else if (stopBits == StopBits.Two)
                cmbStopBits.SelectedIndex = 2;
        }

        #endregion

        #region 加载配置

        void LoadConfig()
        {
            controllerInfo = serializer.DeserializeFromFile<ComLightControllerInfo>(configfilename);

            if (controllerInfo == null)
            {
                controllerInfo = new ComLightControllerInfo
                {
                    CommProtocol = CommProtocol.TCP,
                    ChannelCount = 8
                };
            }

            cmbLightControllerBrand.SelectedItem = controllerInfo.Brand;
            nudChannelCount.Value = controllerInfo.ChannelCount;

            SetProtocol(controllerInfo.CommProtocol);

            if (controllerInfo.CommProtocol == CommProtocol.TCP)
            {
                if (controllerInfo.NetworkInfo != null)
                {
                    tbTcpIP.Text = controllerInfo.NetworkInfo.IP;
                    tbTcpPort.Text = controllerInfo.NetworkInfo.Port.ToString();
                }
            }
            else if (controllerInfo.CommProtocol == CommProtocol.UDP)
            {
                if (controllerInfo.NetworkInfo != null)
                {
                    tbUdpIP.Text = controllerInfo.NetworkInfo.IP;
                    tbUdpPort.Text = controllerInfo.NetworkInfo.Port.ToString();
                }
            }
            else if (controllerInfo.CommProtocol == CommProtocol.COM)
            {
                if (controllerInfo.SerialInfo != null)
                {
                    cmbCom.Text = controllerInfo.SerialInfo.PortName;
                    cmbBaudRate.SelectedItem = controllerInfo.SerialInfo.BaudRate;
                    cmbDataBits.SelectedItem = controllerInfo.SerialInfo.DataBits;
                    cmbParity.SelectedItem = controllerInfo.SerialInfo.Parity;
                    setStopBits(controllerInfo.SerialInfo.StopBits);
                }
            }
        }

        void buildData()
        {
            controllerInfo.Brand = (LightControllerBrand)cmbLightControllerBrand.SelectedItem;
            controllerInfo.ChannelCount = (int)nudChannelCount.Value;

            controllerInfo.CommProtocol = GetProtocol();

            if (controllerInfo.CommProtocol == CommProtocol.TCP)
            {
                controllerInfo.NetworkInfo = new NetworkInfo
                {
                    IP = tbTcpIP.Text,
                    Port = tbTcpPort.Text.Length > 0 ? int.Parse(tbTcpPort.Text) : 0
                };
            }
            else if (controllerInfo.CommProtocol == CommProtocol.UDP)
            {
                controllerInfo.NetworkInfo = new NetworkInfo
                {
                    IP = tbUdpIP.Text,
                    Port = tbUdpPort.Text.Length > 0 ? int.Parse(tbUdpPort.Text) : 0
                };
            }
            else
            {
                controllerInfo.SerialInfo = new SerialInfo
                {
                    PortName = cmbCom.Text,
                };
                if (cmbBaudRate.SelectedIndex > -1)
                    controllerInfo.SerialInfo.BaudRate = int.Parse(cmbBaudRate.Text);
                if (cmbDataBits.SelectedIndex > -1)
                    controllerInfo.SerialInfo.DataBits = int.Parse(cmbDataBits.Text);
                if (cmbParity.SelectedIndex > -1)
                    controllerInfo.SerialInfo.Parity = (Parity)cmbParity.SelectedItem;
                if (cmbStopBits.SelectedIndex > -1)
                    controllerInfo.SerialInfo.StopBits = getStopBits();
            }
        }

        #endregion

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!check()) return;

            buildData();

            controller = ControllerCreater.Create(controllerInfo, log);
            controller.ChannelCountChanged += Controller_ChannelCountChanged;
            controller.Connect();

            controller.SetLightness(1, 50);

            int a = controller.GetLightness(1);

            btnConnect.Enabled = false;
            btnDisconnect.Enabled = true;
            gbControllerInfo.Enabled = false;

            if (controllerInfo.CommProtocol == CommProtocol.TCP)
            {
                btnSearch.Enabled = false;
            }
            else if (controllerInfo.CommProtocol == CommProtocol.UDP)
            {
                btnSetUdpIP.Enabled = true;
            }

            controller.OnMultiChannel();
            int[] lightnesses = controller.GetMultiLightness();

            for (int i = 0; i < controller.ChannelCount; i++)
            {
                settings[i].MaxValue = controller.MaxLightness;
                settings[i].Enabled = true;

                settings[i].SetInitialValue(lightnesses[i]);
            }
        }

        private void Controller_ChannelCountChanged(object sender, EventArgs e)
        {
            controllerInfo.ChannelCount = controller.ChannelCount;
            nudChannelCount.Value = controller.ChannelCount;
        }

        private void btnDisconnect_Click(object sender, EventArgs e)
        {
            CloseController();
        }

        void CloseController()
        {
            controller.Disconnect();
            controller = null;

            btnConnect.Enabled = true;
            btnDisconnect.Enabled = false;
            gbControllerInfo.Enabled = true;

            if (controllerInfo.CommProtocol == CommProtocol.UDP)
            {
                btnSetUdpIP.Enabled = false;
            }

            settings.ForEach(uc => uc.Enabled = false);
        }

        // 设置亮度
        private void ucLightSettings_ValueChanged(object sender, EventArgs e)
        {
            UcLightSettings uc = sender as UcLightSettings;

            controller.SetLightness(uc.Index, uc.Value);
        }

        bool check()
        {
            bool result = cmbLightControllerBrand.CheckSelected("请选择光源控制器品牌");

            if (!result) return false;

            CommProtocol protocol = GetProtocol();

            if (protocol == CommProtocol.TCP)
            {
                return tbTcpIP.CheckNotEmpty("请输入 IP 地址")
                    && tbTcpIP.CheckRegex(ComPattern.IpPattern, "无效的 IP 地址");
            }
            else if (protocol == CommProtocol.UDP)
            {
                return tbUdpIP.CheckNotEmpty("请输入 IP 地址")
                    && tbUdpIP.CheckRegex(ComPattern.IpPattern, "无效的 IP 地址");
            }
            else if (protocol == CommProtocol.COM)
            {
                return cmbCom.CheckSelected("请选择串口");
            }

            return true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (fac == null)
            {
                fac = new LightControllerFactory(log);
            }

            List<ILightController_Tcp> ctrls = fac.Search((LightControllerBrand)cmbLightControllerBrand.SelectedItem);

            if (ctrls.Count > 0)
            {
                tbTcpIP.Text = ctrls[0].NetworkInfo.IP;
                tbTcpPort.Text = ctrls[0].NetworkInfo.Port.ToString();

                controller = ctrls[0];
            }
        }

        private void btnSetTcpIP_Click(object sender, EventArgs e)
        {
            if (tbTcpIP.CheckNotEmpty("请输入 IP 地址")
                    && tbTcpIP.CheckRegex(ComPattern.IpPattern, "无效的 IP 地址"))
            {
                ((ILightController_Tcp)controller).SetIP(tbTcpIP.Text, tbTcpPort.Text.Length > 0 ? int.Parse(tbTcpPort.Text) : 0);

                CloseController();
            }
        }

        private void btnSetUdpIP_Click(object sender, EventArgs e)
        {
            if (tbUdpIP.CheckNotEmpty("请输入 IP 地址")
                    && tbUdpIP.CheckRegex(ComPattern.IpPattern, "无效的 IP 地址")
                    && tbUdpPort.CheckNotEmpty("请输入端口号")
                    && tbUdpPort.CheckIntRange(1, 65535, "无效的端口号"))
            {
                ((ILightController_Tcp)controller).SetIP(tbUdpIP.Text, int.Parse(tbUdpPort.Text));

                CloseController();
            }
        }

        private void tsmiClearLog_Click(object sender, EventArgs e)
        {
            rtbLog.Clear();
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (controller != null && controller.Connected)
                e.Cancel = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            buildData();

            serializer.SerializeToFile(controllerInfo, configfilename);
        }

        CommProtocol GetProtocol()
        {
            if (tabControl1.SelectedIndex == 0)
                return CommProtocol.TCP;
            else if (tabControl1.SelectedIndex == 1)
                return CommProtocol.UDP;
            else
                return CommProtocol.COM;
        }

        void SetProtocol(CommProtocol protocol)
        {
            if (protocol == CommProtocol.TCP)
                tabControl1.SelectedIndex = 0;
            else if (protocol == CommProtocol.UDP)
                tabControl1.SelectedIndex = 1;
            else
                tabControl1.SelectedIndex = 2;
        }
    }
}
