using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Rendering;
using Microsoft.Data.Entity;
using IntSisAV2.Models;
using Microsoft.AspNet.Authorization;

namespace IntSisAV2.Controllers
{
    [Authorize]
    public class LojasController : Controller
    {
        private ApplicationDbContext _context;

        public LojasController(ApplicationDbContext context)
        {
            _context = context;    
        }

        // GET: Lojas
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Loja.ToListAsync());
        }

        // GET: Lojas/Details/5
        [AllowAnonymous]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Loja loja = await _context.Loja.SingleAsync(m => m.LojaID == id);
            if (loja == null)
            {
                return HttpNotFound();
            }

            return View(loja);
        }

        // GET: Lojas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lojas/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Loja loja)
        {
            if (ModelState.IsValid)
            {
                _context.Loja.Add(loja);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(loja);
        }

        // GET: Lojas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Loja loja = await _context.Loja.SingleAsync(m => m.LojaID == id);
            if (loja == null)
            {
                return HttpNotFound();
            }
            return View(loja);
        }

        // POST: Lojas/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Loja loja)
        {
            if (ModelState.IsValid)
            {
                _context.Update(loja);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(loja);
        }

        // GET: Lojas/Delete/5
        [ActionName("Delete")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }

            Loja loja = await _context.Loja.SingleAsync(m => m.LojaID == id);
            if (loja == null)
            {
                return HttpNotFound();
            }

            return View(loja);
        }

        // POST: Lojas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            Loja loja = await _context.Loja.SingleAsync(m => m.LojaID == id);
            _context.Loja.Remove(loja);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
