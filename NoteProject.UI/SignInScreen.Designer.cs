namespace NoteProject.UI
{
    partial class SignInScreen
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
            txtSoyad = new TextBox();
            label5 = new Label();
            txtAd = new TextBox();
            label4 = new Label();
            txtSifreTekrar = new TextBox();
            label3 = new Label();
            btnKayit = new Button();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(272, 103);
            txtSoyad.Margin = new Padding(4);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(296, 43);
            txtSoyad.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 110);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(103, 37);
            label5.TabIndex = 46;
            label5.Text = "Soyad :";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(272, 32);
            txtAd.Margin = new Padding(4);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(296, 43);
            txtAd.TabIndex = 36;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 40);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(70, 37);
            label4.TabIndex = 45;
            label4.Text = "Ad : ";
            // 
            // txtSifreTekrar
            // 
            txtSifreTekrar.Location = new Point(272, 332);
            txtSifreTekrar.Margin = new Padding(4);
            txtSifreTekrar.Name = "txtSifreTekrar";
            txtSifreTekrar.Size = new Size(296, 43);
            txtSifreTekrar.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 339);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(159, 37);
            label3.TabIndex = 44;
            label3.Text = "Şifre Tekrar :";
            // 
            // btnKayit
            // 
            btnKayit.Location = new Point(35, 429);
            btnKayit.Margin = new Padding(4);
            btnKayit.Name = "btnKayit";
            btnKayit.Size = new Size(535, 64);
            btnKayit.TabIndex = 42;
            btnKayit.Text = "Kayıt Ol";
            btnKayit.UseVisualStyleBackColor = true;
            btnKayit.Click += btnKayit_Click;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(272, 254);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(296, 43);
            txtSifre.TabIndex = 39;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(272, 171);
            txtKullaniciAdi.Margin = new Padding(4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(296, 43);
            txtKullaniciAdi.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 262);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 37);
            label2.TabIndex = 41;
            label2.Text = "Şifre : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 178);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 37);
            label1.TabIndex = 43;
            label1.Text = "Kullanıcı Adı :";
            // 
            // SignInScreen
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 548);
            Controls.Add(txtSoyad);
            Controls.Add(label5);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(txtSifreTekrar);
            Controls.Add(label3);
            Controls.Add(btnKayit);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "SignInScreen";
            Text = "SignInScreen";
            Load += SignInScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtSoyad;
        private Label label5;
        private TextBox txtAd;
        private Label label4;
        private TextBox txtSifreTekrar;
        private Label label3;
        private Button btnKayit;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private Label label1;
    }
}