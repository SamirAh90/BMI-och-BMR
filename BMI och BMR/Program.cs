using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_och_BMR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Välkommen meddelande 
            Console.WriteLine("\t \t \t *** ==== Hej och välkommen till BMI och BMR räknare =====*** \n \t \t   \n\n-BMI räknare enligt WHO (Världshälsoorganisationen): \n\n");

            // Här börjar BMI räknares kod
            // Får in data från användaren avseende vikt och längd för att räkna BMI
            Console.WriteLine("Vänligen ange din vikt (i kg):");
            string strVikt = Console.ReadLine();
            double vikt = Convert.ToDouble(strVikt);

            Console.WriteLine("Vänligen ange din längd (i m) - exempelvis 1,76 meter läses som 1 meter och 76 centimeter:");
            string strHojd = Console.ReadLine();
            double hojd = Convert.ToDouble(strHojd);

            // Beräkning av BMI värde med hjälp av WHO formula
            double BMIcalc = 1.3 * vikt;
            double BMIdivide = Math.Pow(hojd, 2.5);
            double BMI = BMIcalc / BMIdivide;
            Console.Write("\nDitt BMI värde är:");
            Console.WriteLine(BMI);
            Console.WriteLine("Enligt BMI-tabellen är din vikt:");
            
            // Använder if satsen för att skriva ut om personen har en normal vikt eller inte enligt BMI tabell:

            // BMI under 18.5  	undervikt  
            // BMI 18.5–25      sund och normal vikt
            // BMI 25–30        övervikt
            // BMI 30–40      	kraftig övervikt
            // BMI över 40      extrem övervikt


            if (BMI < 18.5)
            {
                Console.WriteLine("\n*Undervikt*");
            }
            else if (BMI >= 18.5 && BMI < 24.9)
            {
                Console.WriteLine("\n*Sund och normal vikt*");
            }
            else if (BMI >= 25.0 && BMI < 29.9)
            {
                Console.WriteLine("\n*Övervikt*");
            }
            else if (BMI >= 30.0 && BMI < 39.99)
            {
                Console.WriteLine("\n*Krfatig övervikt*");
            }
            else if (BMI >= 40)
            {
                Console.WriteLine("\n*Exrem övervikt*");
            }

            
            // Här börjar BMR räknares kod
            Console.WriteLine("\n\n\n-BMR räknare enligt Mifflin-st Jeor ekvationen: \n\n");

            // Får in data från användaren avseende vikt, längd, ålder och kön för att räkna BMR
            Console.WriteLine("Vänligen ange din vikt (i kg):");
            string strViktBmr = Console.ReadLine();
            double viktBmr = Convert.ToDouble(strViktBmr);

            Console.WriteLine("Vänligen ange din längd (i cm) - exempelvis 1,76 meter läses som 176 centimeter:");
            string strHojdBmr = Console.ReadLine();
            double hojdBmr = Convert.ToDouble(strHojdBmr);

            Console.WriteLine("Vänlingen ange din ålder:");
            string strAlderBmr = Console.ReadLine();
            double alderBmr = Convert.ToDouble(strAlderBmr);

            Console.WriteLine("Vänlingen ange din kön (M/F): ");
            string kon = Console.ReadLine();

            // Använder if satsen för att skriva ut verfiera att inmatade värden är giltiga:

            // längd 50 [cm] ≤ längd ≤ 220 [cm]     // användarens längd
            // vikt 10 [kg] ≤ vikt ≤ 250 [kg]       // användarens vikt
            // 18 [år] ≤ ålder ≤ 70 [år]            // användarens ålder
            // M och m för man F f för kvinna       // användarens kon

            double bmr = 0;

            if ((kon == "M" || kon == "m") && viktBmr >= 10 && viktBmr <= 250 && hojdBmr >= 50 && hojdBmr <= 220 && alderBmr >= 18 && alderBmr <= 70)
            {
                // Räknar BMR för kvinna
                bmr = 66.47 + (13.75 * viktBmr) + (5.003 * hojdBmr) - (6.755 * alderBmr);
            }
            else if ((kon == "F" || kon == "f") && viktBmr >= 10 && viktBmr <= 250 && hojdBmr >= 50 && hojdBmr <= 220 && alderBmr >= 18 && alderBmr <= 70)
            {
                // Räknar BMR for man
                bmr = 655.1 + (9.563 * viktBmr) + (1.85 * hojdBmr) - (4.676 * alderBmr);
            }
            // Om använderen skriver fel uppgifter 
            else

            {
                Console.WriteLine("Ogiltligt val!");
            }

            // Programmet skriver ut både BMR och BMI
            Console.Write("\n\nDitt (BMR) är:");
            Console.WriteLine(" " + bmr);

            Console.Write("Ditt (BMI) är:");
            Console.WriteLine(" " + BMI);

            // Programmet avslutas med en hälsning och ber användaren att trycka på valfri tangent på tangentbordet för avslutning
            Console.WriteLine("\n\n \t \t \t \t\t ***===== Tack för att du använder vårt program =====*** \n \t \t \t    Du kan avsluta programmet genom att trycka på valfri tangent på tangentbordet");
            Console.ReadKey();

        }
    }
}

