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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            dbContext=new AppDbContext();
        }
        AppDbContext dbContext;
        private void Login_Load(object sender, EventArgs e)
        {
            txtSifre.PasswordChar = '*';
        }

        private void linkKayit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignInScreen signInScreen = new SignInScreen();
            signInScreen.ShowDialog();

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi=txtKullaniciAdi.Text;
            string Parola=txtSifre.Text;

           
            var userDB=dbContext.Users.FirstOrDefault(x=>x.UserName==kullaniciAdi);

            var adminDb = dbContext.Admins.FirstOrDefault(x => x.UserName == kullaniciAdi);

            if (userDB != null )
            {

                var userSifre = dbContext.Users.FirstOrDefault(x => x.UserName == kullaniciAdi && x.Sifre == Parola);
                var adminSifre = dbContext.Admins.FirstOrDefault(x => x.UserName == kullaniciAdi && x.Sifre == Parola);
                if (userSifre == null  )
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı");
                }
                else
                {
                    
                    if (adminDb != null)
                    {
                        MessageBox.Show("Giriş başarılı");
                        AdminScreen adminScreen = new AdminScreen();
                        this.Hide();
                        adminScreen.ShowDialog(); 
                        this.Show();
                        
                    }
                    else if(userDB.Durum==Durum.Pasif)
                    {
                        MessageBox.Show("Kullanıcılığınız henüz aktive olmamış admin ile iletişime geçiniz.");
                    }
                    else
                    {
                        int userId = userDB.UserID;
                        UserScreen userScreen = new UserScreen(userId);
                        this.Hide();
                        userScreen.ShowDialog();
                        this.Show();
                        
                    }
                }

            }
            else
            {
                MessageBox.Show("Bu kullanıcı adında kayıt bulunamadı lütfen tekrar deneyiniz.");
            }
           
            
        }
    }
}
