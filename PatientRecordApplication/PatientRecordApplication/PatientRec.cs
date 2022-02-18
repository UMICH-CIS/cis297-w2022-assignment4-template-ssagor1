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
    public class PatientRec : Patient
    {
        public static void PatientRecord()
        {
            // Read and show each line from the file.

            string line = "";

            int id;

            Console.Write("\nEnter ID to be searched: ");



            id = Convert.ToInt32(Console.ReadLine());

            //Try

            try

            {

                //The text reader

                using (StreamReader sr = new StreamReader("PatientRecords.txt"))

                {

                    while ((line = sr.ReadLine()) != null)

                    {

                        //split the line and extract the id

                        string[] tokens = line.Split(' ');

                        //if idis same

                        if (Convert.ToInt32(tokens[0]) == id)

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
