using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevApp1.Repository
{
    class Statistique
    {
        PatientDao patientDao = new PatientDao();
        RdvDao rdvDao = new RdvDao();
        ConsultationDao consultationDao = new ConsultationDao();
        UserDao userDao = new UserDao();
        DateTime Date = DateTime.Now;
       
        public string GetNbAttends(string periode , DateTime Date)
        {
            int nbr =  rdvDao.rendez_vouss.ToList()
                        .Where(p => DateTime.Parse(p.date_rdv).Date == Date.Date && p.seance==periode && p.disponible == 1 && p.traiter==0 && p.terminer==0)
                        .Select(p => p.id_patient)
                        .ToList().Count;
            if (nbr >= 10)
                return nbr.ToString();
            else
                return "0" + nbr; 


        }
        
        public int GetNbPatient(int index)
        {
            int num = 0;

            switch (index)
            {
                case 0:
                    
                    num = rdvDao.rendez_vouss.ToList()
                        .Where(p => DateTime.Parse(p.date_rdv).Date == Date.Date)
                        .Select(p => p.id_patient)
                        .Distinct().ToList().Count;
                    

                    break;
                case 1:
                    Date = DateTime.Now.AddDays(-1);
                     num = rdvDao.rendez_vouss.ToList()
                        .Where(p => DateTime.Parse(p.date_rdv).Date == Date.Date)
                        .Select(p => p.id_patient)
                        .Distinct().ToList().Count;
                    break;
                case 2:
                    Date = DateTime.Now.AddDays(-7);
                    num = rdvDao.rendez_vouss.ToList()
                         .Where(p => DateTime.Parse(p.date_rdv) >= Date)
                         .Select(p => p.id_patient)
                         .Distinct()
                         .ToList()
                         .Count;
                    break;
                case 3:
                    Date = DateTime.Now.AddMonths(-1);
                    num = rdvDao.rendez_vouss.ToList()
                         .Where(p => DateTime.Parse(p.date_rdv) >= Date)
                         .Select(p => p.id_patient)
                         .Distinct()
                         .ToList()
                         .Count;
                    break;
                case 4:
                    num = rdvDao.rendez_vouss.ToList()
                         .Where(p => DateTime.Parse(p.date_rdv).Year == Date.Year)
                         .Select(p => p.id_patient)
                         .Distinct()
                         .ToList()
                         .Count;
                    break;
                case 5:
                    num = rdvDao.rendez_vouss.Select(p => p.id_patient).Distinct().ToList().Count;
                    break;
                default:
                    num = 0;
                    break;

            }

            return num;

        }

        public int GetNbVisite(int index)
        {
            int num = 0;

            switch (index)
            {
                case 0:
                    
                    num = rdvDao.rendez_vouss.ToList()
                         .Where(p => p.terminer == 1 && DateTime.Parse(p.date_rdv).Date == Date.Date)
                         .Select(p => p.id_patient)
                         .Distinct()
                         .ToList()
                         .Count;
                    break;
                case 1:
                    Date = DateTime.Now.AddDays(-1);
                    
                    num = rdvDao.rendez_vouss.ToList()
                         .Where(p => p.terminer == 1 && DateTime.Parse(p.date_rdv).Date == Date.Date)
                         .Select(p => p.id_patient)
                         .Distinct()
                         .ToList()
                         .Count;
                    break;
                case 2:
                    Date = DateTime.Now.AddDays(-7);
                    num = rdvDao.rendez_vouss.ToList()
                         .Where(p => p.terminer == 1 && DateTime.Parse(p.date_rdv) >= Date)
                         .Select(p => p.id_patient)
                         .Distinct()
                         .ToList()
                         .Count;
                    break;
                case 3:
                    Date = DateTime.Now.AddMonths(-1);
                    num = rdvDao.rendez_vouss.ToList()
                         .Where(p => p.terminer == 1 && DateTime.Parse(p.date_rdv) >= Date)
                         .Select(p => p.id_patient)
                         .Distinct()
                         .ToList()
                         .Count;
                    break;
                case 4:
                    num = rdvDao.rendez_vouss.ToList()
                         .Where(p => p.terminer == 1 && DateTime.Parse(p.date_rdv).Year == Date.Year)
                         .Select(p => p.id_patient)
                         .Distinct()
                         .ToList()
                         .Count;
                    break;
                case 5:
                    num = rdvDao.rendez_vouss
                        .Where(r => r.terminer == 1)
                        .Select(p=> p.id_patient)
                        .Distinct().ToList().Count;
                    break;
                default:
                    num = 0;
                    break;

            }

            return num;

        }

        public double GetNbRevenu(int index)
        {
            

            double num = 0;
            

            switch (index)
            {
                case 0:
                    
                    var res0 = consultationDao.consultations.ToList()
                        .Where(r => DateTime.Parse(r.rendez_vous.date_rdv).Date == Date.Date)
                        .GroupBy(x => x.rendez_vous.id_patient)
                        .Select(p => new { membername = p.Key, total = p.Sum(s => s.payement.avance) });
                    foreach (var item in res0)
                    {
                        num += item.total.Value;
                    }
                    break;
                case 1:
                    Date = DateTime.Now.AddDays(-1);
                    
                    var res1 = consultationDao.consultations.ToList()
                        .Where(r => DateTime.Parse(r.rendez_vous.date_rdv).Date == Date.Date)
                        .GroupBy(x => x.rendez_vous.id_patient)
                        .Select(p => new { membername = p.Key, total = p.Sum(s => s.payement.avance) });
                    foreach (var item in res1)
                    {
                        num += item.total.Value;
                    }
                    break;
                case 2:
                    Date = DateTime.Now.AddDays(-7);
                    var res2 = consultationDao.consultations.ToList()
                        .Where(r => DateTime.Parse(r.rendez_vous.date_rdv) >= Date)
                        .GroupBy(x => x.rendez_vous.id_patient)
                        .Select(p => new { membername = p.Key, total = p.Sum(s => s.payement.avance) });
                    foreach (var item in res2)
                    {
                        num += item.total.Value;
                    }
                    break;
                case 3:
                    Date = DateTime.Now.AddMonths(-1);
                    var res3 = consultationDao.consultations
                        .ToList()
                        .Where(r => DateTime.Parse(r.rendez_vous.date_rdv) >= Date)
                        .GroupBy(x => x.rendez_vous.id_patient)
                        .Select(p => new { membername = p.Key, total = p.Sum(s => s.payement.avance) });
                    foreach (var item in res3)
                    {
                        num += item.total.Value;
                    }
                    break;
                case 4:
                    var res4 = consultationDao.consultations
                        .ToList()
                        .Where(r => DateTime.Parse(r.rendez_vous.date_rdv).Year == Date.Year)
                        .GroupBy(x => x.rendez_vous.id_patient)
                        .Select(p => new { membername = p.Key, total = p.Sum(s => s.payement.avance) });
                    foreach (var item in res4)
                    {
                        num += item.total.Value;
                    }
                    break;
                case 5:
                    var res5 = consultationDao.consultations
                        .GroupBy(x => x.rendez_vous.id_patient)
                        .Select(p => new { membername = p.Key, total = p.Sum(s => s.payement.avance) });
                    foreach (var item in res5)
                    {
                        num += item.total.Value;
                    }
                    break;
                default:
                    num = 0;
                    break;

            }

            return num;

        }

        public double GetNbDette(int index)
        {
           

            double num = 0;


            switch (index)
            {
                case 0:
                    
                    var res0 = consultationDao.consultations.ToList()
                        .Where(r => DateTime.Parse(r.rendez_vous.date_rdv).Date == Date.Date)
                        .GroupBy(x => x.rendez_vous.id_patient)
                        .Select(p => new { membername = p.Key, total = p.Sum(s => s.payement.montant - s.payement.avance) });
                    foreach (var item in res0)
                    {
                        num += item.total.Value;
                    }
                    break;
                case 1:
                    Date = DateTime.Now.AddDays(-1);
                    
                    var res1 = consultationDao.consultations.ToList()
                        .Where(r => DateTime.Parse(r.rendez_vous.date_rdv).Date == Date.Date)
                        .GroupBy(x => x.rendez_vous.id_patient)
                        .Select(p => new { membername = p.Key, total = p.Sum(s => s.payement.montant - s.payement.avance) });
                    foreach (var item in res1)
                    {
                        num += item.total.Value;
                    }
                    break;
                case 2:
                    Date = DateTime.Now.AddDays(-7);
                    var res2 = consultationDao.consultations.ToList()
                        .Where(r => DateTime.Parse(r.rendez_vous.date_rdv) >= Date)
                        .GroupBy(x => x.rendez_vous.id_patient)
                        .Select(p => new { membername = p.Key, total = p.Sum(s => s.payement.montant - s.payement.avance) });
                    foreach (var item in res2)
                    {
                        num += item.total.Value;
                    }
                    break;
                case 3:
                    Date = DateTime.Now.AddMonths(-1);
                    var res3 = consultationDao.consultations
                        .ToList()
                        .Where(r => DateTime.Parse(r.rendez_vous.date_rdv) >= Date)
                        .GroupBy(x => x.rendez_vous.id_patient)
                        .Select(p => new { membername = p.Key, total = p.Sum(s => s.payement.montant - s.payement.avance) });
                    foreach (var item in res3)
                    {
                        num += item.total.Value;
                    }
                    break;
                case 4:
                    var res4 = consultationDao.consultations
                        .ToList()
                        .Where(r => DateTime.Parse(r.rendez_vous.date_rdv).Year == Date.Year)
                        .GroupBy(x => x.rendez_vous.id_patient)
                        .Select(p => new { membername = p.Key, total = p.Sum(s => s.payement.montant - s.payement.avance) });
                    foreach (var item in res4)
                    {
                        num += item.total.Value;
                    }
                    break;
                case 5:
                    var res5 = consultationDao.consultations
                        .GroupBy(x => x.rendez_vous.id_patient)
                        .Select(p => new { membername = p.Key, total = p.Sum(s => s.payement.montant - s.payement.avance) });
                    foreach (var item in res5)
                    {
                        num += item.total.Value;
                    }
                    break;
                default:
                    num = 0;
                    break;

            }

            return num;

        }
    }
}
