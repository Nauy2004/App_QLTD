namespace GUI
{
    partial class loging
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.header_logo = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.title_top = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textBox_tk = new Guna.UI2.WinForms.Guna2TextBox();
            this.textBoxMk = new Guna.UI2.WinForms.Guna2TextBox();
            this.checkBoxShowPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.header_logo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // header_logo
            // 
            this.header_logo.BackColor = System.Drawing.Color.Transparent;
            this.header_logo.Controls.Add(this.pictureBox1);
            this.header_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.header_logo.Location = new System.Drawing.Point(0, 0);
            this.header_logo.Name = "header_logo";
            this.header_logo.Size = new System.Drawing.Size(308, 112);
            this.header_logo.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnLogin);
            this.panel1.Controls.Add(this.checkBoxShowPass);
            this.panel1.Controls.Add(this.textBoxMk);
            this.panel1.Controls.Add(this.textBox_tk);
            this.panel1.Controls.Add(this.guna2HtmlLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 112);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(50, 30, 50, 0);
            this.panel1.Size = new System.Drawing.Size(308, 344);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox1.Image = global::GUI.Properties.Resources.Pa_logo;
            this.pictureBox1.Location = new System.Drawing.Point(101, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // title_top
            // 
            this.title_top.BackColor = System.Drawing.Color.Transparent;
            this.title_top.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_top.Location = new System.Drawing.Point(37, 13);
            this.title_top.Name = "title_top";
            this.title_top.Size = new System.Drawing.Size(121, 35);
            this.title_top.TabIndex = 0;
            this.title_top.Text = "Đăng nhập";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 455);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(308, 145);
            this.guna2Panel1.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(87, 33);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(121, 35);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Đăng nhập";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_tk
            // 
            this.textBox_tk.Animated = true;
            this.textBox_tk.AutoSize = true;
            this.textBox_tk.BackColor = System.Drawing.Color.Transparent;
            this.textBox_tk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.textBox_tk.BorderColor = System.Drawing.Color.DarkGray;
            this.textBox_tk.BorderRadius = 5;
            this.textBox_tk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_tk.DefaultText = "";
            this.textBox_tk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBox_tk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBox_tk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_tk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBox_tk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBox_tk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_tk.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tk.ForeColor = System.Drawing.Color.Black;
            this.textBox_tk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBox_tk.Location = new System.Drawing.Point(26, 119);
            this.textBox_tk.Name = "textBox_tk";
            this.textBox_tk.PasswordChar = '\0';
            this.textBox_tk.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textBox_tk.PlaceholderText = "TÊN NGƯỜI DÙNG";
            this.textBox_tk.SelectedText = "";
            this.textBox_tk.Size = new System.Drawing.Size(263, 42);
            this.textBox_tk.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textBox_tk.TabIndex = 0;
            this.textBox_tk.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.textBox_tk.Click += new System.EventHandler(this.enter_input);
            // 
            // textBoxMk
            // 
            this.textBoxMk.BorderRadius = 5;
            this.textBoxMk.CausesValidation = false;
            this.textBoxMk.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxMk.DefaultText = "";
            this.textBoxMk.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textBoxMk.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textBoxMk.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMk.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textBoxMk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.textBoxMk.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMk.Font = new System.Drawing.Font("Calibri", 9F);
            this.textBoxMk.ForeColor = System.Drawing.Color.Black;
            this.textBoxMk.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textBoxMk.Location = new System.Drawing.Point(26, 179);
            this.textBoxMk.Name = "textBoxMk";
            this.textBoxMk.PasswordChar = '\0';
            this.textBoxMk.PlaceholderForeColor = System.Drawing.Color.Black;
            this.textBoxMk.PlaceholderText = "MẬT KHẨU";
            this.textBoxMk.SelectedText = "";
            this.textBoxMk.Size = new System.Drawing.Size(263, 42);
            this.textBoxMk.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.textBoxMk.TabIndex = 0;
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.CheckedState.BorderColor = System.Drawing.Color.Transparent;
            this.checkBoxShowPass.CheckedState.BorderRadius = 3;
            this.checkBoxShowPass.CheckedState.BorderThickness = 0;
            this.checkBoxShowPass.CheckedState.FillColor = System.Drawing.Color.DarkRed;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBoxShowPass.ForeColor = System.Drawing.Color.Black;
            this.checkBoxShowPass.Location = new System.Drawing.Point(30, 227);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(105, 19);
            this.checkBoxShowPass.TabIndex = 1;
            this.checkBoxShowPass.Text = "Hiển mật khẩu";
            this.checkBoxShowPass.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.checkBoxShowPass.UncheckedState.BorderRadius = 3;
            this.checkBoxShowPass.UncheckedState.BorderThickness = 0;
            this.checkBoxShowPass.UncheckedState.FillColor = System.Drawing.Color.DarkGray;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // btnLogin
            // 
            this.btnLogin.BorderRadius = 5;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(131)))), ((int)(((byte)(149)))));
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(87, 292);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 45);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Đăng nhập";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // loging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 600);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.header_logo);
            this.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loging";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.header_logo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel header_logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel title_top;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox textBoxMk;
        private Guna.UI2.WinForms.Guna2TextBox textBox_tk;
        private Guna.UI2.WinForms.Guna2CheckBox checkBoxShowPass;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
    }
}

