using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Crystallographic
{
    class Mtrixn
    {

        private uint _serialnum;
        private double _mn1;
        private double _mn2;
        private double _mn3;
        private double _vn;
        private bool _igiven;

        public Mtrixn(uint serialnum, double mn1, double mn2, double mn3, double vn, bool igiven)
        {
            _serialnum = serialnum;
            _mn1 = mn1;
            _mn2 = mn2;
            _mn3 = mn3;
            _vn = vn;
            _igiven = igiven;
        }

        public uint GetSerialNum() { return _serialnum; }
        public double GetMn1() { return _mn1; }
        public double GetMn2() { return _mn2; }
        public double GetMn3() { return _mn3; }
        public double GetVn() { return _vn; }
        public bool GetIGiven() { return _igiven; }
    }
}
