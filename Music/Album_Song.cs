using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Music
{
    public class Album_Song
    {
        public Album Album { get; set; }
        [ForeignKey("Album")]
        public int Album_Id { get; set; }
        public Song Song { get; set; }
        [Key]
        [ForeignKey("Song")]
        public string Song_Title { get; set; }
    }
}
