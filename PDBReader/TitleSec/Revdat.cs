﻿namespace PDBReader.TitleSec
{
    class Revdat
    {

        private uint _modnum;
        private ushort _cont;
        private string _date;
        private string _modid;
        private int _modtype;
        private string _record1;
        private string _record2;
        private string _record3;
        private string _record4;

        public Revdat(uint modnum, ushort cont, string date, string modid, int modtype, string record1, string record2, string record3, string record4)
        {
            _modnum = modnum;
            _cont = cont;
            _date = date;
            _modid = modid;
            _modtype = modtype;
            _record1 = record1;
            _record2 = record2;
            _record3 = record3;
            _record4 = record4;
        }

        public uint GetModNum() { return _modnum; }
        public ushort GetCont() { return _cont; }
        public string GetDate() { return _date; }
        public string GetModId() { return _modid; }
        public int GetModType() { return _modtype; }
        public string GetRecord1() { return _record1; }
        public string GetRecord2() { return _record2; }
        public string GetRecord3() { return _record3; }
        public string GetRecord4() { return _record4; }

    }
}
