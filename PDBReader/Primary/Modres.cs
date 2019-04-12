using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Primary
{
    class Modres
    {

        private string _idcode;
        private string _resname;
        private char _chainid;
        private uint _seqnum;
        private char _icode;
        private string _stdres;
        private string _comment;

        public Modres(string idcode, string resname, char chainid, uint seqnum, char icode, string stdres, string comment)
        {
            _idcode = idcode;
            _resname = resname;
            _chainid = chainid;
            _seqnum = seqnum;
            _icode = icode;
            _stdres = stdres;
            _comment = comment;
        }

        public string GetIdCode() { return _idcode; }
        public string GetResName() { return _resname; }
        public char GetChainId() { return _chainid; }
        public uint GetSeqNum() { return _seqnum; }
        public char GetICode() { return _icode; }
        public string GetStdRes() { return _stdres; }
        public string GetComment() { return _comment; }
    }
}
