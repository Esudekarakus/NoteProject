using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteProject.UI.context;

namespace NoteProject.UI
{
    public partial class PasswordChangeScreen : Form
    {
        public PasswordChangeScreen(int userID)
        {
            InitializeComponent();
            this.userID = userID;
            dbContext = new AppDbContext();
        }
        int userID;
        AppDbContext dbContext;

        private void PasswordChangeScreen_Load(object sender, EventArgs e)
        {
            txtEskiSifre.PasswordChar = '*';
            txtYeniSifre.PasswordChar = '*';
            txtYeniSifreTekrar.PasswordChar = '*';
        }

        private void btnSifreDegis_Click(object sender, EventArgs e)
        {
            bool SifrelerEslesiyorMu = txtYeniSifre.Text == txtYeniSifreTekrar.Text;
            bool SifreGecerliMi = txtYeniSifre.Text.Length >= 7;
            var userdb=dbContext.Users.FirstOrDefault(x => x.UserID == userID && x.Sifre==txtEskiSifre.Text);
            bool YeniSifreGrildiMi = txtYeniSifre.Text !=txtEskiSifre.Text;
            if (userdb != null)
            {
                if(SifrelerEslesiyorMu &&  YeniSifreGrildiMi && SifreGecerliMi)
                {
                    userdb.Sifre = txtYeniSifre.Text;
                    MessageBox.Show("Şifreniz başarıyla kaydedilmiştir.");
                    dbContext.SaveChanges();
                    


                    this.Close();

                }
                else if (!YeniSifreGrildiMi)
                {
                    MessageBox.Show("Lütfen eski şifrenizden farklı bir şifre giriniz","Hata Mesajı",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(!SifrelerEslesiyorMu)
                {
                    MessageBox.Show("Girdiğiniz şifreler eşleşmiyor,lütfen tekrar deneyiniz.", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if(!SifreGecerliMi)
                {
                    MessageBox.Show("Şifreniz 7 karakter veya daha uzun olmalıdır!", "Hata Mesajı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

                
            }
            else
                MessageBox.Show("Şifreyi hatalı,lütfen tekrar deneyiniz.");
        }
    }
}
