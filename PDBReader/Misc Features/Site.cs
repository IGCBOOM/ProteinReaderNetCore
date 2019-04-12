using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Misc_Features
{
    class Site
    {

        private uint _seqnum;
        private string _siteid;
        private uint _resname1;
        private char _chainid1;
        private uint _seq1;
        private char _icode1;
        private uint _resname2;
        private char _chainid2;
        private uint _seq2;
        private char _icode2;
        private uint _resname3;
        private char _chainid3;
        private uint _seq3;
        private char _icode3;
        private uint _resname4;
        private char _chainid4;
        private uint _seq4;
        private char _icode4;

        public Site(uint seqnum, string siteid, uint resname1, char chainid1, uint seq1, char icode1, uint resname2, char chainid2, uint seq2, char icode2, uint resname3, char chainid3, uint seq3, char icode3, uint resname4, char chainid4, uint seq4, char icode4)
        {
            _seqnum = seqnum;
            _siteid = siteid;
            _resname1 = resname1;
            _chainid1 = chainid1;
            _seq1 = seq1;
            _icode1 = icode1;
            _resname2 = resname2;
            _chainid2 = chainid2;
            _seq2 = seq2;
            _icode2 = icode2;
            _resname3 = resname3;
            _chainid3 = chainid3;
            _seq3 = seq3;
            _icode3 = icode3;
            _resname4 = resname4;
            _chainid4 = chainid4;
            _seq4 = seq4;
            _icode4 = icode4;
        }

        public uint GetSeqNum() { return _seqnum; }
        public string GetSiteId() { return  _siteid; }
        public uint GetResName1() { return _resname1; }
        public char GetChainId1() { return _chainid1; }
        public uint GetSeq1() { return _seq1; }
        public char GetICode1() { return _icode1; }
        public uint GetResName2() { return _resname2; }
        public char GetChainId2() { return _chainid2; }
        public uint GetSeq2() { return _seq2; }
        public char GetICode2() { return _icode2; }
        public uint GetResName3() { return _resname3; }
        public char GetChainId3() { return _chainid3; }
        public uint GetSeq3() { return _seq3; }
        public char GetICode3() { return _icode3; }
        public uint GetResName4() { return _resname4; }
        public char GetChainId4() { return _chainid4; }
        public uint GetSeq4() { return _seq4; }
        public char GetICode4() { return _icode4; }
    }
}
