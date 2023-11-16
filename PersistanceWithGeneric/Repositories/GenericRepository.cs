using MyDatabase;
using PersistanceWithGeneric.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistanceWithGeneric.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext db;
        private DbSet<T> table = null;
        public GenericRepository(ApplicationDbContext context)
        {
            db = context;
            table = db.Set<T>();
        }

        public void Add(T enitity)
        {
            table.Add(enitity);
            db.SaveChanges();
        }

        public T Get(int id)
        {
            var Entity = table.Find(id);
            return Entity;
        }

        public IEnumerable<T> GetAll()
        {
            var Entities = table.ToList();
            return Entities;
        }

        public void Remove(int id)
        {
            var Entity = table.Find(id);
            if(Entity == null)
            {
                throw new Exception("Doesn't exist");
            }
            table.Remove(Entity);
            db.SaveChanges();
        }
    }
}
