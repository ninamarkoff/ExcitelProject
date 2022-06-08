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
    [Route("[controller]")]
    [ApiController]
    public class LeadsController : BaseController<Lead, EFCoreLeadRepository>
    {
        //private readonly ApplicationDbContext _context;

        public LeadsController(EFCoreLeadRepository repository) : base(repository)
        {            
        }

        //// GET: Leads
        //public async Task<IActionResult> Index()
        //{
        //    return _context.Leads != null ?
        //                View(await _context.Leads
        //                .Include(l => l.Subarea)
        //                .ToListAsync()) :
        //                Problem("Entity set 'ApplicationDbContext.Leads'  is null.");
        //}

        //// GET: Leads/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null || _context.Leads == null)
        //    {
        //        return NotFound();
        //    }

        //    var lead = await _context.Leads
        //        .Include(l => l.Subarea)
        //        .FirstOrDefaultAsync(m => m.Id == id);

        //    if (lead == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(lead);
        //}

        //// GET: Leads/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Leads/Create
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Id,SubareaId,Name,Address,MobileNumber,Email")] Lead lead)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(lead);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(lead);
        //}

        //// GET: Leads/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null || _context.Leads == null)
        //    {
        //        return NotFound();
        //    }

        //    var lead = await _context.Leads
        //        .Include(l => l.Subarea)
        //        .FirstOrDefaultAsync(l => l.Id == id);

        //    var subareas = await _context.Subareas.ToListAsync();
        //    var subareasView = new List<SelectListItem>();

        //    foreach (var subarea in subareas)
        //    {
        //        subareasView.Add(new SelectListItem
        //        {
        //            Text = subarea.Name,
        //            Value = subarea.Id.ToString(),
        //        });
        //    }

        //    ViewBag.Subareas = subareasView;


        //    if (lead == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(lead);
        //}

        //// POST: Leads/Edit/5
        //// To protect from overposting attacks, enable the specific properties you want to bind to.
        //// For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Id,SubareaId,Name,Address,MobileNumber,Email")] Lead lead)
        //{
        //    if (id != lead.Id)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            bool hasChanges = _context.ChangeTracker.HasChanges();
        //            int updates = _context.SaveChanges();
        //            _context.Update(lead);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!LeadExists(lead.Id))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(lead);
        //}

        //private bool LeadExists(int id)
        //{
        //    return (_context.Leads?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
