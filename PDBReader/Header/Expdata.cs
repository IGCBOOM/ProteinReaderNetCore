using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Header
{
    class Expdata
    {

        private string _cont;
        private string _tech;

        public Expdata(string cont, string tech)
        {
            _cont = cont;
            _tech = tech;
        }
    }
}
