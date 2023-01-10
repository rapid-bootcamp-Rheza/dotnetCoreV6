using dotnet_ef_core_6.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_ef_core_6.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            IEnumerable<CategoryEntity> categories = _context.CategoryEntities.ToList();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Details(int? id)
        {
            CategoryEntity category = _context.CategoryEntities.Find(id);
            return View(category);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Save([Bind("CategoryCode, CategoryName, Description")] CategoryEntity request)
        {
            // add ke entity
            _context.CategoryEntities.Add(request);

            // commit ke data base
            _context.SaveChanges();

            return Redirect("GetAll");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            var entity = _context.CategoryEntities.Find(id);
            return View(entity);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            var entity = _context.CategoryEntities.Find(id);
            if (entity == null)
            {
                return Redirect("/Category/Delete");
            }
            //remove from entity
            _context.CategoryEntities.Remove(entity);
            //commit database
            _context.SaveChanges();
            return Redirect("/Category/Delete");
        }

        [HttpPost]
        public IActionResult Update([Bind("Id, CategoryCode, CategoryName, Description")] CategoryEntity request)
        {
            //update entity
            _context.CategoryEntities.Update(request);
            //commit to database
            _context.SaveChanges();
            return Redirect("GetAll");
        }
    }
}
