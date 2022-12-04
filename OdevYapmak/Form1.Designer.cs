namespace OdevYapmak
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOgrenciEkle = new System.Windows.Forms.Button();
            this.cmbDanisman = new System.Windows.Forms.ComboBox();
            this.txtNO = new System.Windows.Forms.TextBox();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstOgrenciler = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.secmelirdo = new System.Windows.Forms.RadioButton();
            this.zorunlurdo = new System.Windows.Forms.RadioButton();
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.txtKredi = new System.Windows.Forms.TextBox();
            this.txtDersKodu = new System.Windows.Forms.TextBox();
            this.txtDersAdi = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lstDersler = new System.Windows.Forms.ListBox();
            this.btnOgrenciDersEkrani = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOgrenciEkle);
            this.groupBox1.Controls.Add(this.cmbDanisman);
            this.groupBox1.Controls.Add(this.txtNO);
            this.groupBox1.Controls.Add(this.txtBolum);
            this.groupBox1.Controls.Add(this.txtSoyad);
            this.groupBox1.Controls.Add(this.txtAd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 297);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "öğrenci ekleme";
            // 
            // btnOgrenciEkle
            // 
            this.btnOgrenciEkle.Location = new System.Drawing.Point(11, 246);
            this.btnOgrenciEkle.Name = "btnOgrenciEkle";
            this.btnOgrenciEkle.Size = new System.Drawing.Size(291, 45);
            this.btnOgrenciEkle.TabIndex = 9;
            this.btnOgrenciEkle.Text = "ÖğrenciEkle";
            this.btnOgrenciEkle.UseVisualStyleBackColor = true;
            this.btnOgrenciEkle.Click += new System.EventHandler(this.btnOgrenciEkle_Click);
            // 
            // cmbDanisman
            // 
            this.cmbDanisman.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDanisman.FormattingEnabled = true;
            this.cmbDanisman.Location = new System.Drawing.Point(93, 212);
            this.cmbDanisman.Name = "cmbDanisman";
            this.cmbDanisman.Size = new System.Drawing.Size(209, 28);
            this.cmbDanisman.TabIndex = 8;
            // 
            // txtNO
            // 
            this.txtNO.Location = new System.Drawing.Point(93, 138);
            this.txtNO.Name = "txtNO";
            this.txtNO.Size = new System.Drawing.Size(209, 27);
            this.txtNO.TabIndex = 7;
            // 
            // txtBolum
            // 
            this.txtBolum.Location = new System.Drawing.Point(93, 178);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(209, 27);
            this.txtBolum.TabIndex = 5;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(93, 91);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(209, 27);
            this.txtSoyad.TabIndex = 6;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(93, 48);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(209, 27);
            this.txtAd.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Danışman";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bölüm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad";
            // 
            // lstOgrenciler
            // 
            this.lstOgrenciler.FormattingEnabled = true;
            this.lstOgrenciler.ItemHeight = 20;
            this.lstOgrenciler.Location = new System.Drawing.Point(366, 12);
            this.lstOgrenciler.Name = "lstOgrenciler";
            this.lstOgrenciler.Size = new System.Drawing.Size(475, 284);
            this.lstOgrenciler.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.secmelirdo);
            this.groupBox2.Controls.Add(this.zorunlurdo);
            this.groupBox2.Controls.Add(this.btnDersEkle);
            this.groupBox2.Controls.Add(this.txtKredi);
            this.groupBox2.Controls.Add(this.txtDersKodu);
            this.groupBox2.Controls.Add(this.txtDersAdi);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 315);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 271);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ders ekleme";
            // 
            // secmelirdo
            // 
            this.secmelirdo.AutoSize = true;
            this.secmelirdo.Location = new System.Drawing.Point(233, 177);
            this.secmelirdo.Name = "secmelirdo";
            this.secmelirdo.Size = new System.Drawing.Size(80, 24);
            this.secmelirdo.TabIndex = 11;
            this.secmelirdo.TabStop = true;
            this.secmelirdo.Text = "seçmeli";
            this.secmelirdo.UseVisualStyleBackColor = true;
            // 
            // zorunlurdo
            // 
            this.zorunlurdo.AutoSize = true;
            this.zorunlurdo.Location = new System.Drawing.Point(104, 177);
            this.zorunlurdo.Name = "zorunlurdo";
            this.zorunlurdo.Size = new System.Drawing.Size(79, 24);
            this.zorunlurdo.TabIndex = 10;
            this.zorunlurdo.TabStop = true;
            this.zorunlurdo.Text = "zorunlu";
            this.zorunlurdo.UseVisualStyleBackColor = true;
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.Location = new System.Drawing.Point(11, 216);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(302, 45);
            this.btnDersEkle.TabIndex = 9;
            this.btnDersEkle.Text = "Ders ekle";
            this.btnDersEkle.UseVisualStyleBackColor = true;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click);
            // 
            // txtKredi
            // 
            this.txtKredi.Location = new System.Drawing.Point(104, 138);
            this.txtKredi.Name = "txtKredi";
            this.txtKredi.Size = new System.Drawing.Size(209, 27);
            this.txtKredi.TabIndex = 7;
            // 
            // txtDersKodu
            // 
            this.txtDersKodu.Location = new System.Drawing.Point(104, 91);
            this.txtDersKodu.Name = "txtDersKodu";
            this.txtDersKodu.Size = new System.Drawing.Size(209, 27);
            this.txtDersKodu.TabIndex = 6;
            // 
            // txtDersAdi
            // 
            this.txtDersAdi.Location = new System.Drawing.Point(104, 48);
            this.txtDersAdi.Name = "txtDersAdi";
            this.txtDersAdi.Size = new System.Drawing.Size(209, 27);
            this.txtDersAdi.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "Kredisi";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Dersin Kodu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(28, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ad";
            // 
            // lstDersler
            // 
            this.lstDersler.FormattingEnabled = true;
            this.lstDersler.ItemHeight = 20;
            this.lstDersler.Location = new System.Drawing.Point(366, 302);
            this.lstDersler.Name = "lstDersler";
            this.lstDersler.Size = new System.Drawing.Size(475, 284);
            this.lstDersler.TabIndex = 12;
            // 
            // btnOgrenciDersEkrani
            // 
            this.btnOgrenciDersEkrani.Location = new System.Drawing.Point(12, 592);
            this.btnOgrenciDersEkrani.Name = "btnOgrenciDersEkrani";
            this.btnOgrenciDersEkrani.Size = new System.Drawing.Size(828, 41);
            this.btnOgrenciDersEkrani.TabIndex = 13;
            this.btnOgrenciDersEkrani.Text = "ÖĞRENCİ DERS EKRANI";
            this.btnOgrenciDersEkrani.UseVisualStyleBackColor = true;
            this.btnOgrenciDersEkrani.Click += new System.EventHandler(this.btnOgrenciDersEkrani_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 640);
            this.Controls.Add(this.btnOgrenciDersEkrani);
            this.Controls.Add(this.lstDersler);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lstOgrenciler);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnOgrenciEkle;
        private ComboBox cmbDanisman;
        private TextBox txtNO;
        private TextBox txtBolum;
        private TextBox txtSoyad;
        private TextBox txtAd;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ListBox lstOgrenciler;
        private GroupBox groupBox2;
        private RadioButton secmelirdo;
        private RadioButton zorunlurdo;
        private Button btnDersEkle;
        private TextBox txtKredi;
        private TextBox txtDersKodu;
        private TextBox txtDersAdi;
        private Label label8;
        private Label label9;
        private Label label10;
        private ListBox lstDersler;
        private Button btnOgrenciDersEkrani;
    }
}