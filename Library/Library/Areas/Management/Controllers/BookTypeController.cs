using Library.Context;
using Library.Models;
using Library.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Areas.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class BookTypeController : Controller
    {
        IBookTypeRepository _repoBooktype;
        public BookTypeController(IBookTypeRepository repoBookType)
        {
            _repoBooktype = repoBookType;
        }
        public IActionResult BookTypeList()
        {
            List<Tbl_BookType> bookTypes = _repoBooktype.GetAll();
            return View(bookTypes);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tbl_BookType bookType)
        {
            if (!ModelState.IsValid)
            {
                return View(bookType);
            }
            _repoBooktype.Add(bookType);
            return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });
        }
        public IActionResult Edit(int id)
        {
            Tbl_BookType bookType = _repoBooktype.GetById(id);
            return View(bookType);
        }

        [HttpPost]
        public IActionResult Edit(Tbl_BookType bookType)
        {
            _repoBooktype.Update(bookType);
            return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });
        }
        public IActionResult HardDelete(int id)
        {
            _repoBooktype.SpecialDelete(id);
            return RedirectToAction("BookTypeList", "BookType", new { area = "Management" });
        }
    }
}
