using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Coordinates
{
    class Anisou
    {

        private uint _serial;
        private string _atomname;
        private char _altloc;
        private string _resname;
        private char _chainid;
        private uint _resseq;
        private char _icode;
        private int _i1;
        private int _i2;
        private int _i3;
        private int _i4;
        private int _i5;
        private int _i6;
        private string _vanity;
        private int _charge;

        public Anisou(uint serial, string atomname, char altloc, string resname, char chainid, uint resseq, char icode, int i1, int i2, int i3, int i4, int i5, int i6, string vanity, int charge)
        {
            _serial = serial;
            _atomname = atomname;
            _altloc = altloc;
            _resname = resname;
            _chainid = chainid;
            _resseq = resseq;
            _icode = icode;
            _i1 = i1;
            _i2 = i2;
            _i3 = i3;
            _i4 = i4;
            _i5 = i5;
            _i6 = i6;
            _vanity = vanity;
            _charge = charge;
        }

        public uint GetSerial() { return _serial; }

        public string GetAtomName() { return _atomname; }

        public char GetAltLoc() { return _altloc; }

        public string GetResName() { return _resname; }

        public char GetChainId() { return _chainid; }

        public uint GetResSeq() { return _resseq; }

        public char GetiCode() { return _icode; }

        public int GetI1() { return _i1; }

        public int GetI2() { return _i2; }

        public int GetI3() { return _i3; }

        public int GetI4() { return _i4; }

        public int GetI5() { return _i5; }

        public int GetI6() { return _i6; }

        public string GetVanity() { return _vanity; }

        public int GetCharge() { return _charge; }
    }
}
