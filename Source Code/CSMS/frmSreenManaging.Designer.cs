namespace CSMS
{
    partial class frmSreenManaging
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSreenManaging));
            this.flpSeat = new System.Windows.Forms.FlowLayoutPanel();
            this.pInsert = new System.Windows.Forms.Panel();
            this.btnSeatAdd = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDeleteScreen = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnAddCinema = new Bunifu.Framework.UI.BunifuThinButton2();
            this.lbScreen = new System.Windows.Forms.Label();
            this.cbScreen = new System.Windows.Forms.ComboBox();
            this.lbScreenName = new System.Windows.Forms.Label();
            this.cbTheater = new System.Windows.Forms.ComboBox();
            this.lbTheaterName = new System.Windows.Forms.Label();
            this.pChooseScreen = new System.Windows.Forms.Panel();
            this.beInsert = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pSeat = new System.Windows.Forms.Panel();
            this.beChooseScreen = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.beSeat = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.tbScreenInsertName = new System.Windows.Forms.TextBox();
            this.pInsert.SuspendLayout();
            this.pChooseScreen.SuspendLayout();
            this.pSeat.SuspendLayout();
            this.SuspendLayout();
            // 
            // flpSeat
            // 
            this.flpSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.flpSeat.Location = new System.Drawing.Point(10, 30);
            this.flpSeat.Name = "flpSeat";
            this.flpSeat.Size = new System.Drawing.Size(730, 260);
            this.flpSeat.TabIndex = 0;
            // 
            // pInsert
            // 
            this.pInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.pInsert.Controls.Add(this.tbScreenInsertName);
            this.pInsert.Controls.Add(this.btnSeatAdd);
            this.pInsert.Controls.Add(this.btnDeleteScreen);
            this.pInsert.Controls.Add(this.btnAddCinema);
            this.pInsert.Controls.Add(this.lbScreen);
            this.pInsert.Location = new System.Drawing.Point(770, 192);
            this.pInsert.Name = "pInsert";
            this.pInsert.Size = new System.Drawing.Size(580, 210);
            this.pInsert.TabIndex = 14;
            // 
            // btnSeatAdd
            // 
            this.btnSeatAdd.ActiveBorderThickness = 1;
            this.btnSeatAdd.ActiveCornerRadius = 15;
            this.btnSeatAdd.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSeatAdd.ActiveForecolor = System.Drawing.Color.White;
            this.btnSeatAdd.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnSeatAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnSeatAdd.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSeatAdd.BackgroundImage")));
            this.btnSeatAdd.ButtonText = "THÊM GHẾ";
            this.btnSeatAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeatAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeatAdd.ForeColor = System.Drawing.Color.White;
            this.btnSeatAdd.IdleBorderThickness = 1;
            this.btnSeatAdd.IdleCornerRadius = 15;
            this.btnSeatAdd.IdleFillColor = System.Drawing.Color.Red;
            this.btnSeatAdd.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnSeatAdd.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnSeatAdd.Location = new System.Drawing.Point(250, 136);
            this.btnSeatAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnSeatAdd.Name = "btnSeatAdd";
            this.btnSeatAdd.Size = new System.Drawing.Size(290, 60);
            this.btnSeatAdd.TabIndex = 33;
            this.btnSeatAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSeatAdd.Click += new System.EventHandler(this.btnSeatAdd_Click);
            // 
            // btnDeleteScreen
            // 
            this.btnDeleteScreen.ActiveBorderThickness = 1;
            this.btnDeleteScreen.ActiveCornerRadius = 15;
            this.btnDeleteScreen.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDeleteScreen.ActiveForecolor = System.Drawing.Color.White;
            this.btnDeleteScreen.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnDeleteScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnDeleteScreen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDeleteScreen.BackgroundImage")));
            this.btnDeleteScreen.ButtonText = "XÓA";
            this.btnDeleteScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteScreen.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteScreen.ForeColor = System.Drawing.Color.White;
            this.btnDeleteScreen.IdleBorderThickness = 1;
            this.btnDeleteScreen.IdleCornerRadius = 15;
            this.btnDeleteScreen.IdleFillColor = System.Drawing.Color.Red;
            this.btnDeleteScreen.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnDeleteScreen.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnDeleteScreen.Location = new System.Drawing.Point(400, 66);
            this.btnDeleteScreen.Margin = new System.Windows.Forms.Padding(5);
            this.btnDeleteScreen.Name = "btnDeleteScreen";
            this.btnDeleteScreen.Size = new System.Drawing.Size(140, 60);
            this.btnDeleteScreen.TabIndex = 34;
            this.btnDeleteScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteScreen.Click += new System.EventHandler(this.btnDeleteScreen_Click);
            // 
            // btnAddCinema
            // 
            this.btnAddCinema.ActiveBorderThickness = 1;
            this.btnAddCinema.ActiveCornerRadius = 15;
            this.btnAddCinema.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddCinema.ActiveForecolor = System.Drawing.Color.White;
            this.btnAddCinema.ActiveLineColor = System.Drawing.Color.Transparent;
            this.btnAddCinema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnAddCinema.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddCinema.BackgroundImage")));
            this.btnAddCinema.ButtonText = "THÊM";
            this.btnAddCinema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCinema.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCinema.ForeColor = System.Drawing.Color.White;
            this.btnAddCinema.IdleBorderThickness = 1;
            this.btnAddCinema.IdleCornerRadius = 15;
            this.btnAddCinema.IdleFillColor = System.Drawing.Color.Red;
            this.btnAddCinema.IdleForecolor = System.Drawing.Color.Transparent;
            this.btnAddCinema.IdleLineColor = System.Drawing.Color.Transparent;
            this.btnAddCinema.Location = new System.Drawing.Point(250, 66);
            this.btnAddCinema.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddCinema.Name = "btnAddCinema";
            this.btnAddCinema.Size = new System.Drawing.Size(140, 60);
            this.btnAddCinema.TabIndex = 32;
            this.btnAddCinema.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddCinema.Click += new System.EventHandler(this.btnAddCinema_Click);
            // 
            // lbScreen
            // 
            this.lbScreen.AutoSize = true;
            this.lbScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbScreen.ForeColor = System.Drawing.Color.White;
            this.lbScreen.Location = new System.Drawing.Point(5, 23);
            this.lbScreen.Name = "lbScreen";
            this.lbScreen.Size = new System.Drawing.Size(246, 32);
            this.lbScreen.TabIndex = 9;
            this.lbScreen.Text = "Nhập phòng chiếu";
            // 
            // cbScreen
            // 
            this.cbScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cbScreen.FormattingEnabled = true;
            this.cbScreen.Location = new System.Drawing.Point(250, 93);
            this.cbScreen.Name = "cbScreen";
            this.cbScreen.Size = new System.Drawing.Size(290, 39);
            this.cbScreen.TabIndex = 7;
            this.cbScreen.SelectedIndexChanged += new System.EventHandler(this.cbScreen_SelectedIndexChanged);
            // 
            // lbScreenName
            // 
            this.lbScreenName.AutoSize = true;
            this.lbScreenName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.lbScreenName.ForeColor = System.Drawing.Color.White;
            this.lbScreenName.Location = new System.Drawing.Point(5, 100);
            this.lbScreenName.Name = "lbScreenName";
            this.lbScreenName.Size = new System.Drawing.Size(227, 32);
            this.lbScreenName.TabIndex = 4;
            this.lbScreenName.Text = "Tên phòng chiếu";
            // 
            // cbTheater
            // 
            this.cbTheater.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.cbTheater.FormattingEnabled = true;
            this.cbTheater.Location = new System.Drawing.Point(250, 23);
            this.cbTheater.Name = "cbTheater";
            this.cbTheater.Size = new System.Drawing.Size(290, 39);
            this.cbTheater.TabIndex = 6;
            this.cbTheater.SelectedIndexChanged += new System.EventHandler(this.cbTheater_SelectedIndexChanged);
            // 
            // lbTheaterName
            // 
            this.lbTheaterName.AutoSize = true;
            this.lbTheaterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTheaterName.ForeColor = System.Drawing.Color.White;
            this.lbTheaterName.Location = new System.Drawing.Point(5, 30);
            this.lbTheaterName.Name = "lbTheaterName";
            this.lbTheaterName.Size = new System.Drawing.Size(123, 32);
            this.lbTheaterName.TabIndex = 3;
            this.lbTheaterName.Text = "Tên Rạp";
            // 
            // pChooseScreen
            // 
            this.pChooseScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.pChooseScreen.Controls.Add(this.lbTheaterName);
            this.pChooseScreen.Controls.Add(this.cbTheater);
            this.pChooseScreen.Controls.Add(this.lbScreenName);
            this.pChooseScreen.Controls.Add(this.cbScreen);
            this.pChooseScreen.Location = new System.Drawing.Point(770, 10);
            this.pChooseScreen.Name = "pChooseScreen";
            this.pChooseScreen.Size = new System.Drawing.Size(580, 176);
            this.pChooseScreen.TabIndex = 13;
            // 
            // beInsert
            // 
            this.beInsert.ElipseRadius = 20;
            this.beInsert.TargetControl = this.pInsert;
            // 
            // pSeat
            // 
            this.pSeat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.pSeat.Controls.Add(this.flpSeat);
            this.pSeat.Location = new System.Drawing.Point(10, 10);
            this.pSeat.Name = "pSeat";
            this.pSeat.Size = new System.Drawing.Size(740, 340);
            this.pSeat.TabIndex = 15;
            // 
            // beChooseScreen
            // 
            this.beChooseScreen.ElipseRadius = 20;
            this.beChooseScreen.TargetControl = this.pInsert;
            // 
            // beSeat
            // 
            this.beSeat.ElipseRadius = 20;
            this.beSeat.TargetControl = this.pInsert;
            // 
            // tbScreenInsertName
            // 
            this.tbScreenInsertName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F);
            this.tbScreenInsertName.Location = new System.Drawing.Point(257, 17);
            this.tbScreenInsertName.Name = "tbScreenInsertName";
            this.tbScreenInsertName.Size = new System.Drawing.Size(283, 38);
            this.tbScreenInsertName.TabIndex = 16;
            // 
            // frmSreenManaging
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(1362, 753);
            this.Controls.Add(this.pSeat);
            this.Controls.Add(this.pInsert);
            this.Controls.Add(this.pChooseScreen);
            this.Name = "frmSreenManaging";
            this.Text = "frmSreenManaging";
            this.Load += new System.EventHandler(this.frmSreenManaging_Load);
            this.pInsert.ResumeLayout(false);
            this.pInsert.PerformLayout();
            this.pChooseScreen.ResumeLayout(false);
            this.pChooseScreen.PerformLayout();
            this.pSeat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpSeat;
        private System.Windows.Forms.Panel pInsert;
        private System.Windows.Forms.Label lbScreen;
        private System.Windows.Forms.ComboBox cbScreen;
        private System.Windows.Forms.Label lbScreenName;
        private System.Windows.Forms.ComboBox cbTheater;
        private System.Windows.Forms.Label lbTheaterName;
        private System.Windows.Forms.Panel pChooseScreen;
        private Bunifu.Framework.UI.BunifuThinButton2 btnAddCinema;
        private Bunifu.Framework.UI.BunifuThinButton2 btnSeatAdd;
        private Bunifu.Framework.UI.BunifuThinButton2 btnDeleteScreen;
        private Bunifu.Framework.UI.BunifuElipse beInsert;
        private System.Windows.Forms.Panel pSeat;
        private Bunifu.Framework.UI.BunifuElipse beChooseScreen;
        private Bunifu.Framework.UI.BunifuElipse beSeat;
        private System.Windows.Forms.TextBox tbScreenInsertName;
    }
}