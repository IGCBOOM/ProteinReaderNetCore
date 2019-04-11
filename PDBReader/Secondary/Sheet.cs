using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Secondary
{
    class Sheet
    {

        private uint _strand;
        private string _sheetid;
        private uint _numstrands;
        private string _initresname;
        private char _initchainid;
        private uint _initseqnum;
        private char _initicode;
        private string _endresname;
        private char _endchainid;
        private uint _endseqnum;
        private char _endicode;
        private int _sense;
        private string _curatom;
        private string _curresname;
        private char _curchainid;
        private int _curresseq;
        private char _curicode;
        private string _prevatom;
        private string _prevresname;
        private char _prevchainid;
        private uint _prevresseq;
        private char _previcode;

        public Sheet(uint strand, string sheetid, uint numstrands, string initresname, char initchainid, uint initseqnum, char initicode, string endresname, char endchainid, uint endseqnum, char endicode, int sense, string curatom, string curresname, char curchainid, int curresseq, char curicode, string prevatom, string prevresname, char prevchainid, uint prevresseq, char previcode)
        {
            _strand = strand;
            _sheetid = sheetid;
            _numstrands = numstrands;
            _initresname = initresname;
            _initchainid = initchainid;
            _initseqnum = initseqnum;
            _initicode = initicode;
            _endresname = endresname;
            _endchainid = endchainid;
            _endseqnum = endseqnum;
            _endicode = endicode;
            _sense = sense;
            _curatom = curatom;
            _curresname = curresname;
            _curchainid = curchainid;
            _curresseq = curresseq;
            _curicode = curicode;
            _prevatom = prevatom;
            _prevresname = prevresname;
            _prevchainid = prevchainid;
            _prevresseq = prevresseq;
            _previcode = previcode;
        }

        //todo: functions

    }
}
