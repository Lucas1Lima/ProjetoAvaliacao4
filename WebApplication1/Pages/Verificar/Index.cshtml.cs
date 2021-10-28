using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;

namespace WebApplication1.Pages.Verificar
{
    public class IndexModel : PageModel
    {
        private readonly WebApplication1.Data.WebApplication1Context _context;

        public IndexModel(WebApplication1.Data.WebApplication1Context context)
        {
            _context = context;
        }

        public IList<Verificar> Verificar { get;set; }

        public async Task OnGetAsync()
        {
            Verificar = await _context.Verificar
                .Include(v => v.Entrada)
                .Include(v => v.Saidas).ToListAsync();
        }
    }
}
