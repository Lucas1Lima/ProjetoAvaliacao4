using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Data;
using WebApplication1.Pages.Verificar;

namespace WebApplication1.Pages.Controllers
{
    public class VerificarsController : Controller
    {
        private readonly WebApplication1Context _context;

        public object ID { get; private set; }

        public VerificarsController(WebApplication1Context context)
        {
            _context = context;
        }

        // GET: Verificars
        public async Task<IActionResult> Index()
        {
            var webApplication1Context = _context.Verificar.Include(v => v.Entrada).Include(v => v.Saidas);
            return View(await webApplication1Context.ToListAsync());
        }

        // GET: Verificars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var verificar = await _context.Verificar
                .Include(v => v.Entrada)
                .Include(v => v.Saidas)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (verificar == null)
            {
                return NotFound();
            }

            return View(verificar);
        }

        // GET: Verificars/Create
        public IActionResult Create()
        {
            ViewData["ID"] = new SelectList(_context.Entradas, "ID", "ID");
            ViewData["ID"] = new SelectList(_context.Saidas, "ID", "ID");
            return View();
        }

        // POST: Verificars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ValorTotal,ValorEntrada,ValorSaida")] VerificarsController verificar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(verificar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ID"] = new SelectList(_context.Entradas, "ID", "ID", verificar.ID);
            ViewData["ID"] = new SelectList(_context.Saidas, "ID", "ID", verificar.ID);
            return View(verificar);
        }

        // GET: Verificars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var verificar = await _context.Verificar.FindAsync(id);
            if (verificar == null)
            {
                return NotFound();
            }
            ViewData["ID"] = new SelectList(_context.Entradas, "ID", "ID", verificar.ID);
            ViewData["ID"] = new SelectList(_context.Saidas, "ID", "ID", verificar.ID);
            return View(verificar);
        }

        // POST: Verificars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ValorTotal,ValorEntrada,ValorSaida")] VerificarsController verificar)
        {
            

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(verificar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VerificarExists(verificar.ID))
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
            ViewData["ID"] = new SelectList(_context.Entradas, "ID", "ID", verificar.ID);
            ViewData["ID"] = new SelectList(_context.Saidas, "ID", "ID", verificar.ID);
            return View(verificar);
        }

        private bool VerificarExists(object iD)
        {
            throw new NotImplementedException();
        }

        // GET: Verificars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var verificar = await _context.Verificar
                .Include(v => v.Entrada)
                .Include(v => v.Saidas)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (verificar == null)
            {
                return NotFound();
            }

            return View(verificar);
        }

        // POST: Verificars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var verificar = await _context.Verificar.FindAsync(id);
            _context.Verificar.Remove(verificar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VerificarExists(int id)
        {
            return _context.Verificar.Any(e => e.ID == id);
        }
    }
}
