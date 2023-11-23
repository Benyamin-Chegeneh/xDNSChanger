namespace xDNSChanger
{
    partial class frm_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Main));
            this.btn_connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_primary = new System.Windows.Forms.TextBox();
            this.txt_secondary = new System.Windows.Forms.TextBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_icon = new System.Windows.Forms.PictureBox();
            this.pic_github = new System.Windows.Forms.PictureBox();
            this.pic_telegram = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_github)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_telegram)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_connect
            // 
            this.btn_connect.BackColor = System.Drawing.Color.Black;
            this.btn_connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_connect.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(131)))), ((int)(((byte)(48)))));
            this.btn_connect.Location = new System.Drawing.Point(245, 233);
            this.btn_connect.Margin = new System.Windows.Forms.Padding(2);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(113, 33);
            this.btn_connect.TabIndex = 0;
            this.btn_connect.Text = "Connect";
            this.toolTip.SetToolTip(this.btn_connect, "Connect to DNS");
            this.btn_connect.UseVisualStyleBackColor = false;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(131)))), ((int)(((byte)(48)))));
            this.label1.Location = new System.Drawing.Point(130, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Primary DNS : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(131)))), ((int)(((byte)(48)))));
            this.label2.Location = new System.Drawing.Point(112, 193);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Secondary DNS :";
            // 
            // txt_primary
            // 
            this.txt_primary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_primary.Location = new System.Drawing.Point(236, 155);
            this.txt_primary.Margin = new System.Windows.Forms.Padding(2);
            this.txt_primary.Name = "txt_primary";
            this.txt_primary.Size = new System.Drawing.Size(238, 22);
            this.txt_primary.TabIndex = 3;
            this.txt_primary.Text = "8.8.8.8";
            this.txt_primary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.txt_primary, "Primary DNS");
            this.txt_primary.Click += new System.EventHandler(this.txt_primary_Click);
            // 
            // txt_secondary
            // 
            this.txt_secondary.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_secondary.Location = new System.Drawing.Point(236, 184);
            this.txt_secondary.Margin = new System.Windows.Forms.Padding(2);
            this.txt_secondary.Name = "txt_secondary";
            this.txt_secondary.Size = new System.Drawing.Size(238, 22);
            this.txt_secondary.TabIndex = 4;
            this.txt_secondary.Text = "8.8.4.4";
            this.txt_secondary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.toolTip.SetToolTip(this.txt_secondary, "Secondary DNS");
            this.txt_secondary.Click += new System.EventHandler(this.txt_secondary_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(311, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Changer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(253, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "x";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::xDNSChanger.Properties.Resources.help;
            this.pictureBox1.Location = new System.Drawing.Point(2, 385);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.toolTip.SetToolTip(this.pictureBox1, "Support :\r\n1 - Telegram : @Benyamin_Chegeneh\r\n2 - Github : Benyamin-Chegeneh\r\n3 -" +
        " Email : Chegeneh.Benyamin@Gmail.com");
            // 
            // pic_icon
            // 
            this.pic_icon.Image = global::xDNSChanger.Properties.Resources.icon;
            this.pic_icon.Location = new System.Drawing.Point(257, 25);
            this.pic_icon.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pic_icon.Name = "pic_icon";
            this.pic_icon.Size = new System.Drawing.Size(70, 65);
            this.pic_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_icon.TabIndex = 7;
            this.pic_icon.TabStop = false;
            this.toolTip.SetToolTip(this.pic_icon, "Telegram");
            // 
            // pic_github
            // 
            this.pic_github.Image = global::xDNSChanger.Properties.Resources.gh_icon_1;
            this.pic_github.Location = new System.Drawing.Point(558, 370);
            this.pic_github.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pic_github.Name = "pic_github";
            this.pic_github.Size = new System.Drawing.Size(45, 45);
            this.pic_github.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_github.TabIndex = 6;
            this.pic_github.TabStop = false;
            this.toolTip.SetToolTip(this.pic_github, "Github");
            this.pic_github.Click += new System.EventHandler(this.pic_github_Click);
            this.pic_github.MouseLeave += new System.EventHandler(this.pic_github_MouseLeave);
            this.pic_github.MouseHover += new System.EventHandler(this.pic_github_MouseHover);
            // 
            // pic_telegram
            // 
            this.pic_telegram.Image = global::xDNSChanger.Properties.Resources.tel_icon_1;
            this.pic_telegram.Location = new System.Drawing.Point(514, 370);
            this.pic_telegram.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.pic_telegram.Name = "pic_telegram";
            this.pic_telegram.Size = new System.Drawing.Size(45, 45);
            this.pic_telegram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_telegram.TabIndex = 5;
            this.pic_telegram.TabStop = false;
            this.toolTip.SetToolTip(this.pic_telegram, "Telegram");
            this.pic_telegram.Click += new System.EventHandler(this.pic_telegram_Click);
            this.pic_telegram.MouseLeave += new System.EventHandler(this.pic_telegram_MouseLeave);
            this.pic_telegram.MouseHover += new System.EventHandler(this.pic_telegram_MouseHover);
            // 
            // frm_Main
            // 
            this.AcceptButton = this.btn_connect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(604, 416);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pic_icon);
            this.Controls.Add(this.pic_github);
            this.Controls.Add(this.pic_telegram);
            this.Controls.Add(this.txt_secondary);
            this.Controls.Add(this.txt_primary);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_connect);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 455);
            this.MinimumSize = new System.Drawing.Size(620, 455);
            this.Name = "frm_Main";
            this.Text = "xDNSChanger";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_github)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_telegram)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_primary;
        private System.Windows.Forms.TextBox txt_secondary;
        private System.Windows.Forms.PictureBox pic_telegram;
        private System.Windows.Forms.PictureBox pic_github;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.PictureBox pic_icon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

