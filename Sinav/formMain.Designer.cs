namespace Sinav
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblLogo = new Bunifu.UI.WinForms.BunifuLabel();
            this.pnlKategoriler = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFormMainClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnIstatislik = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSinavaGir = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.pnlTop.SuspendLayout();
            this.pnlKategoriler.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.pnlMain);
            this.bunifuGradientPanel1.Controls.Add(this.pnlTop);
            this.bunifuGradientPanel1.Controls.Add(this.pnlKategoriler);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.DarkSlateGray;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Gray;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(45)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(783, 496);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.Transparent;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(173, 67);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(610, 429);
            this.pnlMain.TabIndex = 2;
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlTop.Controls.Add(this.lblLogo);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(173, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(610, 67);
            this.pnlTop.TabIndex = 1;
            // 
            // lblLogo
            // 
            this.lblLogo.AutoEllipsis = false;
            this.lblLogo.AutoSize = false;
            this.lblLogo.CursorType = null;
            this.lblLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLogo.Font = new System.Drawing.Font("Showcard Gothic", 22.2F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.lblLogo.Location = new System.Drawing.Point(0, 0);
            this.lblLogo.Margin = new System.Windows.Forms.Padding(2);
            this.lblLogo.Name = "lblLogo";
            this.lblLogo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblLogo.Size = new System.Drawing.Size(610, 67);
            this.lblLogo.TabIndex = 0;
            this.lblLogo.Text = "MATH EXAM";
            this.lblLogo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblLogo.Click += new System.EventHandler(this.lblLogo_Click);
            // 
            // pnlKategoriler
            // 
            this.pnlKategoriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlKategoriler.Controls.Add(this.bunifuFlatButton2);
            this.pnlKategoriler.Controls.Add(this.bunifuFlatButton1);
            this.pnlKategoriler.Controls.Add(this.btnFormMainClose);
            this.pnlKategoriler.Controls.Add(this.btnIstatislik);
            this.pnlKategoriler.Controls.Add(this.btnSinavaGir);
            this.pnlKategoriler.Controls.Add(this.pnlLogo);
            this.pnlKategoriler.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlKategoriler.Location = new System.Drawing.Point(0, 0);
            this.pnlKategoriler.Margin = new System.Windows.Forms.Padding(2);
            this.pnlKategoriler.Name = "pnlKategoriler";
            this.pnlKategoriler.Size = new System.Drawing.Size(173, 496);
            this.pnlKategoriler.TabIndex = 0;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Active = false;
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "EXAM 3";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(7, 191);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(148, 51);
            this.bunifuFlatButton2.TabIndex = 5;
            this.bunifuFlatButton2.Text = "EXAM 3";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Active = false;
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DarkRed;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "EXAM 2";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(7, 132);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(148, 51);
            this.bunifuFlatButton1.TabIndex = 4;
            this.bunifuFlatButton1.Text = "EXAM 2";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.Silver;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnFormMainClose
            // 
            this.btnFormMainClose.AllowToggling = false;
            this.btnFormMainClose.AnimationSpeed = 200;
            this.btnFormMainClose.AutoGenerateColors = false;
            this.btnFormMainClose.BackColor = System.Drawing.Color.Transparent;
            this.btnFormMainClose.BackColor1 = System.Drawing.Color.Brown;
            this.btnFormMainClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFormMainClose.BackgroundImage")));
            this.btnFormMainClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFormMainClose.ButtonText = "LOG OUT";
            this.btnFormMainClose.ButtonTextMarginLeft = 0;
            this.btnFormMainClose.ColorContrastOnClick = 45;
            this.btnFormMainClose.ColorContrastOnHover = 45;
            this.btnFormMainClose.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnFormMainClose.CustomizableEdges = borderEdges1;
            this.btnFormMainClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFormMainClose.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btnFormMainClose.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFormMainClose.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnFormMainClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnFormMainClose.Font = new System.Drawing.Font("Showcard Gothic", 12F);
            this.btnFormMainClose.ForeColor = System.Drawing.Color.White;
            this.btnFormMainClose.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormMainClose.IconMarginLeft = 11;
            this.btnFormMainClose.IconPadding = 10;
            this.btnFormMainClose.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnFormMainClose.IdleBorderColor = System.Drawing.Color.DarkRed;
            this.btnFormMainClose.IdleBorderRadius = 3;
            this.btnFormMainClose.IdleBorderThickness = 1;
            this.btnFormMainClose.IdleFillColor = System.Drawing.Color.Brown;
            this.btnFormMainClose.IdleIconLeftImage = null;
            this.btnFormMainClose.IdleIconRightImage = null;
            this.btnFormMainClose.IndicateFocus = false;
            this.btnFormMainClose.Location = new System.Drawing.Point(0, 447);
            this.btnFormMainClose.Margin = new System.Windows.Forms.Padding(2);
            this.btnFormMainClose.Name = "btnFormMainClose";
            this.btnFormMainClose.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnFormMainClose.onHoverState.BorderRadius = 3;
            this.btnFormMainClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFormMainClose.onHoverState.BorderThickness = 1;
            this.btnFormMainClose.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnFormMainClose.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnFormMainClose.onHoverState.IconLeftImage = null;
            this.btnFormMainClose.onHoverState.IconRightImage = null;
            this.btnFormMainClose.OnIdleState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnFormMainClose.OnIdleState.BorderRadius = 3;
            this.btnFormMainClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFormMainClose.OnIdleState.BorderThickness = 1;
            this.btnFormMainClose.OnIdleState.FillColor = System.Drawing.Color.Brown;
            this.btnFormMainClose.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnFormMainClose.OnIdleState.IconLeftImage = null;
            this.btnFormMainClose.OnIdleState.IconRightImage = null;
            this.btnFormMainClose.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnFormMainClose.OnPressedState.BorderRadius = 3;
            this.btnFormMainClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnFormMainClose.OnPressedState.BorderThickness = 1;
            this.btnFormMainClose.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnFormMainClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnFormMainClose.OnPressedState.IconLeftImage = null;
            this.btnFormMainClose.OnPressedState.IconRightImage = null;
            this.btnFormMainClose.Size = new System.Drawing.Size(155, 49);
            this.btnFormMainClose.TabIndex = 2;
            this.btnFormMainClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFormMainClose.TextMarginLeft = 0;
            this.btnFormMainClose.UseDefaultRadiusAndThickness = true;
            this.btnFormMainClose.Click += new System.EventHandler(this.btnFormMainClose_Click);
            // 
            // btnIstatislik
            // 
            this.btnIstatislik.Active = false;
            this.btnIstatislik.Activecolor = System.Drawing.Color.DarkRed;
            this.btnIstatislik.BackColor = System.Drawing.Color.Transparent;
            this.btnIstatislik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIstatislik.BorderRadius = 0;
            this.btnIstatislik.ButtonText = "STATISTICS";
            this.btnIstatislik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIstatislik.DisabledColor = System.Drawing.Color.Gray;
            this.btnIstatislik.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIstatislik.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnIstatislik.Iconimage")));
            this.btnIstatislik.Iconimage_right = null;
            this.btnIstatislik.Iconimage_right_Selected = null;
            this.btnIstatislik.Iconimage_Selected = null;
            this.btnIstatislik.IconMarginLeft = 0;
            this.btnIstatislik.IconMarginRight = 0;
            this.btnIstatislik.IconRightVisible = true;
            this.btnIstatislik.IconRightZoom = 0D;
            this.btnIstatislik.IconVisible = true;
            this.btnIstatislik.IconZoom = 90D;
            this.btnIstatislik.IsTab = false;
            this.btnIstatislik.Location = new System.Drawing.Point(4, 320);
            this.btnIstatislik.Margin = new System.Windows.Forms.Padding(4);
            this.btnIstatislik.Name = "btnIstatislik";
            this.btnIstatislik.Normalcolor = System.Drawing.Color.Transparent;
            this.btnIstatislik.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnIstatislik.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIstatislik.selected = false;
            this.btnIstatislik.Size = new System.Drawing.Size(152, 51);
            this.btnIstatislik.TabIndex = 3;
            this.btnIstatislik.Text = "STATISTICS";
            this.btnIstatislik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIstatislik.Textcolor = System.Drawing.Color.Silver;
            this.btnIstatislik.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIstatislik.Click += new System.EventHandler(this.btnIstatislik_Click);
            // 
            // btnSinavaGir
            // 
            this.btnSinavaGir.Active = false;
            this.btnSinavaGir.Activecolor = System.Drawing.Color.DarkRed;
            this.btnSinavaGir.BackColor = System.Drawing.Color.Transparent;
            this.btnSinavaGir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSinavaGir.BorderRadius = 0;
            this.btnSinavaGir.ButtonText = "EXAM";
            this.btnSinavaGir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinavaGir.DisabledColor = System.Drawing.Color.Gray;
            this.btnSinavaGir.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSinavaGir.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSinavaGir.Iconimage")));
            this.btnSinavaGir.Iconimage_right = null;
            this.btnSinavaGir.Iconimage_right_Selected = null;
            this.btnSinavaGir.Iconimage_Selected = null;
            this.btnSinavaGir.IconMarginLeft = 0;
            this.btnSinavaGir.IconMarginRight = 0;
            this.btnSinavaGir.IconRightVisible = true;
            this.btnSinavaGir.IconRightZoom = 0D;
            this.btnSinavaGir.IconVisible = true;
            this.btnSinavaGir.IconZoom = 90D;
            this.btnSinavaGir.IsTab = false;
            this.btnSinavaGir.Location = new System.Drawing.Point(4, 73);
            this.btnSinavaGir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSinavaGir.Name = "btnSinavaGir";
            this.btnSinavaGir.Normalcolor = System.Drawing.Color.Transparent;
            this.btnSinavaGir.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSinavaGir.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSinavaGir.selected = false;
            this.btnSinavaGir.Size = new System.Drawing.Size(148, 51);
            this.btnSinavaGir.TabIndex = 2;
            this.btnSinavaGir.Text = "EXAM";
            this.btnSinavaGir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSinavaGir.Textcolor = System.Drawing.Color.Silver;
            this.btnSinavaGir.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSinavaGir.Click += new System.EventHandler(this.btnSinavaGir_Click);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.pnlLogo.Controls.Add(this.bunifuImageButton1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(173, 67);
            this.pnlLogo.TabIndex = 2;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(44, 2);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(2);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(59, 58);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 1;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 496);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formMain";
            this.Text = "formMain";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            this.pnlKategoriler.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Panel pnlKategoriler;
        private Bunifu.Framework.UI.BunifuFlatButton btnIstatislik;
        private Bunifu.Framework.UI.BunifuFlatButton btnSinavaGir;
        private System.Windows.Forms.Panel pnlLogo;
        private Bunifu.UI.WinForms.BunifuLabel lblLogo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnFormMainClose;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel pnlMain;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}