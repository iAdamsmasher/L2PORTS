
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
            this.tabPageDepth = new System.Windows.Forms.TabPage();
            this.buttonClear2 = new System.Windows.Forms.Button();
            this.labelPortsDeph = new System.Windows.Forms.Label();
            this.labelBaudRate2 = new System.Windows.Forms.Label();
            this.buttonSearch2 = new System.Windows.Forms.Button();
            this.labelDataBits2 = new System.Windows.Forms.Label();
            this.textBoxCode2 = new System.Windows.Forms.TextBox();
            this.labelStopBits2 = new System.Windows.Forms.Label();
            this.buttonSend2 = new System.Windows.Forms.Button();
            this.comboBoxPorts2 = new System.Windows.Forms.ComboBox();
            this.comboBoxBoundRate2 = new System.Windows.Forms.ComboBox();
            this.comboBoxDataBits2 = new System.Windows.Forms.ComboBox();
            this.comboBoxStopBits2 = new System.Windows.Forms.ComboBox();
            this.textBoxCommand2 = new System.Windows.Forms.TextBox();
            this.buttonOrigin = new System.Windows.Forms.Button();
            this.buttonDistance25 = new System.Windows.Forms.Button();
            this.buttonDistance30 = new System.Windows.Forms.Button();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.buttonUP = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.tabControlMain.SuspendLayout();
            this.tabPageL2AR.SuspendLayout();
            this.tabPageDepth.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelPort
            // 
            this.labelPort.AutoSize = true;
            this.labelPort.Location = new System.Drawing.Point(77, 18);
            this.labelPort.Name = "labelPort";
            this.labelPort.Size = new System.Drawing.Size(59, 20);
            this.labelPort.TabIndex = 0;
            this.labelPort.Text = "Portas:";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(42, 70);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(94, 20);
            this.labelBaudRate.TabIndex = 1;
            this.labelBaudRate.Text = "Baud Rate: ";
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Location = new System.Drawing.Point(53, 127);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(79, 20);
            this.labelDataBits.TabIndex = 2;
            this.labelDataBits.Text = "Data Bits:";
            // 
            // labelStopBits
            // 
            this.labelStopBits.AutoSize = true;
            this.labelStopBits.Location = new System.Drawing.Point(53, 183);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(82, 20);
            this.labelStopBits.TabIndex = 3;
            this.labelStopBits.Text = "Stop Bits: ";
            // 
            // comboBoxPorts
            // 
            this.comboBoxPorts.FormattingEnabled = true;
            this.comboBoxPorts.Location = new System.Drawing.Point(172, 18);
            this.comboBoxPorts.Name = "comboBoxPorts";
            this.comboBoxPorts.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPorts.TabIndex = 6;
            // 
            // comboBoxBoundRate
            // 
            this.comboBoxBoundRate.FormattingEnabled = true;
            this.comboBoxBoundRate.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBoxBoundRate.Location = new System.Drawing.Point(172, 67);
            this.comboBoxBoundRate.Name = "comboBoxBoundRate";
            this.comboBoxBoundRate.Size = new System.Drawing.Size(121, 28);
            this.comboBoxBoundRate.TabIndex = 7;
            this.comboBoxBoundRate.Text = "9600";
            // 
            // comboBoxDataBits
            // 
            this.comboBoxDataBits.FormattingEnabled = true;
            this.comboBoxDataBits.Location = new System.Drawing.Point(172, 127);
            this.comboBoxDataBits.Name = "comboBoxDataBits";
            this.comboBoxDataBits.Size = new System.Drawing.Size(121, 28);
            this.comboBoxDataBits.TabIndex = 8;
            this.comboBoxDataBits.Text = "8";
            // 
            // comboBoxStopBits
            // 
            this.comboBoxStopBits.FormattingEnabled = true;
            this.comboBoxStopBits.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBoxStopBits.Location = new System.Drawing.Point(172, 183);
            this.comboBoxStopBits.Name = "comboBoxStopBits";
            this.comboBoxStopBits.Size = new System.Drawing.Size(121, 28);
            this.comboBoxStopBits.TabIndex = 9;
            this.comboBoxStopBits.Text = "One";
            // 
            // buttonOpenDrawer
            // 
            this.buttonOpenDrawer.Location = new System.Drawing.Point(423, 39);
            this.buttonOpenDrawer.Name = "buttonOpenDrawer";
            this.buttonOpenDrawer.Size = new System.Drawing.Size(107, 51);
            this.buttonOpenDrawer.TabIndex = 12;
            this.buttonOpenDrawer.Text = "Open";
            this.buttonOpenDrawer.UseVisualStyleBackColor = true;
            this.buttonOpenDrawer.Click += new System.EventHandler(this.buttonOpenDrawer_Click);
            // 
            // buttonCloseDrawer
            // 
            this.buttonCloseDrawer.Location = new System.Drawing.Point(538, 39);
            this.buttonCloseDrawer.Name = "buttonCloseDrawer";
            this.buttonCloseDrawer.Size = new System.Drawing.Size(105, 51);
            this.buttonCloseDrawer.TabIndex = 13;
            this.buttonCloseDrawer.Text = "Close";
            this.buttonCloseDrawer.UseVisualStyleBackColor = true;
            this.buttonCloseDrawer.Click += new System.EventHandler(this.buttonCloseDrawer_Click);
            // 
            // buttonUpClip
            // 
            this.buttonUpClip.Location = new System.Drawing.Point(423, 96);
            this.buttonUpClip.Name = "buttonUpClip";
            this.buttonUpClip.Size = new System.Drawing.Size(107, 50);
            this.buttonUpClip.TabIndex = 14;
            this.buttonUpClip.Text = "Up Clip";
            this.buttonUpClip.UseVisualStyleBackColor = true;
            this.buttonUpClip.Click += new System.EventHandler(this.buttonUpClip_Click);
            // 
            // buttonDownClip
            // 
            this.buttonDownClip.Location = new System.Drawing.Point(538, 96);
            this.buttonDownClip.Name = "buttonDownClip";
            this.buttonDownClip.Size = new System.Drawing.Size(105, 50);
            this.buttonDownClip.TabIndex = 15;
            this.buttonDownClip.Text = "Down Clip";
            this.buttonDownClip.UseVisualStyleBackColor = true;
            this.buttonDownClip.Click += new System.EventHandler(this.buttonDownClip_Click);
            // 
            // buttonUSBIn
            // 
            this.buttonUSBIn.Location = new System.Drawing.Point(423, 158);
            this.buttonUSBIn.Name = "buttonUSBIn";
            this.buttonUSBIn.Size = new System.Drawing.Size(107, 47);
            this.buttonUSBIn.TabIndex = 16;
            this.buttonUSBIn.Text = "USB IN";
            this.buttonUSBIn.UseVisualStyleBackColor = true;
            this.buttonUSBIn.Click += new System.EventHandler(this.buttonUSBIn_Click);
            // 
            // buttonUSBOut
            // 
            this.buttonUSBOut.Location = new System.Drawing.Point(538, 155);
            this.buttonUSBOut.Name = "buttonUSBOut";
            this.buttonUSBOut.Size = new System.Drawing.Size(105, 52);
            this.buttonUSBOut.TabIndex = 17;
            this.buttonUSBOut.Text = "USB OUT";
            this.buttonUSBOut.UseVisualStyleBackColor = true;
            this.buttonUSBOut.Click += new System.EventHandler(this.buttonUSBOut_Click);
            // 
            // buttonP3In
            // 
            this.buttonP3In.Location = new System.Drawing.Point(423, 213);
            this.buttonP3In.Name = "buttonP3In";
            this.buttonP3In.Size = new System.Drawing.Size(107, 52);
            this.buttonP3In.TabIndex = 18;
            this.buttonP3In.Text = "P3 IN";
            this.buttonP3In.UseVisualStyleBackColor = true;
            this.buttonP3In.Click += new System.EventHandler(this.buttonP3In_Click);
            // 
            // buttonP3Out
            // 
            this.buttonP3Out.Location = new System.Drawing.Point(538, 213);
            this.buttonP3Out.Name = "buttonP3Out";
            this.buttonP3Out.Size = new System.Drawing.Size(105, 52);
            this.buttonP3Out.TabIndex = 19;
            this.buttonP3Out.Text = "P3 OUT";
            this.buttonP3Out.UseVisualStyleBackColor = true;
            this.buttonP3Out.Click += new System.EventHandler(this.buttonP3Out_Click);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(16, 299);
            this.textBoxResult.Multiline = true;
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxResult.Size = new System.Drawing.Size(355, 234);
            this.textBoxResult.TabIndex = 22;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(391, 502);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(97, 31);
            this.buttonClear.TabIndex = 23;
            this.buttonClear.Text = "CLEAR";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonAudio
            // 
            this.buttonAudio.Location = new System.Drawing.Point(424, 271);
            this.buttonAudio.Name = "buttonAudio";
            this.buttonAudio.Size = new System.Drawing.Size(105, 51);
            this.buttonAudio.TabIndex = 25;
            this.buttonAudio.Text = "AUDIO";
            this.buttonAudio.UseVisualStyleBackColor = true;
            this.buttonAudio.Click += new System.EventHandler(this.buttonAudio_Click);
            // 
            // buttonRadio
            // 
            this.buttonRadio.Location = new System.Drawing.Point(538, 271);
            this.buttonRadio.Name = "buttonRadio";
            this.buttonRadio.Size = new System.Drawing.Size(105, 51);
            this.buttonRadio.TabIndex = 26;
            this.buttonRadio.Text = "RADIO";
            this.buttonRadio.UseVisualStyleBackColor = true;
            this.buttonRadio.Click += new System.EventHandler(this.buttonRadio_Click);
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(16, 238);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(107, 52);
            this.buttonSend.TabIndex = 27;
            this.buttonSend.Text = "SEND";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxSend
            // 
            this.textBoxSend.Location = new System.Drawing.Point(129, 264);
            this.textBoxSend.Name = "textBoxSend";
            this.textBoxSend.Size = new System.Drawing.Size(242, 26);
            this.textBoxSend.TabIndex = 28;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(309, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 40);
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
            this.labelName.Location = new System.Drawing.Point(9, 596);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(192, 17);
            this.labelName.TabIndex = 30;
            this.labelName.Text = "Developed by Matheus.Paiva";
            // 
            // labelL2ARCommands
            // 
            this.labelL2ARCommands.AutoSize = true;
            this.labelL2ARCommands.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelL2ARCommands.Location = new System.Drawing.Point(420, 15);
            this.labelL2ARCommands.Name = "labelL2ARCommands";
            this.labelL2ARCommands.Size = new System.Drawing.Size(148, 20);
            this.labelL2ARCommands.TabIndex = 31;
            this.labelL2ARCommands.Text = "L2AR COMMANDS";
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageL2AR);
            this.tabControlMain.Controls.Add(this.tabPageDepth);
            this.tabControlMain.ItemSize = new System.Drawing.Size(54, 25);
            this.tabControlMain.Location = new System.Drawing.Point(0, 6);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(880, 587);
            this.tabControlMain.TabIndex = 32;
            // 
            // tabPageL2AR
            // 
            this.tabPageL2AR.Controls.Add(this.buttonOpenDrawer);
            this.tabPageL2AR.Controls.Add(this.labelL2ARCommands);
            this.tabPageL2AR.Controls.Add(this.buttonClear);
            this.tabPageL2AR.Controls.Add(this.labelPort);
            this.tabPageL2AR.Controls.Add(this.labelBaudRate);
            this.tabPageL2AR.Controls.Add(this.buttonSearch);
            this.tabPageL2AR.Controls.Add(this.labelDataBits);
            this.tabPageL2AR.Controls.Add(this.textBoxSend);
            this.tabPageL2AR.Controls.Add(this.labelStopBits);
            this.tabPageL2AR.Controls.Add(this.buttonSend);
            this.tabPageL2AR.Controls.Add(this.comboBoxPorts);
            this.tabPageL2AR.Controls.Add(this.buttonRadio);
            this.tabPageL2AR.Controls.Add(this.comboBoxBoundRate);
            this.tabPageL2AR.Controls.Add(this.buttonAudio);
            this.tabPageL2AR.Controls.Add(this.comboBoxDataBits);
            this.tabPageL2AR.Controls.Add(this.comboBoxStopBits);
            this.tabPageL2AR.Controls.Add(this.textBoxResult);
            this.tabPageL2AR.Controls.Add(this.buttonCloseDrawer);
            this.tabPageL2AR.Controls.Add(this.buttonP3Out);
            this.tabPageL2AR.Controls.Add(this.buttonUpClip);
            this.tabPageL2AR.Controls.Add(this.buttonP3In);
            this.tabPageL2AR.Controls.Add(this.buttonDownClip);
            this.tabPageL2AR.Controls.Add(this.buttonUSBOut);
            this.tabPageL2AR.Controls.Add(this.buttonUSBIn);
            this.tabPageL2AR.Location = new System.Drawing.Point(4, 29);
            this.tabPageL2AR.Name = "tabPageL2AR";
            this.tabPageL2AR.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageL2AR.Size = new System.Drawing.Size(872, 554);
            this.tabPageL2AR.TabIndex = 0;
            this.tabPageL2AR.Text = "L2AR";
            this.tabPageL2AR.UseVisualStyleBackColor = true;
            // 
            // tabPageDepth
            // 
            this.tabPageDepth.Controls.Add(this.buttonDown);
            this.tabPageDepth.Controls.Add(this.buttonUP);
            this.tabPageDepth.Controls.Add(this.buttonStatus);
            this.tabPageDepth.Controls.Add(this.buttonDistance30);
            this.tabPageDepth.Controls.Add(this.buttonDistance25);
            this.tabPageDepth.Controls.Add(this.buttonOrigin);
            this.tabPageDepth.Controls.Add(this.buttonClear2);
            this.tabPageDepth.Controls.Add(this.labelPortsDeph);
            this.tabPageDepth.Controls.Add(this.labelBaudRate2);
            this.tabPageDepth.Controls.Add(this.buttonSearch2);
            this.tabPageDepth.Controls.Add(this.labelDataBits2);
            this.tabPageDepth.Controls.Add(this.textBoxCode2);
            this.tabPageDepth.Controls.Add(this.labelStopBits2);
            this.tabPageDepth.Controls.Add(this.buttonSend2);
            this.tabPageDepth.Controls.Add(this.comboBoxPorts2);
            this.tabPageDepth.Controls.Add(this.comboBoxBoundRate2);
            this.tabPageDepth.Controls.Add(this.comboBoxDataBits2);
            this.tabPageDepth.Controls.Add(this.comboBoxStopBits2);
            this.tabPageDepth.Controls.Add(this.textBoxCommand2);
            this.tabPageDepth.Location = new System.Drawing.Point(4, 29);
            this.tabPageDepth.Name = "tabPageDepth";
            this.tabPageDepth.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDepth.Size = new System.Drawing.Size(872, 554);
            this.tabPageDepth.TabIndex = 1;
            this.tabPageDepth.Text = "DEPTH";
            this.tabPageDepth.UseVisualStyleBackColor = true;
            // 
            // buttonClear2
            // 
            this.buttonClear2.Location = new System.Drawing.Point(385, 507);
            this.buttonClear2.Name = "buttonClear2";
            this.buttonClear2.Size = new System.Drawing.Size(97, 31);
            this.buttonClear2.TabIndex = 39;
            this.buttonClear2.Text = "CLEAR";
            this.buttonClear2.UseVisualStyleBackColor = true;
            // 
            // labelPortsDeph
            // 
            this.labelPortsDeph.AutoSize = true;
            this.labelPortsDeph.Location = new System.Drawing.Point(71, 23);
            this.labelPortsDeph.Name = "labelPortsDeph";
            this.labelPortsDeph.Size = new System.Drawing.Size(59, 20);
            this.labelPortsDeph.TabIndex = 30;
            this.labelPortsDeph.Text = "Portas:";
            // 
            // labelBaudRate2
            // 
            this.labelBaudRate2.AutoSize = true;
            this.labelBaudRate2.Location = new System.Drawing.Point(36, 75);
            this.labelBaudRate2.Name = "labelBaudRate2";
            this.labelBaudRate2.Size = new System.Drawing.Size(94, 20);
            this.labelBaudRate2.TabIndex = 31;
            this.labelBaudRate2.Text = "Baud Rate: ";
            // 
            // buttonSearch2
            // 
            this.buttonSearch2.Location = new System.Drawing.Point(303, 17);
            this.buttonSearch2.Name = "buttonSearch2";
            this.buttonSearch2.Size = new System.Drawing.Size(75, 40);
            this.buttonSearch2.TabIndex = 42;
            this.buttonSearch2.Text = "Search";
            this.buttonSearch2.UseVisualStyleBackColor = true;
            // 
            // labelDataBits2
            // 
            this.labelDataBits2.AutoSize = true;
            this.labelDataBits2.Location = new System.Drawing.Point(47, 132);
            this.labelDataBits2.Name = "labelDataBits2";
            this.labelDataBits2.Size = new System.Drawing.Size(79, 20);
            this.labelDataBits2.TabIndex = 32;
            this.labelDataBits2.Text = "Data Bits:";
            // 
            // textBoxCode2
            // 
            this.textBoxCode2.Location = new System.Drawing.Point(123, 269);
            this.textBoxCode2.Name = "textBoxCode2";
            this.textBoxCode2.Size = new System.Drawing.Size(242, 26);
            this.textBoxCode2.TabIndex = 41;
            // 
            // labelStopBits2
            // 
            this.labelStopBits2.AutoSize = true;
            this.labelStopBits2.Location = new System.Drawing.Point(47, 188);
            this.labelStopBits2.Name = "labelStopBits2";
            this.labelStopBits2.Size = new System.Drawing.Size(82, 20);
            this.labelStopBits2.TabIndex = 33;
            this.labelStopBits2.Text = "Stop Bits: ";
            // 
            // buttonSend2
            // 
            this.buttonSend2.Location = new System.Drawing.Point(10, 243);
            this.buttonSend2.Name = "buttonSend2";
            this.buttonSend2.Size = new System.Drawing.Size(107, 52);
            this.buttonSend2.TabIndex = 40;
            this.buttonSend2.Text = "SEND";
            this.buttonSend2.UseVisualStyleBackColor = true;
            // 
            // comboBoxPorts2
            // 
            this.comboBoxPorts2.FormattingEnabled = true;
            this.comboBoxPorts2.Location = new System.Drawing.Point(166, 23);
            this.comboBoxPorts2.Name = "comboBoxPorts2";
            this.comboBoxPorts2.Size = new System.Drawing.Size(121, 28);
            this.comboBoxPorts2.TabIndex = 34;
            // 
            // comboBoxBoundRate2
            // 
            this.comboBoxBoundRate2.FormattingEnabled = true;
            this.comboBoxBoundRate2.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBoxBoundRate2.Location = new System.Drawing.Point(166, 72);
            this.comboBoxBoundRate2.Name = "comboBoxBoundRate2";
            this.comboBoxBoundRate2.Size = new System.Drawing.Size(121, 28);
            this.comboBoxBoundRate2.TabIndex = 35;
            this.comboBoxBoundRate2.Text = "115200";
            // 
            // comboBoxDataBits2
            // 
            this.comboBoxDataBits2.FormattingEnabled = true;
            this.comboBoxDataBits2.Location = new System.Drawing.Point(166, 132);
            this.comboBoxDataBits2.Name = "comboBoxDataBits2";
            this.comboBoxDataBits2.Size = new System.Drawing.Size(121, 28);
            this.comboBoxDataBits2.TabIndex = 36;
            this.comboBoxDataBits2.Text = "8";
            // 
            // comboBoxStopBits2
            // 
            this.comboBoxStopBits2.FormattingEnabled = true;
            this.comboBoxStopBits2.Items.AddRange(new object[] {
            "One",
            "Two"});
            this.comboBoxStopBits2.Location = new System.Drawing.Point(166, 188);
            this.comboBoxStopBits2.Name = "comboBoxStopBits2";
            this.comboBoxStopBits2.Size = new System.Drawing.Size(121, 28);
            this.comboBoxStopBits2.TabIndex = 37;
            this.comboBoxStopBits2.Text = "One";
            // 
            // textBoxCommand2
            // 
            this.textBoxCommand2.Location = new System.Drawing.Point(10, 304);
            this.textBoxCommand2.Multiline = true;
            this.textBoxCommand2.Name = "textBoxCommand2";
            this.textBoxCommand2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxCommand2.Size = new System.Drawing.Size(355, 234);
            this.textBoxCommand2.TabIndex = 38;
            // 
            // buttonOrigin
            // 
            this.buttonOrigin.Location = new System.Drawing.Point(427, 23);
            this.buttonOrigin.Name = "buttonOrigin";
            this.buttonOrigin.Size = new System.Drawing.Size(107, 51);
            this.buttonOrigin.TabIndex = 43;
            this.buttonOrigin.Text = "ORIGEM";
            this.buttonOrigin.UseVisualStyleBackColor = true;
            this.buttonOrigin.Click += new System.EventHandler(this.buttonOrigin_Click);
            // 
            // buttonDistance25
            // 
            this.buttonDistance25.Location = new System.Drawing.Point(549, 23);
            this.buttonDistance25.Name = "buttonDistance25";
            this.buttonDistance25.Size = new System.Drawing.Size(107, 51);
            this.buttonDistance25.TabIndex = 44;
            this.buttonDistance25.Text = "Distance_25";
            this.buttonDistance25.UseVisualStyleBackColor = true;
            this.buttonDistance25.Click += new System.EventHandler(this.buttonDistance25_Click);
            // 
            // buttonDistance30
            // 
            this.buttonDistance30.Location = new System.Drawing.Point(671, 23);
            this.buttonDistance30.Name = "buttonDistance30";
            this.buttonDistance30.Size = new System.Drawing.Size(107, 51);
            this.buttonDistance30.TabIndex = 45;
            this.buttonDistance30.Text = "Distance_30";
            this.buttonDistance30.UseVisualStyleBackColor = true;
            this.buttonDistance30.Click += new System.EventHandler(this.buttonDistance30_Click);
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(427, 89);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(107, 51);
            this.buttonStatus.TabIndex = 46;
            this.buttonStatus.Text = "STATUS";
            this.buttonStatus.UseVisualStyleBackColor = true;
            // 
            // buttonUP
            // 
            this.buttonUP.Location = new System.Drawing.Point(549, 89);
            this.buttonUP.Name = "buttonUP";
            this.buttonUP.Size = new System.Drawing.Size(107, 51);
            this.buttonUP.TabIndex = 47;
            this.buttonUP.Text = "Chart_up";
            this.buttonUP.UseVisualStyleBackColor = true;
            // 
            // buttonDown
            // 
            this.buttonDown.Location = new System.Drawing.Point(671, 89);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(107, 51);
            this.buttonDown.TabIndex = 48;
            this.buttonDown.Text = "Chart_down";
            this.buttonDown.UseVisualStyleBackColor = true;
            // 
            // FormSerialPortAutomation
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 619);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.labelName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormSerialPortAutomation";
            this.Text = "L2AR Port Automation";
            this.tabControlMain.ResumeLayout(false);
            this.tabPageL2AR.ResumeLayout(false);
            this.tabPageL2AR.PerformLayout();
            this.tabPageDepth.ResumeLayout(false);
            this.tabPageDepth.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPort;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelStopBits;
        private System.Windows.Forms.ComboBox comboBoxPorts;
        private System.Windows.Forms.ComboBox comboBoxBoundRate;
        private System.Windows.Forms.ComboBox comboBoxDataBits;
        private System.Windows.Forms.ComboBox comboBoxStopBits;
        private System.Windows.Forms.Button buttonOpenDrawer;
        private System.Windows.Forms.Button buttonCloseDrawer;
        private System.Windows.Forms.Button buttonUpClip;
        private System.Windows.Forms.Button buttonDownClip;
        private System.Windows.Forms.Button buttonUSBIn;
        private System.Windows.Forms.Button buttonUSBOut;
        private System.Windows.Forms.Button buttonP3In;
        private System.Windows.Forms.Button buttonP3Out;
        private System.Windows.Forms.TextBox textBoxResult;
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
        private System.Windows.Forms.Button buttonClear2;
        private System.Windows.Forms.Label labelPortsDeph;
        private System.Windows.Forms.Label labelBaudRate2;
        private System.Windows.Forms.Button buttonSearch2;
        private System.Windows.Forms.Label labelDataBits2;
        private System.Windows.Forms.TextBox textBoxCode2;
        private System.Windows.Forms.Label labelStopBits2;
        private System.Windows.Forms.Button buttonSend2;
        private System.Windows.Forms.ComboBox comboBoxPorts2;
        private System.Windows.Forms.ComboBox comboBoxBoundRate2;
        private System.Windows.Forms.ComboBox comboBoxDataBits2;
        private System.Windows.Forms.ComboBox comboBoxStopBits2;
        private System.Windows.Forms.TextBox textBoxCommand2;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUP;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.Button buttonDistance30;
        private System.Windows.Forms.Button buttonDistance25;
        private System.Windows.Forms.Button buttonOrigin;
    }
}