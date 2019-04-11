using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Header
{
    class Revdat
    {

        private uint _modnum;
        private string _cont;
        private string _date;
        private string _modid;
        private int _modtype;
        private string _record1;
        private string _record2;
        private string _record3;
        private string _record4;

        public Revdat(uint modnum, string cont, string date, string modid, int modtype, string record1, string record2, string record3, string record4)
        {
            _modnum = modnum;
            _cont = cont;
            _date = date;
            _modid = modid;
            _modtype = modtype;
            _record1 = record1;
            _record2 = record2;
            _record3 = record3;
            _record4 = record4;
        }
    }
}
