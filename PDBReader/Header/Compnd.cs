using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Header
{
    class Compnd
    {

        private string _cont;
        private string _comp;

        public Compnd(string cont, string comp)
        {
            _cont = cont;
            _comp = comp;
        }
    }
}
