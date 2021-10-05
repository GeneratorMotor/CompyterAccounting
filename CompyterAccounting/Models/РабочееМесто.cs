using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompyterAccounting.Models
{
    public class РабочееМесто
    {
        public РабочееМесто()
        {
            СистемныйБлокs = new HashSet<СистемныйБлок>();
        }

        public int IdРабочееМесто { get; set; }
        public string IdИнвентарныйНомер { get; set; }
        public int? IdKeyboard { get; set; }
        public int? IdDisplay { get; set; }
        public int? IdMouse { get; set; }
        public int? IdUps { get; set; }
        public int? IdPerson { get; set; }

        public virtual Монитор IdDisplayNavigation { get; set; }
        public virtual Keyboard IdKeyboardNavigation { get; set; }
        public virtual Mouse IdMouseNavigation { get; set; }
        public virtual Ups IdUpsNavigation { get; set; }
        public virtual ICollection<СистемныйБлок> СистемныйБлокs { get; set; }
    }
}
