namespace app_kasirku
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_login = new Button();
            btn_cancel = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.ForeColor = Color.White;
            btn_login.Image = Properties.Resources.Frame_2;
            btn_login.Location = new Point(218, 475);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(141, 40);
            btn_login.TabIndex = 0;
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.Black;
            btn_cancel.FlatStyle = FlatStyle.Flat;
            btn_cancel.Image = Properties.Resources.Frame_3;
            btn_cancel.Location = new Point(219, 527);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(146, 37);
            btn_cancel.TabIndex = 1;
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(79, 241);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(427, 71);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(79, 366);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(427, 66);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Frame_1;
            ClientSize = new Size(562, 579);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_cancel);
            Controls.Add(btn_login);
            Name = "FormLogin";
            Text = "FormLogin";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private Button btn_cancel;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
