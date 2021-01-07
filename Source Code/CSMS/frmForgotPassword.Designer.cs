namespace CSMS
{
    partial class frmForgotPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmForgotPassword));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnResetPwd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnReturn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.beRegister = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txtUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pbLogo, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbTitle, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnReturn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnResetPwd, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtUsername, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 101F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 650);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtEmail.ForeColor = System.Drawing.Color.White;
            this.txtEmail.HintForeColor = System.Drawing.Color.White;
            this.txtEmail.HintText = "Email";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Red;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Red;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtEmail.LineThickness = 4;
            this.txtEmail.Location = new System.Drawing.Point(56, 216);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(368, 37);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnResetPwd
            // 
            this.btnResetPwd.ActiveBorderThickness = 1;
            this.btnResetPwd.ActiveCornerRadius = 20;
            this.btnResetPwd.ActiveFillColor = System.Drawing.Color.Brown;
            this.btnResetPwd.ActiveForecolor = System.Drawing.Color.White;
            this.btnResetPwd.ActiveLineColor = System.Drawing.Color.Brown;
            this.btnResetPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnResetPwd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnResetPwd.BackgroundImage")));
            this.btnResetPwd.ButtonText = "Đặt lại mật khẩu";
            this.btnResetPwd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetPwd.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResetPwd.ForeColor = System.Drawing.Color.White;
            this.btnResetPwd.IdleBorderThickness = 1;
            this.btnResetPwd.IdleCornerRadius = 20;
            this.btnResetPwd.IdleFillColor = System.Drawing.Color.Red;
            this.btnResetPwd.IdleForecolor = System.Drawing.Color.White;
            this.btnResetPwd.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnResetPwd.Location = new System.Drawing.Point(57, 370);
            this.btnResetPwd.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnResetPwd.Name = "btnResetPwd";
            this.btnResetPwd.Size = new System.Drawing.Size(366, 60);
            this.btnResetPwd.TabIndex = 1;
            this.btnResetPwd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnResetPwd.Click += new System.EventHandler(this.btnResetPwd_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pbLogo.Image = global::CSMS.Properties.Resources._1280px_UNO_Logo_svg;
            this.pbLogo.Location = new System.Drawing.Point(162, 47);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(156, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 7;
            this.pbLogo.TabStop = false;
            // 
            // lbTitle
            // 
            this.lbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(84, 164);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(311, 32);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "RẠP CHIẾU PHIM UNO";
            // 
            // btnReturn
            // 
            this.btnReturn.ActiveBorderThickness = 1;
            this.btnReturn.ActiveCornerRadius = 20;
            this.btnReturn.ActiveFillColor = System.Drawing.Color.Brown;
            this.btnReturn.ActiveForecolor = System.Drawing.Color.White;
            this.btnReturn.ActiveLineColor = System.Drawing.Color.Brown;
            this.btnReturn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.ButtonText = "QUAY LẠI";
            this.btnReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.IdleBorderThickness = 1;
            this.btnReturn.IdleCornerRadius = 20;
            this.btnReturn.IdleFillColor = System.Drawing.Color.Red;
            this.btnReturn.IdleForecolor = System.Drawing.Color.White;
            this.btnReturn.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnReturn.Location = new System.Drawing.Point(140, 458);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(200, 60);
            this.btnReturn.TabIndex = 8;
            this.btnReturn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // beRegister
            // 
            this.beRegister.ElipseRadius = 15;
            this.beRegister.TargetControl = this;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.HintForeColor = System.Drawing.Color.White;
            this.txtUsername.HintText = "Tên đăng nhập";
            this.txtUsername.isPassword = false;
            this.txtUsername.LineFocusedColor = System.Drawing.Color.Red;
            this.txtUsername.LineIdleColor = System.Drawing.Color.Red;
            this.txtUsername.LineMouseHoverColor = System.Drawing.Color.Red;
            this.txtUsername.LineThickness = 4;
            this.txtUsername.Location = new System.Drawing.Point(56, 286);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(368, 37);
            this.txtUsername.TabIndex = 9;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frmForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 650);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmForgotPassword";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuThinButton2 btnResetPwd;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lbTitle;
        private Bunifu.Framework.UI.BunifuThinButton2 btnReturn;
        private Bunifu.Framework.UI.BunifuElipse beRegister;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtUsername;
    }
}