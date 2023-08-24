namespace GestionHotel.Views
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelHeure = new System.Windows.Forms.Label();
            this.btnconnecter = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtuser = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtpassword = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaTransfarantPictureBox2 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bunifuPictureBox2 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.labelHeure);
            this.panel1.Controls.Add(this.bunifuPictureBox2);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 452);
            this.panel1.TabIndex = 1;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDate.Location = new System.Drawing.Point(99, 69);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(0, 40);
            this.labelDate.TabIndex = 14;
            this.labelDate.Tag = "";
            // 
            // labelHeure
            // 
            this.labelHeure.AutoSize = true;
            this.labelHeure.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeure.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelHeure.Location = new System.Drawing.Point(99, 29);
            this.labelHeure.Name = "labelHeure";
            this.labelHeure.Size = new System.Drawing.Size(0, 40);
            this.labelHeure.TabIndex = 13;
            this.labelHeure.Tag = "";
            // 
            // btnconnecter
            // 
            this.btnconnecter.BorderColor = System.Drawing.Color.White;
            this.btnconnecter.BorderRadius = 15;
            this.btnconnecter.FillColor = System.Drawing.Color.White;
            this.btnconnecter.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.btnconnecter.ForeColor = System.Drawing.Color.Teal;
            this.btnconnecter.Image = ((System.Drawing.Image)(resources.GetObject("btnconnecter.Image")));
            this.btnconnecter.Location = new System.Drawing.Point(494, 350);
            this.btnconnecter.Name = "btnconnecter";
            this.btnconnecter.Size = new System.Drawing.Size(165, 43);
            this.btnconnecter.TabIndex = 4;
            this.btnconnecter.Text = "Connecter";
            this.btnconnecter.Click += new System.EventHandler(this.btnconnecter_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(400, 61);
            this.label2.Margin = new System.Windows.Forms.Padding(3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(349, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Connectez-vous !!!";
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.Color.Teal;
            this.txtuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtuser.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtuser.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.Color.White;
            this.txtuser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtuser.LineColor = System.Drawing.Color.White;
            this.txtuser.Location = new System.Drawing.Point(423, 184);
            this.txtuser.Name = "txtuser";
            this.txtuser.PasswordChar = '\0';
            this.txtuser.SelectedText = "";
            this.txtuser.Size = new System.Drawing.Size(315, 41);
            this.txtuser.TabIndex = 6;
            // 
            // txtpassword
            // 
            this.txtpassword.BackColor = System.Drawing.Color.Teal;
            this.txtpassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtpassword.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtpassword.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.ForeColor = System.Drawing.Color.White;
            this.txtpassword.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtpassword.LineColor = System.Drawing.Color.White;
            this.txtpassword.Location = new System.Drawing.Point(423, 294);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.SelectedText = "";
            this.txtpassword.Size = new System.Drawing.Size(315, 41);
            this.txtpassword.TabIndex = 7;
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("gunaTransfarantPictureBox1.Image")));
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(374, 192);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(40, 35);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 8;
            this.gunaTransfarantPictureBox1.TabStop = false;
            // 
            // gunaTransfarantPictureBox2
            // 
            this.gunaTransfarantPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox2.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("gunaTransfarantPictureBox2.Image")));
            this.gunaTransfarantPictureBox2.Location = new System.Drawing.Point(374, 302);
            this.gunaTransfarantPictureBox2.Name = "gunaTransfarantPictureBox2";
            this.gunaTransfarantPictureBox2.Size = new System.Drawing.Size(40, 35);
            this.gunaTransfarantPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox2.TabIndex = 9;
            this.gunaTransfarantPictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(420, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 40);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nom d\'utilisateur";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(420, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 40);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mot de passe";
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 16;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(755, 7);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(33, 33);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 12;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // bunifuPictureBox2
            // 
            this.bunifuPictureBox2.AllowFocused = false;
            this.bunifuPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox2.AutoSizeHeight = true;
            this.bunifuPictureBox2.BorderRadius = 190;
            this.bunifuPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox2.Image")));
            this.bunifuPictureBox2.IsCircle = true;
            this.bunifuPictureBox2.Location = new System.Drawing.Point(-11, 49);
            this.bunifuPictureBox2.Name = "bunifuPictureBox2";
            this.bunifuPictureBox2.Size = new System.Drawing.Size(380, 380);
            this.bunifuPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox2.TabIndex = 0;
            this.bunifuPictureBox2.TabStop = false;
            this.bunifuPictureBox2.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gunaTransfarantPictureBox2);
            this.Controls.Add(this.gunaTransfarantPictureBox1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnconnecter);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnconnecter;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLineTextBox txtuser;
        private Guna.UI.WinForms.GunaLineTextBox txtpassword;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label labelHeure;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelDate;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox2;
    }
}