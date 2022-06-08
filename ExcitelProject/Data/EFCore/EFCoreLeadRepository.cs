using ExcitelProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ExcitelProject.Data.EFCore
{
    public class EFCoreLeadRepository : EfCoreRepository<Lead, ApplicationDbContext>
    {
        private readonly ApplicationDbContext _context;

        public EFCoreLeadRepository(ApplicationDbContext context) : base(context)
        {
            this._context = context;
        }

        public override async Task<List<Lead>> Index()
        {
            return await _context.Leads
                        .Include(l => l.Subarea)
                        .ToListAsync();
        }
        public override async Task<Lead> Details(int id)
        {
            return await _context.Leads
                .Include(l => l.Subarea)
                .FirstOrDefaultAsync(m => m.Id == id);
        }
    }
}
