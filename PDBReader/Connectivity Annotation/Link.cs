using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Connectivity_Annotation
{
    class Link
    {

        private string _name1;
        private char _altloc1;
        private string _resname1;
        private char _chainid1;
        private uint _resseq1;
        private char _icode1;
        private string _name2;
        private char _altloc2;
        private uint _resname2;
        private char _chainid2;
        private int _resseq2;
        private char _icode2;
        private int _sym1;
        private int _sym2;
        private double _len;

        public Link(string name1, char altloc1, string resname1, char chainid1, uint resseq1, char icode1, string name2, char altloc2, uint resname2, char chainid2, int resseq2, char icode2, int sym1, int sym2, double len)
        {
            _name1 = name1;
            _altloc1 = altloc1;
            _resname1 = resname1;
            _chainid1 = chainid1;
            _resseq1 = resseq1;
            _icode1 = icode1;
            _name2 = name2;
            _altloc2 = altloc2;
            _resname2 = resname2;
            _chainid2 = chainid2;
            _resseq2 = resseq2;
            _icode2 = icode2;
            _sym1 = sym1;
            _sym2 = sym2;
            _len = len;
        }

        public string GetName1() { return _name1; }
        public char GetAltLoc1() { return _altloc1; }
        public string GetResName1() { return _resname1; }
        public char GetChainID1() { return _chainid1; }
        public uint GetResSeq1() { return _resseq1; }
        public char GetICode1() { return _icode1; }
        public string GetName2() { return _name2; }
        public char GetAltLoc2() { return _altloc2; }
        public uint GetResName2() { return _resname2; }
        public char GetChainID2() { return _chainid2; }
        public int GetResSeq2() { return _resseq2; }
        public char GetICode2() { return _icode2; }
        public int GetSym1() { return _sym1; }
        public int GetSym2() { return _sym2; }
        public double GetLen() { return _len; }

    }
}
