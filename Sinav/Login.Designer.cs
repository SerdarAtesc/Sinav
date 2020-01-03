namespace Sinav
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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnStudentLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnTeacherlogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnClose = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuGradientPanel1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.bunifuGradientPanel1.Controls.Add(this.pnlLogin);
            this.bunifuGradientPanel1.Controls.Add(this.btnClose);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Yellow;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Chartreuse;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(545, 557);
            this.bunifuGradientPanel1.TabIndex = 4;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.Controls.Add(this.groupBox1);
            this.pnlLogin.Location = new System.Drawing.Point(12, 54);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(494, 479);
            this.pnlLogin.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnStudentLogin);
            this.groupBox1.Controls.Add(this.btnTeacherlogin);
            this.groupBox1.Font = new System.Drawing.Font("Cooper Black", 10.2F, System.Drawing.FontStyle.Italic);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.groupBox1.Location = new System.Drawing.Point(50, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 305);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOGIN";
            // 
            // btnStudentLogin
            // 
            this.btnStudentLogin.Active = false;
            this.btnStudentLogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStudentLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStudentLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStudentLogin.BorderRadius = 0;
            this.btnStudentLogin.ButtonText = "STUDENT LOGIN";
            this.btnStudentLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStudentLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnStudentLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnStudentLogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnStudentLogin.Iconimage")));
            this.btnStudentLogin.Iconimage_right = null;
            this.btnStudentLogin.Iconimage_right_Selected = null;
            this.btnStudentLogin.Iconimage_Selected = null;
            this.btnStudentLogin.IconMarginLeft = 0;
            this.btnStudentLogin.IconMarginRight = 0;
            this.btnStudentLogin.IconRightVisible = true;
            this.btnStudentLogin.IconRightZoom = 0D;
            this.btnStudentLogin.IconVisible = true;
            this.btnStudentLogin.IconZoom = 90D;
            this.btnStudentLogin.IsTab = false;
            this.btnStudentLogin.Location = new System.Drawing.Point(54, 172);
            this.btnStudentLogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnStudentLogin.Name = "btnStudentLogin";
            this.btnStudentLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnStudentLogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnStudentLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnStudentLogin.selected = false;
            this.btnStudentLogin.Size = new System.Drawing.Size(292, 74);
            this.btnStudentLogin.TabIndex = 5;
            this.btnStudentLogin.Text = "STUDENT LOGIN";
            this.btnStudentLogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStudentLogin.Textcolor = System.Drawing.Color.White;
            this.btnStudentLogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudentLogin.Click += new System.EventHandler(this.btnStudentLogin_Click);
            // 
            // btnTeacherlogin
            // 
            this.btnTeacherlogin.Active = false;
            this.btnTeacherlogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTeacherlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTeacherlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTeacherlogin.BorderRadius = 0;
            this.btnTeacherlogin.ButtonText = "TEACHER LOGIN";
            this.btnTeacherlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTeacherlogin.DisabledColor = System.Drawing.Color.Gray;
            this.btnTeacherlogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTeacherlogin.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnTeacherlogin.Iconimage")));
            this.btnTeacherlogin.Iconimage_right = null;
            this.btnTeacherlogin.Iconimage_right_Selected = null;
            this.btnTeacherlogin.Iconimage_Selected = null;
            this.btnTeacherlogin.IconMarginLeft = 0;
            this.btnTeacherlogin.IconMarginRight = 0;
            this.btnTeacherlogin.IconRightVisible = true;
            this.btnTeacherlogin.IconRightZoom = 0D;
            this.btnTeacherlogin.IconVisible = true;
            this.btnTeacherlogin.IconZoom = 90D;
            this.btnTeacherlogin.IsTab = false;
            this.btnTeacherlogin.Location = new System.Drawing.Point(54, 78);
            this.btnTeacherlogin.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnTeacherlogin.Name = "btnTeacherlogin";
            this.btnTeacherlogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnTeacherlogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnTeacherlogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTeacherlogin.selected = false;
            this.btnTeacherlogin.Size = new System.Drawing.Size(292, 69);
            this.btnTeacherlogin.TabIndex = 5;
            this.btnTeacherlogin.Text = "TEACHER LOGIN";
            this.btnTeacherlogin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeacherlogin.Textcolor = System.Drawing.Color.White;
            this.btnTeacherlogin.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTeacherlogin.Click += new System.EventHandler(this.btnTeacherlogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.AllowToggling = false;
            this.btnClose.AnimationSpeed = 200;
            this.btnClose.AutoGenerateColors = false;
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackColor1 = System.Drawing.Color.DarkRed;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.ButtonText = "X";
            this.btnClose.ButtonTextMarginLeft = 0;
            this.btnClose.ColorContrastOnClick = 45;
            this.btnClose.ColorContrastOnHover = 45;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnClose.CustomizableEdges = borderEdges1;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.DisabledBorderColor = System.Drawing.Color.Empty;
            this.btnClose.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnClose.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btnClose.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btnClose.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.IconMarginLeft = 11;
            this.btnClose.IconPadding = 10;
            this.btnClose.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.IdleBorderColor = System.Drawing.Color.DarkRed;
            this.btnClose.IdleBorderRadius = 3;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleFillColor = System.Drawing.Color.DarkRed;
            this.btnClose.IdleIconLeftImage = null;
            this.btnClose.IdleIconRightImage = null;
            this.btnClose.IndicateFocus = false;
            this.btnClose.Location = new System.Drawing.Point(466, 4);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnClose.onHoverState.BorderRadius = 3;
            this.btnClose.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.onHoverState.BorderThickness = 1;
            this.btnClose.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.btnClose.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btnClose.onHoverState.IconLeftImage = null;
            this.btnClose.onHoverState.IconRightImage = null;
            this.btnClose.OnIdleState.BorderColor = System.Drawing.Color.DarkRed;
            this.btnClose.OnIdleState.BorderRadius = 3;
            this.btnClose.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnIdleState.BorderThickness = 1;
            this.btnClose.OnIdleState.FillColor = System.Drawing.Color.DarkRed;
            this.btnClose.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnIdleState.IconLeftImage = null;
            this.btnClose.OnIdleState.IconRightImage = null;
            this.btnClose.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.OnPressedState.BorderRadius = 3;
            this.btnClose.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btnClose.OnPressedState.BorderThickness = 1;
            this.btnClose.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btnClose.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btnClose.OnPressedState.IconLeftImage = null;
            this.btnClose.OnPressedState.IconRightImage = null;
            this.btnClose.Size = new System.Drawing.Size(67, 34);
            this.btnClose.TabIndex = 4;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.TextMarginLeft = 0;
            this.btnClose.UseDefaultRadiusAndThickness = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 557);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Login";
            this.Text = "Form1";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnStudentLogin;
        private Bunifu.Framework.UI.BunifuFlatButton btnTeacherlogin;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btnClose;
        private System.Windows.Forms.Panel pnlLogin;
    }
}

