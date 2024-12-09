namespace app_kasirku
{
    partial class Form1
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
            button1 = new Button();
            buttonEdit = new Button();
            buttonHapus = new Button();
            buttonTutup = new Button();
            comboBoxlevelkasir = new ComboBox();
            textBoxKodeKasir = new TextBox();
            textBoxNamaKasir = new TextBox();
            textBoxPassword = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Transparent;
            button1.Location = new Point(114, 478);
            button1.Name = "button1";
            button1.Size = new Size(96, 40);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.BackColor = Color.Transparent;
            buttonEdit.FlatStyle = FlatStyle.Flat;
            buttonEdit.ForeColor = Color.Transparent;
            buttonEdit.Location = new Point(313, 478);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(96, 40);
            buttonEdit.TabIndex = 1;
            buttonEdit.UseVisualStyleBackColor = false;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // buttonHapus
            // 
            buttonHapus.BackColor = Color.Transparent;
            buttonHapus.FlatStyle = FlatStyle.Flat;
            buttonHapus.ForeColor = Color.Transparent;
            buttonHapus.Location = new Point(507, 478);
            buttonHapus.Name = "buttonHapus";
            buttonHapus.Size = new Size(96, 40);
            buttonHapus.TabIndex = 2;
            buttonHapus.UseVisualStyleBackColor = false;
            buttonHapus.Click += buttonHapus_Click;
            // 
            // buttonTutup
            // 
            buttonTutup.BackColor = Color.Transparent;
            buttonTutup.FlatStyle = FlatStyle.Flat;
            buttonTutup.ForeColor = Color.Transparent;
            buttonTutup.Location = new Point(703, 478);
            buttonTutup.Name = "buttonTutup";
            buttonTutup.Size = new Size(96, 40);
            buttonTutup.TabIndex = 3;
            buttonTutup.UseVisualStyleBackColor = false;
            buttonTutup.Click += buttonTutup_Click;
            // 
            // comboBoxlevelkasir
            // 
            comboBoxlevelkasir.FormattingEnabled = true;
            comboBoxlevelkasir.Location = new Point(98, 407);
            comboBoxlevelkasir.Name = "comboBoxlevelkasir";
            comboBoxlevelkasir.Size = new Size(747, 28);
            comboBoxlevelkasir.TabIndex = 4;
            // 
            // textBoxKodeKasir
            // 
            textBoxKodeKasir.BorderStyle = BorderStyle.None;
            textBoxKodeKasir.Location = new Point(101, 128);
            textBoxKodeKasir.Multiline = true;
            textBoxKodeKasir.Name = "textBoxKodeKasir";
            textBoxKodeKasir.Size = new Size(734, 49);
            textBoxKodeKasir.TabIndex = 5;
            textBoxKodeKasir.KeyPress += textBoxKodeKasir_KeyPress;
            // 
            // textBoxNamaKasir
            // 
            textBoxNamaKasir.BorderStyle = BorderStyle.None;
            textBoxNamaKasir.Location = new Point(98, 214);
            textBoxNamaKasir.Multiline = true;
            textBoxNamaKasir.Name = "textBoxNamaKasir";
            textBoxNamaKasir.Size = new Size(734, 49);
            textBoxNamaKasir.TabIndex = 6;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Location = new Point(101, 308);
            textBoxPassword.Multiline = true;
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(734, 49);
            textBoxPassword.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(113, 556);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(732, 137);
            dataGridView1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_4;
            ClientSize = new Size(950, 723);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxNamaKasir);
            Controls.Add(textBoxKodeKasir);
            Controls.Add(comboBoxlevelkasir);
            Controls.Add(buttonTutup);
            Controls.Add(buttonHapus);
            Controls.Add(buttonEdit);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button buttonEdit;
        private Button buttonHapus;
        private Button buttonTutup;
        private ComboBox comboBoxlevelkasir;
        private TextBox textBoxKodeKasir;
        private TextBox textBoxNamaKasir;
        private TextBox textBoxPassword;
        private DataGridView dataGridView1;
    }
}