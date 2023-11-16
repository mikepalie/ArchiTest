using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Entities;
using MyDatabase;
using PersistanceWithGeneric.Repositories;

namespace ArchiTest.Controllers.ApiControllers
{
    public class BooksController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        private BookRepository BookService;
        public BooksController()
        {
             BookService = new BookRepository(db);
        }

        // GET: api/Books
        public IHttpActionResult GetBooks()
        {
            var books = BookService.GetBooksWithMember().
                Select(b => new { b.Title, b.NumberOfPages,b.Member.Name});


            return Json(books);
        }

        public IHttpActionResult GetBookById(int id)
        {
            var book = BookService.Get(id);
            return Json(book);
        }

        [HttpGet]
        [Route("api/books/orderby")]
        public IHttpActionResult GetBooksOrderBy()
        {
            var books = BookService.GetBooksOrderBy();
            return Json(books);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

       
    }
}