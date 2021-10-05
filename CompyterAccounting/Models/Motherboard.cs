using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompyterAccounting.Models
{
    public class Motherboard
    {
        public Motherboard()
        {
            СистемныйБлокs = new HashSet<СистемныйБлок>();
        }

        public int IdМатеринскаяПлата { get; set; }
        public string МодельМатеринскаяПлата { get; set; }

        public virtual ICollection<СистемныйБлок> СистемныйБлокs { get; set; }
    }
}
