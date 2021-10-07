using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CompyterAccounting.Repositories;
using CompyterAccounting.Models;

namespace CompyterAccounting.Pages
{
    public class ReferencesModel : PageModel
    {
        private readonly DataContext dc;

        // Модель страницы.
        public List<ModelUps> listModelsUps;

        [BindProperty]
        public ModelUps modelUps { get; set; }

        public ReferencesModel(DataContext dc)
        {
            this.dc = dc ?? throw new ArgumentNullException(nameof(dc));

            this.dc = dc;
        }

        public void OnGet()
        {
            var list = dc.ModelUps?.ToList();

            if(list != null)
            {
                this.listModelsUps = list;
            }
            else
            {
                ModelUps ups = new ModelUps();
                ups.id_modelUps = 0;
                ups.Model = "";

                this.listModelsUps.Append(ups);
            }
        }

        public async Task<IActionResult> OnPostDeleteAsync(int id)
        {
            var model = await dc.ModelUps.FindAsync(id);
            //var model = await dc.ModelUps.FindAsync(100);

            if (model != null)
            {
                dc.ModelUps.Remove(model);

                await dc.SaveChangesAsync();
            }

            return RedirectToPage();
        }
    }
}
