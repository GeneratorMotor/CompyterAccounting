using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompyterAccounting.Models
{
    public class СистемныйБлок
    {
        public СистемныйБлок()
        {
            CompIncs = new HashSet<CompInc>();
            HddComps = new HashSet<HddComp>();
        }

        public int IdСистемныйБлок { get; set; }
        public string ИнвентарныйНомер { get; set; }
        public int IdСтатус { get; set; }
        public int? IdРабочееМесто { get; set; }
        public int? IdCabinet { get; set; }
        public int? IdМатеринскаяПлата { get; set; }
        public int? IdПроцессор { get; set; }
        public int? IdОзу { get; set; }
        public int? IdHddComp { get; set; }
        public int? IdIncComp { get; set; }
        public string Примечание { get; set; }

        public virtual Motherboard IdМатеринскаяПлатаNavigation { get; set; }
        public virtual Озу IdОзуNavigation { get; set; }
        public virtual Процессор IdПроцессорNavigation { get; set; }
        public virtual РабочееМесто IdРабочееМестоNavigation { get; set; }
        public virtual Статус IdСтатусNavigation { get; set; }
        public virtual ICollection<CompInc> CompIncs { get; set; }
        public virtual ICollection<HddComp> HddComps { get; set; }
    }
}
