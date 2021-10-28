using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebApplication1.Data;

namespace WebApplication1.Pages.Verificar
{
    public class CreateModel : PageModel
    {
        private readonly WebApplication1.Data.WebApplication1Context _context;

        public CreateModel(WebApplication1.Data.WebApplication1Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["ID"] = new SelectList(_context.Entradas, "ID", "ID");
        ViewData["ID"] = new SelectList(_context.Saidas, "ID", "ID");
            return Page();
        }

        [BindProperty]
        public Verificar Verificar { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Verificar.Add(Verificar);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
