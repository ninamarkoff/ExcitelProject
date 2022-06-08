using ExcitelProject.Data;
using Microsoft.AspNetCore.Mvc;

namespace ExcitelProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public abstract class BaseController<TEntity, TRepository> : Controller
       where TEntity : class, IEntity
       where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public BaseController(TRepository repository)
        {
            this.repository = repository;
        }


        // GET: [controller]
        [HttpGet]
        public virtual async Task<ActionResult<IEnumerable<TEntity>>> Index()
        {
            return View(await repository.Index());
        }

        // GET: [controller]/5
        [HttpGet("Details/{id}")]
        public virtual async Task<ActionResult<TEntity>> Details(int id)
        {
            var entity = await repository.Details(id);
            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }

        // GET: [controller]/5
        [HttpGet("Edit/{id}")]
        public virtual async Task<IActionResult> Edit(int id)
        {
            var entity = await repository.Details(id);
            if (entity == null)
            {
                return NotFound();
            }
            return View(entity);
        }

        // POST: [controller]/5
        [HttpPost("Edit/{id}")]
        [ValidateAntiForgeryToken]
        public virtual async Task<IActionResult> Edit(int id, [FromForm] TEntity entity)
        {
            if (id != entity.Id)
            {
                return BadRequest();
            }
            await repository.Edit(entity);
            return RedirectToAction(nameof(Index)); ;
        }

        // GET: [controller]
        [HttpGet("Create")]
        public virtual IActionResult Create()
        {
            return View();
        }

        // POST: [controller]
        [HttpPost("Create")]
        [ValidateAntiForgeryToken]
        public virtual async Task<ActionResult<TEntity>> Create([FromForm] TEntity entity)
        {
            await repository.Create(entity);
            return RedirectToAction(nameof(Index));
        }

    }
}
