using Entities.SchoolLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public int NumberOfPages { get; set; }

        public int? MemberId { get; set; }
        public Member Member  { get; set; }
    }
}
