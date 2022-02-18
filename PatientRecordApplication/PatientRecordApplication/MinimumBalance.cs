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
    public class MininumBalance : PatientRec
    {
        public static void MinBalance()
        {
            // Read and show each line from the file.

            string line = "";

            int id;

            Console.Write("\nEnter minimum balance: ");



            id = Convert.ToInt32(Console.ReadLine());

            //Try

            try

            {

                //The text reader

                using (StreamReader sr = new StreamReader("PatientRecords.txt"))

                {

                    while ((line = sr.ReadLine()) != null)

                    {

                        //split the line to extract the balance

                        string[] tokens = line.Split(' ');

                        //if balance is gretaer than enterd

                        if (Convert.ToInt32(tokens[2]) >= id)

                            Console.WriteLine(line);

                    }

                }

            }

            //Exception handling

            catch

            {

                Console.WriteLine("Exception!!!The file is invalid or no data found");

            }

            // Console.ReadKey();


        }
    }
}

