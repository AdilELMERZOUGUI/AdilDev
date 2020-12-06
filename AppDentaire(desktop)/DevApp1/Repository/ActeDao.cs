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
     class ActeDao
    {
        private Dao<acte> data = new Dao<acte>();

        private mainEntities Db = new mainEntities();

        public DbSet<acte> actes = Program.dbContext.Set<acte>();

        public void Add(acte acte)
        {
            data.Add(acte);

            
          
        }

        public void Delete(int id_acte)
        {
            data.Delete(id_acte);
            
        }

        public void Update(acte acte)
        {
            data.Update(acte);
        }

        public acte Find(int id_acte)
        {
            return data.Find(id_acte);
        }

        public List<acte> Get()
        {

            return data.Get();
        }
    }
}
