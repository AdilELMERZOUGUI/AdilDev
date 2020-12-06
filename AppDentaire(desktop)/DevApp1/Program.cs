using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using System.Data.Entity;
using DevApp1.Models;
using DevApp1.Forms;
using System.Configuration;
using System.Reflection;
using DevApp1.Properties;

namespace DevApp1
{
    static class Program
    {

        public static DbContext dbContext = new mainEntities();
        private static int id_user;

        public static int ID_user { get => id_user; set => id_user = value; }

        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ConnectionAdapter();
            Application.Run(new Login());
            //Application.Run(new Home());
        }

        public static void ConnectionAdapter()
        {
            var settings = ConfigurationManager.ConnectionStrings["mainEntities"];


            var fi = typeof(ConfigurationElement).GetField("_bReadOnly", BindingFlags.Instance | BindingFlags.NonPublic);

            fi.SetValue(settings, false);

            string con = string.Format("metadata =res://*/Models.DentModel.csdl|res://*/Models.DentModel.ssdl|res://*/Models.DentModel.msl;provider=Devart.Data.SQLite;provider connection string=\"Data Source = {0}\"",Settings.Default.PathSource);


            settings.ConnectionString = con;
            

        }
    }
}