using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Music
{
    public class Album
    {
        public int Id { get; set; } 
        public string Title { get; set; }

        public DateTime Date { get; set; }

        public Musician Musician { get; set; }
        [ForeignKey("Musician")]
        public int Mus_Id { get; set; }
    }
}
