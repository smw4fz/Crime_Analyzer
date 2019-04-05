using System;

namespace Crime_Analyzer
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length != 2)
            {
                Console.WriteLine("CrimeAnalyzer <crime_csv_file_path> <report_file_path>");
                Environment.Exit(1);
            }

            string csvDataFilePath = args[0];
            string reportFilePath = args[1];

            CrimeVar CrimeVarList = null;
            try
            {
                CrimeVarList = CrimeVarLoader.Load(csvDataFilePath);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(2);
            } // end try-catch 1 

            var report = CrimeVarReport.GenerateText(CrimeVarList);

            try
            {
                System.IO.File.WriteAllText(reportFilePath, report);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Environment.Exit(3);
            } // end try-catch 2 

        } // end main
    } // end class
} // end namespace
