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
using Entities.SchoolLibrary;
using MyDatabase;
using PersistanceWithGeneric.Repositories;

namespace ArchiTest.Controllers.ApiControllers
{
    public class MembersController : ApiController
    {
        private ApplicationDbContext db;
        private MemberRepository MemberService;
        public MembersController()
        {
            db = new ApplicationDbContext();
            MemberService = new MemberRepository(db);
        }

        // GET: api/Members
        public IHttpActionResult GetMembers()
        {
            var members = MemberService.GetMembersWithBooks()
                .Select(m=> new 
                {
                    m.Name,
                    m.Age,
                    books = m.Books.Select(b=>b.Title)
                });
            return Json(members);
        }

        // GET: api/Members/5
        [ResponseType(typeof(Member))]
        public IHttpActionResult GetMember(int id)
        {
            var member = MemberService.Get(id);
            return Json(member);
        }

        [HttpGet]
        [Route("api/members/orderby")]
        public IHttpActionResult GetMembersOrderBy()
        {
            var members = MemberService.GetMembersOrderBy();
            return Json(members);
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