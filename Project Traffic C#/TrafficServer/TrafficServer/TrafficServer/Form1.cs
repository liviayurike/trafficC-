using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrafficServer
{
    public partial class Form1 : Form
    {
        public static string alamatIPServer;
        public static int port;
        public static string terimapesandiserver = "";
        public static string[] command;
        public static string[] bulb = { "Merah Off", "Kuning Off", "Hijau Off" };

        public Form1()
        {
            InitializeComponent();
        }

        private void listenSocket()
        {
            varGlobal.port = Int16.Parse(portServer.Text); // konversi dari string ke integer
            varGlobal.alamatIPServer = ipServer.Text;
            SocketTCP.StartListening();
        }

        private void timerServer_Tick(object sender, EventArgs e)
        {
            if (varGlobal.terimapesandiserver.Length > 1)
            {
                txtStatus.Clear();
                string[] data = varGlobal.terimapesandiserver.Trim().Split(',');
                StringBuilder sb = new StringBuilder();
                sb.Append("Lampu ").Append(data[0]).Append(" ").Append(data[1]);
                changer(data);
                txtStatus.Text = sb.ToString();
            }
        }

        private void changer(string[] tmp)
        {
            Color color = Color.Black;
            if (tmp[1].Equals("Hidup"))
            {
                color = chooserColor(tmp[0]);
            }
            switch (tmp[0])
            {
                case "Merah":
                    panelRed.BackColor = color;
                    break;
                case "Kuning":
                    panelYellow.BackColor = color;
                    break;
                case "Hijau":
                    panelGreen.BackColor = color;
                    break;
            }
        }

        private Color chooserColor(String choose)
        {
            switch (choose)
            {
                case "Merah":
                    return Color.Red;
                case "Kuning":
                    return Color.Yellow;
                case "Hijau":
                    return Color.Green;
                default:
                    return Color.Black;
            }
        }

        private void btnListen_Click(object sender, EventArgs e)
        {
            Thread thr = new Thread(listenSocket);
            if (ipServer.Text != "" && portServer.Text != "")
            {
                thr.Start();
                btnListen.Enabled = false;
                ipServer.Enabled = false;
                portServer.Enabled = false;
            }
            else
            {
                MessageBox.Show("Lengkapi port dan alamat IP terlebih dahulu !!!");
            }
        }
    }
}