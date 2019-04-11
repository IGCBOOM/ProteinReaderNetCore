using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Coordinates
{
    class Ter
    {

        private string _atomserial;
        private string _resname;
        private char _chainid;
        private uint _resseq;
        private char _rescode;

        public Ter(string atomserial, string resname, char chainid, uint resseq, char rescode)
        {
            _atomserial = atomserial;
            _resname = resname;
            _chainid = chainid;
            _resseq = resseq;
            _rescode = rescode;
        }

        public string GetAtomSerial() { return _atomserial; }
        public string GetResName() { return _resname; }
        public char GetChainId() { return _chainid; }
        public uint GetResSeq() { return _resseq; }
        public char GetResCode() { return _rescode; }

    }
}
