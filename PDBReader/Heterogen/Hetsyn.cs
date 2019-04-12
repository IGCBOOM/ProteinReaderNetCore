using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Heterogen
{
    class Hetsyn
    {

        private string _continuation;
        private string _hetid;
        private string _hetsynonyms;

        public Hetsyn(string continuation, string hetid, string hetsynonyms)
        {
            _continuation = continuation;
            _hetid = hetid;
            _hetsynonyms = hetsynonyms;
        }

        public string GetHetId() { return _hetid; }
        public string GetHetSynonyms() { return _hetsynonyms; }
    }
}
