
namespace L2ARAutomationSerialPort
{
    partial class FormSerialPortAutomation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSerialPortAutomation));
            this.labelPort = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.labelStopBits = new System.Windows.Forms.Label();
            this.comboBoxPorts = new System.Windows.Forms.ComboBox();
            this.comboBoxBoundRate = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBits = new System.Windows.Forms.ComboBox();
            this.buttonOpenDrawer = new System.Windows.Forms.Button();
            this.buttonCloseDrawer = new System.Windows.Forms.Button();
            this.buttonUpClip = new System.Windows.Forms.Button();
            this.buttonDownClip = new System.Windows.Forms.Button();
            this.buttonUSBIn = new System.Windows.Forms.Button();
            this.buttonUSBOut = new System.Windows.Forms.Button();
            this.buttonP3In = new System.Windows.Forms.Button();
            this.buttonP3Out = new System.Windows.Forms.Button();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonAudio = new System.Windows.Forms.Button();
            this.buttonRadio = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxSend = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.labelL2ARCommands = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageL2AR = new System.Windows.Forms.TabPage();
            this.grBxPower = new System.Windows.Forms.GroupBox();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelC = new System.Windows.Forms.Label();
            this.labelV = new System.Windows.Forms.Label();
            this.comboBoxVolt = new System.Windows.Forms.ComboBox();
            this.btnPowerSupply = new System.Windows.Forms.Button();
            this.comboBoxCurr = new System.Windows.Forms.ComboBox();
            this.grBxAction = new System.Windows.Forms.GroupBox();
            this.btnSenEnd = new System.Windows.Forms.Button();
            this.LckClose = new System.Windows.Forms.Button();
            this.LckOpen = new System.Windows.Forms.Button();
            this.grBxConfig = new System.Windows.Forms.GroupBox();
            this.btnUSBOff = new System.Windows.Forms.Button();
            this.btnUSBOn = new System.Windows.Forms.Button();
            this.buttonHeadSetOn = new System.Windows.Forms.Button();
            this.buttonHeadSetOff = new System.Windows.Forms.Button();
            this.tabPageDepth = new System.Windows.Forms.TabPage();
            this.labelDepthCommands = new System.Windows.Forms.Label();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUP = new System.Windows.Forms.Button();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.buttonDistance30 = new System.Windows.Forms.Button();
            this.buttonDistance25 = new System.Windows.Forms.Button();
            this.buttonOrigin = new System.Windows.Forms.Button();
            this.tabPageL2Vision = new System.Windows.Forms.TabPage();
            this.labelUpdating = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCloseV = new System.Windows.Forms.Button();
            this.buttonOpenV = new System.Windows.Forms.Button();
            this.tabPageSqt = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonDrStatus = new System.Windows.Forms.Button();
            this.buttonUnlockDr = new System.Windows.Forms.Button();
            this.buttonLockDr = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.tabPageRGB = new System.Windows.Forms.TabPage();
            this.buttonFetl = new System.Windows.Forms.Button();
            this.buttonLightOff = new System.Windows.Forms.Button();
            this.buttonLightOn = new System.Windows.Forms.Button();
            this.buttonDownRGB = new System.Windows.Forms.Button();
            this.buttonUpRGB = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabPageL2AR.SuspendLayout();
            this.grBxPower.SuspendLayout();
            this.grBxAction.SuspendLayout();
            this.grBxConfig.SuspendLayout();
            this.tabPageDepth.SuspendLayout();
            this.tabPageL2Vision.SuspendLayout();
            this.tabPageSqt.SuspendLayout();
            this.tabPageRGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(43, 29);
            this.labelPort.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(40, 13);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Portas:";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(20, 62);
            this.labelBaudRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(64, 13);
            this.labelBaudRate.TabIndex = 1;
            this.labelBaudRate.Text = "Baud Rate: ";
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Location = new System.Drawing.Point(27, 99);
            this.labelDataBits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(53, 13);
            this.labelDataBits.TabIndex = 2;
            this.labelDataBits.Text = "Data Bits:";
            // 
            // labelStopBits
            // 
            this.labelStopBits.AutoSize = true;
            this.labelStopBits.Location = new System.Drawing.Point(27, 136);
            this.labelStopBits.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(55, 13);
            this.labelStopBits.TabIndex = 3;
            this.labelStopBits.Text = "Stop Bits: ";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(107, 29);
            this.comboBoxPorts.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(82, 21);
            this.comboBoxPorts.TabIndex = 6;
            this.comboBoxPorts.Text = "COM2";
            // 
            // comboBoxBoundRate
            // 
            this.comboBoxBoundRate.FormattingEnabled = true;
            this.comboBoxBoundRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBoxBoundRate.Location = new System.Drawing.Point(107, 60);
            this.comboBoxBoundRate.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxBoundRate.Name = "comboBoxBoundRate";
            this.comboBoxBoundRate.Size = new System.Drawing.Size(82, 21);
            this.comboBoxBoundRate.TabIndex = 7;
            this.comboBoxBoundRate.Text = "9600";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Location = new System.Drawing.Point(107, 99);
            this.comboBoxDataBits.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(82, 21);
            this.comboBoxDataBits.TabIndex = 8;
            this.comboBoxDataBits.Text = "8";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(107, 136);
            this.comboBoxStopBits.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(82, 21);
            this.comboBoxStopBits.TabIndex = 9;
            this.comboBoxStopBits.Text = "One";
            // 
            // buttonOpenDrawer
            // 
            this.buttonOpenDrawer.Location = new System.Drawing.Point(18, 73);
            this.buttonOpenDrawer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenDrawer.Name = "buttonOpenDrawer";
            this.buttonOpenDrawer.Size = new System.Drawing.Size(70, 40);
            this.buttonOpenDrawer.TabIndex = 12;
            this.buttonOpenDrawer.Text = "Open";
            this.buttonOpenDrawer.UseVisualStyleBackColor = true;
            this.buttonOpenDrawer.Click += new System.EventHandler(this.buttonOpenDrawer_Click);
            // 
            // buttonCloseDrawer
            // 
            this.buttonCloseDrawer.Location = new System.Drawing.Point(92, 73);
            this.buttonCloseDrawer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCloseDrawer.Name = "buttonCloseDrawer";
            this.buttonCloseDrawer.Size = new System.Drawing.Size(70, 40);
            this.buttonCloseDrawer.TabIndex = 13;
            this.buttonCloseDrawer.Text = "Close";
            this.buttonCloseDrawer.UseVisualStyleBackColor = true;
            this.buttonCloseDrawer.Click += new System.EventHandler(this.buttonCloseDrawer_Click);
            // 
            // buttonUpClip
            // 
            this.buttonUpClip.Location = new System.Drawing.Point(18, 117);
            this.buttonUpClip.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpClip.Name = "buttonUpClip";
            this.buttonUpClip.Size = new System.Drawing.Size(70, 40);
            this.buttonUpClip.TabIndex = 14;
            this.buttonUpClip.Text = "Up Clip";
            this.buttonUpClip.UseVisualStyleBackColor = true;
            this.buttonUpClip.Click += new System.EventHandler(this.buttonUpClip_Click);
            // 
            // buttonDownClip
            // 
            this.buttonDownClip.Location = new System.Drawing.Point(92, 117);
            this.buttonDownClip.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDownClip.Name = "buttonDownClip";
            this.buttonDownClip.Size = new System.Drawing.Size(70, 40);
            this.buttonDownClip.TabIndex = 15;
            this.buttonDownClip.Text = "Down Clip";
            this.buttonDownClip.UseVisualStyleBackColor = true;
            this.buttonDownClip.Click += new System.EventHandler(this.buttonDownClip_Click);
            // 
            // buttonUSBIn
            // 
            this.buttonUSBIn.Location = new System.Drawing.Point(18, 163);
            this.buttonUSBIn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUSBIn.Name = "buttonUSBIn";
            this.buttonUSBIn.Size = new System.Drawing.Size(70, 40);
            this.buttonUSBIn.TabIndex = 16;
            this.buttonUSBIn.Text = "USB IN";
            this.buttonUSBIn.UseVisualStyleBackColor = true;
            this.buttonUSBIn.Click += new System.EventHandler(this.buttonUSBIn_Click);
            // 
            // buttonUSBOut
            // 
            this.buttonUSBOut.Location = new System.Drawing.Point(92, 163);
            this.buttonUSBOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUSBOut.Name = "buttonUSBOut";
            this.buttonUSBOut.Size = new System.Drawing.Size(70, 40);
            this.buttonUSBOut.TabIndex = 17;
            this.buttonUSBOut.Text = "USB OUT";
            this.buttonUSBOut.UseVisualStyleBackColor = true;
            this.buttonUSBOut.Click += new System.EventHandler(this.buttonUSBOut_Click);
            // 
            // buttonP3In
            // 
            this.buttonP3In.Location = new System.Drawing.Point(18, 208);
            this.buttonP3In.Margin = new System.Windows.Forms.Padding(2);
            this.buttonP3In.Name = "buttonP3In";
            this.buttonP3In.Size = new System.Drawing.Size(70, 40);
            this.buttonP3In.TabIndex = 18;
            this.buttonP3In.Text = "P3 IN";
            this.buttonP3In.UseVisualStyleBackColor = true;
            this.buttonP3In.Click += new System.EventHandler(this.buttonP3In_Click);
            // 
            // buttonP3Out
            // 
            this.buttonP3Out.Location = new System.Drawing.Point(92, 208);
            this.buttonP3Out.Margin = new System.Windows.Forms.Padding(2);
            this.buttonP3Out.Name = "buttonP3Out";
            this.buttonP3Out.Size = new System.Drawing.Size(70, 40);
            this.buttonP3Out.TabIndex = 19;
            this.buttonP3Out.Text = "P3 OUT";
            this.buttonP3Out.UseVisualStyleBackColor = true;
            this.buttonP3Out.Click += new System.EventHandler(this.buttonP3Out_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(9, 224);
            this.textBoxResult.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResult.Size = new System.Drawing.Size(238, 153);
            this.textBoxResult.TabIndex = 22;
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.SkyBlue;
            this.buttonClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClear.ForeColor = System.Drawing.Color.Black;
            this.buttonClear.Location = new System.Drawing.Point(181, 383);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(65, 20);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAudio
            // 
            this.buttonAudio.Location = new System.Drawing.Point(14, 28);
            this.buttonAudio.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAudio.Name = "buttonAudio";
            this.buttonAudio.Size = new System.Drawing.Size(70, 40);
            this.buttonAudio.TabIndex = 25;
            this.buttonAudio.Text = "AUDIO";
            this.buttonAudio.UseVisualStyleBackColor = true;
            this.buttonAudio.Click += new System.EventHandler(this.buttonAudio_Click);
            // 
            // buttonRadio
            // 
            this.buttonRadio.Location = new System.Drawing.Point(88, 28);
            this.buttonRadio.Margin = new System.Windows.Forms.Padding(2);
            this.buttonRadio.Name = "buttonRadio";
            this.buttonRadio.Size = new System.Drawing.Size(70, 40);
            this.buttonRadio.TabIndex = 26;
            this.buttonRadio.Text = "RADIO";
            this.buttonRadio.UseVisualStyleBackColor = true;
            this.buttonRadio.Click += new System.EventHandler(this.buttonRadio_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(8, 186);
            this.buttonSend.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(71, 34);
            this.buttonSend.TabIndex = 27;
            this.buttonSend.Text = "SEND";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(84, 201);
            this.textBoxSend.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(163, 20);
            this.textBoxSend.TabIndex = 28;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(198, 25);
            this.buttonSearch.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(50, 26);
            this.buttonSearch.TabIndex = 29;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.SkyBlue;
            this.labelName.Location = new System.Drawing.Point(6, 387);
            this.labelName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(147, 13);
            this.labelName.TabIndex = 30;
            this.labelName.Text = "Developed by Matheus.Paiva";
            // 
            // labelL2ARCommands
            // 
            this.labelL2ARCommands.AutoSize = true;
            this.labelL2ARCommands.BackColor = System.Drawing.Color.SteelBlue;
            this.labelL2ARCommands.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.labelL2ARCommands.Location = new System.Drawing.Point(41, 0);
            this.labelL2ARCommands.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelL2ARCommands.Name = "labelL2ARCommands";
            this.labelL2ARCommands.Size = new System.Drawing.Size(247, 13);
            this.labelL2ARCommands.TabIndex = 31;
            this.labelL2ARCommands.Text = "                        L2AR COMMANDS                         ";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageL2AR);
            this.tabControlMain.Controls.Add(this.tabPageDepth);
            this.tabControlMain.Controls.Add(this.tabPageL2Vision);
            this.tabControlMain.Controls.Add(this.tabPageSqt);
            this.tabControlMain.Controls.Add(this.tabPageRGB);
            this.tabControlMain.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControlMain.ItemSize = new System.Drawing.Size(54, 25);
            this.tabControlMain.Location = new System.Drawing.Point(265, 8);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(389, 395);
            this.tabControlMain.TabIndex = 32;
            // 
            // tabPageL2AR
            // 
            this.tabPageL2AR.BackColor = System.Drawing.Color.Transparent;
            this.tabPageL2AR.Controls.Add(this.grBxPower);
            this.tabPageL2AR.Controls.Add(this.grBxAction);
            this.tabPageL2AR.Controls.Add(this.grBxConfig);
            this.tabPageL2AR.Controls.Add(this.labelL2ARCommands);
            this.tabPageL2AR.ForeColor = System.Drawing.Color.Black;
            this.tabPageL2AR.Location = new System.Drawing.Point(4, 29);
            this.tabPageL2AR.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageL2AR.Name = "tabPageL2AR";
            this.tabPageL2AR.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageL2AR.Size = new System.Drawing.Size(381, 362);
            this.tabPageL2AR.TabIndex = 0;
            this.tabPageL2AR.Text = "L2AR";
            // 
            // grBxPower
            // 
            this.grBxPower.Controls.Add(this.textBoxAddress);
            this.grBxPower.Controls.Add(this.labelAddress);
            this.grBxPower.Controls.Add(this.labelC);
            this.grBxPower.Controls.Add(this.labelV);
            this.grBxPower.Controls.Add(this.comboBoxVolt);
            this.grBxPower.Controls.Add(this.btnPowerSupply);
            this.grBxPower.Controls.Add(this.comboBoxCurr);
            this.grBxPower.Location = new System.Drawing.Point(196, 194);
            this.grBxPower.Name = "grBxPower";
            this.grBxPower.Size = new System.Drawing.Size(169, 159);
            this.grBxPower.TabIndex = 40;
            this.grBxPower.TabStop = false;
            this.grBxPower.Text = "Accessory Power Supply";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Location = new System.Drawing.Point(11, 37);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(144, 20);
            this.textBoxAddress.TabIndex = 6;
            this.textBoxAddress.Text = "GPIB0::9::INSTR";
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(13, 18);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(116, 13);
            this.labelAddress.TabIndex = 5;
            this.labelAddress.Text = "Address Power Supply:";
            // 
            // labelC
            // 
            this.labelC.AutoSize = true;
            this.labelC.Location = new System.Drawing.Point(83, 68);
            this.labelC.Name = "labelC";
            this.labelC.Size = new System.Drawing.Size(44, 13);
            this.labelC.TabIndex = 4;
            this.labelC.Text = "Current:";
            // 
            // labelV
            // 
            this.labelV.AutoSize = true;
            this.labelV.Location = new System.Drawing.Point(10, 68);
            this.labelV.Name = "labelV";
            this.labelV.Size = new System.Drawing.Size(46, 13);
            this.labelV.TabIndex = 3;
            this.labelV.Text = "Voltage:";
            // 
            // comboBoxVolt
            // 
            this.comboBoxVolt.FormattingEnabled = true;
            this.comboBoxVolt.Items.AddRange(new object[] {
            "5.0",
            "5.2",
            "5.4",
            "5.6",
            "5.8"});
            this.comboBoxVolt.Location = new System.Drawing.Point(9, 87);
            this.comboBoxVolt.Name = "comboBoxVolt";
            this.comboBoxVolt.Size = new System.Drawing.Size(70, 21);
            this.comboBoxVolt.TabIndex = 2;
            this.comboBoxVolt.Text = "5.0";
            // 
            // btnPowerSupply
            // 
            this.btnPowerSupply.Location = new System.Drawing.Point(27, 119);
            this.btnPowerSupply.Name = "btnPowerSupply";
            this.btnPowerSupply.Size = new System.Drawing.Size(103, 28);
            this.btnPowerSupply.TabIndex = 1;
            this.btnPowerSupply.Text = "Set Power Supply";
            this.btnPowerSupply.UseVisualStyleBackColor = true;
            this.btnPowerSupply.Click += new System.EventHandler(this.btnPowerSupply_Click);
            // 
            // comboBoxCurr
            // 
            this.comboBoxCurr.FormattingEnabled = true;
            this.comboBoxCurr.Items.AddRange(new object[] {
            "1.0",
            "1.2",
            "1.4",
            "1.6"});
            this.comboBoxCurr.Location = new System.Drawing.Point(86, 87);
            this.comboBoxCurr.Name = "comboBoxCurr";
            this.comboBoxCurr.Size = new System.Drawing.Size(70, 21);
            this.comboBoxCurr.TabIndex = 0;
            this.comboBoxCurr.Text = "1.0";
            // 
            // grBxAction
            // 
            this.grBxAction.Controls.Add(this.btnSenEnd);
            this.grBxAction.Controls.Add(this.LckClose);
            this.grBxAction.Controls.Add(this.buttonUSBIn);
            this.grBxAction.Controls.Add(this.buttonUSBOut);
            this.grBxAction.Controls.Add(this.LckOpen);
            this.grBxAction.Controls.Add(this.buttonDownClip);
            this.grBxAction.Controls.Add(this.buttonOpenDrawer);
            this.grBxAction.Controls.Add(this.buttonP3In);
            this.grBxAction.Controls.Add(this.buttonUpClip);
            this.grBxAction.Controls.Add(this.buttonCloseDrawer);
            this.grBxAction.Controls.Add(this.buttonP3Out);
            this.grBxAction.Location = new System.Drawing.Point(5, 16);
            this.grBxAction.Name = "grBxAction";
            this.grBxAction.Size = new System.Drawing.Size(182, 304);
            this.grBxAction.TabIndex = 39;
            this.grBxAction.TabStop = false;
            this.grBxAction.Text = "Action commands";
            // 
            // btnSenEnd
            // 
            this.btnSenEnd.Location = new System.Drawing.Point(18, 252);
            this.btnSenEnd.Margin = new System.Windows.Forms.Padding(2);
            this.btnSenEnd.Name = "btnSenEnd";
            this.btnSenEnd.Size = new System.Drawing.Size(144, 40);
            this.btnSenEnd.TabIndex = 38;
            this.btnSenEnd.Text = "HEADSET SEND/END";
            this.btnSenEnd.UseVisualStyleBackColor = true;
            this.btnSenEnd.Click += new System.EventHandler(this.btnSenEnd_Click);
            // 
            // LckClose
            // 
            this.LckClose.Location = new System.Drawing.Point(92, 29);
            this.LckClose.Margin = new System.Windows.Forms.Padding(2);
            this.LckClose.Name = "LckClose";
            this.LckClose.Size = new System.Drawing.Size(70, 40);
            this.LckClose.TabIndex = 35;
            this.LckClose.Text = "Locker Close";
            this.LckClose.UseVisualStyleBackColor = true;
            this.LckClose.Click += new System.EventHandler(this.LckClose_Click);
            // 
            // LckOpen
            // 
            this.LckOpen.Location = new System.Drawing.Point(18, 29);
            this.LckOpen.Margin = new System.Windows.Forms.Padding(2);
            this.LckOpen.Name = "LckOpen";
            this.LckOpen.Size = new System.Drawing.Size(70, 40);
            this.LckOpen.TabIndex = 34;
            this.LckOpen.Text = "Locker Open";
            this.LckOpen.UseVisualStyleBackColor = true;
            this.LckOpen.Click += new System.EventHandler(this.LckOpen_Click);
            // 
            // grBxConfig
            // 
            this.grBxConfig.Controls.Add(this.buttonAudio);
            this.grBxConfig.Controls.Add(this.btnUSBOff);
            this.grBxConfig.Controls.Add(this.buttonRadio);
            this.grBxConfig.Controls.Add(this.btnUSBOn);
            this.grBxConfig.Controls.Add(this.buttonHeadSetOn);
            this.grBxConfig.Controls.Add(this.buttonHeadSetOff);
            this.grBxConfig.Location = new System.Drawing.Point(193, 16);
            this.grBxConfig.Name = "grBxConfig";
            this.grBxConfig.Size = new System.Drawing.Size(174, 173);
            this.grBxConfig.TabIndex = 38;
            this.grBxConfig.TabStop = false;
            this.grBxConfig.Text = "Configuration commands";
            // 
            // btnUSBOff
            // 
            this.btnUSBOff.Location = new System.Drawing.Point(88, 115);
            this.btnUSBOff.Margin = new System.Windows.Forms.Padding(2);
            this.btnUSBOff.Name = "btnUSBOff";
            this.btnUSBOff.Size = new System.Drawing.Size(70, 40);
            this.btnUSBOff.TabIndex = 37;
            this.btnUSBOff.Text = "USB OFF";
            this.btnUSBOff.UseVisualStyleBackColor = true;
            this.btnUSBOff.Click += new System.EventHandler(this.btnUSBOff_Click);
            // 
            // btnUSBOn
            // 
            this.btnUSBOn.Location = new System.Drawing.Point(14, 115);
            this.btnUSBOn.Margin = new System.Windows.Forms.Padding(2);
            this.btnUSBOn.Name = "btnUSBOn";
            this.btnUSBOn.Size = new System.Drawing.Size(70, 40);
            this.btnUSBOn.TabIndex = 36;
            this.btnUSBOn.Text = "USB ON";
            this.btnUSBOn.UseVisualStyleBackColor = true;
            this.btnUSBOn.Click += new System.EventHandler(this.btnUSBOn_Click);
            // 
            // buttonHeadSetOn
            // 
            this.buttonHeadSetOn.Location = new System.Drawing.Point(14, 73);
            this.buttonHeadSetOn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHeadSetOn.Name = "buttonHeadSetOn";
            this.buttonHeadSetOn.Size = new System.Drawing.Size(70, 40);
            this.buttonHeadSetOn.TabIndex = 32;
            this.buttonHeadSetOn.Text = "HEADSET ON";
            this.buttonHeadSetOn.UseVisualStyleBackColor = true;
            this.buttonHeadSetOn.Click += new System.EventHandler(this.buttonHeadSetOn_Click);
            // 
            // buttonHeadSetOff
            // 
            this.buttonHeadSetOff.Location = new System.Drawing.Point(88, 73);
            this.buttonHeadSetOff.Margin = new System.Windows.Forms.Padding(2);
            this.buttonHeadSetOff.Name = "buttonHeadSetOff";
            this.buttonHeadSetOff.Size = new System.Drawing.Size(70, 40);
            this.buttonHeadSetOff.TabIndex = 33;
            this.buttonHeadSetOff.Text = "HEADSET OFF";
            this.buttonHeadSetOff.UseVisualStyleBackColor = true;
            this.buttonHeadSetOff.Click += new System.EventHandler(this.buttonHeadSetOff_Click);
            // 
            // tabPageDepth
            // 
            this.tabPageDepth.Controls.Add(this.labelDepthCommands);
            this.tabPageDepth.Controls.Add(this.buttonDown);
            this.tabPageDepth.Controls.Add(this.buttonUP);
            this.tabPageDepth.Controls.Add(this.buttonStatus);
            this.tabPageDepth.Controls.Add(this.buttonDistance30);
            this.tabPageDepth.Controls.Add(this.buttonDistance25);
            this.tabPageDepth.Controls.Add(this.buttonOrigin);
            this.tabPageDepth.ForeColor = System.Drawing.Color.Black;
            this.tabPageDepth.Location = new System.Drawing.Point(4, 29);
            this.tabPageDepth.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageDepth.Name = "tabPageDepth";
            this.tabPageDepth.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageDepth.Size = new System.Drawing.Size(381, 362);
            this.tabPageDepth.TabIndex = 1;
            this.tabPageDepth.Text = "DEPTH";
            this.tabPageDepth.UseVisualStyleBackColor = true;
            // 
            // labelDepthCommands
            // 
            this.labelDepthCommands.AutoSize = true;
            this.labelDepthCommands.BackColor = System.Drawing.Color.SteelBlue;
            this.labelDepthCommands.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.labelDepthCommands.Location = new System.Drawing.Point(39, 0);
            this.labelDepthCommands.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDepthCommands.Name = "labelDepthCommands";
            this.labelDepthCommands.Size = new System.Drawing.Size(257, 13);
            this.labelDepthCommands.TabIndex = 49;
            this.labelDepthCommands.Text = "                        DEPTH COMMANDS                         ";
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(195, 128);
            this.buttonDown.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(76, 40);
            this.buttonDown.TabIndex = 48;
            this.buttonDown.Text = "Chart_down";
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonDown_Click);
            // 
            // buttonUP
            // 
            this.buttonUP.Location = new System.Drawing.Point(114, 128);
            this.buttonUP.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUP.Name = "buttonUP";
            this.buttonUP.Size = new System.Drawing.Size(76, 40);
            this.buttonUP.TabIndex = 47;
            this.buttonUP.Text = "Chart_up";
            this.buttonUP.UseVisualStyleBackColor = true;
            this.buttonUP.Click += new System.EventHandler(this.buttonUP_Click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(33, 128);
            this.buttonStatus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(76, 40);
            this.buttonStatus.TabIndex = 46;
            this.buttonStatus.Text = "STATUS";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // buttonDistance30
            // 
            this.buttonDistance30.Location = new System.Drawing.Point(195, 85);
            this.buttonDistance30.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDistance30.Name = "buttonDistance30";
            this.buttonDistance30.Size = new System.Drawing.Size(76, 40);
            this.buttonDistance30.TabIndex = 45;
            this.buttonDistance30.Text = "Distance_30";
            this.buttonDistance30.UseVisualStyleBackColor = true;
            this.buttonDistance30.Click += new System.EventHandler(this.buttonDistance30_Click);
            // 
            // buttonDistance25
            // 
            this.buttonDistance25.Location = new System.Drawing.Point(114, 85);
            this.buttonDistance25.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDistance25.Name = "buttonDistance25";
            this.buttonDistance25.Size = new System.Drawing.Size(76, 40);
            this.buttonDistance25.TabIndex = 44;
            this.buttonDistance25.Text = "Distance_25";
            this.buttonDistance25.UseVisualStyleBackColor = true;
            this.buttonDistance25.Click += new System.EventHandler(this.buttonDistance25_Click);
            // 
            // buttonOrigin
            // 
            this.buttonOrigin.Location = new System.Drawing.Point(33, 85);
            this.buttonOrigin.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOrigin.Name = "buttonOrigin";
            this.buttonOrigin.Size = new System.Drawing.Size(76, 40);
            this.buttonOrigin.TabIndex = 43;
            this.buttonOrigin.Text = "ORIGEM";
            this.buttonOrigin.UseVisualStyleBackColor = true;
            this.buttonOrigin.Click += new System.EventHandler(this.buttonOrigin_Click);
            // 
            // tabPageL2Vision
            // 
            this.tabPageL2Vision.Controls.Add(this.labelUpdating);
            this.tabPageL2Vision.Controls.Add(this.label1);
            this.tabPageL2Vision.Controls.Add(this.buttonCloseV);
            this.tabPageL2Vision.Controls.Add(this.buttonOpenV);
            this.tabPageL2Vision.ForeColor = System.Drawing.Color.Black;
            this.tabPageL2Vision.Location = new System.Drawing.Point(4, 29);
            this.tabPageL2Vision.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageL2Vision.Name = "tabPageL2Vision";
            this.tabPageL2Vision.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageL2Vision.Size = new System.Drawing.Size(381, 362);
            this.tabPageL2Vision.TabIndex = 2;
            this.tabPageL2Vision.Text = "L2VISION";
            this.tabPageL2Vision.UseVisualStyleBackColor = true;
            // 
            // labelUpdating
            // 
            this.labelUpdating.AutoSize = true;
            this.labelUpdating.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelUpdating.Location = new System.Drawing.Point(116, 197);
            this.labelUpdating.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUpdating.Name = "labelUpdating";
            this.labelUpdating.Size = new System.Drawing.Size(75, 13);
            this.labelUpdating.TabIndex = 51;
            this.labelUpdating.Text = "UPDATING....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(31, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 13);
            this.label1.TabIndex = 50;
            this.label1.Text = "                        L2VISION COMMANDS                         ";
            // 
            // buttonCloseV
            // 
            this.buttonCloseV.Location = new System.Drawing.Point(173, 64);
            this.buttonCloseV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCloseV.Name = "buttonCloseV";
            this.buttonCloseV.Size = new System.Drawing.Size(76, 40);
            this.buttonCloseV.TabIndex = 48;
            this.buttonCloseV.Text = "CLOSE";
            this.buttonCloseV.UseVisualStyleBackColor = true;
            this.buttonCloseV.Click += new System.EventHandler(this.buttonCloseV_Click);
            // 
            // buttonOpenV
            // 
            this.buttonOpenV.Location = new System.Drawing.Point(52, 64);
            this.buttonOpenV.Margin = new System.Windows.Forms.Padding(2);
            this.buttonOpenV.Name = "buttonOpenV";
            this.buttonOpenV.Size = new System.Drawing.Size(76, 40);
            this.buttonOpenV.TabIndex = 47;
            this.buttonOpenV.Text = "OPEN";
            this.buttonOpenV.UseVisualStyleBackColor = true;
            this.buttonOpenV.Click += new System.EventHandler(this.buttonOpenV_Click);
            // 
            // tabPageSqt
            // 
            this.tabPageSqt.Controls.Add(this.label2);
            this.tabPageSqt.Controls.Add(this.buttonDrStatus);
            this.tabPageSqt.Controls.Add(this.buttonUnlockDr);
            this.tabPageSqt.Controls.Add(this.buttonLockDr);
            this.tabPageSqt.Controls.Add(this.buttonMoveDown);
            this.tabPageSqt.Controls.Add(this.buttonMoveUp);
            this.tabPageSqt.ForeColor = System.Drawing.Color.Black;
            this.tabPageSqt.Location = new System.Drawing.Point(4, 29);
            this.tabPageSqt.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageSqt.Name = "tabPageSqt";
            this.tabPageSqt.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageSqt.Size = new System.Drawing.Size(381, 362);
            this.tabPageSqt.TabIndex = 3;
            this.tabPageSqt.Text = "SQT";
            this.tabPageSqt.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(41, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(257, 13);
            this.label2.TabIndex = 53;
            this.label2.Text = "                           SQT COMMANDS                           ";
            // 
            // buttonDrStatus
            // 
            this.buttonDrStatus.Location = new System.Drawing.Point(111, 174);
            this.buttonDrStatus.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDrStatus.Name = "buttonDrStatus";
            this.buttonDrStatus.Size = new System.Drawing.Size(76, 40);
            this.buttonDrStatus.TabIndex = 52;
            this.buttonDrStatus.Text = "DRAWER STATUS";
            this.buttonDrStatus.UseVisualStyleBackColor = true;
            this.buttonDrStatus.Click += new System.EventHandler(this.buttonDrStatus_Click);
            // 
            // buttonUnlockDr
            // 
            this.buttonUnlockDr.Location = new System.Drawing.Point(172, 110);
            this.buttonUnlockDr.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUnlockDr.Name = "buttonUnlockDr";
            this.buttonUnlockDr.Size = new System.Drawing.Size(76, 40);
            this.buttonUnlockDr.TabIndex = 51;
            this.buttonUnlockDr.Text = "UNLOCK DRAWER";
            this.buttonUnlockDr.UseVisualStyleBackColor = true;
            this.buttonUnlockDr.Click += new System.EventHandler(this.buttonUnlockDr_Click);
            // 
            // buttonLockDr
            // 
            this.buttonLockDr.Location = new System.Drawing.Point(55, 110);
            this.buttonLockDr.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLockDr.Name = "buttonLockDr";
            this.buttonLockDr.Size = new System.Drawing.Size(76, 40);
            this.buttonLockDr.TabIndex = 50;
            this.buttonLockDr.Text = "LOCK DRAWER";
            this.buttonLockDr.UseVisualStyleBackColor = true;
            this.buttonLockDr.Click += new System.EventHandler(this.buttonLockDr_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Location = new System.Drawing.Point(172, 58);
            this.buttonMoveDown.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(76, 40);
            this.buttonMoveDown.TabIndex = 49;
            this.buttonMoveDown.Text = "MOVE DOWN";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Location = new System.Drawing.Point(55, 58);
            this.buttonMoveUp.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(76, 40);
            this.buttonMoveUp.TabIndex = 48;
            this.buttonMoveUp.Text = "MOVE UP";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // tabPageRGB
            // 
            this.tabPageRGB.Controls.Add(this.buttonFetl);
            this.tabPageRGB.Controls.Add(this.buttonLightOff);
            this.tabPageRGB.Controls.Add(this.buttonLightOn);
            this.tabPageRGB.Controls.Add(this.buttonDownRGB);
            this.tabPageRGB.Controls.Add(this.buttonUpRGB);
            this.tabPageRGB.Controls.Add(this.label3);
            this.tabPageRGB.ForeColor = System.Drawing.Color.Black;
            this.tabPageRGB.Location = new System.Drawing.Point(4, 29);
            this.tabPageRGB.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageRGB.Name = "tabPageRGB";
            this.tabPageRGB.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageRGB.Size = new System.Drawing.Size(381, 362);
            this.tabPageRGB.TabIndex = 4;
            this.tabPageRGB.Text = "RGB";
            this.tabPageRGB.UseVisualStyleBackColor = true;
            // 
            // buttonFetl
            // 
            this.buttonFetl.Location = new System.Drawing.Point(69, 153);
            this.buttonFetl.Margin = new System.Windows.Forms.Padding(2);
            this.buttonFetl.Name = "buttonFetl";
            this.buttonFetl.Size = new System.Drawing.Size(77, 38);
            this.buttonFetl.TabIndex = 59;
            this.buttonFetl.Text = "LuxRead";
            this.buttonFetl.UseVisualStyleBackColor = true;
            this.buttonFetl.Click += new System.EventHandler(this.ButtonFetl_Click);
            // 
            // buttonLightOff
            // 
            this.buttonLightOff.Location = new System.Drawing.Point(168, 99);
            this.buttonLightOff.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLightOff.Name = "buttonLightOff";
            this.buttonLightOff.Size = new System.Drawing.Size(77, 38);
            this.buttonLightOff.TabIndex = 58;
            this.buttonLightOff.Text = "LIGHT_OFF";
            this.buttonLightOff.UseVisualStyleBackColor = true;
            this.buttonLightOff.Click += new System.EventHandler(this.buttonLightOff_Click);
            // 
            // buttonLightOn
            // 
            this.buttonLightOn.Location = new System.Drawing.Point(69, 99);
            this.buttonLightOn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLightOn.Name = "buttonLightOn";
            this.buttonLightOn.Size = new System.Drawing.Size(77, 38);
            this.buttonLightOn.TabIndex = 57;
            this.buttonLightOn.Text = "LIGHT_ON";
            this.buttonLightOn.UseVisualStyleBackColor = true;
            this.buttonLightOn.Click += new System.EventHandler(this.buttonLightOn_Click);
            // 
            // buttonDownRGB
            // 
            this.buttonDownRGB.Location = new System.Drawing.Point(168, 48);
            this.buttonDownRGB.Margin = new System.Windows.Forms.Padding(2);
            this.buttonDownRGB.Name = "buttonDownRGB";
            this.buttonDownRGB.Size = new System.Drawing.Size(77, 38);
            this.buttonDownRGB.TabIndex = 56;
            this.buttonDownRGB.Text = "CLOSE";
            this.buttonDownRGB.UseVisualStyleBackColor = true;
            // 
            // buttonUpRGB
            // 
            this.buttonUpRGB.Location = new System.Drawing.Point(69, 48);
            this.buttonUpRGB.Margin = new System.Windows.Forms.Padding(2);
            this.buttonUpRGB.Name = "buttonUpRGB";
            this.buttonUpRGB.Size = new System.Drawing.Size(77, 38);
            this.buttonUpRGB.TabIndex = 55;
            this.buttonUpRGB.Text = "OPEN";
            this.buttonUpRGB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.SteelBlue;
            this.label3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Location = new System.Drawing.Point(38, 2);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(258, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "                           RGB COMMANDS                           ";
            // 
            // FormSerialPortAutomation
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 418);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelPort);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelBaudRate);
            this.Controls.Add(this.comboBoxStopBits);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.comboBoxDataBits);
            this.Controls.Add(this.labelDataBits);
            this.Controls.Add(this.comboBoxBoundRate);
            this.Controls.Add(this.textBoxSend);
            this.Controls.Add(this.comboBoxPorts);
            this.Controls.Add(this.labelStopBits);
            this.Controls.Add(this.buttonSend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormSerialPortAutomation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Serial Ports Automation v1.1";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageL2AR.ResumeLayout(false);
            this.tabPageL2AR.PerformLayout();
            this.grBxPower.ResumeLayout(false);
            this.grBxPower.PerformLayout();
            this.grBxAction.ResumeLayout(false);
            this.grBxConfig.ResumeLayout(false);
            this.tabPageDepth.ResumeLayout(false);
            this.tabPageDepth.PerformLayout();
            this.tabPageL2Vision.ResumeLayout(false);
            this.tabPageL2Vision.PerformLayout();
            this.tabPageSqt.ResumeLayout(false);
            this.tabPageSqt.PerformLayout();
            this.tabPageRGB.ResumeLayout(false);
            this.tabPageRGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelStopBits;
        public System.Windows.Forms.ComboBox comboBoxPorts;
        public System.Windows.Forms.ComboBox comboBoxBoundRate;
        public System.Windows.Forms.ComboBox comboBoxDataBits;
        public System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Button buttonOpenDrawer;
        private System.Windows.Forms.Button buttonCloseDrawer;
        private System.Windows.Forms.Button buttonUpClip;
        private System.Windows.Forms.Button buttonDownClip;
        private System.Windows.Forms.Button buttonUSBIn;
        private System.Windows.Forms.Button buttonUSBOut;
        private System.Windows.Forms.Button buttonP3In;
        private System.Windows.Forms.Button buttonP3Out;
        public System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonAudio;
        private System.Windows.Forms.Button buttonRadio;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxSend;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelL2ARCommands;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageL2AR;
        private System.Windows.Forms.TabPage tabPageDepth;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUP;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.Button buttonDistance30;
        private System.Windows.Forms.Button buttonDistance25;
        private System.Windows.Forms.Button buttonOrigin;
        private System.Windows.Forms.Label labelDepthCommands;
        private System.Windows.Forms.TabPage tabPageL2Vision;
        private System.Windows.Forms.TabPage tabPageSqt;
        private System.Windows.Forms.Button buttonHeadSetOff;
        private System.Windows.Forms.Button buttonHeadSetOn;
        private System.Windows.Forms.Button buttonCloseV;
        private System.Windows.Forms.Button buttonOpenV;
        private System.Windows.Forms.Button buttonDrStatus;
        private System.Windows.Forms.Button buttonUnlockDr;
        private System.Windows.Forms.Button buttonLockDr;
        private System.Windows.Forms.Button buttonMoveDown;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageRGB;
        private System.Windows.Forms.Button buttonLightOff;
        private System.Windows.Forms.Button buttonLightOn;
        private System.Windows.Forms.Button buttonDownRGB;
        private System.Windows.Forms.Button buttonUpRGB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelUpdating;
        private System.Windows.Forms.Button buttonFetl;
        private System.Windows.Forms.Button LckClose;
        private System.Windows.Forms.Button LckOpen;
        private System.Windows.Forms.Button btnUSBOff;
        private System.Windows.Forms.Button btnUSBOn;
        private System.Windows.Forms.GroupBox grBxAction;
        private System.Windows.Forms.GroupBox grBxConfig;
        private System.Windows.Forms.Button btnSenEnd;
        private System.Windows.Forms.GroupBox grBxPower;
        private System.Windows.Forms.Label labelC;
        private System.Windows.Forms.Label labelV;
        private System.Windows.Forms.Button btnPowerSupply;
        private System.Windows.Forms.Label labelAddress;
        public System.Windows.Forms.ComboBox comboBoxCurr;
        public System.Windows.Forms.ComboBox comboBoxVolt;
        public System.Windows.Forms.TextBox textBoxAddress;
    }
}