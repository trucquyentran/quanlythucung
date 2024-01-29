namespace Quyen
{
    partial class dangnhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dangnhap));
            this.textBox_emailDN = new System.Windows.Forms.TextBox();
            this.textBox_matkhauDN = new System.Windows.Forms.TextBox();
            this.button_dangnhap = new System.Windows.Forms.Button();
            this.linkLabel_quenMK = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_emailDN
            // 
            this.textBox_emailDN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_emailDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_emailDN.Location = new System.Drawing.Point(793, 289);
            this.textBox_emailDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_emailDN.Multiline = true;
            this.textBox_emailDN.Name = "textBox_emailDN";
            this.textBox_emailDN.Size = new System.Drawing.Size(269, 34);
            this.textBox_emailDN.TabIndex = 1;
            // 
            // textBox_matkhauDN
            // 
            this.textBox_matkhauDN.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_matkhauDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.textBox_matkhauDN.Location = new System.Drawing.Point(790, 369);
            this.textBox_matkhauDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_matkhauDN.Multiline = true;
            this.textBox_matkhauDN.Name = "textBox_matkhauDN";
            this.textBox_matkhauDN.PasswordChar = '●';
            this.textBox_matkhauDN.Size = new System.Drawing.Size(272, 34);
            this.textBox_matkhauDN.TabIndex = 2;
            this.textBox_matkhauDN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.enter);
            // 
            // button_dangnhap
            // 
            this.button_dangnhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_dangnhap.BackColor = System.Drawing.Color.Tomato;
            this.button_dangnhap.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.button_dangnhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dangnhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button_dangnhap.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_dangnhap.Location = new System.Drawing.Point(701, 438);
            this.button_dangnhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_dangnhap.Name = "button_dangnhap";
            this.button_dangnhap.Size = new System.Drawing.Size(402, 64);
            this.button_dangnhap.TabIndex = 4;
            this.button_dangnhap.Text = "Đăng nhập";
            this.button_dangnhap.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button_dangnhap.UseVisualStyleBackColor = false;
            this.button_dangnhap.Click += new System.EventHandler(this.button_dangnhap_Click);
            // 
            // linkLabel_quenMK
            // 
            this.linkLabel_quenMK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.linkLabel_quenMK.AutoSize = true;
            this.linkLabel_quenMK.BackColor = System.Drawing.Color.White;
            this.linkLabel_quenMK.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.linkLabel_quenMK.Location = new System.Drawing.Point(820, 531);
            this.linkLabel_quenMK.Name = "linkLabel_quenMK";
            this.linkLabel_quenMK.Size = new System.Drawing.Size(153, 24);
            this.linkLabel_quenMK.TabIndex = 3;
            this.linkLabel_quenMK.TabStop = true;
            this.linkLabel_quenMK.Text = "Quên mật khẩu ?";
            this.linkLabel_quenMK.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_quenMK_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(640, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(482, 515);
            this.pictureBox1.TabIndex = 74;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(747, 67);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(268, 234);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 75;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.InitialImage")));
            this.pictureBox3.Location = new System.Drawing.Point(718, 290);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(35, 35);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 76;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(718, 369);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(35, 35);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 76;
            this.pictureBox4.TabStop = false;
            // 
            // dangnhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1331, 750);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.textBox_matkhauDN);
            this.Controls.Add(this.textBox_emailDN);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.linkLabel_quenMK);
            this.Controls.Add(this.button_dangnhap);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "dangnhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.dangnhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_emailDN;
        private System.Windows.Forms.TextBox textBox_matkhauDN;
        private System.Windows.Forms.Button button_dangnhap;
        private System.Windows.Forms.LinkLabel linkLabel_quenMK;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}

