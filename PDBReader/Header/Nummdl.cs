using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Header
{
    class Nummdl
    {

        private uint _number;

        public Nummdl(uint number)
        {
            _number = number;
        }

        public uint GetNumber() { return _number; }

    }
}
