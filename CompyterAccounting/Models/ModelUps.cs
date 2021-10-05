using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompyterAccounting.Models
{
    public class ModelUps
    {
        public ModelUps()
        {
            Ups = new HashSet<Ups>();
        }

        public int IdModelUps { get; set; }
        public string ModelUps1 { get; set; }

        public virtual ICollection<Ups> Ups { get; set; }
    }
}
