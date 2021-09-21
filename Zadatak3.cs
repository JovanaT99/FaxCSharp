using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Zadata3
{
    interface IKontejner
    {

        double zapremina();
        double povrsina();
        string ToString();

    }

    public class Bure : IKontejner
    {
        double precnik;
        double visina;

        public double Precnik { get => precnik; set => precnik = value; }
        public double Visina { get => visina; set => visina = value; }


        public Bure(double precnik, double visina)
        {

            this.precnik = precnik;
            this.visina = visina;

        }

        public double povrsina()
        {
           double poluprecnik = precnik / 2;
            return 2 * poluprecnik * poluprecnik * Math.PI + 2 * poluprecnik * Math.PI * visina;


        }
       

        public double zapremina()
        {
            double poluprecnik = precnik / 2;
            return poluprecnik * poluprecnik * Math.PI * visina;
        }

        public string ToString()
        {
            return "Bure " + "P=" + povrsina() + ", V=" + zapremina();
        }
    }

    public class DrveniKontejner : IKontejner

    {

        double sirina;
        double visina;
        double duzina;

        public double Sirina { get => sirina; set => sirina = value; }
        public double Visina { get => visina; set => visina = value; }
        public double Duzina { get => duzina; set => duzina = value; }


        public DrveniKontejner(double sirina, double visina, double duzina)
        {
            this.duzina = duzina;
            this.sirina = sirina;
            this.visina = visina;
          

        }

        public DrveniKontejner()
        {
        }

        public double povrsina()
        {
            // P = 2ab + 2ac + 2bc
            return 2 * duzina * sirina + 2 + duzina * visina + 2 * sirina * visina;


        }

        public double zapremina()
        {
            // V = abc

            return duzina * visina * sirina;


        }

        public string ToString()
        {
            return "Drveni Kontejner " + "P=" + povrsina() + ", V=" + zapremina();
        }
    }


    class Program
    {
       

        static void Main(string[] args)
        {

        

            List<IKontejner> lista = new List<IKontejner>();

            lista.Add(new Bure(5, 10));
            lista.Add(new Bure(10, 15));
            lista.Add(new Bure(10, 15));
            lista.Add(new DrveniKontejner(6,8,9));
            lista.Add(new DrveniKontejner(9, 12, 19));
            lista.Add(new DrveniKontejner(6, 14, 19));


            
            Console.WriteLine("Originalna lista");
            foreach (IKontejner ik in lista)
            {
                Console.WriteLine(ik.ToString());
            }

            
            Console.WriteLine("Unesite povrsinu:");
         
            double povrsinaUnos = Convert.ToDouble(Console.ReadLine()); ;

          
            Console.WriteLine("Unesena povrsina: " + povrsinaUnos);

            
            IEnumerable<IKontejner> rezultati =
                from kontejner in lista
                where (kontejner.povrsina() >= povrsinaUnos)
                select kontejner;


            Console.WriteLine("Kontejneri koji imaju vecu ili jednaku povrsinu:" + povrsinaUnos);
            foreach (IKontejner ik in rezultati)
            {
                Console.WriteLine(ik.ToString());
            }


        }


    }
}
