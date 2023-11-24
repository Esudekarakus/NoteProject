namespace NoteProject.UI
{
    partial class UserScreen
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
            linkSifreDegis = new LinkLabel();
            btnKaydet = new Button();
            btnNotSil = new Button();
            btnYeniNot = new Button();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            txtIcerik = new TextBox();
            txtBaslik = new TextBox();
            lboxNotlar = new ListBox();
            SuspendLayout();
            // 
            // linkSifreDegis
            // 
            linkSifreDegis.AutoSize = true;
            linkSifreDegis.Location = new Point(44, 603);
            linkSifreDegis.Margin = new Padding(4, 0, 4, 0);
            linkSifreDegis.Name = "linkSifreDegis";
            linkSifreDegis.Size = new Size(168, 37);
            linkSifreDegis.TabIndex = 35;
            linkSifreDegis.TabStop = true;
            linkSifreDegis.Text = "Şifre Değiştir";
            linkSifreDegis.LinkClicked += linkSifreDegis_LinkClicked;
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(730, 588);
            btnKaydet.Margin = new Padding(4);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(148, 53);
            btnKaydet.TabIndex = 34;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnNotSil
            // 
            btnNotSil.Location = new Point(530, 588);
            btnNotSil.Margin = new Padding(4);
            btnNotSil.Name = "btnNotSil";
            btnNotSil.Size = new Size(148, 53);
            btnNotSil.TabIndex = 33;
            btnNotSil.Text = "Not Sil";
            btnNotSil.UseVisualStyleBackColor = true;
            btnNotSil.Click += btnNotSil_Click;
            // 
            // btnYeniNot
            // 
            btnYeniNot.Location = new Point(335, 588);
            btnYeniNot.Margin = new Padding(4);
            btnYeniNot.Name = "btnYeniNot";
            btnYeniNot.Size = new Size(148, 53);
            btnYeniNot.TabIndex = 29;
            btnYeniNot.Text = "Yeni Not";
            btnYeniNot.UseVisualStyleBackColor = true;
            btnYeniNot.Click += btnYeniNot_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(335, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(79, 37);
            label2.TabIndex = 30;
            label2.Text = "İçerik";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 28);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(122, 37);
            label3.TabIndex = 31;
            label3.Text = "Notlarım";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(335, 28);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 37);
            label1.TabIndex = 32;
            label1.Text = "Başlık";
            // 
            // txtIcerik
            // 
            txtIcerik.Location = new Point(335, 177);
            txtIcerik.Margin = new Padding(4);
            txtIcerik.Multiline = true;
            txtIcerik.Name = "txtIcerik";
            txtIcerik.Size = new Size(542, 378);
            txtIcerik.TabIndex = 28;
            // 
            // txtBaslik
            // 
            txtBaslik.Location = new Point(335, 70);
            txtBaslik.Margin = new Padding(4);
            txtBaslik.Name = "txtBaslik";
            txtBaslik.Size = new Size(542, 43);
            txtBaslik.TabIndex = 27;
            // 
            // lboxNotlar
            // 
            lboxNotlar.FormattingEnabled = true;
            lboxNotlar.ItemHeight = 37;
            lboxNotlar.Location = new Point(44, 70);
            lboxNotlar.Margin = new Padding(4);
            lboxNotlar.Name = "lboxNotlar";
            lboxNotlar.Size = new Size(245, 485);
            lboxNotlar.TabIndex = 36;
            lboxNotlar.SelectedIndexChanged += lboxNotlar_SelectedIndexChanged;
            // 
            // UserScreen
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(970, 676);
            Controls.Add(linkSifreDegis);
            Controls.Add(btnKaydet);
            Controls.Add(btnNotSil);
            Controls.Add(btnYeniNot);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtIcerik);
            Controls.Add(txtBaslik);
            Controls.Add(lboxNotlar);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "UserScreen";
            Text = "UserScreen";
            FormClosing += UserScreen_FormClosing;
            Load += UserScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkSifreDegis;
        private Button btnKaydet;
        private Button btnNotSil;
        private Button btnYeniNot;
        private Label label2;
        private Label label3;
        private Label label1;
        private TextBox txtIcerik;
        private TextBox txtBaslik;
        private ListBox lboxNotlar;
    }
}