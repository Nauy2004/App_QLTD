namespace GUI
{
    partial class ProjectAll
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
            this.components = new System.ComponentModel.Container();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.Panel_Project_top = new Guna.UI2.WinForms.Guna2Panel();
            this.panel_project_topleft = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.panel_Project_topright = new Guna.UI2.WinForms.Guna2Panel();
            this.btn_create_project = new Guna.UI2.WinForms.Guna2Button();
            this.guna2AnimateWindow2 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.btn_delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Panel_Project_top.SuspendLayout();
            this.panel_project_topleft.SuspendLayout();
            this.panel_Project_topright.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Project_top
            // 
            this.Panel_Project_top.Controls.Add(this.panel_project_topleft);
            this.Panel_Project_top.Controls.Add(this.panel_Project_topright);
            this.Panel_Project_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel_Project_top.Location = new System.Drawing.Point(0, 0);
            this.Panel_Project_top.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Panel_Project_top.Name = "Panel_Project_top";
            this.Panel_Project_top.Size = new System.Drawing.Size(2821, 134);
            this.Panel_Project_top.TabIndex = 1;
            // 
            // panel_project_topleft
            // 
            this.panel_project_topleft.AutoSize = true;
            this.panel_project_topleft.Controls.Add(this.guna2HtmlLabel1);
            this.panel_project_topleft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_project_topleft.Location = new System.Drawing.Point(0, 0);
            this.panel_project_topleft.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel_project_topleft.Name = "panel_project_topleft";
            this.panel_project_topleft.Size = new System.Drawing.Size(510, 134);
            this.panel_project_topleft.TabIndex = 2;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(32, 29);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(286, 83);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Tạo dự án";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Project_topright
            // 
            this.panel_Project_topright.Controls.Add(this.btn_create_project);
            this.panel_Project_topright.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel_Project_topright.Location = new System.Drawing.Point(2077, 0);
            this.panel_Project_topright.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.panel_Project_topright.Name = "panel_Project_topright";
            this.panel_Project_topright.Size = new System.Drawing.Size(744, 134);
            this.panel_Project_topright.TabIndex = 2;
            // 
            // btn_create_project
            // 
            this.btn_create_project.BorderRadius = 8;
            this.btn_create_project.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_create_project.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_create_project.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_create_project.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_create_project.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_create_project.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_create_project.ForeColor = System.Drawing.Color.White;
            this.btn_create_project.Location = new System.Drawing.Point(24, 14);
            this.btn_create_project.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.btn_create_project.Name = "btn_create_project";
            this.btn_create_project.Size = new System.Drawing.Size(285, 103);
            this.btn_create_project.TabIndex = 2;
            this.btn_create_project.Text = "Tạo Dự Án";
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.Location = new System.Drawing.Point(40, 343);
            this.guna2TextBox1.Margin = new System.Windows.Forms.Padding(19, 19, 19, 19);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.Size = new System.Drawing.Size(693, 74);
            this.guna2TextBox1.TabIndex = 2;
            // 
            // btn_delete
            // 
            this.btn_delete.MinimumWidth = 12;
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Width = 250;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Image = global::GUI.Properties.Resources.icons8_search_50__1_;
            this.guna2Button1.Location = new System.Drawing.Point(629, 339);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(88, 79);
            this.guna2Button1.TabIndex = 3;
            // 
            // ProjectAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2821, 1686);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2TextBox1);
            this.Controls.Add(this.Panel_Project_top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "ProjectAll";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProjectAll";
            this.Load += new System.EventHandler(this.ProjectAll_Load);
            this.Panel_Project_top.ResumeLayout(false);
            this.Panel_Project_top.PerformLayout();
            this.panel_project_topleft.ResumeLayout(false);
            this.panel_project_topleft.PerformLayout();
            this.panel_Project_topright.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2Panel Panel_Project_top;
        private Guna.UI2.WinForms.Guna2Panel panel_project_topleft;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2Panel panel_Project_topright;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow2;
        private Guna.UI2.WinForms.Guna2Button btn_create_project;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn btn_delete;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}