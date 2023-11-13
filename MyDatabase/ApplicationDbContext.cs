using Entities;
using Entities.IdentityUsers;
using Entities.SchoolLibrary;
using Microsoft.AspNet.Identity.EntityFramework;
using MyDatabase.Initializers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MyDatabase
{
    public class ApplicationDbContext: IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("Sindesmos",throwIfV1Schema: false)
        {
            Database.SetInitializer<ApplicationDbContext>(new MockUpDbInitializer());
            Database.Initialize(false);
        }
        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }


        public DbSet<Book> Books { get; set; }
        public DbSet<Member> Members { get; set; }
    }
}
