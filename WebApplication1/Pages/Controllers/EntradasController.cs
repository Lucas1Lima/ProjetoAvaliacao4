using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Pages.Entrada;

namespace WebApplication1.Pages.Controllers
{
    public class EntradasController : Controller
    {
        private readonly WebApplication1Context _context;

        public EntradasController(WebApplication1Context context)
        {
            _context = context;
        }

        // GET: Entradas
        public async Task<IActionResult> Index()
        {
            return View(await _context.Entradas.ToListAsync());
        }

        // GET: Entradas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entradas = await _context.Entradas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (entradas == null)
            {
                return NotFound();
            }

            return View(entradas);
        }

        // GET: Entradas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Entradas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ValorEntrada,NomeEntrada,HoraEntrada")] Entradas entradas)
        {
            if (ModelState.IsValid)
            {
                _context.Add(entradas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(entradas);
        }

        // GET: Entradas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entradas = await _context.Entradas.FindAsync(id);
            if (entradas == null)
            {
                return NotFound();
            }
            return View(entradas);
        }

        // POST: Entradas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ValorEntrada,NomeEntrada,HoraEntrada")] Entradas entradas)
        {
            if (id != entradas.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(entradas);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EntradasExists(entradas.ID))
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
            return View(entradas);
        }

        // GET: Entradas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var entradas = await _context.Entradas
                .FirstOrDefaultAsync(m => m.ID == id);
            if (entradas == null)
            {
                return NotFound();
            }

            return View(entradas);
        }

        // POST: Entradas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var entradas = await _context.Entradas.FindAsync(id);
            _context.Entradas.Remove(entradas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EntradasExists(int id)
        {
            return _context.Entradas.Any(e => e.ID == id);
        }
    }
}
