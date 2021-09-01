using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge_Backend_CSharp_.Net.Entities
{
    public class Movie
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string Denomination { get; set; }
        public int Population { get; set; }
        public int Area { get; set; }
        public Genre Genre { get; set; }
        public ICollection<Character> Characters { get; set; }
    }
}
