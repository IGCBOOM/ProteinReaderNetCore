using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Header
{
    class Caveat
    {

        private string _cont;
        private string _id;
        private string _comment;

        public Caveat(string cont, string id, string comment)
        {
            _cont = cont;
            _id = id;
            _comment = comment;
        }
    }
}
