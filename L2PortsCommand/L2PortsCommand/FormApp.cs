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
            serialCmd.sendSerialComandAndRead("TWOON", "L2AR");
            buttonOpenDrawer.BackColor = Color.Green;
            buttonCloseDrawer.BackColor = Color.Red;
        }
        private void buttonCloseDrawer_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("TWOOFF", "L2AR");
            buttonCloseDrawer.BackColor = Color.Green;
            buttonOpenDrawer.BackColor = Color.Red;
        }

        private void LckOpen_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("OPEN", "L2AR");
            LckOpen.BackColor = Color.Green;
            LckClose.BackColor = Color.Red;
        }

        private void LckClose_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("CLOSE", "L2AR");
            LckClose.BackColor = Color.Green;
            LckOpen.BackColor = Color.Red;
        }

        private void buttonUpClip_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("SIXON", "L2AR");
            buttonUpClip.BackColor = Color.Green;
            buttonDownClip.BackColor = Color.Red;
        }
        private void buttonDownClip_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("SIXOFF", "L2AR");
            buttonDownClip.BackColor = Color.Green;
            buttonUpClip.BackColor = Color.Red;
        }
        private void buttonUSBIn_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("FOURON", "L2AR");
            buttonUSBIn.BackColor = Color.Green;
            buttonUSBOut.BackColor = Color.Red;
        }
        private void buttonUSBOut_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("FOUROFF", "L2AR");
            buttonUSBOut.BackColor = Color.Green;
            buttonUSBIn.BackColor = Color.Red;
        }
        private void buttonP3In_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("FIVEON", "L2AR");
            buttonP3In.BackColor = Color.Green;
            buttonP3Out.BackColor = Color.Red;
        }
        private void buttonP3Out_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("FIVEOFF", "L2AR");
            buttonP3Out.BackColor = Color.Green;
            buttonP3In.BackColor = Color.Red;
        }
        private void buttonAudio_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("Audio", "L2AR");
            buttonAudio.BackColor = Color.Green;
            buttonRadio.BackColor = Color.Red;
        }
        private void buttonRadio_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("Radio", "L2AR");
            buttonRadio.BackColor = Color.Green;
            buttonAudio.BackColor = Color.Red;
        }
        private void buttonHeadSetOn_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("ONAUD", "L2AR");
            buttonHeadSetOn.BackColor = Color.Green;
            buttonHeadSetOff.BackColor = Color.Red;
        }
        private void buttonHeadSetOff_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("OFFAUD", "L2AR");
            buttonHeadSetOff.BackColor = Color.Green;
            buttonHeadSetOn.BackColor = Color.Red;
        }

        private void btnUSBOn_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("0", "L2AR");
            btnUSBOn.BackColor = Color.Green;
            btnUSBOff.BackColor = Color.Red;
        }

        private void btnUSBOff_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("1", "L2AR");
            btnUSBOff.BackColor = Color.Green;
            btnUSBOn.BackColor = Color.Red;
        }

        private void buttonOrigin_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("move000", "DEPTH");
        }

        private void buttonDistance25_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("move250", "DEPTH");
        }

        private void buttonDistance30_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("move300", "DEPTH");
        }

        private void buttonStatus_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("status", "DEPTH");
        }

        private void buttonUP_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("H1UP", "DEPTH");
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("H1DOWN", "DEPTH");
        }
        private void buttonOpenV_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("OUT6", "L2VISION");
            buttonOpenV.BackColor = Color.Green;
            buttonCloseV.BackColor = Color.Red;
        }
        private void buttonCloseV_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("OUT8", "L2VISION");
            buttonCloseV.BackColor = Color.Green;
            buttonOpenV.BackColor = Color.Red;
        }
        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = "";
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead(textBoxSend.Text, "button");
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
            serialCmd.sendSerialComandAndRead("H1UP", "SQT");
            buttonMoveUp.BackColor = Color.Green;
            buttonMoveDown.BackColor = Color.Red;
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("H1DOWN", "SQT");
            buttonMoveDown.BackColor = Color.Green;
            buttonMoveUp.BackColor = Color.Red;
        }

        private void buttonLockDr_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("H2ON", "SQT");
            buttonLockDr.BackColor = Color.Green;
            buttonUnlockDr.BackColor = Color.Red;
        }

        private void buttonUnlockDr_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("H2OFF", "SQT");
            buttonUnlockDr.BackColor = Color.Green;
            buttonLockDr.BackColor = Color.Red;
        }

        private void buttonDrStatus_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("H1STATUS", "SQT");
        }

        private void buttonLightOn_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("SETI:0E", "RGB");
        }

        private void buttonLightOff_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("SETI:00", "RGB");
        }

        private void buttonFetl_Click(object sender, EventArgs e)
        {
            serialCmd.sendSerialComandAndRead("FETL", "RGB");
        }


    }
}