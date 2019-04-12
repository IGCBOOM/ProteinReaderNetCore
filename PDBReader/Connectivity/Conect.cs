using System;
using System.Collections.Generic;
using System.Text;

namespace PDBReader.Connectivity
{
    class Conect
    {

        private uint _serial1;
        private uint _serial2;
        private uint _serial3;
        private uint _serial4;
        private uint _serial5;

        public Conect(uint serial1, uint serial2, uint serial3, uint serial4, uint serial5)
        {
            _serial1 = serial1;
            _serial2 = serial2;
            _serial3 = serial3;
            _serial4 = serial4;
            _serial5 = serial5;
        }

        public uint GetSerial(uint num)
        {

            switch (num)
            {

                case 1:
                    return _serial1;

                case 2:
                    return _serial2;

                case 3:
                    return _serial3;

                case 4:
                    return _serial4;

                case 5:
                    return _serial5;

                default:
                    return 0;

            }

        }

    }
}
