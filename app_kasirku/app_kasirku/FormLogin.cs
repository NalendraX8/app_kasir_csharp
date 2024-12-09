using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Security.Policy;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace app_kasirku
{
    public partial class FormLogin : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;

        Koneksi konek = new Koneksi();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = 'X';
            textBox1.Text = "ksr001";
            textBox2.Text = "admin";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            SqlDataReader reader = null;
            SqlConnection conn = konek.GetConn();
            {
                conn.Open();
                cmd = new SqlCommand("select * from TBL_KASIR where KodeKasir='" + textBox1.Text + "' and PasswordKasir='" + textBox2.Text + "'", conn);
                cmd.ExecuteNonQuery();
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    FormMenuUtama frmUtama = new FormMenuUtama();
                    frmUtama.Show();

                    FormMenuUtama.menu.loginToolStripMenuItem.Enabled = false;

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Salah cuy");
                }
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {

        }
    }
}
