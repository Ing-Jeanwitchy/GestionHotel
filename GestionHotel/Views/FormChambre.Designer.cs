﻿namespace GestionHotel.Views
{
    partial class FormChambre
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChambre));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.txtPrix = new Guna.UI.WinForms.GunaLineTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.viewschambre = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.rbnon = new Guna.UI.WinForms.GunaRadioButton();
            this.rboui = new Guna.UI.WinForms.GunaRadioButton();
            this.Picrecher = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.txtreche = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddChambre = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Option = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.gunaLineTextBox1 = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtNo = new Guna.UI.WinForms.GunaLineTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtType = new Guna.UI.WinForms.GunaLineTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.viewschambre)).BeginInit();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picrecher)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPrix
            // 
            this.txtPrix.BackColor = System.Drawing.Color.Teal;
            this.txtPrix.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrix.FocusedLineColor = System.Drawing.Color.White;
            this.txtPrix.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrix.ForeColor = System.Drawing.Color.White;
            this.txtPrix.LineColor = System.Drawing.Color.Black;
            this.txtPrix.Location = new System.Drawing.Point(394, 201);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.PasswordChar = '\0';
            this.txtPrix.SelectedText = "";
            this.txtPrix.Size = new System.Drawing.Size(197, 39);
            this.txtPrix.TabIndex = 62;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(315, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 28);
            this.label5.TabIndex = 56;
            this.label5.Text = "Prix";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(615, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 28);
            this.label4.TabIndex = 55;
            this.label4.Text = "Disponibilite";
            // 
            // viewschambre
            // 
            this.viewschambre.AllowCustomTheming = false;
            this.viewschambre.AllowUserToAddRows = false;
            this.viewschambre.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.viewschambre.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.viewschambre.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.viewschambre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.viewschambre.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.viewschambre.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewschambre.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.viewschambre.ColumnHeadersHeight = 40;
            this.viewschambre.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(223)))), ((int)(((byte)(223)))));
            this.viewschambre.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.viewschambre.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.viewschambre.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.viewschambre.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.White;
            this.viewschambre.CurrentTheme.BackColor = System.Drawing.Color.Teal;
            this.viewschambre.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.viewschambre.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.viewschambre.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.viewschambre.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.viewschambre.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.viewschambre.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.viewschambre.CurrentTheme.Name = null;
            this.viewschambre.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.viewschambre.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.viewschambre.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.viewschambre.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            this.viewschambre.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(178)))), ((int)(((byte)(178)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewschambre.DefaultCellStyle = dataGridViewCellStyle3;
            this.viewschambre.EnableHeadersVisualStyles = false;
            this.viewschambre.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.viewschambre.HeaderBackColor = System.Drawing.Color.Teal;
            this.viewschambre.HeaderBgColor = System.Drawing.Color.Empty;
            this.viewschambre.HeaderForeColor = System.Drawing.Color.White;
            this.viewschambre.Location = new System.Drawing.Point(48, 364);
            this.viewschambre.Name = "viewschambre";
            this.viewschambre.ReadOnly = true;
            this.viewschambre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.viewschambre.RowHeadersVisible = false;
            this.viewschambre.RowHeadersWidth = 51;
            this.viewschambre.RowTemplate.Height = 40;
            this.viewschambre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.viewschambre.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.viewschambre.Size = new System.Drawing.Size(1049, 267);
            this.viewschambre.TabIndex = 63;
            this.viewschambre.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            this.viewschambre.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewschambre_CellClick);
            this.viewschambre.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuDataGridView1_CellContentClick);
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.Teal;
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Teal;
            this.bunifuPanel1.BorderRadius = 50;
            this.bunifuPanel1.BorderThickness = 5;
            this.bunifuPanel1.Controls.Add(this.bunifuButton1);
            this.bunifuPanel1.Controls.Add(this.rbnon);
            this.bunifuPanel1.Controls.Add(this.rboui);
            this.bunifuPanel1.Controls.Add(this.Picrecher);
            this.bunifuPanel1.Controls.Add(this.txtreche);
            this.bunifuPanel1.Controls.Add(this.btnAddChambre);
            this.bunifuPanel1.Controls.Add(this.Option);
            this.bunifuPanel1.Controls.Add(this.label4);
            this.bunifuPanel1.Controls.Add(this.txtPrix);
            this.bunifuPanel1.Controls.Add(this.label5);
            this.bunifuPanel1.Controls.Add(this.gunaLineTextBox1);
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(1250, 722);
            this.bunifuPanel1.TabIndex = 73;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.AllowAnimations = true;
            this.bunifuButton1.AllowMouseEffects = true;
            this.bunifuButton1.AllowToggling = false;
            this.bunifuButton1.AnimationSpeed = 200;
            this.bunifuButton1.AutoGenerateColors = false;
            this.bunifuButton1.AutoRoundBorders = true;
            this.bunifuButton1.AutoSizeLeftIcon = true;
            this.bunifuButton1.AutoSizeRightIcon = true;
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackColor1 = System.Drawing.Color.White;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.ButtonText = "Vider";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.ColorContrastOnClick = 45;
            this.bunifuButton1.ColorContrastOnHover = 45;
            this.bunifuButton1.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.bunifuButton1.CustomizableEdges = borderEdges1;
            this.bunifuButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuButton1.ForeColor = System.Drawing.Color.Teal;
            this.bunifuButton1.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton1.IconMarginLeft = 11;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton1.IconSize = 30;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.Teal;
            this.bunifuButton1.IdleBorderRadius = 42;
            this.bunifuButton1.IdleBorderThickness = 1;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.White;
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.IndicateFocus = true;
            this.bunifuButton1.Location = new System.Drawing.Point(592, 288);
            this.bunifuButton1.Name = "bunifuButton1";
            this.bunifuButton1.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton1.OnDisabledState.BorderRadius = 20;
            this.bunifuButton1.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnDisabledState.BorderThickness = 1;
            this.bunifuButton1.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton1.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton1.OnDisabledState.IconLeftImage = null;
            this.bunifuButton1.OnDisabledState.IconRightImage = null;
            this.bunifuButton1.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.BorderRadius = 20;
            this.bunifuButton1.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.onHoverState.BorderThickness = 1;
            this.bunifuButton1.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.bunifuButton1.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.onHoverState.IconLeftImage = null;
            this.bunifuButton1.onHoverState.IconRightImage = null;
            this.bunifuButton1.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.bunifuButton1.OnIdleState.BorderRadius = 20;
            this.bunifuButton1.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnIdleState.BorderThickness = 1;
            this.bunifuButton1.OnIdleState.FillColor = System.Drawing.Color.White;
            this.bunifuButton1.OnIdleState.ForeColor = System.Drawing.Color.Teal;
            this.bunifuButton1.OnIdleState.IconLeftImage = null;
            this.bunifuButton1.OnIdleState.IconRightImage = null;
            this.bunifuButton1.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.BorderRadius = 20;
            this.bunifuButton1.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton1.OnPressedState.BorderThickness = 1;
            this.bunifuButton1.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.bunifuButton1.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.OnPressedState.IconLeftImage = null;
            this.bunifuButton1.OnPressedState.IconRightImage = null;
            this.bunifuButton1.Size = new System.Drawing.Size(185, 44);
            this.bunifuButton1.TabIndex = 89;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bunifuButton1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton1.TextMarginLeft = 0;
            this.bunifuButton1.TextPadding = new System.Windows.Forms.Padding(2);
            this.bunifuButton1.UseDefaultRadiusAndThickness = true;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // rbnon
            // 
            this.rbnon.BackColor = System.Drawing.Color.Teal;
            this.rbnon.BaseColor = System.Drawing.SystemColors.Control;
            this.rbnon.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbnon.CheckedOnColor = System.Drawing.Color.Black;
            this.rbnon.FillColor = System.Drawing.Color.Transparent;
            this.rbnon.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnon.ForeColor = System.Drawing.Color.White;
            this.rbnon.Location = new System.Drawing.Point(871, 206);
            this.rbnon.Name = "rbnon";
            this.rbnon.Size = new System.Drawing.Size(77, 33);
            this.rbnon.TabIndex = 87;
            this.rbnon.Text = "Non";
            this.rbnon.CheckedChanged += new System.EventHandler(this.rbnon_CheckedChanged);
            // 
            // rboui
            // 
            this.rboui.BackColor = System.Drawing.Color.Teal;
            this.rboui.BaseColor = System.Drawing.SystemColors.Control;
            this.rboui.CheckedOffColor = System.Drawing.Color.Gray;
            this.rboui.CheckedOnColor = System.Drawing.Color.Black;
            this.rboui.FillColor = System.Drawing.Color.Transparent;
            this.rboui.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rboui.ForeColor = System.Drawing.Color.White;
            this.rboui.Location = new System.Drawing.Point(801, 205);
            this.rboui.Name = "rboui";
            this.rboui.Size = new System.Drawing.Size(70, 33);
            this.rboui.TabIndex = 86;
            this.rboui.Text = "Oui";
            this.rboui.CheckedChanged += new System.EventHandler(this.rboui_CheckedChanged);
            // 
            // Picrecher
            // 
            this.Picrecher.AllowFocused = false;
            this.Picrecher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Picrecher.AutoSizeHeight = true;
            this.Picrecher.BackColor = System.Drawing.Color.White;
            this.Picrecher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Picrecher.BackgroundImage")));
            this.Picrecher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Picrecher.BorderRadius = 27;
            this.Picrecher.Image = ((System.Drawing.Image)(resources.GetObject("Picrecher.Image")));
            this.Picrecher.IsCircle = true;
            this.Picrecher.Location = new System.Drawing.Point(1045, 282);
            this.Picrecher.Name = "Picrecher";
            this.Picrecher.Size = new System.Drawing.Size(55, 55);
            this.Picrecher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picrecher.TabIndex = 85;
            this.Picrecher.TabStop = false;
            this.Picrecher.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.Picrecher.Click += new System.EventHandler(this.Picrecher_Click_1);
            // 
            // txtreche
            // 
            this.txtreche.BackColor = System.Drawing.Color.Teal;
            this.txtreche.BorderRadius = 18;
            this.txtreche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtreche.DefaultText = "";
            this.txtreche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtreche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtreche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtreche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtreche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtreche.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtreche.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtreche.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtreche.Location = new System.Drawing.Point(829, 287);
            this.txtreche.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtreche.Name = "txtreche";
            this.txtreche.PasswordChar = '\0';
            this.txtreche.PlaceholderText = "Rechercher";
            this.txtreche.SelectedText = "";
            this.txtreche.Size = new System.Drawing.Size(268, 47);
            this.txtreche.TabIndex = 84;
            // 
            // btnAddChambre
            // 
            this.btnAddChambre.AllowAnimations = true;
            this.btnAddChambre.AllowMouseEffects = true;
            this.btnAddChambre.AllowToggling = false;
            this.btnAddChambre.AnimationSpeed = 200;
            this.btnAddChambre.AutoGenerateColors = false;
            this.btnAddChambre.AutoRoundBorders = true;
            this.btnAddChambre.AutoSizeLeftIcon = true;
            this.btnAddChambre.AutoSizeRightIcon = true;
            this.btnAddChambre.BackColor = System.Drawing.Color.Transparent;
            this.btnAddChambre.BackColor1 = System.Drawing.Color.White;
            this.btnAddChambre.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddChambre.BackgroundImage")));
            this.btnAddChambre.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddChambre.ButtonText = "Inserer";
            this.btnAddChambre.ButtonTextMarginLeft = 0;
            this.btnAddChambre.ColorContrastOnClick = 45;
            this.btnAddChambre.ColorContrastOnHover = 45;
            this.btnAddChambre.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnAddChambre.CustomizableEdges = borderEdges2;
            this.btnAddChambre.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddChambre.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddChambre.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddChambre.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddChambre.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnAddChambre.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddChambre.ForeColor = System.Drawing.Color.Teal;
            this.btnAddChambre.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddChambre.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddChambre.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btnAddChambre.IconMarginLeft = 11;
            this.btnAddChambre.IconPadding = 10;
            this.btnAddChambre.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddChambre.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btnAddChambre.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btnAddChambre.IconSize = 30;
            this.btnAddChambre.IdleBorderColor = System.Drawing.Color.Teal;
            this.btnAddChambre.IdleBorderRadius = 44;
            this.btnAddChambre.IdleBorderThickness = 1;
            this.btnAddChambre.IdleFillColor = System.Drawing.Color.White;
            this.btnAddChambre.IdleIconLeftImage = null;
            this.btnAddChambre.IdleIconRightImage = null;
            this.btnAddChambre.IndicateFocus = true;
            this.btnAddChambre.Location = new System.Drawing.Point(93, 287);
            this.btnAddChambre.Name = "btnAddChambre";
            this.btnAddChambre.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnAddChambre.OnDisabledState.BorderRadius = 20;
            this.btnAddChambre.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddChambre.OnDisabledState.BorderThickness = 1;
            this.btnAddChambre.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnAddChambre.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnAddChambre.OnDisabledState.IconLeftImage = null;
            this.btnAddChambre.OnDisabledState.IconRightImage = null;
            this.btnAddChambre.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddChambre.onHoverState.BorderRadius = 20;
            this.btnAddChambre.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddChambre.onHoverState.BorderThickness = 1;
            this.btnAddChambre.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnAddChambre.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnAddChambre.onHoverState.IconLeftImage = null;
            this.btnAddChambre.onHoverState.IconRightImage = null;
            this.btnAddChambre.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.btnAddChambre.OnIdleState.BorderRadius = 20;
            this.btnAddChambre.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddChambre.OnIdleState.BorderThickness = 1;
            this.btnAddChambre.OnIdleState.FillColor = System.Drawing.Color.White;
            this.btnAddChambre.OnIdleState.ForeColor = System.Drawing.Color.Teal;
            this.btnAddChambre.OnIdleState.IconLeftImage = null;
            this.btnAddChambre.OnIdleState.IconRightImage = null;
            this.btnAddChambre.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddChambre.OnPressedState.BorderRadius = 20;
            this.btnAddChambre.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnAddChambre.OnPressedState.BorderThickness = 1;
            this.btnAddChambre.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnAddChambre.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnAddChambre.OnPressedState.IconLeftImage = null;
            this.btnAddChambre.OnPressedState.IconRightImage = null;
            this.btnAddChambre.Size = new System.Drawing.Size(217, 46);
            this.btnAddChambre.TabIndex = 83;
            this.btnAddChambre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddChambre.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAddChambre.TextMarginLeft = 0;
            this.btnAddChambre.TextPadding = new System.Windows.Forms.Padding(2);
            this.btnAddChambre.UseDefaultRadiusAndThickness = true;
            this.btnAddChambre.Click += new System.EventHandler(this.btnAddChambre_Click);
            // 
            // Option
            // 
            this.Option.AllowAnimations = true;
            this.Option.AllowMouseEffects = true;
            this.Option.AllowToggling = false;
            this.Option.AnimationSpeed = 200;
            this.Option.AutoGenerateColors = false;
            this.Option.AutoRoundBorders = true;
            this.Option.AutoSizeLeftIcon = true;
            this.Option.AutoSizeRightIcon = true;
            this.Option.BackColor = System.Drawing.Color.Transparent;
            this.Option.BackColor1 = System.Drawing.Color.White;
            this.Option.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Option.BackgroundImage")));
            this.Option.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Option.ButtonText = "Modifier";
            this.Option.ButtonTextMarginLeft = 0;
            this.Option.ColorContrastOnClick = 45;
            this.Option.ColorContrastOnHover = 45;
            this.Option.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.Option.CustomizableEdges = borderEdges3;
            this.Option.DialogResult = System.Windows.Forms.DialogResult.None;
            this.Option.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Option.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Option.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Option.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.Option.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option.ForeColor = System.Drawing.Color.Teal;
            this.Option.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Option.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.Option.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.Option.IconMarginLeft = 11;
            this.Option.IconPadding = 10;
            this.Option.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Option.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.Option.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.Option.IconSize = 30;
            this.Option.IdleBorderColor = System.Drawing.Color.Teal;
            this.Option.IdleBorderRadius = 42;
            this.Option.IdleBorderThickness = 1;
            this.Option.IdleFillColor = System.Drawing.Color.White;
            this.Option.IdleIconLeftImage = null;
            this.Option.IdleIconRightImage = null;
            this.Option.IndicateFocus = true;
            this.Option.Location = new System.Drawing.Point(333, 288);
            this.Option.Name = "Option";
            this.Option.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.Option.OnDisabledState.BorderRadius = 20;
            this.Option.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Option.OnDisabledState.BorderThickness = 1;
            this.Option.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Option.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.Option.OnDisabledState.IconLeftImage = null;
            this.Option.OnDisabledState.IconRightImage = null;
            this.Option.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Option.onHoverState.BorderRadius = 20;
            this.Option.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Option.onHoverState.BorderThickness = 1;
            this.Option.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.Option.onHoverState.ForeColor = System.Drawing.Color.White;
            this.Option.onHoverState.IconLeftImage = null;
            this.Option.onHoverState.IconRightImage = null;
            this.Option.OnIdleState.BorderColor = System.Drawing.Color.Teal;
            this.Option.OnIdleState.BorderRadius = 20;
            this.Option.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Option.OnIdleState.BorderThickness = 1;
            this.Option.OnIdleState.FillColor = System.Drawing.Color.White;
            this.Option.OnIdleState.ForeColor = System.Drawing.Color.Teal;
            this.Option.OnIdleState.IconLeftImage = null;
            this.Option.OnIdleState.IconRightImage = null;
            this.Option.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Option.OnPressedState.BorderRadius = 20;
            this.Option.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.Option.OnPressedState.BorderThickness = 1;
            this.Option.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.Option.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.Option.OnPressedState.IconLeftImage = null;
            this.Option.OnPressedState.IconRightImage = null;
            this.Option.Size = new System.Drawing.Size(217, 44);
            this.Option.TabIndex = 82;
            this.Option.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Option.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.Option.TextMarginLeft = 0;
            this.Option.TextPadding = new System.Windows.Forms.Padding(2);
            this.Option.UseDefaultRadiusAndThickness = true;
            this.Option.Click += new System.EventHandler(this.Option_Click);
            // 
            // gunaLineTextBox1
            // 
            this.gunaLineTextBox1.BackColor = System.Drawing.Color.Teal;
            this.gunaLineTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaLineTextBox1.FocusedLineColor = System.Drawing.Color.White;
            this.gunaLineTextBox1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLineTextBox1.ForeColor = System.Drawing.Color.White;
            this.gunaLineTextBox1.LineColor = System.Drawing.Color.Black;
            this.gunaLineTextBox1.Location = new System.Drawing.Point(788, 206);
            this.gunaLineTextBox1.Name = "gunaLineTextBox1";
            this.gunaLineTextBox1.PasswordChar = '\0';
            this.gunaLineTextBox1.ReadOnly = true;
            this.gunaLineTextBox1.SelectedText = "";
            this.gunaLineTextBox1.Size = new System.Drawing.Size(157, 39);
            this.gunaLineTextBox1.TabIndex = 88;
            this.gunaLineTextBox1.TextChanged += new System.EventHandler(this.gunaLineTextBox1_TextChanged);
            // 
            // txtNo
            // 
            this.txtNo.BackColor = System.Drawing.Color.Teal;
            this.txtNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNo.FocusedLineColor = System.Drawing.Color.White;
            this.txtNo.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNo.ForeColor = System.Drawing.Color.White;
            this.txtNo.LineColor = System.Drawing.Color.Black;
            this.txtNo.Location = new System.Drawing.Point(394, 131);
            this.txtNo.Name = "txtNo";
            this.txtNo.PasswordChar = '\0';
            this.txtNo.ReadOnly = true;
            this.txtNo.SelectedText = "";
            this.txtNo.Size = new System.Drawing.Size(197, 39);
            this.txtNo.TabIndex = 50;
            this.txtNo.TextChanged += new System.EventHandler(this.txtNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(328, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 28);
            this.label2.TabIndex = 51;
            this.label2.Text = "No";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtType
            // 
            this.txtType.BackColor = System.Drawing.Color.Teal;
            this.txtType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtType.FocusedLineColor = System.Drawing.Color.White;
            this.txtType.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.Color.White;
            this.txtType.LineColor = System.Drawing.Color.Black;
            this.txtType.Location = new System.Drawing.Point(684, 131);
            this.txtType.Name = "txtType";
            this.txtType.PasswordChar = '\0';
            this.txtType.SelectedText = "";
            this.txtType.Size = new System.Drawing.Size(262, 39);
            this.txtType.TabIndex = 52;
            this.txtType.TextChanged += new System.EventHandler(this.txtType_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(615, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 28);
            this.label3.TabIndex = 53;
            this.label3.Text = "Type";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Teal;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Silver;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(446, 81);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(0);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Horizontal;
            this.bunifuSeparator1.Size = new System.Drawing.Size(424, 15);
            this.bunifuSeparator1.TabIndex = 64;
            this.bunifuSeparator1.Click += new System.EventHandler(this.bunifuSeparator1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(439, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(414, 34);
            this.label1.TabIndex = 65;
            this.label1.Text = "GESTION DES CHAMBRES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormChambre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1262, 734);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.viewschambre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNo);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChambre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChambre";
            this.Load += new System.EventHandler(this.FormChambre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewschambre)).EndInit();
            this.bunifuPanel1.ResumeLayout(false);
            this.bunifuPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picrecher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLineTextBox txtPrix;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuDataGridView viewschambre;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnAddChambre;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton Option;
        private Bunifu.UI.WinForms.BunifuPictureBox Picrecher;
        private Guna.UI2.WinForms.Guna2TextBox txtreche;
        private Guna.UI.WinForms.GunaRadioButton rbnon;
        private Guna.UI.WinForms.GunaRadioButton rboui;
        private Guna.UI.WinForms.GunaLineTextBox gunaLineTextBox1;
        private Guna.UI.WinForms.GunaLineTextBox txtNo;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaLineTextBox txtType;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
    }
}