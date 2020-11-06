using System;
using System.Windows.Forms;

namespace TrafficClient
{
    public partial class Form1 : Form
    {
        public static string IPServer;
        public static int Port;
        public static string terimapesandariserver;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void merahON_CheckedChanged(object sender, EventArgs e)
        {
            if (merahON.Checked.Equals(true))
            {
                varGlobal.alamatIPServer = ipTujuan.Text;
                varGlobal.port = Int16.Parse(portClient.Text);
                SocketTCP.StartClient("Merah,Hidup");
            }
        }

        private void merahOFF_CheckedChanged(object sender, EventArgs e)
        {
            if (merahOFF.Checked.Equals(true))
            {
                varGlobal.alamatIPServer = ipTujuan.Text;
                varGlobal.port = Int16.Parse(portClient.Text);
                SocketTCP.StartClient("Merah,Mati");
            }
        }

        private void kuningON_CheckedChanged(object sender, EventArgs e)
        {
            varGlobal.alamatIPServer = ipTujuan.Text;
            varGlobal.port = Int16.Parse(portClient.Text);
            SocketTCP.StartClient("Kuning,Hidup");
        }

        private void kuningOFF_CheckedChanged(object sender, EventArgs e)
        {
            varGlobal.alamatIPServer = ipTujuan.Text;
            varGlobal.port = Int16.Parse(portClient.Text);
            SocketTCP.StartClient("Kuning,Mati");
        }

        private void hijauON_CheckedChanged(object sender, EventArgs e)
        {
            varGlobal.alamatIPServer = ipTujuan.Text;
            varGlobal.port = Int16.Parse(portClient.Text);
            SocketTCP.StartClient("Hijau,Hidup");
        }

        private void hijauOFF_CheckedChanged(object sender, EventArgs e)
        {
            varGlobal.alamatIPServer = ipTujuan.Text;
            varGlobal.port = Int16.Parse(portClient.Text);
            SocketTCP.StartClient("Hijau,Mati");
        }
    }
}
