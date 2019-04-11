using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Header
{
    class Author
    {

        private string _cont;
        private string _auth;

        public Author(string cont, string auth)
        {
            _cont = cont;
            _auth = auth;
        }

        public string GetCont() { return _cont; }
        public string GetAuth() { return _auth; }

    }
}
