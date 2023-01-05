using Library.Models;
using Library.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Areas.Management.Controllers
{
    [Area("Management")]
    [Authorize(Policy = "AdminPolicy")]
    public class AuthorController : Controller
    {
        IAuthorRepository _repoAuthor;
        public AuthorController(IAuthorRepository repoAuthor)
        {
            _repoAuthor = repoAuthor;
        }

        public IActionResult AuthorList()
        {
            List<Tbl_Author> authors = _repoAuthor.GetActives();
            return View(authors);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Tbl_Author author)
        {
            if (!ModelState.IsValid)
            {
                return View(author);
            }
            _repoAuthor.Add(author);
            return RedirectToAction("AuthorList", "Author", new { area = "Management" });
        }

        public IActionResult Edit(int id)
        {
            Tbl_Author author = _repoAuthor.GetById(id);
            return View(author);
        }
        [HttpPost]
        public IActionResult Edit(Tbl_Author author)
        {
            _repoAuthor.Update(author);
            return RedirectToAction("AuthorList", "Author", new { area = "Management" });
        }

        public IActionResult Delete(int id)
        {
            _repoAuthor.Delete(id);
            return RedirectToAction("AuthorList", "Author", new { area = "Management" });
        }
    }
}
