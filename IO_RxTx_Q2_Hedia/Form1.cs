using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace IO_RxTx_Q2_Hedia
{
    public partial class Form1 : Form
    {
        private SerialPort port;
       
        public Form1()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames(); // Liste des ports
            foreach (string port in ports) 
            {
                cbPorts.Items.Add(port);
            }
            btnOpen.Enabled = false;
            btnClose.Enabled = false;
            btnEnvoi.Enabled = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames(); 
            cbPorts.Items.Clear(); //efface la liste dans la combobox
            foreach (string port in ports) 
            {
                cbPorts.Items.Add(port);
            }
        }

        private void cbPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnOpen.Enabled = true;
            //tbReception.Text += cbPorts.SelectedItem.ToString();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                port = new SerialPort(cbPorts.SelectedItem.ToString(), int.Parse(tbBauds.Text), Parity.None, 8, StopBits.One);
                port.Open();
                
                if (port.IsOpen == false)
                {
                    lblInfos.Text = "Erreur, port non ouvert";
                }
                else
                {
                    lblInfos.Text = "Ouvert sur " + port.PortName + "(" + port.BaudRate + "bds)";
                    btnOpen.Enabled = false;
                    btnClose.Enabled = true;
                    btnEnvoi.Enabled = true;
                    timerRX.Tick += new EventHandler(this.timerRX_Tick);
                    timerRX.Start();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblInfos.Text = "Aucune connexion établie";
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (port.IsOpen)
            {
                try
                {
                    port.Close();
                    lblInfos.Text = "Port fermé";
                    btnOpen.Enabled = true;
                    btnClose.Enabled = false;
                    btnEnvoi.Enabled = false;
                    timerRX.Stop();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEnvoi_Click(object sender, EventArgs e)
        {
            try
            {
                if (port.IsOpen && tbEmission.Text != "")
                {
                    port.Write(tbEmission.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void timerRX_Tick(object sender, EventArgs e)
        {
            if (port.IsOpen) { tbReception.Text += port.ReadExisting(); }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbEmission.Text = "";
            tbReception.Text = "";
        }

        private void btnInfos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Copyright Jonathan W. HEL IS 2017-2018", "Copyright", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
