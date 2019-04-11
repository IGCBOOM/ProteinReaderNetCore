using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Header
{
    class Mdltyp
    {

        private string _cont;
        private string _comment;

        public Mdltyp(string cont, string comment)
        {
            _cont = cont;
            _comment = comment;
        }
    }
}
