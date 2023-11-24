namespace NoteProject.UI
{
    partial class PasswordChangeScreen
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
            txtYeniSifreTekrar = new TextBox();
            label3 = new Label();
            btnSifreDegis = new Button();
            txtYeniSifre = new TextBox();
            txtEskiSifre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtYeniSifreTekrar
            // 
            txtYeniSifreTekrar.Location = new Point(330, 216);
            txtYeniSifreTekrar.Margin = new Padding(4);
            txtYeniSifreTekrar.Name = "txtYeniSifreTekrar";
            txtYeniSifreTekrar.Size = new Size(296, 43);
            txtYeniSifreTekrar.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 223);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(215, 37);
            label3.TabIndex = 37;
            label3.Text = "Yeni Şifre Tekrar :";
            // 
            // btnSifreDegis
            // 
            btnSifreDegis.Location = new Point(92, 313);
            btnSifreDegis.Margin = new Padding(4);
            btnSifreDegis.Name = "btnSifreDegis";
            btnSifreDegis.Size = new Size(535, 64);
            btnSifreDegis.TabIndex = 34;
            btnSifreDegis.Text = "Şifre Değiştir";
            btnSifreDegis.UseVisualStyleBackColor = true;
            btnSifreDegis.Click += btnSifreDegis_Click;
            // 
            // txtYeniSifre
            // 
            txtYeniSifre.Location = new Point(330, 138);
            txtYeniSifre.Margin = new Padding(4);
            txtYeniSifre.Name = "txtYeniSifre";
            txtYeniSifre.Size = new Size(296, 43);
            txtYeniSifre.TabIndex = 32;
            // 
            // txtEskiSifre
            // 
            txtEskiSifre.Location = new Point(330, 54);
            txtEskiSifre.Margin = new Padding(4);
            txtEskiSifre.Name = "txtEskiSifre";
            txtEskiSifre.Size = new Size(296, 43);
            txtEskiSifre.TabIndex = 31;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 147);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(138, 37);
            label2.TabIndex = 35;
            label2.Text = "Yeni Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 62);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 36;
            label1.Text = "Eski Şifre :";
            // 
            // PasswordChangeScreen
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 437);
            Controls.Add(txtYeniSifreTekrar);
            Controls.Add(label3);
            Controls.Add(btnSifreDegis);
            Controls.Add(txtYeniSifre);
            Controls.Add(txtEskiSifre);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "PasswordChangeScreen";
            Text = "PasswordChangeScreen";
            Load += PasswordChangeScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtYeniSifreTekrar;
        private Label label3;
        private Button btnSifreDegis;
        private TextBox txtYeniSifre;
        private TextBox txtEskiSifre;
        private Label label2;
        private Label label1;
    }
}