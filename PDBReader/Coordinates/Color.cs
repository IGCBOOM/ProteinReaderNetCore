using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Coordinates
{
    class Color
    {

        private float _r;
        private float _g;
        private float _b;
        private float _a;

        public Color(float r, float g, float b, float a)
        {
            _r = r;
            _g = g;
            _b = b;
            _a = a;
        }

        public float GetR() { return _r; }
        public float GetG() { return _g; }
        public float GetB() { return _b; }
        public float GetA() { return _a; }

    }
}
