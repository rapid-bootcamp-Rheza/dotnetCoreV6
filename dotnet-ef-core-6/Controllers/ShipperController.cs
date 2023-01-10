using dotnet_ef_core_6.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_ef_core_6.Controllers
{
    public class ShipperController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShipperController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<ShipperEntity> ship = _context.ShipperEntities.ToList();
            return View(ship);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            ShipperEntity ship = _context.ShipperEntities.Find(id);
            return View(ship);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save([Bind("NamaShipper, Product, Region, PriceShipper, Branch")] ShipperEntity request)
        {
            // add ke entity
            _context.ShipperEntities.Add(request);

            // commit ke data base
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.ShipperEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.ShipperEntities.Find(id);
            if (entity == null)
            {
                return Redirect("/Shipper/GetAll");
            }
            //remove
            _context.ShipperEntities.Remove(entity);
            //commit
            _context.SaveChanges();
            return Redirect("/Shipper/GetAll");
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, NamaShipper, Product, Region, PriceShipper, Branch")] ShipperEntity request)
        {
            //update
            _context.ShipperEntities.Update(request);
            //commit
            _context.SaveChanges();
            return Redirect("GetAll");
        }


    }
}
