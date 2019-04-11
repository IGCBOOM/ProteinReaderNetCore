using System;
using System.Collections.Generic;
using System.Text;
using PDBReader.Coordinates;
using System.IO;

namespace PDBReader
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" - START - ");
            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string Filepath = Path.Combine(projectFolder, @"../6cbs.pdb");
            string[] lines = File.ReadAllLines(Filepath);
            string RecName;
            List<Atom> AllHetAtoms = new List<Atom>();
            List<Atom> AllAtoms = new List<Atom>();

            foreach (string line in lines)
            {

                RecName = GetFromString(0, 5, line);

                switch (RecName)
                {
                    case "ATOM  ":

                        AllAtoms.Add(new Atom(
                            Convert.ToUInt32(GetFromString(6, 10, line)),
                            GetFromString(12, 15, line),
                            Convert.ToChar(GetFromString(16, 16, line)),
                            GetFromString(17, 19, line),
                            Convert.ToChar(GetFromString(21, 21, line)),
                            Convert.ToUInt32(GetFromString(22, 25, line)),
                            Convert.ToChar(GetFromString(26, 26, line)),
                            new Vector3(Convert.ToDouble(GetFromString(30, 37, line)), Convert.ToDouble(GetFromString(38, 45, line)), Convert.ToDouble(GetFromString(46, 53, line))),
                            Convert.ToDouble(GetFromString(54, 59, line)),
                            Convert.ToDouble(GetFromString(60, 65, line)),
                            GetFromString(76, 77, line),
                            testCharge(GetFromString(78, 79, line)),
                            false
                            ));

                        break;

                    case "HETATM":

                        AllHetAtoms.Add(new Atom( 
                            Convert.ToUInt32(GetFromString(6, 10, line)), 
                            GetFromString(12, 15, line),
                            Convert.ToChar(GetFromString(16, 16, line)),
                            GetFromString(17, 19, line),
                            Convert.ToChar(GetFromString(21, 21, line)),
                            Convert.ToUInt32(GetFromString(22, 25, line)),
                            Convert.ToChar(GetFromString(26, 26, line)),
                            new Vector3( Convert.ToDouble(GetFromString(30, 37, line)), Convert.ToDouble(GetFromString(38, 45, line)), Convert.ToDouble(GetFromString(46, 53, line)) ),
                            Convert.ToDouble(GetFromString(54, 59, line)),
                            Convert.ToDouble(GetFromString(60, 65, line)),
                            GetFromString(76, 77, line),
                            testCharge(GetFromString(78, 79, line)),
                            true
                            ));

                        break;

                    case "END   ":
                        Console.WriteLine("Finished reading!");
                        break;

                    default:
                        //Console.WriteLine("Unknown type.");
                        break;

                }

            }

            Console.WriteLine(AllAtoms[3].getVanity());

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

        static int testCharge(string charge) //this is bullshit
        {

            if (charge != "  ")
            {

                return Convert.ToInt32(charge);

            } else { return 0; }

        }

    }
}
