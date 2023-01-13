using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entity
{
    public class Session
    {
        public int ID { get; set; }
        public string SessionName { get; set; }
        //mapping
        public List<Theater> Theaters { get; set; }
    }
}
