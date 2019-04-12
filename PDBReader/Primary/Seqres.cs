using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Primary
{
    class Seqres
    {

        private uint _sernum;
        private char _chainid;
        private uint _numres;
        private string _resname1;
        private string _resname2;
        private string _resname3;
        private string _resname4;
        private string _resname5;
        private string _resname6;
        private string _resname7;
        private string _resname8;
        private string _resname9;
        private string _resname10;
        private string _resname11;
        private string _resname12;
        private string _resname13;

        public Seqres(uint sernum, char chainid, uint numres, string resname1, string resname2, string resname3, string resname4, string resname5, string resname6, string resname7, string resname8, string resname9, string resname10, string resname11, string resname12, string resname13)
        {
            _sernum = sernum;
            _chainid = chainid;
            _numres = numres;
            _resname1 = resname1;
            _resname2 = resname2;
            _resname3 = resname3;
            _resname4 = resname4;
            _resname5 = resname5;
            _resname6 = resname6;
            _resname7 = resname7;
            _resname8 = resname8;
            _resname9 = resname9;
            _resname10 = resname10;
            _resname11 = resname11;
            _resname12 = resname12;
            _resname13 = resname13;
        }

        public uint GetSerNum() { return _sernum; }
        public char GetChainId() { return _chainid; }
        public uint GetNumRes() { return _numres; }
        public string GetResName1() { return _resname1; }
        public string GetResName2() { return _resname2; }
        public string GetResName3() { return _resname3; }
        public string GetResName4() { return _resname4; }
        public string GetResName5() { return _resname5; }
        public string GetResName6() { return _resname6; }
        public string GetResName7() { return _resname7; }
        public string GetResName8() { return _resname8; }
        public string GetResName9() { return _resname9; }
        public string GetResName10() { return _resname10; }
        public string GetResName11() { return _resname11; }
        public string GetResName12() { return _resname12; }
        public string GetResName13() { return _resname13; }

    }
}
