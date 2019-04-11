using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Coordinates
{
    class Model
    {

        private int _serial;

        public Model(int serial)
        {
            _serial = serial;
        }

        public int GetSerial() { return _serial; }

    }
}
