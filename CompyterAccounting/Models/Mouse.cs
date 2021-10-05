using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompyterAccounting.Models
{
    public class Mouse
    {
        public Mouse()
        {
            РабочееМестоs = new HashSet<РабочееМесто>();
        }

        public int IdМышь { get; set; }
        public string МодельМышь { get; set; }

        public virtual ICollection<РабочееМесто> РабочееМестоs { get; set; }
    }
}
