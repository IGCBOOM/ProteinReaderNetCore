using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Header
{
    class Keywds
    {

        private string _cont;
        private string _keywds;

        public Keywds(string cont, string keywds)
        {
            _cont = cont;
            _keywds = keywds;
        }

        public string GetCont() { return _cont; }
        public string GetKeywds() { return _keywds; }

    }
}
