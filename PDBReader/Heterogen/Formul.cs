using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Heterogen
{
    class Formul
    {

        private uint _compnum;
        private string _hetid;
        private uint _continuation;
        private char _asterisk;
        private string _text;

        public Formul(uint compnum, string hetid, uint continuation, char asterisk, string text)
        {
            _compnum = compnum;
            _hetid = hetid;
            _continuation = continuation;
            _asterisk = asterisk;
            _text = text;
        }

        public uint GetCompNum() { return _compnum; }
        public string GetHetId() { return _hetid; }
        public char GetAsterisk() { return _asterisk; }
        public string GetText() { return _text; }
    }
}
