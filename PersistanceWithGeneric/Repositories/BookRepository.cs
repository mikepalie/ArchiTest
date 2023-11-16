using Entities;
using MyDatabase;
using PersistanceWithGeneric.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PersistanceWithGeneric.Repositories
{
    public class BookRepository : GenericRepository<Book>, IBookRepository
    {

        public BookRepository(ApplicationDbContext context) : base(context)
        {

        }

        public IEnumerable<Book> GetBooksWithMember()
        {
            var books = db.Books.Include(b=>b.Member).ToList();
            return books;
        } 

        public IEnumerable<Book> GetBooksOrderBy()
        {
            var Books = db.Books.OrderBy(b => b.Title).ToList();
            return Books;
        }
    }
}
