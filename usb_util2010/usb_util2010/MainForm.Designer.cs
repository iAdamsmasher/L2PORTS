namespace usb_util2010
{
    partial class MainForm
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
            this.EventInfoTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxDuplicateForUSB1 = new System.Windows.Forms.CheckBox();
            this.SetUSB2PortButton = new System.Windows.Forms.Button();
            this.ChangeUSB2PortButton = new System.Windows.Forms.Button();
            this.Usb2PortBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Usb2PortBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EventInfoTextBox
            // 
            this.EventInfoTextBox.BackColor = System.Drawing.Color.White;
            this.EventInfoTextBox.ForeColor = System.Drawing.Color.Black;
            this.EventInfoTextBox.Location = new System.Drawing.Point(12, 12);
            this.EventInfoTextBox.Multiline = true;
            this.EventInfoTextBox.Name = "EventInfoTextBox";
            this.EventInfoTextBox.ReadOnly = true;
            this.EventInfoTextBox.Size = new System.Drawing.Size(471, 278);
            this.EventInfoTextBox.TabIndex = 0;
            this.EventInfoTextBox.TextChanged += new System.EventHandler(this.EventInfoTextBox_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SetUSB2PortButton);
            this.groupBox1.Controls.Add(this.ChangeUSB2PortButton);
            this.groupBox1.Controls.Add(this.Usb2PortBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 76);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Assigned Port";
            // 
            // SetUSB2PortButton
            // 
            this.SetUSB2PortButton.Location = new System.Drawing.Point(336, 22);
            this.SetUSB2PortButton.Name = "SetUSB2PortButton";
            this.SetUSB2PortButton.Size = new System.Drawing.Size(84, 36);
            this.SetUSB2PortButton.TabIndex = 13;
            this.SetUSB2PortButton.Text = "Set";
            this.SetUSB2PortButton.UseVisualStyleBackColor = true;
            this.SetUSB2PortButton.Click += new System.EventHandler(this.SetUSB2PortButton_Click);
            // 
            // ChangeUSB2PortButton
            // 
            this.ChangeUSB2PortButton.Location = new System.Drawing.Point(199, 22);
            this.ChangeUSB2PortButton.Name = "ChangeUSB2PortButton";
            this.ChangeUSB2PortButton.Size = new System.Drawing.Size(81, 36);
            this.ChangeUSB2PortButton.TabIndex = 12;
            this.ChangeUSB2PortButton.Text = "Change";
            this.ChangeUSB2PortButton.UseVisualStyleBackColor = true;
            this.ChangeUSB2PortButton.Click += new System.EventHandler(this.ChangeUSB2PortButton_Click);
            // 
            // Usb2PortBox
            // 
            this.Usb2PortBox.Enabled = false;
            this.Usb2PortBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Usb2PortBox.Location = new System.Drawing.Point(72, 30);
            this.Usb2PortBox.Maximum = new decimal(new int[] {
            203,
            0,
            0,
            0});
            this.Usb2PortBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.Usb2PortBox.Name = "Usb2PortBox";
            this.Usb2PortBox.Size = new System.Drawing.Size(70, 20);
            this.Usb2PortBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "USB Port";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 362);
            this.Controls.Add(this.EventInfoTextBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(482, 434);
            this.Name = "MainForm";
            this.Text = "USB_Util 2010";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Usb2PortBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EventInfoTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button SetUSB2PortButton;
        private System.Windows.Forms.Button ChangeUSB2PortButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Usb2PortBox;
        private System.Windows.Forms.CheckBox checkBoxDuplicateForUSB1;
    }
}

