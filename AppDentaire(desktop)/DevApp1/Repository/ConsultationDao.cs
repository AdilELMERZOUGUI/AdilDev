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
     class ConsultationDao 
    {
        private Dao<consultation> data = new Dao<consultation>();

        private mainEntities Db = new mainEntities();

        public DbSet<consultation> consultations = Program.dbContext.Set<consultation>();

        public void Add(consultation consultation)
        {
            data.Add(consultation);

            
          
        }

        public void Delete(int id_consultation)
        {
            data.Delete(id_consultation);
            
        }

        public void Update(consultation consultation)
        {
            data.Update(consultation);
        }

        public consultation Find(int id_consultation)
        {
            return data.Find(id_consultation);
        }

        public List<consultation> Get()
        {

            return data.Get();
        }
    }
}
