using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExcitelProject.Models;
using ExcitelProject.Data.EFCore;

namespace ExcitelProject.Controllers
{
    public class SubareasController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SubareasController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Subareas
        public async Task<IActionResult> Index()
        {
              return _context.Subareas != null ? 
                          View(await _context.Subareas.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Subareas'  is null.");
        }

        // GET: Subareas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Subareas == null)
            {
                return NotFound();
            }

            var subarea = await _context.Subareas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (subarea == null)
            {
                return NotFound();
            }

            return View(subarea);
        }

        private bool SubareaExists(int id)
        {
          return (_context.Subareas?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
