using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Diplom.Entities;
using Diplom.Repository;
using Diplom.Repository.IRepository;

namespace Diplom.Controllers
{
    [Route("[controller]")]

    public class FormsController : Controller
    {
        private readonly ParkSharingDBContext _context;
        private readonly IFormRepository _repository;


        public FormsController(ParkSharingDBContext context, IFormRepository repository)
        {
            _repository = repository;
            _context = context;
        }

        [HttpGet]
        // GET: Forms
        public async Task<IActionResult> Index()
        {
            return _context.Forms != null ?
                        View(_repository.GetAll()) :
                        Problem("Entity set 'ParkSharingDBContext.Forms'  is null.");
        }
        [HttpGet("{id}")]
        // GET: Forms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Forms == null)
            {
                return NotFound();
            }

            var form = await _context.Forms
                .FirstOrDefaultAsync(m => m.Id == id);
            if (form == null)
            {
                return NotFound();
            }

            return View(form);
        }

        [HttpPost]
        // GET: Forms/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Forms/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,UserId,CreatedAt")] Form form)
        {
            if (ModelState.IsValid)
            {
                _context.Add(form);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(form);
        }

        private bool FormExists(int id)
        {
            return (_context.Forms?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
