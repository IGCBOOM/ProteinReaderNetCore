using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Bookkeeping
{
    class Master
    {

        private uint _numremark;
        private uint _zero = 0;
        private uint _numhet;
        private uint _numhelix;

        private uint _numsheet;
        private uint _numturn;
        private uint _numsite;
        private uint _numxform;

        private uint _numcoord;
        private uint _numter;
        private uint _numconect;
        private uint _numseq;

        public Master(uint numremark, uint zero, uint numhet, uint numhelix, uint numsheet, uint numturn, uint numsite, uint numxform, uint numcoord, uint numter, uint numconect, uint numseq)
        {
            _numremark = numremark;
            _zero = zero;
            _numhet = numhet;
            _numhelix = numhelix;
            _numsheet = numsheet;
            _numturn = numturn;
            _numsite = numsite;
            _numxform = numxform;
            _numcoord = numcoord;
            _numter = numter;
            _numconect = numconect;
            _numseq = numseq;
        }

        public uint GetNumRemark() { return _numremark; }
        public uint GetZero() { return _zero; }
        public uint GetNumHet() { return _numhet; }
        public uint GetNumHelix () { return _numhelix; }

        public uint GetNumSheet() { return _numsheet; }
        public uint GetNumTurn() { return _numturn; }
        public uint GetNumSite() { return _numsite; }
        public uint GetNumXform() { return _numxform; }

        public uint GetNumCoord() { return _numcoord; }
        public uint GetNumTer() { return _numter; }
        public uint GetNumConect() { return _numconect; }
        public uint GetNumSeq() { return _numseq; }

    }
}
