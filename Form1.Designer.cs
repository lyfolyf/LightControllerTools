namespace LightControllerTools
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.pageTCP = new System.Windows.Forms.TabPage();
            this.btnSetTcpIP = new System.Windows.Forms.Button();
            this.tbTcpPort = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbTcpIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pageUDP = new System.Windows.Forms.TabPage();
            this.btnSetUdpIP = new System.Windows.Forms.Button();
            this.tbUdpPort = new System.Windows.Forms.TextBox();
            this.tbUdpIP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pageCOM = new System.Windows.Forms.TabPage();
            this.cmbStopBits = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDataBits = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbBaudRate = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbParity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCom = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbControllerInfo = new System.Windows.Forms.GroupBox();
            this.nudChannelCount = new System.Windows.Forms.NumericUpDown();
            this.cmbLightControllerBrand = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiClearLog = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.pageTCP.SuspendLayout();
            this.pageUDP.SuspendLayout();
            this.pageCOM.SuspendLayout();
            this.gbControllerInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChannelCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnDisconnect);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Controls.Add(this.gbControllerInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(363, 753);
            this.panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.pageTCP);
            this.tabControl1.Controls.Add(this.pageUDP);
            this.tabControl1.Controls.Add(this.pageCOM);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(20, 170);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(321, 289);
            this.tabControl1.TabIndex = 17;
            this.tabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabControl1_Selecting);
            // 
            // pageTCP
            // 
            this.pageTCP.Controls.Add(this.btnSetTcpIP);
            this.pageTCP.Controls.Add(this.tbTcpPort);
            this.pageTCP.Controls.Add(this.btnSearch);
            this.pageTCP.Controls.Add(this.tbTcpIP);
            this.pageTCP.Controls.Add(this.label1);
            this.pageTCP.Controls.Add(this.label2);
            this.pageTCP.Location = new System.Drawing.Point(4, 27);
            this.pageTCP.Name = "pageTCP";
            this.pageTCP.Padding = new System.Windows.Forms.Padding(3);
            this.pageTCP.Size = new System.Drawing.Size(313, 258);
            this.pageTCP.TabIndex = 0;
            this.pageTCP.Text = "TCP";
            this.pageTCP.UseVisualStyleBackColor = true;
            // 
            // btnSetTcpIP
            // 
            this.btnSetTcpIP.Location = new System.Drawing.Point(177, 126);
            this.btnSetTcpIP.Name = "btnSetTcpIP";
            this.btnSetTcpIP.Size = new System.Drawing.Size(100, 40);
            this.btnSetTcpIP.TabIndex = 25;
            this.btnSetTcpIP.Text = "设置 IP";
            this.btnSetTcpIP.UseVisualStyleBackColor = true;
            this.btnSetTcpIP.Click += new System.EventHandler(this.btnSetTcpIP_Click);
            // 
            // tbTcpPort
            // 
            this.tbTcpPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTcpPort.Location = new System.Drawing.Point(127, 71);
            this.tbTcpPort.MaxLength = 5;
            this.tbTcpPort.Name = "tbTcpPort";
            this.tbTcpPort.Size = new System.Drawing.Size(150, 27);
            this.tbTcpPort.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(34, 126);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSearch.TabIndex = 16;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbTcpIP
            // 
            this.tbTcpIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTcpIP.Location = new System.Drawing.Point(127, 26);
            this.tbTcpIP.MaxLength = 15;
            this.tbTcpIP.Name = "tbTcpIP";
            this.tbTcpIP.Size = new System.Drawing.Size(150, 27);
            this.tbTcpIP.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "IP地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "端口号：";
            // 
            // pageUDP
            // 
            this.pageUDP.Controls.Add(this.btnSetUdpIP);
            this.pageUDP.Controls.Add(this.tbUdpPort);
            this.pageUDP.Controls.Add(this.tbUdpIP);
            this.pageUDP.Controls.Add(this.label9);
            this.pageUDP.Controls.Add(this.label10);
            this.pageUDP.Location = new System.Drawing.Point(4, 27);
            this.pageUDP.Name = "pageUDP";
            this.pageUDP.Padding = new System.Windows.Forms.Padding(3);
            this.pageUDP.Size = new System.Drawing.Size(313, 258);
            this.pageUDP.TabIndex = 1;
            this.pageUDP.Text = "UDP";
            this.pageUDP.UseVisualStyleBackColor = true;
            // 
            // btnSetUdpIP
            // 
            this.btnSetUdpIP.Enabled = false;
            this.btnSetUdpIP.Location = new System.Drawing.Point(177, 126);
            this.btnSetUdpIP.Name = "btnSetUdpIP";
            this.btnSetUdpIP.Size = new System.Drawing.Size(100, 40);
            this.btnSetUdpIP.TabIndex = 24;
            this.btnSetUdpIP.Text = "设置 IP";
            this.btnSetUdpIP.UseVisualStyleBackColor = true;
            this.btnSetUdpIP.Click += new System.EventHandler(this.btnSetUdpIP_Click);
            // 
            // tbUdpPort
            // 
            this.tbUdpPort.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUdpPort.Location = new System.Drawing.Point(127, 71);
            this.tbUdpPort.MaxLength = 5;
            this.tbUdpPort.Name = "tbUdpPort";
            this.tbUdpPort.Size = new System.Drawing.Size(150, 27);
            this.tbUdpPort.TabIndex = 23;
            // 
            // tbUdpIP
            // 
            this.tbUdpIP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUdpIP.Location = new System.Drawing.Point(127, 26);
            this.tbUdpIP.MaxLength = 15;
            this.tbUdpIP.Name = "tbUdpIP";
            this.tbUdpIP.Size = new System.Drawing.Size(150, 27);
            this.tbUdpIP.TabIndex = 22;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(31, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "IP地址：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(31, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "端口号：";
            // 
            // pageCOM
            // 
            this.pageCOM.Controls.Add(this.cmbStopBits);
            this.pageCOM.Controls.Add(this.label3);
            this.pageCOM.Controls.Add(this.cmbDataBits);
            this.pageCOM.Controls.Add(this.label6);
            this.pageCOM.Controls.Add(this.label7);
            this.pageCOM.Controls.Add(this.cmbBaudRate);
            this.pageCOM.Controls.Add(this.label4);
            this.pageCOM.Controls.Add(this.cmbParity);
            this.pageCOM.Controls.Add(this.label5);
            this.pageCOM.Controls.Add(this.cmbCom);
            this.pageCOM.Location = new System.Drawing.Point(4, 27);
            this.pageCOM.Name = "pageCOM";
            this.pageCOM.Size = new System.Drawing.Size(313, 258);
            this.pageCOM.TabIndex = 2;
            this.pageCOM.Text = "串口";
            this.pageCOM.UseVisualStyleBackColor = true;
            // 
            // cmbStopBits
            // 
            this.cmbStopBits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbStopBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStopBits.FormattingEnabled = true;
            this.cmbStopBits.Location = new System.Drawing.Point(127, 206);
            this.cmbStopBits.Name = "cmbStopBits";
            this.cmbStopBits.Size = new System.Drawing.Size(143, 25);
            this.cmbStopBits.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "端口号：";
            // 
            // cmbDataBits
            // 
            this.cmbDataBits.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbDataBits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDataBits.FormattingEnabled = true;
            this.cmbDataBits.Location = new System.Drawing.Point(127, 116);
            this.cmbDataBits.Name = "cmbDataBits";
            this.cmbDataBits.Size = new System.Drawing.Size(143, 25);
            this.cmbDataBits.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "校验位：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(31, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "停止位：";
            // 
            // cmbBaudRate
            // 
            this.cmbBaudRate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBaudRate.FormattingEnabled = true;
            this.cmbBaudRate.Location = new System.Drawing.Point(127, 71);
            this.cmbBaudRate.Name = "cmbBaudRate";
            this.cmbBaudRate.Size = new System.Drawing.Size(143, 25);
            this.cmbBaudRate.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 13;
            this.label4.Text = "波特率：";
            // 
            // cmbParity
            // 
            this.cmbParity.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbParity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbParity.FormattingEnabled = true;
            this.cmbParity.Location = new System.Drawing.Point(127, 161);
            this.cmbParity.Name = "cmbParity";
            this.cmbParity.Size = new System.Drawing.Size(143, 25);
            this.cmbParity.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "数据位：";
            // 
            // cmbCom
            // 
            this.cmbCom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbCom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCom.FormattingEnabled = true;
            this.cmbCom.Location = new System.Drawing.Point(127, 26);
            this.cmbCom.Name = "cmbCom";
            this.cmbCom.Size = new System.Drawing.Size(143, 25);
            this.cmbCom.TabIndex = 16;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(321, 20);
            this.panel2.TabIndex = 18;
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Enabled = false;
            this.btnDisconnect.Location = new System.Drawing.Point(201, 478);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(100, 40);
            this.btnDisconnect.TabIndex = 13;
            this.btnDisconnect.Text = "断开";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(48, 478);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(100, 40);
            this.btnConnect.TabIndex = 12;
            this.btnConnect.Text = "连接";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbControllerInfo
            // 
            this.gbControllerInfo.Controls.Add(this.nudChannelCount);
            this.gbControllerInfo.Controls.Add(this.cmbLightControllerBrand);
            this.gbControllerInfo.Controls.Add(this.label11);
            this.gbControllerInfo.Controls.Add(this.label8);
            this.gbControllerInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbControllerInfo.Location = new System.Drawing.Point(20, 20);
            this.gbControllerInfo.Name = "gbControllerInfo";
            this.gbControllerInfo.Size = new System.Drawing.Size(321, 130);
            this.gbControllerInfo.TabIndex = 14;
            this.gbControllerInfo.TabStop = false;
            this.gbControllerInfo.Text = "基本参数";
            // 
            // nudChannelCount
            // 
            this.nudChannelCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nudChannelCount.Location = new System.Drawing.Point(131, 81);
            this.nudChannelCount.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.nudChannelCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudChannelCount.Name = "nudChannelCount";
            this.nudChannelCount.Size = new System.Drawing.Size(150, 27);
            this.nudChannelCount.TabIndex = 4;
            this.nudChannelCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudChannelCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudChannelCount.ValueChanged += new System.EventHandler(this.nudChannelCount_ValueChanged);
            // 
            // cmbLightControllerBrand
            // 
            this.cmbLightControllerBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbLightControllerBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLightControllerBrand.FormattingEnabled = true;
            this.cmbLightControllerBrand.Location = new System.Drawing.Point(131, 36);
            this.cmbLightControllerBrand.Name = "cmbLightControllerBrand";
            this.cmbLightControllerBrand.Size = new System.Drawing.Size(150, 25);
            this.cmbLightControllerBrand.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(35, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 17);
            this.label11.TabIndex = 9;
            this.label11.Text = "通道数量：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 17);
            this.label8.TabIndex = 6;
            this.label8.Text = "设备品牌：";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(363, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AutoScroll = true;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbLog);
            this.splitContainer1.Size = new System.Drawing.Size(727, 753);
            this.splitContainer1.SplitterDistance = 530;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 4;
            // 
            // rtbLog
            // 
            this.rtbLog.ContextMenuStrip = this.contextMenuStrip1;
            this.rtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbLog.Location = new System.Drawing.Point(0, 0);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.Size = new System.Drawing.Size(727, 218);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClearLog});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 28);
            // 
            // tsmiClearLog
            // 
            this.tsmiClearLog.Name = "tsmiClearLog";
            this.tsmiClearLog.Size = new System.Drawing.Size(108, 24);
            this.tsmiClearLog.Text = "清空";
            this.tsmiClearLog.Click += new System.EventHandler(this.tsmiClearLog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 753);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.pageTCP.ResumeLayout(false);
            this.pageTCP.PerformLayout();
            this.pageUDP.ResumeLayout(false);
            this.pageUDP.PerformLayout();
            this.pageCOM.ResumeLayout(false);
            this.pageCOM.PerformLayout();
            this.gbControllerInfo.ResumeLayout(false);
            this.gbControllerInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChannelCount)).EndInit();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbControllerInfo;
        private System.Windows.Forms.NumericUpDown nudChannelCount;
        private System.Windows.Forms.ComboBox cmbLightControllerBrand;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage pageTCP;
        private System.Windows.Forms.TabPage pageUDP;
        private System.Windows.Forms.TabPage pageCOM;
        private System.Windows.Forms.ComboBox cmbStopBits;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDataBits;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbBaudRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbParity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCom;
        private System.Windows.Forms.TextBox tbTcpPort;
        private System.Windows.Forms.TextBox tbTcpIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbUdpPort;
        private System.Windows.Forms.TextBox tbUdpIP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiClearLog;
        private System.Windows.Forms.Button btnSetUdpIP;
        private System.Windows.Forms.Button btnSetTcpIP;
    }
}

