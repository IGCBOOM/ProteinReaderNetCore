using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Connectivity_Annotation
{
    class Ssbond
    {

        private uint _sernum;
        private string _cys1;
        private char _chainid1;
        private uint _seqnum1;
        private char _icode1;
        private string _cys2;
        private char _chainid2;
        private uint _seqnum2;
        private char _icode2;
        private int _sym1;
        private int _sym2;
        private double _len;

        public Ssbond(uint sernum, string cys1, char chainid1, uint seqnum1, char icode1, string cys2, char chainid2, uint seqnum2, char icode2, int sym1, int sym2, double len)
        {
            _sernum = sernum;
            _cys1 = cys1;
            _chainid1 = chainid1;
            _seqnum1 = seqnum1;
            _icode1 = icode1;
            _cys2 = cys2;
            _chainid2 = chainid2;
            _seqnum2 = seqnum2;
            _icode2 = icode2;
            _sym1 = sym1;
            _sym2 = sym2;
            _len = len;
        }

        public uint GetSerNum() { return _sernum; }
        public string GetCys1() { return _cys1; }
        public char GetChainID1() { return _chainid1; }
        public uint GetSeqNum1() { return _seqnum1; }
        public char GetICode1() { return _icode1; }
        public string GetCys2() { return _cys2; }
        public char GetChainID2() { return _chainid2; }
        public uint GetSeqNum2() { return _seqnum2; }
        public char GetICode2() { return _icode2; }
        public int GetSym1() { return _sym1; }
        public int GetSym2() { return _sym2; }
        public double GetLen() { return _len; }

    }
}
