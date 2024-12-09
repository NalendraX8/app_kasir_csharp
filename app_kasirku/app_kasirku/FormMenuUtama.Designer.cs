namespace app_kasirku
{
    partial class FormMenuUtama
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            File = new ToolStripMenuItem();
            loginToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            Master = new ToolStripMenuItem();
            kasirToolStripMenuItem = new ToolStripMenuItem();
            barangToolStripMenuItem = new ToolStripMenuItem();
            Transaksi = new ToolStripMenuItem();
            Laporan = new ToolStripMenuItem();
            Utility = new ToolStripMenuItem();
            gantiPasswordToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { File, Master, Transaksi, Laporan, Utility });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // File
            // 
            File.DropDownItems.AddRange(new ToolStripItem[] { loginToolStripMenuItem, logoutToolStripMenuItem, exitToolStripMenuItem });
            File.Name = "File";
            File.Size = new Size(46, 24);
            File.Text = "File";
            // 
            // loginToolStripMenuItem
            // 
            loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            loginToolStripMenuItem.Size = new Size(139, 26);
            loginToolStripMenuItem.Text = "Login";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(139, 26);
            logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(139, 26);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // Master
            // 
            Master.DropDownItems.AddRange(new ToolStripItem[] { kasirToolStripMenuItem, barangToolStripMenuItem });
            Master.Name = "Master";
            Master.Size = new Size(68, 24);
            Master.Text = "Master";
            // 
            // kasirToolStripMenuItem
            // 
            kasirToolStripMenuItem.Name = "kasirToolStripMenuItem";
            kasirToolStripMenuItem.Size = new Size(224, 26);
            kasirToolStripMenuItem.Text = "Kasir";
            kasirToolStripMenuItem.Click += kasirToolStripMenuItem_Click;
            // 
            // barangToolStripMenuItem
            // 
            barangToolStripMenuItem.Name = "barangToolStripMenuItem";
            barangToolStripMenuItem.Size = new Size(224, 26);
            barangToolStripMenuItem.Text = "Barang";
            // 
            // Transaksi
            // 
            Transaksi.Name = "Transaksi";
            Transaksi.Size = new Size(82, 24);
            Transaksi.Text = "Transaksi";
            // 
            // Laporan
            // 
            Laporan.Name = "Laporan";
            Laporan.Size = new Size(77, 24);
            Laporan.Text = "Laporan";
            // 
            // Utility
            // 
            Utility.DropDownItems.AddRange(new ToolStripItem[] { gantiPasswordToolStripMenuItem, aboutToolStripMenuItem });
            Utility.Name = "Utility";
            Utility.Size = new Size(62, 24);
            Utility.Text = "Utility";
            // 
            // gantiPasswordToolStripMenuItem
            // 
            gantiPasswordToolStripMenuItem.Name = "gantiPasswordToolStripMenuItem";
            gantiPasswordToolStripMenuItem.Size = new Size(192, 26);
            gantiPasswordToolStripMenuItem.Text = "Ganti Password";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(192, 26);
            aboutToolStripMenuItem.Text = "About";
            // 
            // FormMenuUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMenuUtama";
            Text = "FormMenuUtama";
            Load += FormMenuUtama_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem File;
        public ToolStripMenuItem Master;
        public ToolStripMenuItem Transaksi;
        public ToolStripMenuItem Laporan;
        public ToolStripMenuItem Utility;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem kasirToolStripMenuItem;
        private ToolStripMenuItem barangToolStripMenuItem;
        private ToolStripMenuItem gantiPasswordToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        public ToolStripMenuItem loginToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
    }
}