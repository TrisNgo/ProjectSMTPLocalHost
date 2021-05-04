using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Net;
using System.Net.Sockets;


namespace ProjectSMTPLocalHost
{
    public partial class FrmSmtpLocal : Form
    {
        TcpClient tcpClient;
        IPEndPoint iPEndPoint;
        NetworkStream networkStream;
        Byte[] data;
        
        public FrmSmtpLocal()
        {
            InitializeComponent();
            setupConnection();
        }
        private void setupConnection()
        {
            try
            {
                this.tcpClient = new TcpClient();
                this.iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 465);//Port 465: smtp có mã hóa, SMTPS
                this.tcpClient.Connect(iPEndPoint);
                this.networkStream = tcpClient.GetStream();
                
            }
            catch
            {
                MessageBox.Show("Không tìm thấy mail server tại Local Host");
                this.Close();
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            string mess = "";

        }
    }
}
