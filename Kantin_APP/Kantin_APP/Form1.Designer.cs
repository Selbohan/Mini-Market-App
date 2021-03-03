namespace Kantin_APP
{
    partial class Form1
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

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsimit = new System.Windows.Forms.TextBox();
            this.lsimit = new System.Windows.Forms.Label();
            this.txtcikolata = new System.Windows.Forms.TextBox();
            this.lcikolata = new System.Windows.Forms.Label();
            this.txtkraker = new System.Windows.Forms.TextBox();
            this.lkraker = new System.Windows.Forms.Label();
            this.txttost = new System.Windows.Forms.TextBox();
            this.ltost = new System.Windows.Forms.Label();
            this.txtkahve = new System.Windows.Forms.TextBox();
            this.lkahve = new System.Windows.Forms.Label();
            this.txtcay = new System.Windows.Forms.TextBox();
            this.lcay = new System.Windows.Forms.Label();
            this.txtsu = new System.Windows.Forms.TextBox();
            this.lsu = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.lbkasa = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lbtoplam = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LimeGreen;
            this.groupBox1.Controls.Add(this.txtsimit);
            this.groupBox1.Controls.Add(this.lsimit);
            this.groupBox1.Controls.Add(this.txtcikolata);
            this.groupBox1.Controls.Add(this.lcikolata);
            this.groupBox1.Controls.Add(this.txtkraker);
            this.groupBox1.Controls.Add(this.lkraker);
            this.groupBox1.Controls.Add(this.txttost);
            this.groupBox1.Controls.Add(this.ltost);
            this.groupBox1.Controls.Add(this.txtkahve);
            this.groupBox1.Controls.Add(this.lkahve);
            this.groupBox1.Controls.Add(this.txtcay);
            this.groupBox1.Controls.Add(this.lcay);
            this.groupBox1.Controls.Add(this.txtsu);
            this.groupBox1.Controls.Add(this.lsu);
            this.groupBox1.Location = new System.Drawing.Point(252, 111);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 298);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Miktarları:";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtsimit
            // 
            this.txtsimit.Location = new System.Drawing.Point(125, 259);
            this.txtsimit.Name = "txtsimit";
            this.txtsimit.Size = new System.Drawing.Size(79, 29);
            this.txtsimit.TabIndex = 3;
            // 
            // lsimit
            // 
            this.lsimit.AutoSize = true;
            this.lsimit.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsimit.Location = new System.Drawing.Point(31, 260);
            this.lsimit.Name = "lsimit";
            this.lsimit.Size = new System.Drawing.Size(64, 28);
            this.lsimit.TabIndex = 2;
            this.lsimit.Text = "Simit:";
            // 
            // txtcikolata
            // 
            this.txtcikolata.Location = new System.Drawing.Point(125, 224);
            this.txtcikolata.Name = "txtcikolata";
            this.txtcikolata.Size = new System.Drawing.Size(79, 29);
            this.txtcikolata.TabIndex = 11;
            // 
            // lcikolata
            // 
            this.lcikolata.AutoSize = true;
            this.lcikolata.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lcikolata.Location = new System.Drawing.Point(6, 225);
            this.lcikolata.Name = "lcikolata";
            this.lcikolata.Size = new System.Drawing.Size(89, 28);
            this.lcikolata.TabIndex = 10;
            this.lcikolata.Text = "Çikolata:";
            // 
            // txtkraker
            // 
            this.txtkraker.Location = new System.Drawing.Point(125, 189);
            this.txtkraker.Name = "txtkraker";
            this.txtkraker.Size = new System.Drawing.Size(79, 29);
            this.txtkraker.TabIndex = 9;
            // 
            // lkraker
            // 
            this.lkraker.AutoSize = true;
            this.lkraker.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lkraker.Location = new System.Drawing.Point(21, 190);
            this.lkraker.Name = "lkraker";
            this.lkraker.Size = new System.Drawing.Size(74, 28);
            this.lkraker.TabIndex = 8;
            this.lkraker.Text = "Kraker:";
            // 
            // txttost
            // 
            this.txttost.Location = new System.Drawing.Point(125, 154);
            this.txttost.Name = "txttost";
            this.txttost.Size = new System.Drawing.Size(79, 29);
            this.txttost.TabIndex = 7;
            // 
            // ltost
            // 
            this.ltost.AutoSize = true;
            this.ltost.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ltost.Location = new System.Drawing.Point(41, 155);
            this.ltost.Name = "ltost";
            this.ltost.Size = new System.Drawing.Size(54, 28);
            this.ltost.TabIndex = 6;
            this.ltost.Text = "Tost:";
            // 
            // txtkahve
            // 
            this.txtkahve.Location = new System.Drawing.Point(125, 119);
            this.txtkahve.Name = "txtkahve";
            this.txtkahve.Size = new System.Drawing.Size(79, 29);
            this.txtkahve.TabIndex = 5;
            // 
            // lkahve
            // 
            this.lkahve.AutoSize = true;
            this.lkahve.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lkahve.Location = new System.Drawing.Point(23, 120);
            this.lkahve.Name = "lkahve";
            this.lkahve.Size = new System.Drawing.Size(72, 28);
            this.lkahve.TabIndex = 4;
            this.lkahve.Text = "Kahve:";
            // 
            // txtcay
            // 
            this.txtcay.Location = new System.Drawing.Point(125, 84);
            this.txtcay.Name = "txtcay";
            this.txtcay.Size = new System.Drawing.Size(79, 29);
            this.txtcay.TabIndex = 3;
            // 
            // lcay
            // 
            this.lcay.AutoSize = true;
            this.lcay.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lcay.Location = new System.Drawing.Point(43, 85);
            this.lcay.Name = "lcay";
            this.lcay.Size = new System.Drawing.Size(52, 28);
            this.lcay.TabIndex = 2;
            this.lcay.Text = "Çay:";
            this.lcay.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtsu
            // 
            this.txtsu.Location = new System.Drawing.Point(125, 49);
            this.txtsu.Name = "txtsu";
            this.txtsu.Size = new System.Drawing.Size(79, 29);
            this.txtsu.TabIndex = 1;
            // 
            // lsu
            // 
            this.lsu.AutoSize = true;
            this.lsu.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsu.Location = new System.Drawing.Point(54, 50);
            this.lsu.Name = "lsu";
            this.lsu.Size = new System.Drawing.Size(41, 28);
            this.lsu.TabIndex = 0;
            this.lsu.Text = "Su:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Location = new System.Drawing.Point(23, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 298);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fiyat Listesi:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(58, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "Simit: 2 TL";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(50, 118);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 28);
            this.label12.TabIndex = 15;
            this.label12.Text = "Kahve: 2 TL";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(33, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 28);
            this.label9.TabIndex = 18;
            this.label9.Text = "Çikolata: 3 TL";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(81, 48);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 28);
            this.label14.TabIndex = 12;
            this.label14.Text = "Su: 1 TL";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(48, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 28);
            this.label10.TabIndex = 17;
            this.label10.Text = "Kraker: 2 TL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(70, 83);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 28);
            this.label13.TabIndex = 14;
            this.label13.Text = "Çay: 2 TL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(68, 153);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 28);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tost: 4 TL";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Gainsboro;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.lbkasa);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.lbtoplam);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(482, 111);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(221, 158);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kasa:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkGray;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(120, 28);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 29);
            this.button2.TabIndex = 9;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbkasa
            // 
            this.lbkasa.AutoSize = true;
            this.lbkasa.BackColor = System.Drawing.Color.Silver;
            this.lbkasa.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbkasa.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lbkasa.Location = new System.Drawing.Point(156, 128);
            this.lbkasa.Name = "lbkasa";
            this.lbkasa.Size = new System.Drawing.Size(59, 20);
            this.lbkasa.TabIndex = 8;
            this.lbkasa.Text = "0.00 TL";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label18.Location = new System.Drawing.Point(36, 128);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 21);
            this.label18.TabIndex = 7;
            this.label18.Text = "Kasa T:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(6, 28);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 5;
            this.button1.Text = "Hesapla";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbtoplam
            // 
            this.lbtoplam.AutoSize = true;
            this.lbtoplam.BackColor = System.Drawing.Color.Red;
            this.lbtoplam.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbtoplam.Location = new System.Drawing.Point(156, 83);
            this.lbtoplam.Name = "lbtoplam";
            this.lbtoplam.Size = new System.Drawing.Size(59, 20);
            this.lbtoplam.TabIndex = 4;
            this.lbtoplam.Text = "0.00 TL";
            this.lbtoplam.Click += new System.EventHandler(this.label16_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Palatino Linotype", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(16, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(85, 21);
            this.label15.TabIndex = 3;
            this.label15.Text = "TOPLAM:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("SimSun", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(476, 64);
            this.label17.TabIndex = 3;
            this.label17.Text = "Kantin Paneli:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(482, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(723, 421);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcikolata;
        private System.Windows.Forms.Label lcikolata;
        private System.Windows.Forms.TextBox txtkraker;
        private System.Windows.Forms.Label lkraker;
        private System.Windows.Forms.TextBox txttost;
        private System.Windows.Forms.Label ltost;
        private System.Windows.Forms.TextBox txtkahve;
        private System.Windows.Forms.Label lkahve;
        private System.Windows.Forms.TextBox txtcay;
        private System.Windows.Forms.Label lcay;
        private System.Windows.Forms.TextBox txtsu;
        private System.Windows.Forms.Label lsu;
        private System.Windows.Forms.TextBox txtsimit;
        private System.Windows.Forms.Label lsimit;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lbtoplam;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbkasa;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}

