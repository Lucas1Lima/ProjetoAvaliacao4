using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Pages.Saida;

namespace WebApplication1.Pages.Controllers
{
    public class SaidasController : Controller
    {
        private readonly WebApplication1Context _context;

        public SaidasController(WebApplication1Context context)
        {
            _context = context;
        }

        // GET: Saidas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Saidas.ToListAsync());
        }

        // GET: Saidas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saidas = await _context.Saidas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (saidas == null)
            {
                return NotFound();
            }

            return View(saidas);
        }

        // GET: Saidas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Saidas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ValorSaida,NomeSaida,HoraSaida")] Saidas saidas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(saidas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(saidas);
        }

        // GET: Saidas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saidas = await _context.Saidas.FindAsync(id);
            if (saidas == null)
            {
                return NotFound();
            }
            return View(saidas);
        }

        // POST: Saidas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ValorSaida,NomeSaida,HoraSaida")] Saidas saidas)
        {
            if (id != saidas.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saidas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SaidasExists(saidas.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(saidas);
        }

        // GET: Saidas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saidas = await _context.Saidas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (saidas == null)
            {
                return NotFound();
            }

            return View(saidas);
        }

        // POST: Saidas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var saidas = await _context.Saidas.FindAsync(id);
            _context.Saidas.Remove(saidas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SaidasExists(int id)
        {
            return _context.Saidas.Any(e => e.ID == id);
        }
    }
}
