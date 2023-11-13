using Entities;
using MyDatabase;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PersistanceGeneric.Repositories
{
    public class BookRepository
    {
        protected readonly ApplicationDbContext Context;

        public BookRepository(ApplicationDbContext context)
        {
            Context = context;
        }

        public IEnumerable<Book> GetAll()
        {
            var books = Context.Books.Include(b => b.Member).ToList();
            return books;
        }

        public Book GetBookById(int id)
        {
            var book = Context.Books.Find(id);
            return book;
        }

        public void Edit(Book book)
        {
            var bk = Context.Books.Find(book.BookId);
            if(bk == null)
            {
                throw new ArgumentException("Book doesn't exist");
            }
            Context.Entry(book).State = EntityState.Modified;
            Context.SaveChanges();
        }


    }
}
