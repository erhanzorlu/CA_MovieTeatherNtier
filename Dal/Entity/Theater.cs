using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.Entity
{
    public class Theater
    {
        public int ID { get; set; }
        //mapping
        public Movie Movie { get; set; }
        public Session Session { get; set; }
        public Week Week { get; set; }
        public Saloon Saloon { get; set; }
        public int MovieID { get; set; }
        public int SessionID { get; set; }
        public int WeekID { get; set; }
        public int SaloonID { get; set; }

    }
}
