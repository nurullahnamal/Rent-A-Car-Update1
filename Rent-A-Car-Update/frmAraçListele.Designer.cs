namespace Rent_A_Car_Update
{
    partial class frmAraçListele
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboAraçlar = new System.Windows.Forms.ComboBox();
            this.btnresim = new System.Windows.Forms.Button();
            this.btnİptal = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Kmtxt = new System.Windows.Forms.TextBox();
            this.KiraUcretitxt = new System.Windows.Forms.TextBox();
            this.Renktxt = new System.Windows.Forms.TextBox();
            this.Modeltxt = new System.Windows.Forms.TextBox();
            this.YakitCombo = new System.Windows.Forms.ComboBox();
            this.SeriCombo = new System.Windows.Forms.ComboBox();
            this.MarkaCombo = new System.Windows.Forms.ComboBox();
            this.Plakatxt = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(639, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(531, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // comboAraçlar
            // 
            this.comboAraçlar.FormattingEnabled = true;
            this.comboAraçlar.Items.AddRange(new object[] {
            "Tüm Araçlar",
            "boş Araçlar",
            "Dolu araçlar"});
            this.comboAraçlar.Location = new System.Drawing.Point(845, 12);
            this.comboAraçlar.Name = "comboAraçlar";
            this.comboAraçlar.Size = new System.Drawing.Size(121, 23);
            this.comboAraçlar.TabIndex = 1;
            // 
            // btnresim
            // 
            this.btnresim.Location = new System.Drawing.Point(428, 198);
            this.btnresim.Name = "btnresim";
            this.btnresim.Size = new System.Drawing.Size(75, 23);
            this.btnresim.TabIndex = 33;
            this.btnresim.Text = "Resim Ekle";
            this.btnresim.UseVisualStyleBackColor = true;
            // 
            // btnİptal
            // 
            this.btnİptal.Location = new System.Drawing.Point(173, 350);
            this.btnİptal.Name = "btnİptal";
            this.btnİptal.Size = new System.Drawing.Size(75, 23);
            this.btnİptal.TabIndex = 32;
            this.btnİptal.Text = "İptal";
            this.btnİptal.UseVisualStyleBackColor = true;
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Location = new System.Drawing.Point(56, 350);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGüncelle.TabIndex = 31;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Location = new System.Drawing.Point(330, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(281, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 30;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(-4, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 15);
            this.label8.TabIndex = 29;
            this.label8.Text = "Kira Ücreti";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 15);
            this.label7.TabIndex = 28;
            this.label7.Text = "Yakıt";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 15);
            this.label6.TabIndex = 27;
            this.label6.Text = "Km";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 26;
            this.label5.Text = "Renk";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Model(Yıl)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Seri";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Marka";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Plaka";
            // 
            // Kmtxt
            // 
            this.Kmtxt.Location = new System.Drawing.Point(87, 230);
            this.Kmtxt.Name = "Kmtxt";
            this.Kmtxt.Size = new System.Drawing.Size(161, 23);
            this.Kmtxt.TabIndex = 21;
            // 
            // KiraUcretitxt
            // 
            this.KiraUcretitxt.Location = new System.Drawing.Point(87, 302);
            this.KiraUcretitxt.Name = "KiraUcretitxt";
            this.KiraUcretitxt.Size = new System.Drawing.Size(161, 23);
            this.KiraUcretitxt.TabIndex = 20;
            // 
            // Renktxt
            // 
            this.Renktxt.Location = new System.Drawing.Point(87, 194);
            this.Renktxt.Name = "Renktxt";
            this.Renktxt.Size = new System.Drawing.Size(179, 23);
            this.Renktxt.TabIndex = 19;
            // 
            // Modeltxt
            // 
            this.Modeltxt.Location = new System.Drawing.Point(87, 162);
            this.Modeltxt.Name = "Modeltxt";
            this.Modeltxt.Size = new System.Drawing.Size(179, 23);
            this.Modeltxt.TabIndex = 18;
            // 
            // YakitCombo
            // 
            this.YakitCombo.FormattingEnabled = true;
            this.YakitCombo.Items.AddRange(new object[] {
            "dizel",
            "benzi",
            "benzin+lpg"});
            this.YakitCombo.Location = new System.Drawing.Point(87, 266);
            this.YakitCombo.Name = "YakitCombo";
            this.YakitCombo.Size = new System.Drawing.Size(173, 23);
            this.YakitCombo.TabIndex = 17;
            // 
            // SeriCombo
            // 
            this.SeriCombo.FormattingEnabled = true;
            this.SeriCombo.Location = new System.Drawing.Point(87, 122);
            this.SeriCombo.Name = "SeriCombo";
            this.SeriCombo.Size = new System.Drawing.Size(173, 23);
            this.SeriCombo.TabIndex = 16;
            // 
            // MarkaCombo
            // 
            this.MarkaCombo.FormattingEnabled = true;
            this.MarkaCombo.Items.AddRange(new object[] {
            "Opel",
            "Renault",
            "Fiat",
            "Ford"});
            this.MarkaCombo.Location = new System.Drawing.Point(87, 86);
            this.MarkaCombo.Name = "MarkaCombo";
            this.MarkaCombo.Size = new System.Drawing.Size(173, 23);
            this.MarkaCombo.TabIndex = 15;
            // 
            // Plakatxt
            // 
            this.Plakatxt.Location = new System.Drawing.Point(87, 50);
            this.Plakatxt.Name = "Plakatxt";
            this.Plakatxt.Size = new System.Drawing.Size(179, 23);
            this.Plakatxt.TabIndex = 14;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(1038, 14);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(132, 29);
            this.btnSil.TabIndex = 34;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox2.Location = new System.Drawing.Point(314, 266);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(281, 103);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 30;
            this.pictureBox2.TabStop = false;
            // 
            // frmAraçListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 499);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnresim);
            this.Controls.Add(this.btnİptal);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Kmtxt);
            this.Controls.Add(this.KiraUcretitxt);
            this.Controls.Add(this.Renktxt);
            this.Controls.Add(this.Modeltxt);
            this.Controls.Add(this.YakitCombo);
            this.Controls.Add(this.SeriCombo);
            this.Controls.Add(this.MarkaCombo);
            this.Controls.Add(this.Plakatxt);
            this.Controls.Add(this.comboAraçlar);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmAraçListele";
            this.Text = "Araç Listeleme Sayfası";
            this.Load += new System.EventHandler(this.frmAraçListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox comboAraçlar;
        private Button btnresim;
        private Button btnİptal;
        private Button btnGüncelle;
        private PictureBox pictureBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Kmtxt;
        private TextBox KiraUcretitxt;
        private TextBox Renktxt;
        private TextBox Modeltxt;
        private ComboBox YakitCombo;
        private ComboBox SeriCombo;
        private ComboBox MarkaCombo;
        private TextBox Plakatxt;
        private Button btnSil;
        private PictureBox pictureBox2;
    }
}