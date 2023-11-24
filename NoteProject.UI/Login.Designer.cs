namespace NoteProject.UI
{
    partial class Login
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
            btnGiris = new Button();
            linkKayit = new LinkLabel();
            txtSifre = new TextBox();
            txtKullaniciAdi = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(243, 317);
            btnGiris.Margin = new Padding(4);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(298, 62);
            btnGiris.TabIndex = 23;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // linkKayit
            // 
            linkKayit.AutoSize = true;
            linkKayit.Location = new Point(424, 417);
            linkKayit.Margin = new Padding(4, 0, 4, 0);
            linkKayit.Name = "linkKayit";
            linkKayit.Size = new Size(110, 37);
            linkKayit.TabIndex = 24;
            linkKayit.TabStop = true;
            linkKayit.Text = "Kayıt Ol";
            linkKayit.LinkClicked += linkKayit_LinkClicked;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(243, 216);
            txtSifre.Margin = new Padding(4);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(296, 43);
            txtSifre.TabIndex = 22;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Location = new Point(243, 132);
            txtKullaniciAdi.Margin = new Padding(4);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new Size(296, 43);
            txtKullaniciAdi.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 222);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 37);
            label2.TabIndex = 19;
            label2.Text = "Şifre : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(292, 35);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(191, 37);
            label3.TabIndex = 20;
            label3.Text = "HOŞ GELDİNİZ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 138);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(177, 37);
            label1.TabIndex = 21;
            label1.Text = "Kullanıcı Adı :";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 499);
            Controls.Add(btnGiris);
            Controls.Add(linkKayit);
            Controls.Add(txtSifre);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private LinkLabel linkKayit;
        private TextBox txtSifre;
        private TextBox txtKullaniciAdi;
        private Label label2;
        private Label label3;
        private Label label1;
    }
}