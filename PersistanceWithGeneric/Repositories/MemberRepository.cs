using Entities.SchoolLibrary;
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
    public class MemberRepository:GenericRepository<Member>, IMemberRepository
    {
        public MemberRepository(ApplicationDbContext context): base(context)
        {

        }
        public IEnumerable<Member> GetMembersWithBooks()
        {
            // Explicitly include the related Books
            var members = db.Members.Include(m => m.Books).ToList();
            return members;
        }
        public IEnumerable<Member> GetMembersOrderBy()
        {
            var Members = db.Members.OrderBy(m => m.Name);
            return Members;
        }
    }
}
