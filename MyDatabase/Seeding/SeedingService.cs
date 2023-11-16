using Entities;
using Entities.SchoolLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase.Seeding
{
    public class SeedingService
    {
        ApplicationDbContext db;

        public SeedingService(ApplicationDbContext context)
        {
            db = context;
        }

        public void SeedBooks()
        {
            Book b1 = new Book() { Title = "Harry Potter", NumberOfPages = 187};
            Book b2 = new Book() { Title = "Criminal", NumberOfPages = 237};
            Book b3 = new Book() { Title = "Loving sun", NumberOfPages = 123};
            Book b4 = new Book() { Title = "Sunflower", NumberOfPages = 380};
            Book b5 = new Book() { Title = "Cards", NumberOfPages = 282};
            Book b6 = new Book() { Title = "Rodeo", NumberOfPages = 132};

            Member m1 = new Member() { Name = "Mixalis Palierakis", Age = 33 };
            Member m2 = new Member() { Name = "Nikolas Souflis", Age = 43 };
            Member m3 = new Member() { Name = "Vaggelis Aromas", Age = 22 };
            Member m4 = new Member() { Name = "Dimitra Kara", Age = 21 };
            Member m5 = new Member() { Name = "Maria Papa", Age = 18 };
            Member m6 = new Member() { Name = "Iason Lekas", Age = 55 };

            m1.Books.Add(b1);
            b1.Member = m1;

            m2.Books.Add(b2);
            b2.Member = m2;

            m3.Books.Add(b3);
            b3.Member = m3;

            m4.Books.Add(b4);
            b4.Member = m4;

            m5.Books.Add(b5);
            b5.Member = m5;

            m6.Books.Add(b6);
            b6.Member = m6;


            db.Books.Add(b1);
            db.Books.Add(b2);
            db.Books.Add(b3);
            db.Books.Add(b4);
            db.Books.Add(b5);
            db.Books.Add(b6);

            db.Members.Add(m1);
            db.Members.Add(m2);
            db.Members.Add(m3);
            db.Members.Add(m4);
            db.Members.Add(m5);
            db.Members.Add(m6);

            db.SaveChanges();



        }
    }
}
