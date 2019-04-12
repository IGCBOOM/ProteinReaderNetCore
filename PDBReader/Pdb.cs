using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using PDBReader.Coordinates;
using PDBReader.TitleSec;
using PDBReader.Tools;
using PDBReader.Primary;
using PDBReader.Heterogen;
using PDBReader.Secondary;
using PDBReader.Connectivity_Annotation;
using PDBReader.Misc_Features;
using PDBReader.Crystallographic;
using PDBReader.Connectivity;
using PDBReader.Bookkeeping;

namespace PDBReader
{
    class Pdb
    {

        private Header _header; //title section
        private List<Title> _title = new List<Title>();
        private List<Caveat> _caveat = new List<Caveat>();
        private List<Compnd> _compnd = new List<Compnd>();
        private List<Source> _source = new List<Source>();
        private List<Keywds> _keywds = new List<Keywds>();
        private List<Expdata> _expdata = new List<Expdata>();
        private Nummdl _nummdl;
        private List<Mdltyp> _mdltyp = new List<Mdltyp>();
        private List<Author> _author = new List<Author>();
        private List<Revdat> _revdat = new List<Revdat>();
        private List<Jrnl> _jrnl = new List<Jrnl>();

        private Dbref _dbref; //primary section
        private Seqadv _seqadv;
        private Seqres _seqres;
        private Modres _modres;

        private Het _het; //heterogen section
        private Formul _formul;
        private Hetnam _hetnam;
        private Hetsyn _hetsyn;

        private Helix _helix; //secondary section
        private Sheet _sheet;

        private Ssbond _ssbond; //connectivity section
        private Link _link;
        private Cispep _cicpep;

        private Site _site; //misc

        private Cryst1 _cryst1; //Crystallographic section
        private Mtrixn _mtrixn;
        private Origxn _origxn;
        private Scalen _scalen;

        private Model _model; //Coordinate section
        private List<Atom> _atoms = new List<Atom>();
        private List<Atom> _hetatoms = new List<Atom>();
        private List<Anisou> _anisous = new List<Anisou>();
        private List<Ter> _ters = new List<Ter>();

        private Conect _conect; //connectivity section

        private Master _master; //bookkeeping

        public Pdb(string filepath)
        {

            string[] lines = File.ReadAllLines(filepath);
            string recName;

            foreach (string line in lines)
            {

                recName = GetFromString(0, 5, line);

                switch (recName)
                {
                    case "HEADER":
                        _header = new Header(
                            GetFromString(10, 49, line), 
                            GetFromString(50, 58, line), 
                            GetFromString(62, 65, line));
                        break;

                    case "TITLE ":
                        _title.Add(new Title(
                            TestCont(GetFromString(8,9,line)),
                            GetFromString(10,79,line)));
                        break;

                    case "CAVEAT":
                        _caveat.Add(new Caveat(
                            TestCont(GetFromString(8,9,line)),
                            GetFromString(11,14,line),
                            GetFromString(19,78,line)));
                        break;

                    case "COMPND":
                        _compnd.Add(new Compnd(
                            TestCont(GetFromString(7,9,line)),
                            GetFromString(10,79,line)));
                        break;

                    case "SOURCE":
                        _source.Add(new Source(
                            TestCont(GetFromString(7,9,line)),
                            GetFromString(10,78,line)));
                        break;

                    case "KEYWDS":
                        _keywds.Add(new Keywds(
                            TestCont(GetFromString(8,9,line)),
                            GetFromString(10,78,line)));
                        break;

                    case "EXPDTA":
                        _expdata.Add(new Expdata(
                            TestCont(GetFromString(8,9,line)),
                            GetFromString(10,78,line)));
                        break;

                    case "NUMMDL":
                        _nummdl = new Nummdl(Convert.ToUInt32(GetFromString(10,13,line)));
                        break;

                    case "MDLTYP":
                        _mdltyp.Add(new Mdltyp(
                            TestCont(GetFromString(8,9,line)),
                            GetFromString(10,79,line)));
                        break;

                    case "AUTHOR":
                        _author.Add(new Author(
                            TestCont(GetFromString(8,9,line)),
                            GetFromString(10,78,line)));
                        break;

                    case "REVDAT":
                        _revdat.Add(new Revdat(
                            Convert.ToUInt32(GetFromString(7,9,line)),
                            TestCont(GetFromString(10,11,line)),
                            GetFromString(13,21,line),
                            GetFromString(23,26,line),
                            Convert.ToInt32(GetFromString(31,31,line)),
                            GetFromString(39,44,line),
                            GetFromString(46,51,line),
                            GetFromString(53,58,line),
                            GetFromString(60,65,line)));
                        break;

                    case "JNRL  ":
                        _jrnl.Add(new Jrnl(GetFromString(12,78,line)));
                        break;

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
                        Console.WriteLine("Unknown type.");
                        break;

                }



            }



        }

        private static string ConvertStringArrayToString(string[] array)
        {

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

            if (charge.Trim() != string.Empty)
            {

                return Convert.ToInt32(charge);

            }
            else { return 0; }

        }

        private static ushort TestCont(string cont)
        {

            if (cont.Trim() != string.Empty)
            {

                return Convert.ToUInt16(cont);

            }
            else { return 0; }

        }

    }
}
