using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompyterAccounting.Models
{
    public class Nic
    {
        public Nic()
        {
            CompIncs = new HashSet<CompInc>();
        }

        public int IdNic { get; set; }
        public string МодельNic { get; set; }
        public string СерийныйНомерNic { get; set; }

        public virtual ICollection<CompInc> CompIncs { get; set; }
    }
}
