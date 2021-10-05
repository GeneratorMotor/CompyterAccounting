using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompyterAccounting.Models
{
    public class Hdd
    {
        public Hdd()
        {
            HddComps = new HashSet<HddComp>();
        }

        public int IdHdd { get; set; }
        public string МоделHdd { get; set; }
        public string СерийныйНомерHdd { get; set; }

        public virtual ICollection<HddComp> HddComps { get; set; }
    }
}
