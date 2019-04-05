using System;
namespace Crime_Analyzer
{
    public class CrimeVar
    {
        public int Year;
        public int Population;
        public int Violent_Crime;
        public int Murder;
        public int Rape;
        public int Robbery;
        public int Aggravated_Assault;
        public int Property_Crime;
        public int Burglary;
        public int Theft;
        public int Motor_Vehicle_Theft;


        public CrimeVar(int year, int population, int violentCrime, int murder,
                         int rape, int robbery, int aggAssault, int propertyCrime,
                         int burglary, int theft, int motorTheft)
        {
            Year = year;
            Population = population;
            Violent_Crime = violentCrime;
            Murder = murder;
            Rape = rape;
            Robbery = robbery;
            Aggravated_Assault = aggAssault;
            Property_Crime = propertyCrime;
            Burglary = burglary;
            Theft = theft;
            Motor_Vehicle_Theft = motorTheft;
        }
    } // end Crime Var
}
