using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace app_kasirku
{ 
    public partial class Form1 : Form
    {
        private SqlCommand cmd;
        private DataSet ds;
        private SqlDataAdapter da;
        private SqlDataReader rd;
        Koneksi konek = new Koneksi();

        void MunculLevel()
        {
            comboBoxlevelkasir.Items.Add("ADMIN");
            comboBoxlevelkasir.Items.Add("USER");
        }

        void KondisiAwal()
        {
            textBoxKodeKasir.Text = "";
            textBoxNamaKasir.Text = "";
            textBoxPassword.Text = "";
            comboBoxlevelkasir.Text = "";
            MunculLevel();
            MunculDataKasir();
        }

        void MunculDataKasir()
        {
            SqlConnection conn = konek.GetConn();
            conn.Open();
            cmd = new SqlCommand("Select * from TBL_KASIR", conn);
            ds = new DataSet();
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "TBL_KASIR");
            dataGridView1.DataSource = ds;
            dataGridView1.DataMember = "TBL_KASIR";
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Refresh();

        }

        public Form1()
        {
            InitializeComponent();
        }
        //ini master akun kasirku
        private void Form1_Load(object sender, EventArgs e)
        {
            KondisiAwal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ini button input
            if (textBoxKodeKasir.Text.Trim() == " " || textBoxNamaKasir.Text.Trim() == " " || textBoxPassword.Text.Trim() == " ")
            {
                MessageBox.Show("Pastikan Semua Form Terisi ! ! ! ");
            }

            else
            {
                SqlConnection conn = konek.GetConn();
                cmd = new SqlCommand("insert into TBL_KASIR VALUES('"
                    + textBoxKodeKasir.Text
                    + "','" + textBoxNamaKasir.Text
                    + "','" + textBoxPassword.Text
                    + "','" + comboBoxlevelkasir.Text
                    + "')", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diinputkan");
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {

        }

        private void buttonHapus_Click(object sender, EventArgs e)
        {

        }

        private void buttonTutup_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxKodeKasir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))

            {
                SqlConnection conn = konek.GetConn();
                cmd = new SqlCommand("Insert * TBL_KASIR where KodeKasir= '" + textBoxKodeKasir.Text + "')", conn);
                conn.Open();
                cmd .ExecuteNonQuery();
                rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    textBoxKodeKasir.Text = rd[0].ToString();
                    textBoxNamaKasir.Text = rd[1].ToString();
                    textBoxPassword.Text = rd[2].ToString();
                    comboBoxlevelkasir.Text = rd[3].ToString();
                }
                else
                {
                    MessageBox.Show("data tidak ditemukan!");
                }
            }
        }
        }
    }

