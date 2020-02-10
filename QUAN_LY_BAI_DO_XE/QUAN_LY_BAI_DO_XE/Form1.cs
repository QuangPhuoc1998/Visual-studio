using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QUAN_LY_BAI_DO_XE
{
    public partial class LOGIN : Form
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-VPC6GRQ\SQLDEV2020;Initial Catalog=Quan_ly;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txt_Tai_khoan.Text;
                string mk = txt_mat_khau.Text;
                string sql = "select *from Nguoi_dung where Tai_khoan = '"+tk+"' and Mat_khau = '"+mk+"'";
                SqlCommand cmd = new SqlCommand(sql,conn);
                SqlDataReader data = cmd.ExecuteReader();
                if(data.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại");
                }
            }
            catch 
            {
                MessageBox.Show("LỖI KẾT NỐI");
            }
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
