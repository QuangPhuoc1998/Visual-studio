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

namespace SQL
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str = @"Data Source=DESKTOP-9AF58NQ\WINCCPLUSMIG2014;Initial Catalog=QLCongTy;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
         
        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * ThongTinNhanVien";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // DESKTOP - 9AF58NQ\WINCCPLUSMIG2014
            connection = new SqlConnection(@"Data Source=DESKTOP-9AF58NQ\WINCCPLUSMIG2014;Initial Catalog=QLCongTy;Integrated Security=True");
            try
            {
                connection.Open();
                loaddata();
            }
            catch
            {
                MessageBox.Show("DKM");
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
