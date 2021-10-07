using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompyterAccounting.Models
{
    public class Ups
    {
        public Ups()
        {
            РабочееМестоs = new HashSet<РабочееМесто>();
        }
        [Key]
        public int IdUps { get; set; }
        
        public int? IdModelUps { get; set; }
        public string ИнвентарныйНомер { get; set; }

        public virtual ModelUps IdModelUpsNavigation { get; set; }
        public virtual ICollection<РабочееМесто> РабочееМестоs { get; set; }
    }
}
