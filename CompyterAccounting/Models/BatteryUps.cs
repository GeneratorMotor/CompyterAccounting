using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompyterAccounting.Models
{
    public class BatteryUps
    {
        [Key]
        public int IdUpsBattery { get; set; }
        
        public string Модель { get; set; }
    }
}
