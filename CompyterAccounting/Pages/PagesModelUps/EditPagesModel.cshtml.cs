using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CompyterAccounting.Repositories;
using CompyterAccounting.Models;

namespace CompyterAccounting.Pages.PagesModelUps
{
    public class EditPagesModelModel : PageModel
    {
        private readonly DataContext dc;

        public ModelUps modelUps { get; set; }

        public EditPagesModelModel(DataContext dc)
        {
            this.dc = dc;
        }

        public async Task<IActionResult> OnGetAsync(int? id_modelUps)
        {
            //var model = dc.ModelUps.FindAsync(id_modelUps);
            var model = await dc.ModelUps.FindAsync(1000);

            if (model == null)
            {
                return NotFound();
            }

            var asd = this.modelUps;

            return null;
        }

            //public async Task<IActionResult> OnGetAsync(int? id_modelUps)
            //{
            //    var id = id_modelUps;

            //    return null;
            //}
    }
}
