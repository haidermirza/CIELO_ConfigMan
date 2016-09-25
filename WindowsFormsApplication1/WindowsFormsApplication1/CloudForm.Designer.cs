namespace WindowsFormsApplication1 {
	partial class CloudForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose( );
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloudForm));
      this.cbxMqttTopic = new System.Windows.Forms.ComboBox();
      this.txtResponseWin = new System.Windows.Forms.TextBox();
      this.button9 = new System.Windows.Forms.Button();
      this.button10 = new System.Windows.Forms.Button();
      this.textBox3 = new System.Windows.Forms.TextBox();
      this.textBox4 = new System.Windows.Forms.TextBox();
      this.btnResetLogs = new System.Windows.Forms.Button();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.label2 = new System.Windows.Forms.Label();
      this.timer1 = new System.Windows.Forms.Timer(this.components);
      this.groupBox5 = new System.Windows.Forms.GroupBox();
      this.cbxDeviceIp = new System.Windows.Forms.ComboBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.lumiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.seletColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fullBrightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.oTAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.checksumCalculatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.groupBox6 = new System.Windows.Forms.GroupBox();
      this.btnMqttConnect = new System.Windows.Forms.Button();
      this.cbxMqttConnectionServer = new System.Windows.Forms.ComboBox();
      this.groupBox7 = new System.Windows.Forms.GroupBox();
      this.txtMacAddr = new System.Windows.Forms.TextBox();
      this.txtResponceMQTT = new System.Windows.Forms.TextBox();
      this.btnEraseResponceWin = new System.Windows.Forms.Button();
      this.groupBox8 = new System.Windows.Forms.GroupBox();
      this.groupBox9 = new System.Windows.Forms.GroupBox();
      this.btnSendMqtt = new System.Windows.Forms.Button();
      this.groupBox11 = new System.Windows.Forms.GroupBox();
      this.cbxMqttDeviceServer = new System.Windows.Forms.ComboBox();
      this.groupBox10 = new System.Windows.Forms.GroupBox();
      this.lblHeartbeatMinutes = new System.Windows.Forms.Label();
      this.txtHeartbeat = new System.Windows.Forms.TextBox();
      this.groupBox12 = new System.Windows.Forms.GroupBox();
      this.label1 = new System.Windows.Forms.Label();
      this.groupBox13 = new System.Windows.Forms.GroupBox();
      this.picMqttState = new System.Windows.Forms.PictureBox();
      this.btnCurrentConfig = new System.Windows.Forms.Button();
      this.colorDialog1 = new System.Windows.Forms.ColorDialog();
      this.trkWhite = new System.Windows.Forms.TrackBar();
      this.lblBright = new System.Windows.Forms.Label();
      this.groupBox14 = new System.Windows.Forms.GroupBox();
      this.btnUdpSend = new System.Windows.Forms.Button();
      this.cbxUdp = new System.Windows.Forms.ComboBox();
      this.turnOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.groupBox2.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.groupBox5.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.groupBox6.SuspendLayout();
      this.groupBox7.SuspendLayout();
      this.groupBox8.SuspendLayout();
      this.groupBox9.SuspendLayout();
      this.groupBox11.SuspendLayout();
      this.groupBox10.SuspendLayout();
      this.groupBox12.SuspendLayout();
      this.groupBox13.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picMqttState)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.trkWhite)).BeginInit();
      this.groupBox14.SuspendLayout();
      this.SuspendLayout();
      // 
      // cbxMqttTopic
      // 
      this.cbxMqttTopic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxMqttTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.cbxMqttTopic.FormattingEnabled = true;
      this.cbxMqttTopic.Items.AddRange(new object[] {
            "Accepted",
            "Rejected",
            "Delta",
            "Update"});
      this.cbxMqttTopic.Location = new System.Drawing.Point(133, 12);
      this.cbxMqttTopic.Name = "cbxMqttTopic";
      this.cbxMqttTopic.Size = new System.Drawing.Size(84, 21);
      this.cbxMqttTopic.TabIndex = 36;
      // 
      // txtResponseWin
      // 
      this.txtResponseWin.BackColor = System.Drawing.SystemColors.ControlLightLight;
      this.txtResponseWin.Location = new System.Drawing.Point(6, 21);
      this.txtResponseWin.Multiline = true;
      this.txtResponseWin.Name = "txtResponseWin";
      this.txtResponseWin.ReadOnly = true;
      this.txtResponseWin.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.txtResponseWin.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtResponseWin.Size = new System.Drawing.Size(233, 373);
      this.txtResponseWin.TabIndex = 4;
      this.txtResponseWin.WordWrap = false;
      this.txtResponseWin.TextChanged += new System.EventHandler(this.txtResponseWin_TextChanged);
      // 
      // button9
      // 
      this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button9.Location = new System.Drawing.Point(5, 31);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(218, 28);
      this.button9.TabIndex = 11;
      this.button9.Text = "Show WiFi List";
      this.button9.UseVisualStyleBackColor = true;
      this.button9.Click += new System.EventHandler(this.btnShowWifi);
      // 
      // button10
      // 
      this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.button10.Location = new System.Drawing.Point(6, 69);
      this.button10.Name = "button10";
      this.button10.Size = new System.Drawing.Size(69, 109);
      this.button10.TabIndex = 12;
      this.button10.Text = "Change WiFi";
      this.button10.UseVisualStyleBackColor = true;
      this.button10.Click += new System.EventHandler(this.btnChangeWifi);
      // 
      // textBox3
      // 
      this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox3.Location = new System.Drawing.Point(6, 19);
      this.textBox3.Name = "textBox3";
      this.textBox3.Size = new System.Drawing.Size(128, 21);
      this.textBox3.TabIndex = 13;
      this.textBox3.Text = "YES_Nayatel";
      // 
      // textBox4
      // 
      this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBox4.Location = new System.Drawing.Point(6, 19);
      this.textBox4.Name = "textBox4";
      this.textBox4.Size = new System.Drawing.Size(128, 21);
      this.textBox4.TabIndex = 14;
      this.textBox4.Text = "nayatel321?";
      // 
      // btnResetLogs
      // 
      this.btnResetLogs.Location = new System.Drawing.Point(375, 454);
      this.btnResetLogs.Name = "btnResetLogs";
      this.btnResetLogs.Size = new System.Drawing.Size(106, 23);
      this.btnResetLogs.TabIndex = 19;
      this.btnResetLogs.Text = "Reset Output";
      this.btnResetLogs.UseVisualStyleBackColor = true;
      this.btnResetLogs.Click += new System.EventHandler(this.btnResetLogs_Click);
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.groupBox4);
      this.groupBox2.Controls.Add(this.button9);
      this.groupBox2.Controls.Add(this.groupBox3);
      this.groupBox2.Controls.Add(this.button10);
      this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox2.Location = new System.Drawing.Point(16, 217);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(234, 187);
      this.groupBox2.TabIndex = 21;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "WiFi Commands";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.textBox4);
      this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox4.Location = new System.Drawing.Point(81, 126);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(143, 52);
      this.groupBox4.TabIndex = 23;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "Password";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.textBox3);
      this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox3.Location = new System.Drawing.Point(81, 69);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(143, 51);
      this.groupBox3.TabIndex = 22;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "SSID";
      // 
      // statusStrip1
      // 
      this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
      this.statusStrip1.Location = new System.Drawing.Point(0, 487);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1047, 22);
      this.statusStrip1.TabIndex = 22;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(25, 17);
      this.toolStripStatusLabel1.Text = "NIL";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label2.Location = new System.Drawing.Point(387, 449);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(0, 15);
      this.label2.TabIndex = 23;
      // 
      // timer1
      // 
      this.timer1.Enabled = true;
      this.timer1.Interval = 1000;
      this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
      // 
      // groupBox5
      // 
      this.groupBox5.Controls.Add(this.cbxDeviceIp);
      this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox5.Location = new System.Drawing.Point(16, 56);
      this.groupBox5.Name = "groupBox5";
      this.groupBox5.Size = new System.Drawing.Size(162, 55);
      this.groupBox5.TabIndex = 24;
      this.groupBox5.TabStop = false;
      this.groupBox5.Text = "Device IP";
      // 
      // cbxDeviceIp
      // 
      this.cbxDeviceIp.FormattingEnabled = true;
      this.cbxDeviceIp.Location = new System.Drawing.Point(6, 19);
      this.cbxDeviceIp.Name = "cbxDeviceIp";
      this.cbxDeviceIp.Size = new System.Drawing.Size(139, 23);
      this.cbxDeviceIp.TabIndex = 33;
      this.cbxDeviceIp.SelectedIndexChanged += new System.EventHandler(this.cbxDeviceIp_SelectedIndexChanged);
      // 
      // menuStrip1
      // 
      this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
      this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline) 
                | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lumiToolStripMenuItem,
            this.oTAToolStripMenuItem,
            this.aboutToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1047, 27);
      this.menuStrip1.TabIndex = 25;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // lumiToolStripMenuItem
      // 
      this.lumiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.seletColorToolStripMenuItem,
            this.fullBrightToolStripMenuItem,
            this.turnOffToolStripMenuItem});
      this.lumiToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
      this.lumiToolStripMenuItem.Name = "lumiToolStripMenuItem";
      this.lumiToolStripMenuItem.Size = new System.Drawing.Size(51, 23);
      this.lumiToolStripMenuItem.Text = "Lumi";
      // 
      // seletColorToolStripMenuItem
      // 
      this.seletColorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
      this.seletColorToolStripMenuItem.Name = "seletColorToolStripMenuItem";
      this.seletColorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.seletColorToolStripMenuItem.Text = "Set Color";
      this.seletColorToolStripMenuItem.Click += new System.EventHandler(this.seletColorToolStripMenuItem_Click);
      // 
      // fullBrightToolStripMenuItem
      // 
      this.fullBrightToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
      this.fullBrightToolStripMenuItem.Name = "fullBrightToolStripMenuItem";
      this.fullBrightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.fullBrightToolStripMenuItem.Text = "Full bright";
      this.fullBrightToolStripMenuItem.Click += new System.EventHandler(this.fullBrightToolStripMenuItem_Click);
      // 
      // oTAToolStripMenuItem
      // 
      this.oTAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checksumCalculatorToolStripMenuItem});
      this.oTAToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
      this.oTAToolStripMenuItem.Name = "oTAToolStripMenuItem";
      this.oTAToolStripMenuItem.Size = new System.Drawing.Size(46, 23);
      this.oTAToolStripMenuItem.Text = "OTA";
      // 
      // checksumCalculatorToolStripMenuItem
      // 
      this.checksumCalculatorToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
      this.checksumCalculatorToolStripMenuItem.Name = "checksumCalculatorToolStripMenuItem";
      this.checksumCalculatorToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
      this.checksumCalculatorToolStripMenuItem.Text = "Checksum Calculator";
      this.checksumCalculatorToolStripMenuItem.Click += new System.EventHandler(this.checksumCalculatorToolStripMenuItem_Click);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Checked = true;
      this.aboutToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.infoToolStripMenuItem});
      this.aboutToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(59, 23);
      this.aboutToolStripMenuItem.Text = "About";
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(96, 6);
      // 
      // infoToolStripMenuItem
      // 
      this.infoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
      this.infoToolStripMenuItem.Size = new System.Drawing.Size(99, 22);
      this.infoToolStripMenuItem.Text = "Info";
      this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
      // 
      // groupBox6
      // 
      this.groupBox6.Controls.Add(this.txtResponseWin);
      this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox6.Location = new System.Drawing.Point(258, 38);
      this.groupBox6.Name = "groupBox6";
      this.groupBox6.Size = new System.Drawing.Size(245, 408);
      this.groupBox6.TabIndex = 26;
      this.groupBox6.TabStop = false;
      this.groupBox6.Text = "Output";
      // 
      // btnMqttConnect
      // 
      this.btnMqttConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnMqttConnect.Location = new System.Drawing.Point(18, 131);
      this.btnMqttConnect.Name = "btnMqttConnect";
      this.btnMqttConnect.Size = new System.Drawing.Size(95, 23);
      this.btnMqttConnect.TabIndex = 27;
      this.btnMqttConnect.Text = "Connect";
      this.btnMqttConnect.UseVisualStyleBackColor = true;
      this.btnMqttConnect.Click += new System.EventHandler(this.btnMqttConnect_Click);
      // 
      // cbxMqttConnectionServer
      // 
      this.cbxMqttConnectionServer.FormattingEnabled = true;
      this.cbxMqttConnectionServer.Location = new System.Drawing.Point(6, 17);
      this.cbxMqttConnectionServer.Name = "cbxMqttConnectionServer";
      this.cbxMqttConnectionServer.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.cbxMqttConnectionServer.Size = new System.Drawing.Size(122, 23);
      this.cbxMqttConnectionServer.TabIndex = 5;
      // 
      // groupBox7
      // 
      this.groupBox7.Controls.Add(this.cbxMqttConnectionServer);
      this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox7.Location = new System.Drawing.Point(12, 33);
      this.groupBox7.Name = "groupBox7";
      this.groupBox7.Size = new System.Drawing.Size(134, 46);
      this.groupBox7.TabIndex = 28;
      this.groupBox7.TabStop = false;
      this.groupBox7.Text = "MQTT Server";
      // 
      // txtMacAddr
      // 
      this.txtMacAddr.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtMacAddr.Location = new System.Drawing.Point(6, 19);
      this.txtMacAddr.Name = "txtMacAddr";
      this.txtMacAddr.Size = new System.Drawing.Size(122, 21);
      this.txtMacAddr.TabIndex = 29;
      this.txtMacAddr.Text = "18FE34CB1832";
      // 
      // txtResponceMQTT
      // 
      this.txtResponceMQTT.BackColor = System.Drawing.SystemColors.ButtonHighlight;
      this.txtResponceMQTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtResponceMQTT.Location = new System.Drawing.Point(6, 37);
      this.txtResponceMQTT.Multiline = true;
      this.txtResponceMQTT.Name = "txtResponceMQTT";
      this.txtResponceMQTT.ReadOnly = true;
      this.txtResponceMQTT.ScrollBars = System.Windows.Forms.ScrollBars.Both;
      this.txtResponceMQTT.Size = new System.Drawing.Size(233, 375);
      this.txtResponceMQTT.TabIndex = 30;
      this.txtResponceMQTT.WordWrap = false;
      this.txtResponceMQTT.TextChanged += new System.EventHandler(this.txtResponceMQTT_TextChanged);
      // 
      // btnEraseResponceWin
      // 
      this.btnEraseResponceWin.Location = new System.Drawing.Point(820, 454);
      this.btnEraseResponceWin.Name = "btnEraseResponceWin";
      this.btnEraseResponceWin.Size = new System.Drawing.Size(106, 23);
      this.btnEraseResponceWin.TabIndex = 31;
      this.btnEraseResponceWin.Text = "Clear Logs";
      this.btnEraseResponceWin.UseVisualStyleBackColor = true;
      this.btnEraseResponceWin.Click += new System.EventHandler(this.btnEraseResponceWin_Click);
      // 
      // groupBox8
      // 
      this.groupBox8.Controls.Add(this.txtMacAddr);
      this.groupBox8.Location = new System.Drawing.Point(12, 85);
      this.groupBox8.Name = "groupBox8";
      this.groupBox8.Size = new System.Drawing.Size(134, 44);
      this.groupBox8.TabIndex = 32;
      this.groupBox8.TabStop = false;
      this.groupBox8.Text = "Device MAC";
      // 
      // groupBox9
      // 
      this.groupBox9.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.groupBox9.Controls.Add(this.btnSendMqtt);
      this.groupBox9.Controls.Add(this.groupBox11);
      this.groupBox9.Controls.Add(this.groupBox10);
      this.groupBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox9.Location = new System.Drawing.Point(509, 223);
      this.groupBox9.Name = "groupBox9";
      this.groupBox9.Size = new System.Drawing.Size(167, 187);
      this.groupBox9.TabIndex = 33;
      this.groupBox9.TabStop = false;
      this.groupBox9.Text = "Device Configuration";
      // 
      // btnSendMqtt
      // 
      this.btnSendMqtt.Enabled = false;
      this.btnSendMqtt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnSendMqtt.Location = new System.Drawing.Point(6, 158);
      this.btnSendMqtt.Name = "btnSendMqtt";
      this.btnSendMqtt.Size = new System.Drawing.Size(149, 23);
      this.btnSendMqtt.TabIndex = 24;
      this.btnSendMqtt.Text = "Send";
      this.btnSendMqtt.UseVisualStyleBackColor = true;
      this.btnSendMqtt.Click += new System.EventHandler(this.btnSendMqtt_Click);
      // 
      // groupBox11
      // 
      this.groupBox11.Controls.Add(this.cbxMqttDeviceServer);
      this.groupBox11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox11.Location = new System.Drawing.Point(6, 100);
      this.groupBox11.Name = "groupBox11";
      this.groupBox11.Size = new System.Drawing.Size(149, 46);
      this.groupBox11.TabIndex = 34;
      this.groupBox11.TabStop = false;
      this.groupBox11.Text = "MQTT Server";
      // 
      // cbxMqttDeviceServer
      // 
      this.cbxMqttDeviceServer.FormattingEnabled = true;
      this.cbxMqttDeviceServer.Location = new System.Drawing.Point(12, 17);
      this.cbxMqttDeviceServer.Name = "cbxMqttDeviceServer";
      this.cbxMqttDeviceServer.Size = new System.Drawing.Size(122, 23);
      this.cbxMqttDeviceServer.TabIndex = 0;
      // 
      // groupBox10
      // 
      this.groupBox10.Controls.Add(this.lblHeartbeatMinutes);
      this.groupBox10.Controls.Add(this.txtHeartbeat);
      this.groupBox10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox10.Location = new System.Drawing.Point(6, 33);
      this.groupBox10.Name = "groupBox10";
      this.groupBox10.Size = new System.Drawing.Size(149, 57);
      this.groupBox10.TabIndex = 29;
      this.groupBox10.TabStop = false;
      this.groupBox10.Text = "Heartbeat Time";
      // 
      // lblHeartbeatMinutes
      // 
      this.lblHeartbeatMinutes.AutoSize = true;
      this.lblHeartbeatMinutes.Location = new System.Drawing.Point(42, 29);
      this.lblHeartbeatMinutes.Name = "lblHeartbeatMinutes";
      this.lblHeartbeatMinutes.Size = new System.Drawing.Size(82, 15);
      this.lblHeartbeatMinutes.TabIndex = 36;
      this.lblHeartbeatMinutes.Text = "X 30s = 0 Min";
      // 
      // txtHeartbeat
      // 
      this.txtHeartbeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.txtHeartbeat.Location = new System.Drawing.Point(6, 25);
      this.txtHeartbeat.Name = "txtHeartbeat";
      this.txtHeartbeat.Size = new System.Drawing.Size(30, 21);
      this.txtHeartbeat.TabIndex = 30;
      this.txtHeartbeat.Text = "30";
      this.txtHeartbeat.TextChanged += new System.EventHandler(this.txtHeartbeat_TextChanged);
      // 
      // groupBox12
      // 
      this.groupBox12.Controls.Add(this.label1);
      this.groupBox12.Controls.Add(this.cbxMqttTopic);
      this.groupBox12.Controls.Add(this.txtResponceMQTT);
      this.groupBox12.Location = new System.Drawing.Point(687, 28);
      this.groupBox12.Name = "groupBox12";
      this.groupBox12.Size = new System.Drawing.Size(249, 418);
      this.groupBox12.TabIndex = 34;
      this.groupBox12.TabStop = false;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 15);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(110, 13);
      this.label1.TabIndex = 37;
      this.label1.Text = "MQTT Messages Log";
      // 
      // groupBox13
      // 
      this.groupBox13.Controls.Add(this.picMqttState);
      this.groupBox13.Controls.Add(this.btnMqttConnect);
      this.groupBox13.Controls.Add(this.groupBox8);
      this.groupBox13.Controls.Add(this.groupBox7);
      this.groupBox13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox13.Location = new System.Drawing.Point(509, 38);
      this.groupBox13.Name = "groupBox13";
      this.groupBox13.Size = new System.Drawing.Size(161, 164);
      this.groupBox13.TabIndex = 34;
      this.groupBox13.TabStop = false;
      this.groupBox13.Text = "Connection Settings";
      // 
      // picMqttState
      // 
      this.picMqttState.Image = global::WindowsFormsApplication1.Properties.Resources.off;
      this.picMqttState.Location = new System.Drawing.Point(115, 131);
      this.picMqttState.Name = "picMqttState";
      this.picMqttState.Size = new System.Drawing.Size(25, 22);
      this.picMqttState.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.picMqttState.TabIndex = 31;
      this.picMqttState.TabStop = false;
      // 
      // btnCurrentConfig
      // 
      this.btnCurrentConfig.Enabled = false;
      this.btnCurrentConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnCurrentConfig.Location = new System.Drawing.Point(509, 436);
      this.btnCurrentConfig.Name = "btnCurrentConfig";
      this.btnCurrentConfig.Size = new System.Drawing.Size(167, 41);
      this.btnCurrentConfig.TabIndex = 35;
      this.btnCurrentConfig.Text = "Get Current Config";
      this.btnCurrentConfig.UseVisualStyleBackColor = true;
      this.btnCurrentConfig.Click += new System.EventHandler(this.btnCurrentConfig_Click);
      // 
      // trkWhite
      // 
      this.trkWhite.AutoSize = false;
      this.trkWhite.LargeChange = 255;
      this.trkWhite.Location = new System.Drawing.Point(953, 135);
      this.trkWhite.Maximum = 255;
      this.trkWhite.Name = "trkWhite";
      this.trkWhite.Orientation = System.Windows.Forms.Orientation.Vertical;
      this.trkWhite.Size = new System.Drawing.Size(45, 104);
      this.trkWhite.TabIndex = 38;
      this.trkWhite.ValueChanged += new System.EventHandler(this.trkWhite_ValueChanged);
      // 
      // lblBright
      // 
      this.lblBright.AutoSize = true;
      this.lblBright.Location = new System.Drawing.Point(942, 242);
      this.lblBright.Name = "lblBright";
      this.lblBright.Size = new System.Drawing.Size(59, 13);
      this.lblBright.TabIndex = 39;
      this.lblBright.Text = "Brightness:";
      // 
      // groupBox14
      // 
      this.groupBox14.Controls.Add(this.btnUdpSend);
      this.groupBox14.Controls.Add(this.cbxUdp);
      this.groupBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.groupBox14.Location = new System.Drawing.Point(16, 135);
      this.groupBox14.Name = "groupBox14";
      this.groupBox14.Size = new System.Drawing.Size(223, 55);
      this.groupBox14.TabIndex = 40;
      this.groupBox14.TabStop = false;
      this.groupBox14.Text = "Quick Commands";
      // 
      // btnUdpSend
      // 
      this.btnUdpSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.btnUdpSend.Location = new System.Drawing.Point(153, 19);
      this.btnUdpSend.Name = "btnUdpSend";
      this.btnUdpSend.Size = new System.Drawing.Size(48, 23);
      this.btnUdpSend.TabIndex = 34;
      this.btnUdpSend.Text = "Send";
      this.btnUdpSend.UseVisualStyleBackColor = true;
      this.btnUdpSend.Click += new System.EventHandler(this.btnUdpSend_Click);
      // 
      // cbxUdp
      // 
      this.cbxUdp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cbxUdp.FormattingEnabled = true;
      this.cbxUdp.Location = new System.Drawing.Point(6, 19);
      this.cbxUdp.Name = "cbxUdp";
      this.cbxUdp.Size = new System.Drawing.Size(139, 23);
      this.cbxUdp.TabIndex = 33;
      // 
      // turnOffToolStripMenuItem
      // 
      this.turnOffToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(1)), true);
      this.turnOffToolStripMenuItem.Name = "turnOffToolStripMenuItem";
      this.turnOffToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.turnOffToolStripMenuItem.Text = "Turn Off";
      this.turnOffToolStripMenuItem.Click += new System.EventHandler(this.turnOffToolStripMenuItem_Click);
      // 
      // CloudForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.BackColor = System.Drawing.SystemColors.ButtonFace;
      this.ClientSize = new System.Drawing.Size(1047, 509);
      this.Controls.Add(this.groupBox14);
      this.Controls.Add(this.lblBright);
      this.Controls.Add(this.trkWhite);
      this.Controls.Add(this.btnCurrentConfig);
      this.Controls.Add(this.groupBox13);
      this.Controls.Add(this.groupBox12);
      this.Controls.Add(this.groupBox9);
      this.Controls.Add(this.btnEraseResponceWin);
      this.Controls.Add(this.groupBox6);
      this.Controls.Add(this.groupBox5);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.btnResetLogs);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.ImeMode = System.Windows.Forms.ImeMode.On;
      this.MainMenuStrip = this.menuStrip1;
      this.MinimumSize = new System.Drawing.Size(953, 548);
      this.Name = "CloudForm";
      this.Text = "ConfigMan - Cielo";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.groupBox2.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.groupBox5.ResumeLayout(false);
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.groupBox6.ResumeLayout(false);
      this.groupBox6.PerformLayout();
      this.groupBox7.ResumeLayout(false);
      this.groupBox8.ResumeLayout(false);
      this.groupBox8.PerformLayout();
      this.groupBox9.ResumeLayout(false);
      this.groupBox11.ResumeLayout(false);
      this.groupBox10.ResumeLayout(false);
      this.groupBox10.PerformLayout();
      this.groupBox12.ResumeLayout(false);
      this.groupBox12.PerformLayout();
      this.groupBox13.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.picMqttState)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.trkWhite)).EndInit();
      this.groupBox14.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TextBox txtResponseWin;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Button btnResetLogs;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Button btnMqttConnect;
		private System.Windows.Forms.ComboBox cbxMqttConnectionServer;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.TextBox txtMacAddr;
		private System.Windows.Forms.TextBox txtResponceMQTT;
		private System.Windows.Forms.Button btnEraseResponceWin;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.GroupBox groupBox9;
		private System.Windows.Forms.Button btnSendMqtt;
		private System.Windows.Forms.GroupBox groupBox11;
		private System.Windows.Forms.GroupBox groupBox10;
		private System.Windows.Forms.TextBox txtHeartbeat;
		private System.Windows.Forms.GroupBox groupBox12;
		private System.Windows.Forms.GroupBox groupBox13;
		private System.Windows.Forms.Label lblHeartbeatMinutes;
		private System.Windows.Forms.Button btnCurrentConfig;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.PictureBox picMqttState;
		private System.Windows.Forms.ComboBox cbxMqttDeviceServer;
		private System.Windows.Forms.ComboBox cbxDeviceIp;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxMqttTopic;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem lumiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullBrightToolStripMenuItem;
        private System.Windows.Forms.TrackBar trkWhite;
        private System.Windows.Forms.Label lblBright;
    private System.Windows.Forms.ToolStripMenuItem seletColorToolStripMenuItem;
    private System.Windows.Forms.GroupBox groupBox14;
    private System.Windows.Forms.ComboBox cbxUdp;
    private System.Windows.Forms.Button btnUdpSend;
    private System.Windows.Forms.ToolStripMenuItem oTAToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem checksumCalculatorToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem turnOffToolStripMenuItem;
  }
}

