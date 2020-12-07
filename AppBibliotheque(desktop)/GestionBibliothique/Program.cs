using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GestionBibliothique
{
    static class Program
    {
      public static string photo ;
      public static string nomAdmin;
      public static string strcn = ConfigurationManager.ConnectionStrings["DB_bib"].ConnectionString;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           get();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormLogin());
           
        }
       public static void get()
        {
            using (SqlConnection cn = new SqlConnection(strcn))
            {
                SqlCommand cmd = new SqlCommand("Select * from utilisateur where id=1", cn);
                cn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                nomAdmin = dt.Rows[0][1].ToString() + " " + dt.Rows[0][2].ToString();
                
                 photo  = dt.Rows[0][5].ToString();
             
                
            }
        }
    }
}
