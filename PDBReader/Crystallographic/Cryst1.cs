using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Crystallographic
{
    class Cryst1
    {

        private double _a;
        private double _b;
        private double _c;
        private double _alpha;
        private double _beta;
        private double _gamma;
        private string _sgroup;
        private uint _z;

        public Cryst1(double a, double b, double c, double alpha, double beta, double gamma, string sgroup, uint z)
        {
            _a = a;
            _b = b;
            _c = c;
            _alpha = alpha;
            _beta = beta;
            _gamma = gamma;
            _sgroup = sgroup;
            _z = z;
        }

        public double GetA() { return _a; }
        public double GetB() { return _b; }
        public double GetC() { return _c; }
        public double GetAlpha() { return _alpha; }
        public double GetBeta() { return _beta; }
        public double GetGamma() { return _gamma; }
        public string GetSGroup() { return _sgroup; }
        public uint GetZ() { return _z; }


    }
}
