using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateReadAccessDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PRESS 1 TO VIEW ALL ENTRIES\nPRESS 2 ADD ENTRY\n" +
                "PRESS 3 TO EXIT\n");
            
            while (true)
            {
                Console.Write(">");
                string Choice = Console.ReadLine();
                if (Choice == "1")
                {
                    methods.GetEntries();
                }
                else if (Choice == "2")
                {
                    methods.InsertEntry();
                }
                else
                {
                    break;
                }
            }

        }
    }
}
