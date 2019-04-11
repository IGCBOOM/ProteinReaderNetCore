using System;
using System.Text;

namespace PDBReader
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" - START - ");

            string Filepath = Console.ReadLine();
            string[] lines = System.IO.File.ReadAllLines(Filepath);
            string[] RecName = new string[6];
            string RecName2;

            foreach (string line in lines)
            {
                for (int i = 0; i <= 5; i++)
                {

                    RecName[i] = line[i].ToString();

                }

                RecName2 = ConvertStringArrayToString(RecName);

                switch (RecName2)
                {
                    case "ATOM  ":
                        Console.WriteLine("It's atom time babyyyy!!");
                        break;

                    case "END   ":
                        Console.WriteLine("Finished reading!");
                        break;

                    default:
                        Console.WriteLine("Unknown type.");
                        break;

                }

                //Console.WriteLine(RecName2);
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
    }
}
