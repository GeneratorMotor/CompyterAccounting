using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompyterAccounting.Models
{
    public class Процессор
    {
        public Процессор()
        {
            СистемныйБлокs = new HashSet<СистемныйБлок>();
        }
        public int IdПроцессор { get; set; }
        public string МодельПроцессор { get; set; }

        public virtual ICollection<СистемныйБлок> СистемныйБлокs { get; set; }
    }
}
