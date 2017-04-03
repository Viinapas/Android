using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//
using System.IO;
//date 5.3.17 PV

namespace CaSkiJump
{
    class SkiJump

    {
        static void Main(string[] args)
        {

            // static/muuttujat

            Jumpper SkiJ = new Jumpper(); // Object 

            Jumpper SkiJ2 = new Jumpper();

            Hill h1 = new Hill();  //Ski Hill object


            // Table

            Jumpper[] lahti17competitors = new Jumpper[4]; // Object table // memory exmp. 4 competitor


            // Hill Object 

            Hill lahtiHill = new Hill();
            lahtiHill.hillName = "Lahti Suurmäki";

            lahtiHill.cp = 116; // k point
            lahtiHill.kpp = 60;  // k point factor for long

            lahtiHill.factor = 0.6f;

            int i = 0;


            for (i = 0; i < 6; i++)
            {
                lahti17competitors[i] = new Jumpper();
                lahti17competitors[i].c1 = new Jump();
                lahti17competitors[i].c2 = new Jump();
                // lahti17competitors[i]h = new lahtiHill(); // viittaus mäkeen ??


            }
        }



            // Read Competitor Name from txt file


            //Lue nimet tiedostosta 

        public static void ReadName(Jumpper[] hyppaajat,
            string file)

        { //avataan tiedosto
            StreamReader sr = new StreamReader(file,
                Encoding.Default);
            string tx = "";
            int i = 0; 
            tx = sr.ReadLine();

            while (tx != null)
            {
                hyppaajat[i].fName = tx;
                tx = sr.ReadLine();
                hyppaajat[i].sName = tx;
                hyppaajat[i].number = i + 1;
                Console.WriteLine(hyppaajat[i].number + " " +
                    hyppaajat[i].fName + " " + hyppaajat[i].sName);

                i = i + 1;
                tx = sr.ReadLine();
            }
            sr.Close();





         




            

        }
    }
}
