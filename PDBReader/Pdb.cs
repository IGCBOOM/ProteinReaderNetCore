using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using PDBReader.Coordinates;
using PDBReader.TitleSec;
using PDBReader.Tools;

namespace PDBReader
{
    class Pdb
    {

        private Header _header;
        private Title _title;
        private Caveat _caveat;
        private Compnd _compnd;
        private Source _source;
        private Keywds _keywds;
        private Expdata _expdata;
        private Nummdl _nummdl;
        private Mdltyp _mdltyp;
        private Author _author;
        private Revdat _revdat;
        private Jrnl _jrnl;

        private Model _model;
        private List<Atom> _atoms = new List<Atom>();
        private List<Atom> _hetatoms = new List<Atom>();
        private List<Anisou> _anisous = new List<Anisou>();
        private List<Ter> _ters = new List<Ter>();

        public Pdb(string filepath)
        {

            string[] lines = File.ReadAllLines(filepath);
            string recName;

            foreach (string line in lines)
            {

                recName = GetFromString(0, 5, line);

                switch (recName)
                {
                    case "ATOM  ":

                        _atoms.Add(new Atom(
                            Convert.ToUInt32(GetFromString(6, 10, line)),
                            GetFromString(12, 15, line),
                            Convert.ToChar(GetFromString(16, 16, line)),
                            GetFromString(17, 19, line),
                            Convert.ToChar(GetFromString(21, 21, line)),
                            Convert.ToUInt32(GetFromString(22, 25, line)),
                            Convert.ToChar(GetFromString(26, 26, line)),
                            new Vector3(Convert.ToDouble(GetFromString(30, 37, line)),
                                Convert.ToDouble(GetFromString(38, 45, line)),
                                Convert.ToDouble(GetFromString(46, 53, line))),
                            Convert.ToDouble(GetFromString(54, 59, line)),
                            Convert.ToDouble(GetFromString(60, 65, line)),
                            GetFromString(76, 77, line),
                            TestCharge(GetFromString(78, 79, line)),
                            false,
                            new Color(255, 255, 255, 255)
                        ));
                        break;

                    case "HETATM":

                        _hetatoms.Add(new Atom(
                            Convert.ToUInt32(GetFromString(6, 10, line)),
                            GetFromString(12, 15, line),
                            Convert.ToChar(GetFromString(16, 16, line)),
                            GetFromString(17, 19, line),
                            Convert.ToChar(GetFromString(21, 21, line)),
                            Convert.ToUInt32(GetFromString(22, 25, line)),
                            Convert.ToChar(GetFromString(26, 26, line)),
                            new Vector3(Convert.ToDouble(GetFromString(30, 37, line)),
                                Convert.ToDouble(GetFromString(38, 45, line)),
                                Convert.ToDouble(GetFromString(46, 53, line))),
                            Convert.ToDouble(GetFromString(54, 59, line)),
                            Convert.ToDouble(GetFromString(60, 65, line)),
                            GetFromString(76, 77, line),
                            TestCharge(GetFromString(78, 79, line)),
                            true,
                            new Color(255, 255, 255, 255)
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



        }

        private static string ConvertStringArrayToString(string[] array)
        {
            //https://www.dotnetperls.com/convert-string-array-string
            StringBuilder builder = new StringBuilder();
            foreach (string value in array)
            {

                builder.Append(value);

            }
            return builder.ToString();
        }

        private static string GetFromString(int start, int end, string line)
        {

            string[] tempString = new string[line.Length];

            for (int i = start; i <= end; i++)
            {

                tempString[i] = line[i].ToString();

            }

            return ConvertStringArrayToString(tempString);

        }

        private static int TestCharge(string charge) //this is bullshit
        {

            if (charge != "  ")
            {

                return Convert.ToInt32(charge);

            }
            else { return 0; }

        }

    }
}
