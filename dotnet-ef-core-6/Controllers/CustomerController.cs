using dotnet_ef_core_6.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_ef_core_6.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<CustomerEntity> customer = _context.CustomerEntities.ToList();
            return View(customer);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            CustomerEntity customer = _context.CustomerEntities.Find(id);
            return View(customer);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save([Bind("CustomerName, Gender, Address, City, Province")] CustomerEntity request)
        {
            // add ke entity
            _context.CustomerEntities.Add(request);

            // commit ke data base
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.CustomerEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.CustomerEntities.Find(id);
            if (entity == null)
            {
                return Redirect("/Customer/GetAll");
            }
            //remove from entity
            _context.CustomerEntities.Remove(entity);
            //commit database
            _context.SaveChanges();
            return Redirect("/Customer/GetAll");
        }

        [HttpPost]
        public IActionResult Update([Bind("CustomerId, CustomerName, Gender, Address, City, Province")] CustomerEntity request)
        {
            //update entity
            _context.CustomerEntities.Update(request);
            //commit to database
            _context.SaveChanges();
            return Redirect("GetAll");
        }
    }
}
