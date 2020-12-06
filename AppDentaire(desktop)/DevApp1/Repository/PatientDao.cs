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
     class PatientDao 
    {
        private Dao<patient> data = new Dao<patient>();

        private mainEntities Db = new mainEntities();

        public DbSet<patient> patients = Program.dbContext.Set<patient>();

        public void Add(patient Patient)
        {
            data.Add(Patient);

            
          
        }

        public void Delete(int id_Patient)
        {
            data.Delete(id_Patient);
            
        }

        public void Update(patient Patient)
        {
            data.Update(Patient);
        }

        public patient Find(int id_Patient)
        {
            return data.Find(id_Patient);
        }

        public List<patient> Get()
        {

            return data.Get();
        }
    }
}
