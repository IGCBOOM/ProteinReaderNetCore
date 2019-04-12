using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Connectivity_Annotation
{
    class Cispep
    {

        private uint _sernum;
        private string _pep1;
        private char _chainid1;
        private uint _seqnum1;
        private char _icode1;
        private string _pep2;
        private char _chainid2;
        private uint _seqnum2;
        private char _icode2;
        private int _modnum;
        private double _measure;

        public Cispep(uint sernum, string pep1, char chainid1, uint seqnum1, char icode1, string pep2, char chainid2, uint seqnum2, char icode2, int modnum, double measure)
        {
            _sernum = sernum;
            _pep1 = pep1;
            _chainid1 = chainid1;
            _seqnum1 = seqnum1;
            _icode1 = icode1;
            _pep2 = pep2;
            _chainid2 = chainid2;
            _seqnum2 = seqnum2;
            _icode2 = icode2;
            _modnum = modnum;
            _measure = measure;
        }

        public uint GetSerNum() { return _sernum; }
        public string GetPep1() { return _pep1; }
        public char GetChainID1() { return _chainid1; }
        public uint GetSeqNum1() { return _seqnum1; }
        public char GetICode1() { return _icode1; }
        public string GetPep2() { return _pep2; }
        public char GetChainID2() { return _chainid2; }
        public uint GetSeqNum2() { return _seqnum2; }
        public char GetICode2() { return _icode2; }
        public int GetLen() { return _modnum; }
        public double GetMeasure() { return _measure; }


    }
}
