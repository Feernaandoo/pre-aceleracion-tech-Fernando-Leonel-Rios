using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge_Backend_CSharp_.Net.Entities
{
    public class Genre
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string Denomination { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
