using DataAccess.DataInterface;
using IGames.DataInterface;
using Microsoft.AspNetCore.Mvc;

namespace IGames.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _db;

        public ProductController(IProductRepository db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> objectCategories = _db.GetAll();
            return View(objectCategories);
        }
        //get
        public IActionResult Create()
        {
            return View();
        }
        //post
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product obj)
        {
            if (obj.Name == obj.Name.ToString())
            {
                ModelState.AddModelError("name", "The name cant be same as DisplayOrder number, please try again.");
            }
            if (ModelState.IsValid)
            {
                _db.Add(obj);
                _db.Save();
                return RedirectToAction("Index");
            }
            return View(obj);
        }

        public IActionResult edit(int? Id)
        {

            if (Id == null || Id == 0)
            {
                return NotFound();
            }
            var ID = _db.getFirstOrDefualt(u => u.ID == Id);
            if (ID == null)
            {
                return NotFound();
            }
            return View(ID);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult edit(Product obj)
        {
            if (obj.Name == obj.Name.ToString())
            {
                ModelState.AddModelError("name", "The name cant be same as DisplayOrder number, please try again.");
            }
            if (ModelState.IsValid)
            {
                _db.Update(obj);
                _db.Save();
                return RedirectToAction("Index");
            }

            return View(obj);
        }
        public IActionResult Delete(int? Id)
        {
            if (Id == 0 || Id == null)
                return NotFound();
            var _id = _db.getFirstOrDefualt(u => u.ID == Id);
            if (_id == null)
                return NotFound();
            return View(_id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(Product obj)
        {
            if (ModelState.IsValid)
            {
                _db.Remove(obj);
                _db.Save();
                return RedirectToAction("Index");
            }
            return View(obj);
        }
        public IActionResult ClearAll()
        {
            return View();
        }
        [HttpDelete]
        [ValidateAntiForgeryToken]
        public IActionResult ClearAll(Product obj)
        {
            return View();
        }
    }
}
