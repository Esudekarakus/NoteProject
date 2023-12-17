using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteProject.UI
{
    public class User
    {
        public int UserID {  get; set; }
        public string Ad {  get; set; }
        public string Soyad { get; set; }
        
        public string UserName { get; set; }

        public string Sifre { get; set; }

        //default pasif
        public Durum Durum { get; set; } = Durum.Pasif;
        public ICollection<Notlar> Notlar { get; set; }

    }
}
