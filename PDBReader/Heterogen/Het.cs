using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Heterogen
{
    class Het
    {

        private string _hetid;
        private char _chainid;
        private uint _seqnum;
        private char _icode;
        private uint _numhetatoms;
        private string _text;

        public Het(string hetid, char chainid, uint seqnum, char icode, uint numhetatoms, string text)
        {
            _hetid = hetid;
            _chainid = chainid;
            _seqnum = seqnum;
            _icode = icode;
            _numhetatoms = numhetatoms;
            _text = text;
        }

        public string GetHetId() { return _hetid; }
        public char GetChainId() { return _chainid; }
        public uint GetSeqNum() { return _seqnum; }
        public char GetICode() { return _icode; }
        public uint GetNumHetAtoms() { return _numhetatoms; }
        public string GetText() { return _text; }
    }
}
