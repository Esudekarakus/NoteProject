using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteProject.UI
{
    public partial class SignInScreen : Form
    {
        public SignInScreen()
        {
            InitializeComponent();
            dbContext = new AppDbContext();
        }

        AppDbContext dbContext;
        private void SignInScreen_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
            txtSifreTekrar.PasswordChar= '*';
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
           bool Bos=txtAd.Text==string.Empty||txtKullaniciAdi.Text==string.Empty||txtSifre.Text==string.Empty||txtSifreTekrar.Text==string.Empty;
           bool sifreGecerliMi = txtSifreTekrar.Text == txtSifre.Text && (txtSifre.Text.Length>5);

            var userdb = dbContext.Users.FirstOrDefault(x => x.UserName == txtKullaniciAdi.Text);
            

            if (userdb != null) 
            {
                MessageBox.Show("Kullanıcı adı sistemde kayıtlı");
            }
            else
            {
                if(Bos)
                {
                    MessageBox.Show("Lütfen kutucukları boş bırakmayınız");
                }
                else if (!sifreGecerliMi)
                {
                    MessageBox.Show("Şifre geçerli değil,tekrar deneyiniz.");
                }
                else
                {
                    User user = new User();
                    user.UserName = txtKullaniciAdi.Text;
                    user.Ad = txtAd.Text;
                    user.Soyad = txtSoyad.Text;
                    user.Sifre = txtSifre.Text;
                    dbContext.Users.Add(user);
                    dbContext.SaveChanges();
                    MessageBox.Show("Kayıt başarılı");
                    this.Close();
                    


                }
               

            }

        }
    }
}
