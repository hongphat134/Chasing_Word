namespace DuoiHinhBatChu
{
    partial class DuoiHinhBatChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DuoiHinhBatChu));
            this.ptrDHBC = new System.Windows.Forms.PictureBox();
            this.pnlDHBC = new System.Windows.Forms.Panel();
            this.lblTimeLeft = new System.Windows.Forms.Label();
            this.btnGoiY = new System.Windows.Forms.Button();
            this.lblCoin = new System.Windows.Forms.Label();
            this.lblPoint = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRanKing = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.timerLeft = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ptrDHBC)).BeginInit();
            this.pnlDHBC.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptrDHBC
            // 
            this.ptrDHBC.Location = new System.Drawing.Point(45, 61);
            this.ptrDHBC.Name = "ptrDHBC";
            this.ptrDHBC.Size = new System.Drawing.Size(381, 229);
            this.ptrDHBC.TabIndex = 0;
            this.ptrDHBC.TabStop = false;
            // 
            // pnlDHBC
            // 
            this.pnlDHBC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlDHBC.BackgroundImage")));
            this.pnlDHBC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlDHBC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlDHBC.Controls.Add(this.lblTimeLeft);
            this.pnlDHBC.Controls.Add(this.btnGoiY);
            this.pnlDHBC.Controls.Add(this.lblCoin);
            this.pnlDHBC.Controls.Add(this.lblPoint);
            this.pnlDHBC.Controls.Add(this.lblQuestion);
            this.pnlDHBC.Controls.Add(this.ptrDHBC);
            this.pnlDHBC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDHBC.Location = new System.Drawing.Point(0, 0);
            this.pnlDHBC.Name = "pnlDHBC";
            this.pnlDHBC.Size = new System.Drawing.Size(700, 457);
            this.pnlDHBC.TabIndex = 5;
            this.pnlDHBC.Visible = false;
            // 
            // lblTimeLeft
            // 
            this.lblTimeLeft.BackColor = System.Drawing.Color.DarkBlue;
            this.lblTimeLeft.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblTimeLeft.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblTimeLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimeLeft.Location = new System.Drawing.Point(51, 395);
            this.lblTimeLeft.Name = "lblTimeLeft";
            this.lblTimeLeft.Size = new System.Drawing.Size(196, 51);
            this.lblTimeLeft.TabIndex = 6;
            this.lblTimeLeft.Text = "Thời gian: 180 giây";
            this.lblTimeLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnGoiY
            // 
            this.btnGoiY.BackColor = System.Drawing.Color.Chocolate;
            this.btnGoiY.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGoiY.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGoiY.Font = new System.Drawing.Font("NSimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoiY.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnGoiY.Location = new System.Drawing.Point(508, 4);
            this.btnGoiY.Name = "btnGoiY";
            this.btnGoiY.Size = new System.Drawing.Size(94, 37);
            this.btnGoiY.TabIndex = 5;
            this.btnGoiY.Text = "Gợi ý";
            this.btnGoiY.UseVisualStyleBackColor = false;
            this.btnGoiY.Click += new System.EventHandler(this.btnGoiY_Click);
            // 
            // lblCoin
            // 
            this.lblCoin.AutoSize = true;
            this.lblCoin.BackColor = System.Drawing.Color.Chartreuse;
            this.lblCoin.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoin.ForeColor = System.Drawing.Color.Chocolate;
            this.lblCoin.Location = new System.Drawing.Point(396, 16);
            this.lblCoin.Name = "lblCoin";
            this.lblCoin.Size = new System.Drawing.Size(25, 16);
            this.lblCoin.TabIndex = 4;
            this.lblCoin.Text = "Xu";
            // 
            // lblPoint
            // 
            this.lblPoint.AutoSize = true;
            this.lblPoint.BackColor = System.Drawing.Color.Brown;
            this.lblPoint.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPoint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPoint.Location = new System.Drawing.Point(252, 16);
            this.lblPoint.Name = "lblPoint";
            this.lblPoint.Size = new System.Drawing.Size(43, 16);
            this.lblPoint.TabIndex = 3;
            this.lblPoint.Text = "Điểm";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.CadetBlue;
            this.lblQuestion.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.SystemColors.Control;
            this.lblQuestion.Location = new System.Drawing.Point(23, 17);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(85, 16);
            this.lblQuestion.TabIndex = 2;
            this.lblQuestion.Text = "Câu hỏi số ?";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Yellow;
            this.btnPlay.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Aqua;
            this.btnPlay.Location = new System.Drawing.Point(176, 267);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(133, 62);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "BẮT ĐẦU";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.MouseLeave += new System.EventHandler(this.btnPlay_MouseLeave);
            this.btnPlay.MouseHover += new System.EventHandler(this.btnPlay_MouseHover);
            // 
            // btnRanKing
            // 
            this.btnRanKing.BackColor = System.Drawing.Color.Red;
            this.btnRanKing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRanKing.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRanKing.ForeColor = System.Drawing.Color.Blue;
            this.btnRanKing.Location = new System.Drawing.Point(348, 267);
            this.btnRanKing.Name = "btnRanKing";
            this.btnRanKing.Size = new System.Drawing.Size(133, 62);
            this.btnRanKing.TabIndex = 4;
            this.btnRanKing.Text = "RANKING";
            this.btnRanKing.UseVisualStyleBackColor = false;
            this.btnRanKing.Click += new System.EventHandler(this.btnRanKing_Click);
            this.btnRanKing.MouseLeave += new System.EventHandler(this.btnRanKing_MouseLeave);
            this.btnRanKing.MouseHover += new System.EventHandler(this.btnRanKing_MouseHover);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Lime;
            this.btnBack.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Maroon;
            this.btnBack.Location = new System.Drawing.Point(549, 77);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(123, 54);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Trở về";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // timerLeft
            // 
            this.timerLeft.Interval = 1000;
            this.timerLeft.Tick += new System.EventHandler(this.timerLeft_Tick);
            // 
            // DuoiHinhBatChu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(700, 457);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRanKing);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.pnlDHBC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DuoiHinhBatChu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đuổi hình bắt chữ";
            ((System.ComponentModel.ISupportInitialize)(this.ptrDHBC)).EndInit();
            this.pnlDHBC.ResumeLayout(false);
            this.pnlDHBC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptrDHBC;
        private System.Windows.Forms.Panel pnlDHBC;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnRanKing;
        private System.Windows.Forms.Button btnGoiY;
        private System.Windows.Forms.Label lblCoin;
        private System.Windows.Forms.Label lblPoint;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTimeLeft;
        private System.Windows.Forms.Timer timerLeft;
    }
}

