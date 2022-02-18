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
    public class ReadRec : Patient
    {
        public static void ReadRecord()
        {
            // Read and show each line from the file.

            string line = "";

            //Try

            try

            {

                //The text reader

                using (StreamReader sr = new StreamReader("PatientRecords.txt"))

                {

                    while ((line = sr.ReadLine()) != null)

                    {

                        Console.WriteLine(line);

                    }

                }

            }
            //Exception handling

            catch

            {

                Console.WriteLine("Exception!!!The file is invalid");

            }

            // Console.ReadKey();

        }
    }
}
