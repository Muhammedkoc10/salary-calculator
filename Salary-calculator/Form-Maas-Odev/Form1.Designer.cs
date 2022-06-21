
namespace Form_Maas_Odev
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.grpCocuk = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdEvli = new System.Windows.Forms.RadioButton();
            this.rdBekar = new System.Windows.Forms.RadioButton();
            this.rdSıfır = new System.Windows.Forms.RadioButton();
            this.rdBir = new System.Windows.Forms.RadioButton();
            this.rdİki = new System.Windows.Forms.RadioButton();
            this.rdUc = new System.Windows.Forms.RadioButton();
            this.chbIngilizce = new System.Windows.Forms.CheckBox();
            this.chbAlmanca = new System.Windows.Forms.CheckBox();
            this.chbFransızca = new System.Windows.Forms.CheckBox();
            this.chbYunanca = new System.Windows.Forms.CheckBox();
            this.chbItalyanca = new System.Windows.Forms.CheckBox();
            this.chbArapca = new System.Windows.Forms.CheckBox();
            this.txtMaas = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSonMaas = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpCocuk.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdBekar);
            this.groupBox1.Controls.Add(this.rdEvli);
            this.groupBox1.Location = new System.Drawing.Point(39, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 84);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medeni  Hal";
            // 
            // grpCocuk
            // 
            this.grpCocuk.Controls.Add(this.rdUc);
            this.grpCocuk.Controls.Add(this.rdİki);
            this.grpCocuk.Controls.Add(this.rdBir);
            this.grpCocuk.Controls.Add(this.rdSıfır);
            this.grpCocuk.Location = new System.Drawing.Point(39, 265);
            this.grpCocuk.Name = "grpCocuk";
            this.grpCocuk.Size = new System.Drawing.Size(183, 173);
            this.grpCocuk.TabIndex = 0;
            this.grpCocuk.TabStop = false;
            this.grpCocuk.Text = "Çocuk Sayısı";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chbArapca);
            this.groupBox3.Controls.Add(this.chbItalyanca);
            this.groupBox3.Controls.Add(this.chbYunanca);
            this.groupBox3.Controls.Add(this.chbFransızca);
            this.groupBox3.Controls.Add(this.chbAlmanca);
            this.groupBox3.Controls.Add(this.chbIngilizce);
            this.groupBox3.Location = new System.Drawing.Point(512, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(218, 272);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox1";
            // 
            // rdEvli
            // 
            this.rdEvli.AutoSize = true;
            this.rdEvli.Location = new System.Drawing.Point(22, 20);
            this.rdEvli.Name = "rdEvli";
            this.rdEvli.Size = new System.Drawing.Size(42, 17);
            this.rdEvli.TabIndex = 0;
            this.rdEvli.TabStop = true;
            this.rdEvli.Text = "Evli";
            this.rdEvli.UseVisualStyleBackColor = true;
            this.rdEvli.CheckedChanged += new System.EventHandler(this.rdEvli_CheckedChanged);
            // 
            // rdBekar
            // 
            this.rdBekar.AutoSize = true;
            this.rdBekar.Location = new System.Drawing.Point(22, 52);
            this.rdBekar.Name = "rdBekar";
            this.rdBekar.Size = new System.Drawing.Size(53, 17);
            this.rdBekar.TabIndex = 0;
            this.rdBekar.TabStop = true;
            this.rdBekar.Text = "Bekar";
            this.rdBekar.UseVisualStyleBackColor = true;
            this.rdBekar.CheckedChanged += new System.EventHandler(this.rdBekar_CheckedChanged);
            // 
            // rdSıfır
            // 
            this.rdSıfır.AutoSize = true;
            this.rdSıfır.Location = new System.Drawing.Point(22, 19);
            this.rdSıfır.Name = "rdSıfır";
            this.rdSıfır.Size = new System.Drawing.Size(31, 17);
            this.rdSıfır.TabIndex = 0;
            this.rdSıfır.TabStop = true;
            this.rdSıfır.Text = "0";
            this.rdSıfır.UseVisualStyleBackColor = true;
            // 
            // rdBir
            // 
            this.rdBir.AutoSize = true;
            this.rdBir.Location = new System.Drawing.Point(22, 57);
            this.rdBir.Name = "rdBir";
            this.rdBir.Size = new System.Drawing.Size(31, 17);
            this.rdBir.TabIndex = 0;
            this.rdBir.TabStop = true;
            this.rdBir.Text = "1";
            this.rdBir.UseVisualStyleBackColor = true;
            // 
            // rdİki
            // 
            this.rdİki.AutoSize = true;
            this.rdİki.Location = new System.Drawing.Point(22, 97);
            this.rdİki.Name = "rdİki";
            this.rdİki.Size = new System.Drawing.Size(31, 17);
            this.rdİki.TabIndex = 0;
            this.rdİki.TabStop = true;
            this.rdİki.Text = "2";
            this.rdİki.UseVisualStyleBackColor = true;
            // 
            // rdUc
            // 
            this.rdUc.AutoSize = true;
            this.rdUc.Location = new System.Drawing.Point(22, 137);
            this.rdUc.Name = "rdUc";
            this.rdUc.Size = new System.Drawing.Size(31, 17);
            this.rdUc.TabIndex = 0;
            this.rdUc.TabStop = true;
            this.rdUc.Text = "3";
            this.rdUc.UseVisualStyleBackColor = true;
            // 
            // chbIngilizce
            // 
            this.chbIngilizce.AutoSize = true;
            this.chbIngilizce.Location = new System.Drawing.Point(21, 33);
            this.chbIngilizce.Name = "chbIngilizce";
            this.chbIngilizce.Size = new System.Drawing.Size(64, 17);
            this.chbIngilizce.TabIndex = 0;
            this.chbIngilizce.Text = "İngilizce";
            this.chbIngilizce.UseVisualStyleBackColor = true;
            // 
            // chbAlmanca
            // 
            this.chbAlmanca.AutoSize = true;
            this.chbAlmanca.Location = new System.Drawing.Point(21, 67);
            this.chbAlmanca.Name = "chbAlmanca";
            this.chbAlmanca.Size = new System.Drawing.Size(67, 17);
            this.chbAlmanca.TabIndex = 0;
            this.chbAlmanca.Text = "Almanca";
            this.chbAlmanca.UseVisualStyleBackColor = true;
            // 
            // chbFransızca
            // 
            this.chbFransızca.AutoSize = true;
            this.chbFransızca.Location = new System.Drawing.Point(21, 109);
            this.chbFransızca.Name = "chbFransızca";
            this.chbFransızca.Size = new System.Drawing.Size(71, 17);
            this.chbFransızca.TabIndex = 0;
            this.chbFransızca.Text = "Fransızca";
            this.chbFransızca.UseVisualStyleBackColor = true;
            // 
            // chbYunanca
            // 
            this.chbYunanca.AutoSize = true;
            this.chbYunanca.Location = new System.Drawing.Point(21, 152);
            this.chbYunanca.Name = "chbYunanca";
            this.chbYunanca.Size = new System.Drawing.Size(69, 17);
            this.chbYunanca.TabIndex = 0;
            this.chbYunanca.Text = "Yunanca";
            this.chbYunanca.UseVisualStyleBackColor = true;
            // 
            // chbItalyanca
            // 
            this.chbItalyanca.AutoSize = true;
            this.chbItalyanca.Location = new System.Drawing.Point(21, 197);
            this.chbItalyanca.Name = "chbItalyanca";
            this.chbItalyanca.Size = new System.Drawing.Size(69, 17);
            this.chbItalyanca.TabIndex = 0;
            this.chbItalyanca.Text = "İtalyanca";
            this.chbItalyanca.UseVisualStyleBackColor = true;
            // 
            // chbArapca
            // 
            this.chbArapca.AutoSize = true;
            this.chbArapca.Location = new System.Drawing.Point(21, 236);
            this.chbArapca.Name = "chbArapca";
            this.chbArapca.Size = new System.Drawing.Size(60, 17);
            this.chbArapca.TabIndex = 0;
            this.chbArapca.Text = "Arapça";
            this.chbArapca.UseVisualStyleBackColor = true;
            // 
            // txtMaas
            // 
            this.txtMaas.Location = new System.Drawing.Point(512, 322);
            this.txtMaas.Name = "txtMaas";
            this.txtMaas.Size = new System.Drawing.Size(218, 20);
            this.txtMaas.TabIndex = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(552, 349);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(136, 42);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(508, 402);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "YENİ  MAAŞ";
            // 
            // lblSonMaas
            // 
            this.lblSonMaas.AutoSize = true;
            this.lblSonMaas.Location = new System.Drawing.Point(615, 404);
            this.lblSonMaas.Name = "lblSonMaas";
            this.lblSonMaas.Size = new System.Drawing.Size(0, 13);
            this.lblSonMaas.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 452);
            this.Controls.Add(this.lblSonMaas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtMaas);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grpCocuk);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpCocuk.ResumeLayout(false);
            this.grpCocuk.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdBekar;
        private System.Windows.Forms.RadioButton rdEvli;
        private System.Windows.Forms.GroupBox grpCocuk;
        private System.Windows.Forms.RadioButton rdUc;
        private System.Windows.Forms.RadioButton rdİki;
        private System.Windows.Forms.RadioButton rdBir;
        private System.Windows.Forms.RadioButton rdSıfır;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chbArapca;
        private System.Windows.Forms.CheckBox chbItalyanca;
        private System.Windows.Forms.CheckBox chbYunanca;
        private System.Windows.Forms.CheckBox chbFransızca;
        private System.Windows.Forms.CheckBox chbAlmanca;
        private System.Windows.Forms.CheckBox chbIngilizce;
        private System.Windows.Forms.TextBox txtMaas;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSonMaas;
    }
}

