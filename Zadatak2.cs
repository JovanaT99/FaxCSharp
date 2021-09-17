using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadatak2
{
    public class Osoba
    {
        private string ime;
        private string prezime;


        public string Ime1 { get => ime; set => ime = value; }
        public string Prezime1 { get => prezime; set => prezime = value; }


        public Osoba(string Ime1,string Prezime1 )
        {
            this.Ime1 = Ime1;
            this.Prezime1 = Prezime1;
          

        }
      
        
    }
    public class Student:Osoba
    {

        private int brojIndexa;
        private float prosek;
        private int godinaStudija;

        //Koristim crtl+r i ctr+e za get i set mogu da se napisu i klasicno

        public int BrojIndexa { get => brojIndexa; set => brojIndexa = value; }
        public float Prosek { get => prosek; set => prosek = value; }
        public int GodinaStudija { get => godinaStudija; set => godinaStudija = value; }

       
        public Student(string Ime1, string Prezime1, int brojIndexa, float prosek, int godinaStudija) : base(Ime1, Prezime1)
        {
            this.brojIndexa = brojIndexa;
            this.prosek = prosek;
            this.godinaStudija = godinaStudija;
        }

        public Boolean UpisMaster()
        {
            if (prosek >=8 && godinaStudija==4)
            {
                return true;
            }

            return false;
        }
        public override string ToString()
        {
            return "Ime:" + Ime1+" "+ "Prezime:" + Prezime1;
        }

    }
 

    class Program
    {
        static void Main(string[] args)
        {

            Student Student1 = new Student("Jovana","Blagojevic",11,8.5f,4);
            Student Student2 = new Student("Olja", "Nikolasev", 12, 9, 4);
            ArrayList lista = new ArrayList();
            lista.Add(Student1);
            lista.Add(Student2);


            ArrayList listaZaMaster = new ArrayList();

            foreach (Student student in lista)
            {

                if (student.UpisMaster())
                {
                    listaZaMaster.Add(student);
                }
            }

            Console.WriteLine(Student1.UpisMaster());

            foreach(Student student in listaZaMaster)
            {
                Console.WriteLine(student.ToString());


            }

            }


    }
    
}
