using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Crystallographic
{
    class Origxn
    {

        private double _on1;
        private double _on2;
        private double _on3;
        private double _tn;

        public Origxn(double on1, double on2, double on3, double tn)
        {
            _on1 = on1;
            _on2 = on2;
            _on3 = on3;
            _tn = tn;
        }

        public double getOn1() { return _on1; }
        public double getOn2() { return _on2; }
        public double getOn3() { return _on3; }
        public double getTn() { return _tn; }

    }
}
