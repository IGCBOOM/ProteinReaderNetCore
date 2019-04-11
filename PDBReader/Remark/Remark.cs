using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Remark
{
    class Remark
    {

        //-https://www.wwpdb.org/documentation/file-format-content/format33/remarks.html

        //super basic remark class.
        //im pretty sure that this is all we need
        //and the rest of the complexity is to be done
        //inside of the actual program.

        private int _remarknum;
        private string _text;

        public Remark(int remarknum, string text)
        {
            _remarknum = remarknum;
            _text = text; //not really sure what this one is.
        }
    }
}
