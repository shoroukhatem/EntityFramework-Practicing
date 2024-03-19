using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CORE_Project.Music
{
    public class Musician
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Ph_Number { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public List<Album> Albums { get; set; }
    }
}
