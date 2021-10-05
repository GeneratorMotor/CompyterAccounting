using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompyterAccounting.Models
{
    public class Статус
    {
        public Статус()
        {
            СистемныйБлокs = new HashSet<СистемныйБлок>();
        }

        public int IdСтатус { get; set; }
        public string Статус1 { get; set; }

        public virtual ICollection<СистемныйБлок> СистемныйБлокs { get; set; }
    }
}
