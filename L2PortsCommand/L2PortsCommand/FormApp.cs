using L2PortsCommand;
using System;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

namespace L2ARAutomationSerialPort
{
    public partial class FormSerialPortAutomation : Form
    {
        private static FormSerialPortAutomation INSTANCE = null;
        SerialCommands serialCmd;
        private object serialPort;
        SerialPort serialPorts = new SerialPort();

        public FormSerialPortAutomation()
        {
            InitializeComponent();
            INSTANCE = this;
            instanceSerialCommands();
        }

        public static FormSerialPortAutomation getInstance()
        {
            if (INSTANCE == null)
                INSTANCE = new FormSerialPortAutomation();

            return INSTANCE;
        }
        private void instanceSerialCommands()
        {
            serialCmd = new SerialCommands();
        }
        private void buttonOpenDrawer_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("OPEN");
            buttonOpenDrawer.BackColor = Color.Green;
            buttonCloseDrawer.BackColor = Color.Red;
        }
        private void buttonCloseDrawer_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("CLOSE");
            buttonCloseDrawer.BackColor = Color.Green;
            buttonOpenDrawer.BackColor = Color.Red;
        }
        private void buttonUpClip_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("SIXON");
            buttonUpClip.BackColor = Color.Green;
            buttonDownClip.BackColor = Color.Red;
        }
        private void buttonDownClip_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("SIXOFF");
            buttonDownClip.BackColor = Color.Green;
            buttonUpClip.BackColor = Color.Red;
        }
        private void buttonUSBIn_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("FOURON");
            buttonUSBIn.BackColor = Color.Green;
            buttonUSBOut.BackColor = Color.Red;
        }
        private void buttonUSBOut_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("FOUROFF");
            buttonUSBOut.BackColor = Color.Green;
            buttonUSBIn.BackColor = Color.Red;
        }
        private void buttonP3In_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("FIVEON");
            buttonP3In.BackColor = Color.Green;
            buttonP3Out.BackColor = Color.Red;
        }
        private void buttonP3Out_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("FIVEOFF");
            buttonP3Out.BackColor = Color.Green;
            buttonP3In.BackColor = Color.Red;
        }
        private void buttonAudio_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("Audio");
            buttonAudio.BackColor = Color.Green;
            buttonRadio.BackColor = Color.Red;
        }
        private void buttonRadio_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("Radio");
            buttonRadio.BackColor = Color.Green;
            buttonAudio.BackColor = Color.Red;
        }
        private void buttonHeadSetOn_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("ONAUD");
            buttonHeadSetOn.BackColor = Color.Green;
            buttonHeadSetOff.BackColor = Color.Red;
        }
        private void buttonHeadSetOff_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("OFFAUD");
            buttonHeadSetOff.BackColor = Color.Green;
            buttonHeadSetOn.BackColor = Color.Red;
        }

        private void buttonOrigin_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("move000");
        }

        private void buttonDistance25_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("move250");
        }

        private void buttonDistance30_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("move300");
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("status");
        }

        private void buttonUP_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("H1UP");
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("H1DOWN");
        }
        private void buttonOpenV_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("OUT6");
            buttonOpenV.BackColor = Color.Green;
            buttonCloseV.BackColor = Color.Red;
        }
        private void buttonCloseV_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("OUT8");
            buttonCloseV.BackColor = Color.Green;
            buttonOpenV.BackColor = Color.Red;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand(textBoxSend.Text);
            textBoxSend.Text = "";

        }
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            comboBoxPorts.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            comboBoxPorts.Items.AddRange(ports);
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("H1UP");
            buttonMoveUp.BackColor = Color.Green;
            buttonMoveDown.BackColor = Color.Red;
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("H1DOWN");
            buttonMoveDown.BackColor = Color.Green;
            buttonMoveUp.BackColor = Color.Red;
        }

        private void buttonLockDr_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("H2ON");
            buttonLockDr.BackColor = Color.Green;
            buttonUnlockDr.BackColor = Color.Red;
        }

        private void buttonUnlockDr_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("H2DOWN");
            buttonUnlockDr.BackColor = Color.Green;
            buttonLockDr.BackColor = Color.Red;
        }

        private void buttonDrStatus_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComand("H1STAUS");
        }

    }
}