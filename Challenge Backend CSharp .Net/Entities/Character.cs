using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge_Backend_CSharp_.Net.Entities
{
    public class Character
    {
        public int ID { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public float Height { get; set; }
        public string Story { get; set; }

        public ICollection<Movie> Movies { get; set; }
    }
}
