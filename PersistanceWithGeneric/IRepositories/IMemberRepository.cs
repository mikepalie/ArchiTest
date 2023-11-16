﻿using Entities.SchoolLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistanceWithGeneric.IRepositories
{
    public interface IMemberRepository : IGenericRepository<Member>
    {
        IEnumerable<Member> GetMembersOrderBy();
    }
}
