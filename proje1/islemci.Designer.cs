namespace proje1
{
    partial class islemci
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(islemci));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.islemci_img = new System.Windows.Forms.PictureBox();
            this.anakart_img = new System.Windows.Forms.PictureBox();
            this.ekrankkartı_img = new System.Windows.Forms.PictureBox();
            this.ssd_img = new System.Windows.Forms.PictureBox();
            this.hdd_img = new System.Windows.Forms.PictureBox();
            this.ram_img = new System.Windows.Forms.PictureBox();
            this.gückaynağı_img = new System.Windows.Forms.PictureBox();
            this.kasa_img = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.islemci_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anakart_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekrankkartı_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssd_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdd_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gückaynağı_img)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasa_img)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(95, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(95, 89);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(252, 21);
            this.comboBox2.TabIndex = 1;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(95, 134);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(252, 21);
            this.comboBox3.TabIndex = 1;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1x8 8gb Ram",
            "2x4 8gb Ram",
            "1x16 16gb Ram",
            "2x8 16 gb Ram",
            "1x32 32 gb Ram",
            "2x16 32 gb Ram"});
            this.comboBox4.Location = new System.Drawing.Point(95, 179);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(252, 21);
            this.comboBox4.TabIndex = 1;
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(95, 224);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(252, 21);
            this.comboBox5.TabIndex = 1;
            this.comboBox5.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Items.AddRange(new object[] {
            "500 GB 5400 RPMHarddisk",
            "500 GB 7200 RPMHarddisk",
            "1 TB  7200 RPMHarddisk",
            "2 TB  7200 RPMHarddisk"});
            this.comboBox6.Location = new System.Drawing.Point(95, 273);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(252, 21);
            this.comboBox6.TabIndex = 1;
            this.comboBox6.SelectedIndexChanged += new System.EventHandler(this.comboBox6_SelectedIndexChanged);
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Items.AddRange(new object[] {
            "128 gb SATA 2.5 ssd",
            "240 gb SATA 2.5 ssd",
            "500 gb SATA 2.5 ssd",
            "1 TB SATA 2.5 ssd",
            "240 gb m.2 ssd",
            "500 gb m.2 ssd",
            "1 TB m.2 ssd"});
            this.comboBox7.Location = new System.Drawing.Point(95, 320);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(252, 21);
            this.comboBox7.TabIndex = 1;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "İşlemci";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Anakart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ekran kartı";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ram";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Güç kaynağı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Harddisk";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(103, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ssd";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "Topla";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // islemci_img
            // 
            this.islemci_img.Image = ((System.Drawing.Image)(resources.GetObject("islemci_img.Image")));
            this.islemci_img.Location = new System.Drawing.Point(645, 30);
            this.islemci_img.Name = "islemci_img";
            this.islemci_img.Size = new System.Drawing.Size(103, 88);
            this.islemci_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.islemci_img.TabIndex = 7;
            this.islemci_img.TabStop = false;
            // 
            // anakart_img
            // 
            this.anakart_img.Image = ((System.Drawing.Image)(resources.GetObject("anakart_img.Image")));
            this.anakart_img.Location = new System.Drawing.Point(536, 137);
            this.anakart_img.Name = "anakart_img";
            this.anakart_img.Size = new System.Drawing.Size(103, 88);
            this.anakart_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.anakart_img.TabIndex = 7;
            this.anakart_img.TabStop = false;
            // 
            // ekrankkartı_img
            // 
            this.ekrankkartı_img.Image = ((System.Drawing.Image)(resources.GetObject("ekrankkartı_img.Image")));
            this.ekrankkartı_img.Location = new System.Drawing.Point(558, 253);
            this.ekrankkartı_img.Name = "ekrankkartı_img";
            this.ekrankkartı_img.Size = new System.Drawing.Size(103, 88);
            this.ekrankkartı_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ekrankkartı_img.TabIndex = 7;
            this.ekrankkartı_img.TabStop = false;
            // 
            // ssd_img
            // 
            this.ssd_img.Image = ((System.Drawing.Image)(resources.GetObject("ssd_img.Image")));
            this.ssd_img.Location = new System.Drawing.Point(775, 30);
            this.ssd_img.Name = "ssd_img";
            this.ssd_img.Size = new System.Drawing.Size(103, 88);
            this.ssd_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ssd_img.TabIndex = 7;
            this.ssd_img.TabStop = false;
            // 
            // hdd_img
            // 
            this.hdd_img.Image = ((System.Drawing.Image)(resources.GetObject("hdd_img.Image")));
            this.hdd_img.Location = new System.Drawing.Point(878, 137);
            this.hdd_img.Name = "hdd_img";
            this.hdd_img.Size = new System.Drawing.Size(103, 88);
            this.hdd_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hdd_img.TabIndex = 7;
            this.hdd_img.TabStop = false;
            // 
            // ram_img
            // 
            this.ram_img.Image = ((System.Drawing.Image)(resources.GetObject("ram_img.Image")));
            this.ram_img.Location = new System.Drawing.Point(707, 285);
            this.ram_img.Name = "ram_img";
            this.ram_img.Size = new System.Drawing.Size(103, 84);
            this.ram_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ram_img.TabIndex = 7;
            this.ram_img.TabStop = false;
            // 
            // gückaynağı_img
            // 
            this.gückaynağı_img.Image = ((System.Drawing.Image)(resources.GetObject("gückaynağı_img.Image")));
            this.gückaynağı_img.Location = new System.Drawing.Point(864, 253);
            this.gückaynağı_img.Name = "gückaynağı_img";
            this.gückaynağı_img.Size = new System.Drawing.Size(103, 86);
            this.gückaynağı_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gückaynağı_img.TabIndex = 7;
            this.gückaynağı_img.TabStop = false;
            // 
            // kasa_img
            // 
            this.kasa_img.Image = ((System.Drawing.Image)(resources.GetObject("kasa_img.Image")));
            this.kasa_img.Location = new System.Drawing.Point(674, 136);
            this.kasa_img.Name = "kasa_img";
            this.kasa_img.Size = new System.Drawing.Size(174, 142);
            this.kasa_img.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kasa_img.TabIndex = 7;
            this.kasa_img.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(69, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 357);
            this.panel1.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(503, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(530, 357);
            this.panel2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(69, 391);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(964, 129);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // islemci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.gückaynağı_img);
            this.Controls.Add(this.kasa_img);
            this.Controls.Add(this.ram_img);
            this.Controls.Add(this.hdd_img);
            this.Controls.Add(this.ssd_img);
            this.Controls.Add(this.ekrankkartı_img);
            this.Controls.Add(this.anakart_img);
            this.Controls.Add(this.islemci_img);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "islemci";
            this.Size = new System.Drawing.Size(1118, 530);
            this.Load += new System.EventHandler(this.islemci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.islemci_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anakart_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ekrankkartı_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ssd_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hdd_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ram_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gückaynağı_img)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kasa_img)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox islemci_img;
        private System.Windows.Forms.PictureBox anakart_img;
        private System.Windows.Forms.PictureBox ekrankkartı_img;
        private System.Windows.Forms.PictureBox ssd_img;
        private System.Windows.Forms.PictureBox hdd_img;
        private System.Windows.Forms.PictureBox ram_img;
        private System.Windows.Forms.PictureBox gückaynağı_img;
        private System.Windows.Forms.PictureBox kasa_img;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
