using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompyterAccounting.Models
{
    public class Keyboard
    {
        public Keyboard()
        {
            РабочееМестоs = new HashSet<РабочееМесто>();
        }

        public int IdKeyboard { get; set; }
        public string МодельКлавиатуры { get; set; }

        public virtual ICollection<РабочееМесто> РабочееМестоs { get; set; }
    }
}
