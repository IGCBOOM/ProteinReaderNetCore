using System;
using System.Collections.Generic;
using System.Text;
using PDBReader.Coordinates;
using System.IO;

//TODO: Parse OBSLETETE and SPLITITITT

namespace PDBReader
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" - START - ");

            var projectFolder = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string Filepath = Path.Combine(projectFolder, @"../6cbs.pdb");

            Pdb pdb1 = new Pdb(Filepath);

            Console.WriteLine(" - END - ");
            Console.ReadLine();

        }


    }
}
