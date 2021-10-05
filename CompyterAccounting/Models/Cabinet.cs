using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompyterAccounting.Models
{
    public class Cabinet
    {
        [Key]
        public int IdCabint { get; set; }
        public string NumberCabinet { get; set; }
    }
}
