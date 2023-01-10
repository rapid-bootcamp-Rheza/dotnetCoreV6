using dotnet_ef_core_6.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_ef_core_6.Controllers
{
    public class KosController : Controller
    {
        private readonly ApplicationDbContext _context;

        public KosController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<KosEntity> kos = _context.KosEntities.ToList();
            return View(kos);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            KosEntity kos = _context.KosEntities.Find(id);
            return View(kos);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("NamaPenyewa, Gender, Status, Sewa, JenisKos, LamaSewa")] KosEntity request)
        {
            // add ke entity
            _context.KosEntities.Add(request);

            // commit ke data base
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.KosEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.KosEntities.Find(id);
            if (entity == null)
            {
                return Redirect("/Kos/GetAll");
            }
            //remove
            _context.KosEntities.Remove(entity);
            //commit
            _context.SaveChanges();
            return Redirect("/Kos/GetAll");
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, NamaPenyewa, Gender, Status, Sewa, JenisKos, LamaSewa")] KosEntity request)
        {
            //update
            _context.KosEntities.Update(request);
            //commit
            _context.SaveChanges();
            return Redirect("GetAll");
        }


    }
}
