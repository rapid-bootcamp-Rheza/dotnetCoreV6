using dotnet_ef_core_6.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_ef_core_6.Controllers
{
    public class RentalController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RentalController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<RentalEntity> rental = _context.RentalEntities.ToList();
            return View(rental);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            RentalEntity rental = _context.RentalEntities.Find(id);
            return View(rental);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("NamaPenyewa, Jenis, Merk, Sewa, HariSewa")] RentalEntity request)
        {
            // add ke entity
            _context.RentalEntities.Add(request);

            // commit ke data base
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.RentalEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.RentalEntities.Find(id);
            if (entity == null)
            {
                return Redirect("/Rental/GetAll");
            }
            //remove
            _context.RentalEntities.Remove(entity);
            //commit
            _context.SaveChanges();
            return Redirect("/Rental/GetAll");
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, NamaPenyewa, Jenis, Merk, Sewa, HariSewa")] RentalEntity request)
        {
            //update
            _context.RentalEntities.Update(request);
            //commit
            _context.SaveChanges();
            return Redirect("GetAll");
        }


    }
}
