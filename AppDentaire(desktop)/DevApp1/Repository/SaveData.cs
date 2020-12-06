using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Xml.Linq;
using DevApp1.Models;
using DevApp1.Properties;
using Newtonsoft.Json;

namespace DevApp1.Repository
{
    class SaveData
    {
        
        PatientDao patientDao = new PatientDao();
        RdvDao rdvDao = new RdvDao();
        ConsultationDao consultationDao = new ConsultationDao();
        UserDao userDao = new UserDao();
        ActeDao acteDao = new ActeDao();
        PayementDao payementDao = new PayementDao();

        public void ExportData(string directory)
        {

            string Dbfile = Settings.Default.PathSource;
            directory += "db_dent.db";
           
            File.Copy(Dbfile, directory,true);
        }

        public void ImportData(string path)
        {
            string Dbfile = Settings.Default.PathSource;
            
            Settings.Default.PathSource = path;
            Settings.Default.Save();
            Program.ConnectionAdapter();

            File.Copy(path, Dbfile,true);
 
        }


        public void SaveTojson(string path, IEnumerable list)
        {
            JsonSerializerSettings jsSettings = new JsonSerializerSettings();
            jsSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;


            using (StreamWriter file = new StreamWriter(path, true))
            {
                file.WriteLine(JsonConvert.SerializeObject(list, jsSettings));
            }
        }

        public void ExportToJson(string directory)
        {
            
            string path = directory + "\\Json";
            if (!Directory.Exists(path))
            {
                var di = Directory.CreateDirectory(path);
            }

            SaveTojson(path + "\\Patients.json", patientDao.Get());
            SaveTojson(path + "\\Rendez-vous.json",rdvDao.Get());
            SaveTojson(path + "\\Payements.json",payementDao.Get());
            SaveTojson(path + "\\Consultations.json",consultationDao.Get());
            SaveTojson(path + "\\Actes.json",acteDao.Get());
            SaveTojson(path + "\\Utilisateurs.json",userDao.Get());

            
        }

        

      
    }
}
