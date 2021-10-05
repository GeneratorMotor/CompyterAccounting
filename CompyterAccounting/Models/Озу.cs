using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompyterAccounting.Models
{
    public class Озу
    {
        public Озу()
        {
            СистемныйБлокs = new HashSet<СистемныйБлок>();
        }

        public int IdОзу { get; set; }
        public string МодельОзу { get; set; }

        public virtual ICollection<СистемныйБлок> СистемныйБлокs { get; set; }
    }
}
