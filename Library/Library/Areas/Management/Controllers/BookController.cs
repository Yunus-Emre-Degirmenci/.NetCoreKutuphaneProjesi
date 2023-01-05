using Library.Context;
using Library.Dto;
using Library.Models;
using Library.RepositoryPattern.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Library.Areas.Controllers
{
    [Area("Management")]
    [Authorize(Policy ="AdminPolicy")]
    public class BookController : Controller
    {
        MyDbContext _context;
        IBookRepository _repoBook;
        IAuthorRepository _repoAuthor;
        IBookTypeRepository _repoBookType;
        public BookController(MyDbContext context, IBookRepository repoBook, IAuthorRepository repoAuthor, IBookTypeRepository repoBookType)
        {
            _context = context;
            _repoBook = repoBook;
            _repoAuthor = repoAuthor;
            _repoBookType = repoBookType;
        }
        public IActionResult BookList()
        {
            List<Tbl_Book> books = _repoBook.GetBooks();
            return View(books);
        }
        public IActionResult Create()
        {
            List<AuthorDto> authors = _repoAuthor.SelectAuthorDto();

            List<BookTypeDto> bookTypes = _repoBookType.SelectBookTypeDto();

            return View((new Tbl_Book(), authors, bookTypes));
        }
        [HttpPost]
        public IActionResult Create([Bind(Prefix = "Item1")] Tbl_Book book)
        {
            if(!ModelState.IsValid)
            {
                List<AuthorDto> authors = _repoAuthor.SelectAuthorDto();

                List<BookTypeDto> bookTypes = _repoBookType.SelectBookTypeDto();

                return View((book, authors, bookTypes));
            }
            _repoBook.Add(book);
            return RedirectToAction("BookList", "Book", new { area = "Management" });
        }

        public IActionResult Edit(int id)
        {
            Tbl_Book book = _context.Tbl_Books.Find(id);

            List<AuthorDto> authors = _repoAuthor.SelectAuthorDto();

            List<BookTypeDto> bookTypes = _repoBookType.SelectBookTypeDto();

            return View((book, authors, bookTypes));
        }
        [HttpPost]
        public IActionResult Edit([Bind(Prefix = "Item1")] Tbl_Book book)
        {
            _repoBook.Update(book);
            return RedirectToAction("BookList", "Book", new { area = "Management" });
        }
        public IActionResult Delete(int id)
        {
            _repoBook.Delete(id);
            return RedirectToAction("BookList", "Book", new { area = "Management" });
        }
    }
}
