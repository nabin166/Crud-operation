using Microsoft.AspNetCore.Mvc;
using Crud_operation.Models;

namespace Crud_operation.Controllers
{
    public class CategoryController : Controller
    {
        private ConstructDbContext _context;

        public CategoryController(ConstructDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> categories = _context.Categories;
            return View(categories);
        }
        [HttpGet]
        public IActionResult Create()
        {  
            return View();
        }
        //For Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create( string names ,int displays )
        {
           
            Category catrgory = new Category();
            catrgory.Name = names;  
            catrgory.DisplayOrder= displays;
           
            _context.Add(catrgory);
            _context.SaveChanges();
            return RedirectToAction("Index");
           
        }

        //for Edit

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if(id==null || id == 0)
            {
                return NotFound();

            }
            var category = _context.Categories.Find(id);
            
            if(category == null)
            {
                return NotFound();
            }
            
            return View(category);
        }
        //For Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult  Edit(int? Id,string namess, int displayss)
        {
            Category catgory = new Category();   
           

         //   catgory.Name = namess;
           // catgory.DisplayOrder = displayss;

            _context.Update(catgory);
            _context.SaveChanges();
            return RedirectToAction("Index");
            

        }
        
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();

            }
          
            var category = _context.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }


            _context.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");


           
        }

       
      


    }
}
