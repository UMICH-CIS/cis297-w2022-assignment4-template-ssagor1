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
    public class Patient
    {
        public int num;
        public string name;
        public int balance;

        public static void StreamWriter()
        {
            using (StreamWriter sw = new StreamWriter("PatientRecords.txt"))
            {
                //create the patient object

                Patient pat = new Patient();

                //take the id

                Console.Write("\nEnter patient ID (0 to stop entering data about patients): ");

                pat.num = Convert.ToInt32(Console.ReadLine());

                //While ID not 0

                while (pat.num != 0)
                {

                    //Write to file

                    sw.Write(pat.num + " ");

                    //take and write patient name

                    Console.Write("Enter patient name: ");

                    pat.name = Console.ReadLine();

                    sw.Write(pat.name + " ");

                    //take and write patient balance

                    Console.Write("Enter patient balance: ");

                    pat.balance = Convert.ToInt32(Console.ReadLine());

                    sw.WriteLine(pat.balance);

                    //take next ID

                    Console.Write("\nEnter patient ID (0 to stop entering data about patients): ");

                    pat.num = Convert.ToInt32(Console.ReadLine());


                }

            }
            //Console.ReadKey();
        }
    }
}
