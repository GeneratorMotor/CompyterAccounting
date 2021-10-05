using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompyterAccounting.Models
{
    public class HddComp
    {
        public int IdHddComp { get; set; }
        public int? IdHdd { get; set; }
        public int? IdСистемныйБлок { get; set; }

        public virtual Hdd IdHddNavigation { get; set; }
        public virtual СистемныйБлок IdСистемныйБлокNavigation { get; set; }
    }
}
