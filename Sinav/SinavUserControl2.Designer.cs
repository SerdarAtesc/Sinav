namespace Sinav
{
    partial class SinavUserControl2
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SinavUserControl2));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges7 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges8 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.picBoxResim = new System.Windows.Forms.PictureBox();
            this.btnB = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnD = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnA = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btnC = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblSoru = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // picBoxResim
            // 
            this.picBoxResim.Image = ((System.Drawing.Image)(resources.GetObject("picBoxResim.Image")));
            this.picBoxResim.Location = new System.Drawing.Point(97, 62);
            this.picBoxResim.Margin = new System.Windows.Forms.Padding(2);
            this.picBoxResim.Name = "picBoxResim";
            this.picBoxResim.Size = new System.Drawing.Size(329, 103);
            this.picBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxResim.TabIndex = 8;
            this.picBoxResim.TabStop = false;
            // 
            // btnB
            // 
            this.btnB.AllowToggling = false;
            this.btnB.AnimationSpeed = 200;
            this.btnB.AutoGenerateColors = false;
            this.btnB.BackColor = System.Drawing.Color.Transparent;
            this.btnB.BackColor1 = System.Drawing.Color.DarkRed;
            this.btnB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnB.BackgroundImage")));
            this.btnB.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnB.ButtonText = "B sikki";
            this.btnB.ButtonTextMarginLeft = 0;
            this.btnB.ColorContrastOnClick = 45;
            this.btnB.ColorContrastOnHover = 45;
            this.btnB.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges5.BottomLeft = true;
            borderEdges5.BottomRight = true;
            borderEdges5.TopLeft = true;
            borderEdges5.TopRight = true;
            this.btnB.CustomizableEdges = borderEdges5;
            this.btnB.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnB.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnB.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnB.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnB.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnB.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnB.ForeColor = System.Drawing.Color.White;
            this.btnB.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnB.IconMarginLeft = 11;
            this.btnB.IconPadding = 10;
            this.btnB.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnB.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnB.IdleBorderRadius = 3;
            this.btnB.IdleBorderThickness = 1;
            this.btnB.IdleFillColor = System.Drawing.Color.DarkRed;
            this.btnB.IdleIconLeftImage = null;
            this.btnB.IdleIconRightImage = null;
            this.btnB.IndicateFocus = false;
            this.btnB.Location = new System.Drawing.Point(97, 288);
            this.btnB.Margin = new System.Windows.Forms.Padding(2);
            this.btnB.Name = "btnB";
            this.btnB.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnB.onHoverState.BorderRadius = 3;
            this.btnB.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnB.onHoverState.BorderThickness = 1;
            this.btnB.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnB.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnB.onHoverState.IconLeftImage = null;
            this.btnB.onHoverState.IconRightImage = null;
            this.btnB.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnB.OnIdleState.BorderRadius = 3;
            this.btnB.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnB.OnIdleState.BorderThickness = 1;
            this.btnB.OnIdleState.FillColor = System.Drawing.Color.DarkRed;
            this.btnB.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnB.OnIdleState.IconLeftImage = null;
            this.btnB.OnIdleState.IconRightImage = null;
            this.btnB.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnB.OnPressedState.BorderRadius = 3;
            this.btnB.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnB.OnPressedState.BorderThickness = 1;
            this.btnB.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnB.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnB.OnPressedState.IconLeftImage = null;
            this.btnB.OnPressedState.IconRightImage = null;
            this.btnB.Size = new System.Drawing.Size(158, 37);
            this.btnB.TabIndex = 4;
            this.btnB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnB.TextMarginLeft = 0;
            this.btnB.UseDefaultRadiusAndThickness = true;
            this.btnB.Click += new System.EventHandler(this.btnB_Click);
            // 
            // btnD
            // 
            this.btnD.AllowToggling = false;
            this.btnD.AnimationSpeed = 200;
            this.btnD.AutoGenerateColors = false;
            this.btnD.BackColor = System.Drawing.Color.Transparent;
            this.btnD.BackColor1 = System.Drawing.Color.DarkRed;
            this.btnD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnD.BackgroundImage")));
            this.btnD.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnD.ButtonText = "D sikki";
            this.btnD.ButtonTextMarginLeft = 0;
            this.btnD.ColorContrastOnClick = 45;
            this.btnD.ColorContrastOnHover = 45;
            this.btnD.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges6.BottomLeft = true;
            borderEdges6.BottomRight = true;
            borderEdges6.TopLeft = true;
            borderEdges6.TopRight = true;
            this.btnD.CustomizableEdges = borderEdges6;
            this.btnD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnD.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnD.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnD.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnD.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnD.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnD.ForeColor = System.Drawing.Color.White;
            this.btnD.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnD.IconMarginLeft = 11;
            this.btnD.IconPadding = 10;
            this.btnD.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnD.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnD.IdleBorderRadius = 3;
            this.btnD.IdleBorderThickness = 1;
            this.btnD.IdleFillColor = System.Drawing.Color.DarkRed;
            this.btnD.IdleIconLeftImage = null;
            this.btnD.IdleIconRightImage = null;
            this.btnD.IndicateFocus = false;
            this.btnD.Location = new System.Drawing.Point(269, 288);
            this.btnD.Margin = new System.Windows.Forms.Padding(2);
            this.btnD.Name = "btnD";
            this.btnD.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnD.onHoverState.BorderRadius = 3;
            this.btnD.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnD.onHoverState.BorderThickness = 1;
            this.btnD.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnD.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnD.onHoverState.IconLeftImage = null;
            this.btnD.onHoverState.IconRightImage = null;
            this.btnD.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnD.OnIdleState.BorderRadius = 3;
            this.btnD.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnD.OnIdleState.BorderThickness = 1;
            this.btnD.OnIdleState.FillColor = System.Drawing.Color.DarkRed;
            this.btnD.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnD.OnIdleState.IconLeftImage = null;
            this.btnD.OnIdleState.IconRightImage = null;
            this.btnD.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnD.OnPressedState.BorderRadius = 3;
            this.btnD.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnD.OnPressedState.BorderThickness = 1;
            this.btnD.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnD.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnD.OnPressedState.IconLeftImage = null;
            this.btnD.OnPressedState.IconRightImage = null;
            this.btnD.Size = new System.Drawing.Size(158, 37);
            this.btnD.TabIndex = 5;
            this.btnD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnD.TextMarginLeft = 0;
            this.btnD.UseDefaultRadiusAndThickness = true;
            this.btnD.Click += new System.EventHandler(this.btnD_Click);
            // 
            // btnA
            // 
            this.btnA.AllowToggling = false;
            this.btnA.AnimationSpeed = 200;
            this.btnA.AutoGenerateColors = false;
            this.btnA.BackColor = System.Drawing.Color.Transparent;
            this.btnA.BackColor1 = System.Drawing.Color.DarkRed;
            this.btnA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnA.BackgroundImage")));
            this.btnA.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnA.ButtonText = "A sikki";
            this.btnA.ButtonTextMarginLeft = 0;
            this.btnA.ColorContrastOnClick = 45;
            this.btnA.ColorContrastOnHover = 45;
            this.btnA.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges7.BottomLeft = true;
            borderEdges7.BottomRight = true;
            borderEdges7.TopLeft = true;
            borderEdges7.TopRight = true;
            this.btnA.CustomizableEdges = borderEdges7;
            this.btnA.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnA.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnA.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnA.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnA.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnA.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnA.ForeColor = System.Drawing.Color.White;
            this.btnA.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnA.IconMarginLeft = 11;
            this.btnA.IconPadding = 10;
            this.btnA.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnA.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnA.IdleBorderRadius = 3;
            this.btnA.IdleBorderThickness = 1;
            this.btnA.IdleFillColor = System.Drawing.Color.DarkRed;
            this.btnA.IdleIconLeftImage = null;
            this.btnA.IdleIconRightImage = null;
            this.btnA.IndicateFocus = false;
            this.btnA.Location = new System.Drawing.Point(97, 215);
            this.btnA.Margin = new System.Windows.Forms.Padding(2);
            this.btnA.Name = "btnA";
            this.btnA.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnA.onHoverState.BorderRadius = 3;
            this.btnA.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnA.onHoverState.BorderThickness = 1;
            this.btnA.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnA.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnA.onHoverState.IconLeftImage = null;
            this.btnA.onHoverState.IconRightImage = null;
            this.btnA.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnA.OnIdleState.BorderRadius = 3;
            this.btnA.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnA.OnIdleState.BorderThickness = 1;
            this.btnA.OnIdleState.FillColor = System.Drawing.Color.DarkRed;
            this.btnA.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnA.OnIdleState.IconLeftImage = null;
            this.btnA.OnIdleState.IconRightImage = null;
            this.btnA.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnA.OnPressedState.BorderRadius = 3;
            this.btnA.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnA.OnPressedState.BorderThickness = 1;
            this.btnA.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnA.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnA.OnPressedState.IconLeftImage = null;
            this.btnA.OnPressedState.IconRightImage = null;
            this.btnA.Size = new System.Drawing.Size(158, 37);
            this.btnA.TabIndex = 6;
            this.btnA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnA.TextMarginLeft = 0;
            this.btnA.UseDefaultRadiusAndThickness = true;
            this.btnA.Click += new System.EventHandler(this.btnA_Click);
            // 
            // btnC
            // 
            this.btnC.AllowToggling = false;
            this.btnC.AnimationSpeed = 200;
            this.btnC.AutoGenerateColors = false;
            this.btnC.BackColor = System.Drawing.Color.Transparent;
            this.btnC.BackColor1 = System.Drawing.Color.DarkRed;
            this.btnC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnC.BackgroundImage")));
            this.btnC.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnC.ButtonText = "C sikki";
            this.btnC.ButtonTextMarginLeft = 0;
            this.btnC.ColorContrastOnClick = 45;
            this.btnC.ColorContrastOnHover = 45;
            this.btnC.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges8.BottomLeft = true;
            borderEdges8.BottomRight = true;
            borderEdges8.TopLeft = true;
            borderEdges8.TopRight = true;
            this.btnC.CustomizableEdges = borderEdges8;
            this.btnC.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnC.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnC.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnC.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnC.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnC.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.btnC.ForeColor = System.Drawing.Color.White;
            this.btnC.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnC.IconMarginLeft = 11;
            this.btnC.IconPadding = 10;
            this.btnC.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnC.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.btnC.IdleBorderRadius = 3;
            this.btnC.IdleBorderThickness = 1;
            this.btnC.IdleFillColor = System.Drawing.Color.DarkRed;
            this.btnC.IdleIconLeftImage = null;
            this.btnC.IdleIconRightImage = null;
            this.btnC.IndicateFocus = false;
            this.btnC.Location = new System.Drawing.Point(269, 215);
            this.btnC.Margin = new System.Windows.Forms.Padding(2);
            this.btnC.Name = "btnC";
            this.btnC.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnC.onHoverState.BorderRadius = 3;
            this.btnC.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnC.onHoverState.BorderThickness = 1;
            this.btnC.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnC.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnC.onHoverState.IconLeftImage = null;
            this.btnC.onHoverState.IconRightImage = null;
            this.btnC.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnC.OnIdleState.BorderRadius = 3;
            this.btnC.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnC.OnIdleState.BorderThickness = 1;
            this.btnC.OnIdleState.FillColor = System.Drawing.Color.DarkRed;
            this.btnC.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnC.OnIdleState.IconLeftImage = null;
            this.btnC.OnIdleState.IconRightImage = null;
            this.btnC.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnC.OnPressedState.BorderRadius = 3;
            this.btnC.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnC.OnPressedState.BorderThickness = 1;
            this.btnC.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnC.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnC.OnPressedState.IconLeftImage = null;
            this.btnC.OnPressedState.IconRightImage = null;
            this.btnC.Size = new System.Drawing.Size(158, 37);
            this.btnC.TabIndex = 7;
            this.btnC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnC.TextMarginLeft = 0;
            this.btnC.UseDefaultRadiusAndThickness = true;
            this.btnC.Click += new System.EventHandler(this.btnC_Click);
            // 
            // lblSoru
            // 
            this.lblSoru.AutoSize = true;
            this.lblSoru.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoru.Location = new System.Drawing.Point(103, 179);
            this.lblSoru.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSoru.Name = "lblSoru";
            this.lblSoru.Size = new System.Drawing.Size(43, 14);
            this.lblSoru.TabIndex = 3;
            this.lblSoru.Text = "SORU";
            // 
            // SinavUserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picBoxResim);
            this.Controls.Add(this.btnB);
            this.Controls.Add(this.btnD);
            this.Controls.Add(this.btnA);
            this.Controls.Add(this.btnC);
            this.Controls.Add(this.lblSoru);
            this.Name = "SinavUserControl2";
            this.Size = new System.Drawing.Size(524, 387);
            this.Load += new System.EventHandler(this.SinavUserControl2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxResim;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnB;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnD;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnA;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnC;
        private Bunifu.Framework.UI.BunifuCustomLabel lblSoru;
    }
}
