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
    public class AddPagesModelModel : PageModel
    {
        private readonly DataContext dc;

        [BindProperty]
        public string ModelUps { get; set; }

        public AddPagesModelModel(DataContext dc)
        {
            this.dc = dc;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            ModelUps ups = new ModelUps();
            ups.Model = ModelUps;

            // Добавим модель UPS в БД.
            this.dc.ModelUps.Add(ups);

            // Сохраним изменения.
            this.dc.SaveChanges();

            return RedirectToPage("../References");
           
        }
    }
}
