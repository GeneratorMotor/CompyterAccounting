using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompyterAccounting.Models
{
    public class CompInc
    {
        public int IdIncComp { get; set; }
        public int? IdInc { get; set; }
        public int? IdComp { get; set; }

        public virtual СистемныйБлок IdCompNavigation { get; set; }
        public virtual Nic IdIncNavigation { get; set; }
    }
}
