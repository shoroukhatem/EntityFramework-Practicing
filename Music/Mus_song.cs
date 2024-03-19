using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Music
{
    public class Mus_song
    {
        public Musician Musician { get; set; }
        [ForeignKey("Musician")]
        public int Mus_Id {  get; set; }
        public Song Song { get; set; }
        [ForeignKey("Song")]
        public string Song_Title { get; set; }
    }
}
