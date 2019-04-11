using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Header
{
    class Title
    {

        private string _cont;
        private string _title;

        public Title(string cont, string title)
        {
            _cont = cont;
            _title = title;
        }

        public string GetCont() { return _cont; }
        public string GetTitle() { return _title; }

    }
}
