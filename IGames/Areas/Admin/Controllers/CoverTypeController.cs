using DataAccess.DataInterface;
using IGames.Data;
using IGames.DataInterface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using RModel.Models;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace IGames.Areas.Admian.Controllers
{
    [Area("Admin")]
    public class CoverTypeController : Controller
    {
        private readonly ICoverTypeRepository _db;

        public CoverTypeController(ICoverTypeRepository db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<CoverType> objectCategories = _db.GetAll();
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
        public IActionResult Create(CoverType obj)
        {
            if (obj.Name == obj.Name)
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
            var ID = _db.getFirstOrDefualt(u => u.Id == Id);
            if (ID == null)
            {
                return NotFound();
            }
            return View(ID);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult edit(CoverType obj)
        {
            if (obj.Name == obj.Name)
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
            var _id = _db.getFirstOrDefualt(u => u.Id == Id);
            if (_id == null)
                return NotFound();
            return View(_id);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(CoverType obj)
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
        public IActionResult ClearAll(CoverType obj)
        {
            return View();
        }
    }
}
