using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Caloric.Contexto;
using Caloric.Models;

namespace Caloric.Controllers
{
    public class NutrientesController : Controller
    {
        private readonly CaloricContexto _context;

        public NutrientesController(CaloricContexto context)
        {
            _context = context;
        }

        // GET: Nutrientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Nutrientes.ToListAsync());
        }

        // GET: Nutrientes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nutrientes = await _context.Nutrientes
                .FirstOrDefaultAsync(m => m.NutrientesId == id);
            if (nutrientes == null)
            {
                return NotFound();
            }

            return View(nutrientes);
        }

        // GET: Nutrientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Nutrientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("NutrientesId,Carboidratos,Proteinas,Gorduras,Sodio,Acucar")] Nutrientes nutrientes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(nutrientes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(nutrientes);
        }

        // GET: Nutrientes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nutrientes = await _context.Nutrientes.FindAsync(id);
            if (nutrientes == null)
            {
                return NotFound();
            }
            return View(nutrientes);
        }

        // POST: Nutrientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("NutrientesId,Carboidratos,Proteinas,Gorduras,Sodio,Acucar")] Nutrientes nutrientes)
        {
            if (id != nutrientes.NutrientesId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(nutrientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NutrientesExists(nutrientes.NutrientesId))
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
            return View(nutrientes);
        }

        // GET: Nutrientes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var nutrientes = await _context.Nutrientes
                .FirstOrDefaultAsync(m => m.NutrientesId == id);
            if (nutrientes == null)
            {
                return NotFound();
            }

            return View(nutrientes);
        }

        // POST: Nutrientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var nutrientes = await _context.Nutrientes.FindAsync(id);
            _context.Nutrientes.Remove(nutrientes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NutrientesExists(int id)
        {
            return _context.Nutrientes.Any(e => e.NutrientesId == id);
        }
    }
}
