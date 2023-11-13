using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.SchoolLibrary
{
    public class Member
    {
        public Member()
        {
            Books = new HashSet<Book>();
        }

        public int MemberId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
