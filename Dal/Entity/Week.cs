using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entity
{
    public class Week
    {
        public int ID { get; set; }
        public string WhichWeek { get; set; }
        public DateTime FirstDay { get; set; }
        public DateTime LastDay { get; set; }
        //mapping
        public List<Theater> Theaters { get; set; }
    }
}
