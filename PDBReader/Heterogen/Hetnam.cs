using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Heterogen
{
    class Hetnam
    {

        private string _continuation;
        private string _hetid;
        private string _text;

        public Hetnam(string continuation, string hetid, string text)
        {
            _continuation = continuation;
            _hetid = hetid;
            _text = text;
        }

        public string GetHetId() { return _hetid; }
        public string GetText() { return _text; }
    }
}
