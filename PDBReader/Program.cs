using System;
using System.Collections.Generic;
using System.Text;
using PDBReader.Coordinates;

namespace PDBReader
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" - START - ");

            string Filepath = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(Filepath);
            string RecName;
            List<Atom> AllHetAtoms = null;

            foreach (string line in lines)
            {

                RecName = GetFromString(0, 5, line);

                switch (RecName)
                {
                    case "ATOM  ":
                        Console.WriteLine("It's atom time babyyyy!!");
                        break;

                    case "HETATM":
                        Console.WriteLine("It's (het)atom time babyyyy!!");

                        AllHetAtoms.Add(new Atom( 
                            Convert.ToUInt32(GetFromString(6, 10, line)), 
                            GetFromString(12, 15, line), 
                            GetFromString(16, 16, line)
                            ));

                        break;

                    case "END   ":
                        Console.WriteLine("Finished reading!");
                        break;

                    default:
                        Console.WriteLine("Unknown type.");
                        break;

                }

                //Console.WriteLine(GetFromString(3, 7, "Lorum Ipsum Hello world test abcdef"));
            }


            Console.WriteLine(" - END - ");
            Console.ReadLine();

        }

        static string ConvertStringArrayToString(string[] array)
        {
            //https://www.dotnetperls.com/convert-string-array-string
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {

                builder.Append(value);

            }
            return builder.ToString();
        }

        static string GetFromString(int start, int end, string line)
        {

            string[] tempString = new string[line.Length];

            for (int i = start; i <= end; i++)
            {

                tempString[i] = line[i].ToString();

            }

            return ConvertStringArrayToString(tempString);

        }

    }
}
