using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Header
{
    class Source
    {

        private string _cont;
        private string _src;

        public Source(string cont, string src)
        {
            _cont = cont;
            _src = src;
        }

        public string GetCont() { return _cont; }
        public string GetSrc() { return _src; }

    }
}
