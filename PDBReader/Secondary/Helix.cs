using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Secondary
{
    class Helix
    {

        private uint _sernum;
        private string _helixid;
        private string _initresname;
        private char _initchainid;
        private uint _initseqnum;
        private char _initicode;
        private string _endresname;
        private char _endchainid;
        private uint _endseqnum;
        private char _endicode;
        private uint _helixclass;
        private string _comment;
        private string _length;

        public Helix(uint sernum, string helixid, string initresname, char initchainid, uint initseqnum, char initicode, string endresname, char endchainid, uint endseqnum, char endicode, uint helixclass, string comment, string length)
        {
            _sernum = sernum;
            _helixid = helixid;
            _initresname = initresname;
            _initchainid = initchainid;
            _initseqnum = initseqnum;
            _initicode = initicode;
            _endresname = endresname;
            _endchainid = endchainid;
            _endseqnum = endseqnum;
            _endicode = endicode;
            _helixclass = helixclass;
            _comment = comment;
            _length = length;
        }

        public uint GetSerNum() { return _sernum; }
        public string GetHelixId() { return _helixid; }
        public string GetInitResName() { return _initresname; }
        public char GetInitChainId() { return _initchainid; }
        public uint GetInitSeqNum() { return _initseqnum; }
        public char GetInitICode() { return _initicode; }
        public string GetEndResName() { return _endresname; }
        public char GetEndChainId() { return _endchainid; }
        public uint GetEndSeqNum() { return _endseqnum; }
        public char GetEndICode() { return _endicode; }
        public uint GetHelixClass() { return _helixclass; }
        public string GetComment() { return _comment; }
        public string GetLength() { return _length; }

    }
}
