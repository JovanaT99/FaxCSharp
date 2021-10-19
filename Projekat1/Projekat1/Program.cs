using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekat1
{
    static class Program
    {

        static FormProdaja formProdaja;
        static FormAdmin formAdmin;
        static FormStart formStart;


        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            /*try
            {
                using (var db = new BazaContext())
                {
                    db.Kategorije.RemoveRange(db.Kategorije);
                    db.Artikli.RemoveRange(db.Artikli);
                    db.SaveChanges();
                }
            } catch(Exception e)
            {
                
            }*/

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            formStart = new FormStart();

            Application.Run(formStart);
        }

        public static void otvoriAdmin()
        {
            formAdmin = new FormAdmin();
            formAdmin.Show();
            formStart.Hide();
        }

        public static void otvoriProdaju()
        {
            formProdaja = new FormProdaja();
            formProdaja.Show();
            formStart.Hide();
        }

    }
}
