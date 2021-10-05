using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompyterAccounting.Models
{
    public class Монитор
    {
        public Монитор()
        {
            РабочееМестоs = new HashSet<РабочееМесто>();
        }

        public int IdМонитор { get; set; }
        public int? IdDisplayModel { get; set; }
        public string СерийныйНомерМонитор { get; set; }

        public virtual ModelDisplay IdDisplayModelNavigation { get; set; }
        public virtual ICollection<РабочееМесто> РабочееМестоs { get; set; }
    }
}
