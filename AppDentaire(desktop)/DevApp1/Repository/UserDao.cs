using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevApp1.DataAccessObject;
using DevApp1.Models;

namespace DevApp1.Repository
{
     class UserDao
    {
        private Dao<utilisteur> data = new Dao<utilisteur>();

        private mainEntities Db = new mainEntities();

        public DbSet<utilisteur> utilisteurs = Program.dbContext.Set<utilisteur>();

        public void Add(utilisteur utilisteur)
        {
            data.Add(utilisteur);

            
          
        }

        public void Delete(int id_utilisteur)
        {
            data.Delete(id_utilisteur);
            
        }

        public void Update(utilisteur utilisteur)
        {
            data.Update(utilisteur);
        }

        public utilisteur Find(int id_utilisteur)
        {
            return data.Find(id_utilisteur);
        }

        public List<utilisteur> Get()
        {

            return data.Get();
        }
    }
}
