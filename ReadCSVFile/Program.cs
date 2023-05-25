using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using Microsoft.VisualBasic.FileIO;

namespace ReadCSVFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String filePath = @"C:\Users\Capricorn\Downloads\Business-employment-data-september-2022-quarter-csv\Business-employment-data-september-2022-quarter-csv.csv";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }

    }
}

