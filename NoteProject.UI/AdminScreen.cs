﻿using System;
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
    public partial class AdminScreen : Form
    {
        public AdminScreen()
        {
            InitializeComponent();
            dbContext = new AppDbContext();
        }
        AppDbContext dbContext;
        private void AdminScreen_Load(object sender, EventArgs e)
        {
            listView1.Select();
            listView1.HideSelection = false;
            btnDurum.Enabled = false;
            listView1.FullRowSelect = true;
            
            var kullanicilar = dbContext.Users.ToList();
            listView1.View = View.Details;
            foreach (var kullanici in kullanicilar)
            {
                ListViewItem item = new ListViewItem(kullanici.Ad);
                item.SubItems.Add(kullanici.Soyad);
                item.SubItems.Add(kullanici.UserName);
                item.SubItems.Add(kullanici.Durum.ToString());

                listView1.Items.Add(item);
            }

        }

        private void btnDurum_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                
                var secilenKullanici = listView1.SelectedItems[0].Tag as User;

                // Null kontrolü ekleyin
                if (secilenKullanici != null)
                {
                    int userId = secilenKullanici.UserID;
                    var userdb = dbContext.Users.FirstOrDefault(x => x.UserID == userId);

                   
                    if (userdb != null)
                    {
                        if (userdb.Durum == Durum.Aktif)
                        { userdb.Durum = Durum.Pasif; }
                        else
                        { userdb.Durum = Durum.Aktif; }
                       
                        MessageBox.Show($"UserID: {userdb.UserID}, Yeni Durum: {userdb.Durum}");
                        dbContext.SaveChanges();
                    }

                    
                    listView1.Items.Clear();

                    var kullanicilar = dbContext.Users.ToList();
                    listView1.View = View.Details;
                    foreach (var kullanici in kullanicilar)
                    {
                        ListViewItem item = new ListViewItem(kullanici.Ad);
                        item.SubItems.Add(kullanici.Soyad);
                        item.SubItems.Add(kullanici.UserName);
                        item.SubItems.Add(kullanici.Durum.ToString());

                        item.Tag = kullanici; 

                        listView1.Items.Add(item);
                    }
                }
            }
            else
            {
                btnDurum.Enabled = false;
            }
        }

       
    }
}