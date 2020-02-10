using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Ports;
using System.Xml;

namespace Giao_tiep_MCU
{
    public partial class Form1 : Form
    {
        string Receive_data;
        public Form1()
        {
            InitializeComponent();
            // Cài đặt các thông số cho COM
            // Mảng string port để chứ tất cả các cổng COM đang có trên máy tính
            string[] ports = SerialPort.GetPortNames();
            // Thêm toàn bộ các COM đã tìm được vào combox cbCom
            cbCom.Items.AddRange(ports); // Sử dụng AddRange thay vì dùng foreach 
            Serial_port.ReadTimeout = 1000;
            // P.DataReceived += new SerialDataReceivedEventHandler(DataReceive);
            // Cài đặt cho BaudRate
            string[] BaudRate = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            cbRate.Items.AddRange(BaudRate);
            // Cài đặt cho DataBits
            string[] Databits = { "6", "7", "8" };
            cbData.Items.AddRange(Databits);
            //Cho Parity
            string[] Parity = { "None", "Odd", "Even" };
            cbParity.Items.AddRange(Parity);
            //Cho Stop bit
            string[] stopbit = { "1", "1.5", "2" };
            cbStop.Items.AddRange(stopbit);
        }
        Action<string> serialPortReceiverAction;
        private void Serial_port_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            serialPortReceiverAction = serialPortReceiver;
            try
            {
                this.BeginInvoke(serialPortReceiverAction, Serial_port.ReadExisting());
            }
            catch { }
        }
        // ham xu ly du lieu nhan ve
        private void serialPortReceiver(string input)
        {
            if (input != "\r")
            {
                Receive_data += input;
            }
            else
            {           
                txtTextData.Text = Receive_data;
                Receive_data = "";
            }
            //txtTextData.Text += input;
            char[] chrs = input.ToCharArray();
            foreach(char c in chrs)
            {
                txtNumberData.Text += ((int)c).ToString() + ","; 
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Serial_port.Encoding = Encoding.GetEncoding(28591);
            cbCom.SelectedIndex = 0; // chọn COM được tìm thấy đầu tiên
            cbRate.SelectedIndex = 3; // 9600
            cbData.SelectedIndex = 2; // 8
            cbParity.SelectedIndex = 0; // None
            cbStop.SelectedIndex = 0; // None
            groupBox1.Enabled = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(Serial_port.IsOpen)
            {
                Serial_port.Close();
            }
        }

        private void btKetnoi_Click(object sender, EventArgs e)
        {
            try
            {
                Serial_port.Open();
                groupBox1.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Không thể mở công COM");
            }
        }

        private void cbCom_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Serial_port.IsOpen)
            {
                Serial_port.Close(); // Nếu đang mở Port thì phải đóng lại
            }
            Serial_port.PortName = cbCom.SelectedItem.ToString(); // Gán PortName bằng COM đã chọn
        }

        private void cbRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Serial_port.IsOpen)
            {
                Serial_port.Close();
            }
            Serial_port.BaudRate = Convert.ToInt32(cbRate.Text);
        }

        private void cbData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Serial_port.IsOpen)
            {
                Serial_port.Close();
            }
            Serial_port.DataBits = Convert.ToInt32(cbData.Text);
        }

        private void cbParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Serial_port.IsOpen)
            {
                Serial_port.Close();
            }
            switch (cbParity.SelectedItem.ToString())
            {
                case "Odd":
                    Serial_port.Parity = Parity.Odd;
                    break;
                case "None":
                    Serial_port.Parity = Parity.None;
                    break;
                case "Even":
                    Serial_port.Parity = Parity.Even;
                    break;
            }
        }
        private void cbStop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Serial_port.IsOpen)
            {
                Serial_port.Close();
            }
            switch (cbStop.SelectedItem.ToString())
            {
                case "1":
                    Serial_port.StopBits = StopBits.One;
                    break;
                case "1.5":
                    Serial_port.StopBits = StopBits.OnePointFive;
                    break;
                case "2":
                    Serial_port.StopBits = StopBits.Two;
                    break;
            }
        }
        private void btNgat_Click(object sender, EventArgs e)
        {
            if (Serial_port.IsOpen)
            {
                Serial_port.Close();
                groupBox1.Enabled = true;
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {

        }

        private void btn_led_1_Click(object sender, EventArgs e)
        {
            if(Serial_port.IsOpen)
            {
                Serial_port.Write("i");
            }
            else
            {
                MessageBox.Show("Chưa mở cổng COM");
            }
        }

        private void btn_led_2_Click(object sender, EventArgs e)
        {
            txtNumberData.Clear();
            txtTextData.Clear();
        }

        private void btn_led_3_Click(object sender, EventArgs e)
        {
            if (Serial_port.IsOpen)
            {
                Serial_port.Write("3");
            }
            else
            {
                MessageBox.Show("Chưa mở cổng COM");
            }
        }

        private void txtNumberData_TextChanged(object sender, EventArgs e)
        {

        }

        private void Serial_port_PinChanged(object sender, SerialPinChangedEventArgs e)
        {

        }
    }
}
