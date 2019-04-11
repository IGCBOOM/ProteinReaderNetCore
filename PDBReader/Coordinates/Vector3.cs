namespace PDBReader.Coordinates
{
    internal class Vector3
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

        public double x() { return _x; }
        public double y() { return _y; }
        public double z() { return _z; }

    }
}
