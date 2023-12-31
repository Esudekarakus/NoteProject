using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteProject.UI.model
{
    public class Notlar
    {
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string Icerik { get; set; }


        [ForeignKey("User")]

        public int UserID { get; set; }
    }
}
