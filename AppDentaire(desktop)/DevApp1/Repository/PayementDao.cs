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
     class PayementDao
    {
        private Dao<payement> data = new Dao<payement>();

        private mainEntities Db = new mainEntities();

        public DbSet<payement> payements = Program.dbContext.Set<payement>();

        public void Add(payement payement)
        {
            data.Add(payement);

            
          
        }

        public void Delete(int id_payement)
        {
            data.Delete(id_payement);
            
        }

        public void Update(payement payement)
        {
            data.Update(payement);
        }

        public payement Find(int id_payement)
        {
            return data.Find(id_payement);
        }

        public List<payement> Get()
        {

            return data.Get();
        }
    }
}
