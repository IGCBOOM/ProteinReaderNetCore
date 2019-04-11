using System;

namespace PDBReader.Tools
{
    internal partial class Vector3
    {

        double _x;
        double _y;
        double _z;

        public Vector3(double x, double y, double z)
        {
            this._x = x;
            this._y = y;
            this._z = z;
        }

        public double X() { return _x; }
        public double Y() { return _y; }
        public double Z() { return _z; }

        //Gets distance between Vector3's in units.
        public double GetDist(Vector3 vec1, Vector3 vec2)
        {

            double mathx = vec2._x - vec1._x;
            double mathy = vec2._y - vec1._y;
            double mathz = vec2._z - vec1._z;
            double finalnum;

            mathx = mathx * mathx;
            mathy = mathy * mathy;
            mathz = mathz * mathz;

            finalnum = mathx + mathy + mathz;
            return Math.Sqrt(finalnum);

        }

    }
}
