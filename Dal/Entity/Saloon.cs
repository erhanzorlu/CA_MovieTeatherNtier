using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entity
{
    public class Saloon
    {
        public int ID { get; set; }
        public string SaloonName { get; set; }
        public int Capacity { get; set; }
        //mapping
        public List<Theater> Theaters { get; set; }
    }
}
