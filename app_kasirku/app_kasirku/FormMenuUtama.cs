using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_kasirku
{
    public partial class FormMenuUtama : Form
    {

        public static FormMenuUtama menu;
        public FormMenuUtama()
        {
            InitializeComponent();
            menu = this;
        }

        private void FormMenuUtama_Load(object sender, EventArgs e)
        {
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void kasirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form1().ShowDialog();
            this.Close();
        }
    }
}
