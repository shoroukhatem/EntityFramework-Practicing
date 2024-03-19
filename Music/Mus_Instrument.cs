using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Music
{
    public class Mus_Instrument
    {
        public Musician Musician { get; set; }
        [ForeignKey("Musician")]
        public int Mus_Id { get; set; }
        public Instrument Instrument { get; set; }
        [ForeignKey("Instrument")]
        public string Inst_Name {  get; set; }
    }
}
