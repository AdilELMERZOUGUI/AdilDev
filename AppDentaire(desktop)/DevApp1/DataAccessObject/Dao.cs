using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;


namespace DevApp1.DataAccessObject
{
    class Dao<Table> where Table:class
    {
        public static DbContext dbContext = Program.dbContext;
        private readonly DbSet<Table> dbSet = dbContext.Set<Table>();
        
        public void Add(Table table)
        {
           
            dbSet.Add(table);
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
          
            dbSet.Remove(Find(id));
            dbContext.SaveChanges();
        }

        public void Update(Table table)
        {
            dbSet.AddOrUpdate(table);
            dbContext.SaveChanges();
        }

        public Table Find(int id)
        {
            return  dbSet.Find(id);
        }

        public List<Table> Get()
        {

            return dbSet.ToList();
        }

       

    }
}
