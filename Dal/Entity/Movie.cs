using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entity
{
    public class Movie
    {
        public int ID { get; set; }
        public string MovieName { get; set; }
        public string Description { get; set; }
        public double Duration { get; set; }
        //mapping
        public List<Theater> Theaters { get; set; }

    }
}
