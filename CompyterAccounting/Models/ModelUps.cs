using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations.Schema;

namespace CompyterAccounting.Models
{
    public class ModelUps
    {
        //public ModelUps()
        //{
        //    Ups = new HashSet<Ups>();
        //}

        [Key]
        //[BindProperty]
        public int id_modelUps { get; set; }

        //[BindProperty]
        public string Model { get; set; }
        //[BindProperty]
        //public virtual ICollection<Ups> Ups { get; set; }
    }
}
