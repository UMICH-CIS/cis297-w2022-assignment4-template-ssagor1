/// <summary>
/// This program allows doctor's staff to store patient's data such as Name, ID, Balanced Owed. Also, this program allows user to see all the record as well as individual records. 
/// </summary>
/// <Student> Shahriar Sagor </Student>
/// <Class> CIS297 </Class>
/// <Semester> Winter 2022 </Semester>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace PatientRecordSystem
{

    public class PatientMain
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please choose an option from below: ");
            Console.WriteLine("1 = Enter data about patients.");
            Console.WriteLine("2 = Display each patient's data.");
            Console.WriteLine("3 = See specified record by ID number. ");
            Console.WriteLine("4 = Enter minimum balance due. ");

            int option = 0;
            while (option != 9)
            {

                Console.Write("\nSelect an option or type 9 to quit: ");
                option = Convert.ToInt32(Console.ReadLine());

                if (option == 1)
                {
                    Patient.StreamWriter();

                }
                if (option == 2)
                {
                    ReadRec.ReadRecord();
                }
                if (option == 3)
                {
                    PatientRec.PatientRecord();

                }
                if (option == 4)
                {
                    MininumBalance.MinBalance();
                }

            }
        }
    }
}















