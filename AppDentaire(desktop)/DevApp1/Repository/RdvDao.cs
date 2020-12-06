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
     class RdvDao 
    {
        private Dao<rendez_vous> data = new Dao<rendez_vous>();

        private mainEntities Db = new mainEntities();

        public DbSet<rendez_vous> rendez_vouss = Program.dbContext.Set<rendez_vous>();

        public void Add(rendez_vous rendez_vous)
        {
            data.Add(rendez_vous);

            
          
        }

        public void Delete(int id_rendez_vous)
        {
            data.Delete(id_rendez_vous);
            
        }

        public void Update(rendez_vous rendez_vous)
        {
            data.Update(rendez_vous);
        }

        public rendez_vous Find(int id_rendez_vous)
        {
            return data.Find(id_rendez_vous);
        }

        public List<rendez_vous> Get()
        {

            return data.Get();
        }
    }
}
