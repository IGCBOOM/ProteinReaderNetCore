using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Crystallographic
{
    class Scalen
    {

        private double _sn1;
        private double _sn2;
        private double _sn3;
        private double _un;

        public Scalen(double sn1, double sn2, double sn3, double un)
        {
            _sn1 = sn1;
            _sn2 = sn2;
            _sn3 = sn3;
            _un = un;
        }

        public double getsn1() { return _sn1; }
        public double getsn2() { return _sn2; }
        public double getsn3() { return _sn3; }
        public double getun() { return _un; }

    }
}
