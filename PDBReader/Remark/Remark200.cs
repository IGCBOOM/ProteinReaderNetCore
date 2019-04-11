using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Remark
{
    class Remark200
    {
        //the spookiest, scariest class!
        //(i dont want to make this)

        private string _text;
        private string _info;

        public Remark200(string text, string info)
        {
            _text = text;
            _info = info;
        }

        public string GetText() { return _text; }
        public string GetInfo() { return _info; }

    }
}
