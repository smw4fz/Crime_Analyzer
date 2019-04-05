using System;
namespace Crime_Analyzer
{
    public class CrimeData
    {
        public static string Data(List<CrimeVar> CrimeVarList)
        {
            Console.WriteLine("Crime Analyzer Report"); 

            if (CrimeVarList.Count() < 1)
            {
                Console.WriteLine("Sorry, there isn't any data is available.");
            } // end if 

            var first = (from crimeStats in CrimeVarList select CrimeVar.Year).Min();
            var last = (from crimeStats in CrimeVarList select CrimeVar.Year).Max();

            Console.WriteLine($"Period: {first}-{last} ({CrimeVarList.Count} years)");

            Console.WriteLine("Years murders per year < 15000: ");
            var year = from CrimeVar in CrimeVarList where CrimeVar.Murder < 15000 select CrimeVar.Year;
            if (year.Count() > 0)
            {
                foreach (var year in Year)
                {
                    Console.WriteLine(year + ",");

                }
            } // end if 
            else
            {
                Console.WriteLine("Not enough information.");
            } // end else 


            Console.WriteLine("Robberies per year > 500000: ");
            var report = from CrimeVar in CrimeVarList where CrimeVar.Robbery > 500000 select CrimeVar;
            if (report.Count() > 0)
            {
                foreach (var reports in report)
                {
                    Console.WriteLine(reports.Year + " = " + reports.Robbery + ",");
                }
            } // end if 
            else
            {
                Console.WriteLine("Not enough information");
            } // end else 


            Console.WriteLine("Violent crime per capita rate (2010): ");
            var violent = from crimeStats in CrimeVarList where CrimeVar.Year == 2010 select ((double)(CrimeVar.Violent_Crime) / (double)(CrimeVar.Population));
            if (violent.Count() > 0)
            {
                Console.WriteLine(violent.First());
            } // end if 
            else
            {
                Console.WriteLine("Not enough information");
            } // end else 


            var TotalAvgMurder = (from CrimeVar in CrimeVarList select CrimeVar.Murder).Average();
            Console.WriteLine($"Average murder per year (all years): {TotalAvgMurder}");


            var Avg1994_97 = (from CrimeVar in CrimeVarList where CrimeVar.Year >= 1994 && CrimeVar.Year <= 1997 select CrimeVar.Murder).Average();
            Console.WriteLine($"Average murder per year (1994 - 1997): {Avg1994_97}");


            var Avg2010_13 = (from CrimeVar in CrimeVarList where CrimeVar.Year >= 2010 && CrimeVar.Year <= 2013 select CrimeVar.Murder).Average();
            Console.WriteLine($"Average murder per year (2010 - 2013): {Avg2010_13}");


            var MinThefts1999_04 = (from CrimeVar in CrimeVarList where CrimeVar.Year >= 1999 && CrimeVar.Year <= 2004 select CrimeVar.Theft).Min();
            Console.WriteLine($"Minimum thefts per year (1999 - 2004): {MinThefts1999_04}");


            var MaxThefts1999_04 = (from CrimeVar in CrimeVarList where CrimeVar.Year >= 1999 && CrimeVar.Year <= 2004 select CrimeVar.Theft).Max();
            Console.WriteLine($"Maximum thefts per year (1999 - 2004): {MaxThefts1999_04}");


            var MotorThefts = from CrimeVar in CrimeVarList where CrimeVar.motorTheft == ((from data in CrimeVarList select data.motorTheft).Max()) select CrimeVar.Year;
            Console.WriteLine($"Year of highest number of motor vehicle thefts: {CrimeVar.Year}");
        } // end Data

    } // end CrimeData
} // end namespace
