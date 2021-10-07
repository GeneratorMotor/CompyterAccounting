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
    public class EditModelUpsModel : PageModel
    {
        private readonly DataContext dc;

        [BindProperty]
        public ModelUps model { get; set; }

        public EditModelUpsModel(DataContext dc)
        {
            this.dc = dc;
        }

        public async Task<IActionResult> OnGetAsync(int? id_modelUp)
        {
            //var model = await dc.ModelUps.FindAsync(id);

            var idTest = this.model;

            var model = await dc.ModelUps.FindAsync(100);

            if (model == null)
            {
                return NotFound();
            }

            return RedirectToPage();
        }
    }
}
