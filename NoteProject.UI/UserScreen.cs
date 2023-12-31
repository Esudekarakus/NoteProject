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
using NoteProject.UI.model;

namespace NoteProject.UI
{
    public partial class UserScreen : Form
    {
        public UserScreen(int userID)
        {
            InitializeComponent();
            dbContext = new AppDbContext();
            this.userID = userID;
        }
        int userID;
        AppDbContext dbContext;

        private void UserScreen_Load(object sender, EventArgs e)
        {

            var notlar = dbContext.Notlar.Where(a => a.UserID == userID).ToList();

            foreach (var u in notlar)
            {
                lboxNotlar.Items.Add(u.Baslik);
            }



        }

        private void lboxNotlar_SelectedIndexChanged(object sender, EventArgs e)
        {

            string secilenNotBaslik = lboxNotlar.Text;

            var notdb = dbContext.Notlar.FirstOrDefault(i => i.Baslik == secilenNotBaslik);

            txtBaslik.Text = secilenNotBaslik;
            txtIcerik.Text = notdb.Icerik.ToString();


        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Notlar notlar = new Notlar()
            {
                Baslik = txtBaslik.Text,
                Icerik = txtIcerik.Text,
                UserID = userID

            };
            dbContext.Notlar.Add(notlar);
            dbContext.SaveChanges();
            MessageBox.Show("Not Kaydedildi");
            lboxNotlar.Items.Clear();

            var notla = dbContext.Notlar.Where(a => a.UserID == userID).ToList();

            foreach (var u in notla)
            {
                lboxNotlar.Items.Add(u.Baslik);
            }



        }

        private void btnYeniNot_Click(object sender, EventArgs e)
        {
            txtBaslik.Text = string.Empty;
            txtIcerik.Text = string.Empty;
        }

        private void btnNotSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek istediğinizden emin misiniz?","Onay mesajı",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string secilenNotBaslik = lboxNotlar.Text;
                var notdb = dbContext.Notlar.FirstOrDefault(i => i.Baslik == secilenNotBaslik);

                if (notdb != null)
                {
                    dbContext.Notlar.Remove(notdb);
                    dbContext.SaveChanges();
                    var notlaa = dbContext.Notlar.Where(a => a.UserID == userID).ToList();
                    lboxNotlar.Items.Clear();
                    foreach (var u in notlaa)
                    {
                        lboxNotlar.Items.Add(u.Baslik);
                    }

                }
            }

            txtBaslik.Text = string.Empty;
            txtIcerik.Text = string.Empty;


        }

        private void UserScreen_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void linkSifreDegis_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PasswordChangeScreen passwordChangeScreen = new PasswordChangeScreen(userID);
            this.Hide();
            passwordChangeScreen.ShowDialog();
            this.Show();
            
        }
    }
}
