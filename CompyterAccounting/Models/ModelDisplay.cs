using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompyterAccounting.Models
{
    public class ModelDisplay
    {

        public ModelDisplay()
        {
            Мониторs = new HashSet<Монитор>();
        }

        public int IdModelDisplay { get; set; }
        public string ModelDisplay1 { get; set; }

        public virtual ICollection<Монитор> Мониторs { get; set; }
    }
}
