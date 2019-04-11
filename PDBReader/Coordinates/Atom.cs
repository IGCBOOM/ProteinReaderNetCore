

namespace PDBReader.Coordinates
{
    class Atom
    {

        private uint _atomserial;
        private string _atomname;
        private char _altpos;
        private string _resname;
        private char _chainid;
        private uint _resseq;
        private char _rescode;
        private Vector3 _position;
        private double _occupancy;
        private double _tempFactor;
        private string _vanity;
        private int _charge;
        private bool _het;

        public Atom(uint atomserial, string atomname, char altpos, string resname, char chainid, uint resseq, char rescode, Vector3 position, double occupancy, double tempFactor, string vanity, int charge, bool het)
        {
            _atomserial = atomserial;
            _atomname = atomname;
            _altpos = altpos;
            _resname = resname;
            _chainid = chainid;
            _resseq = resseq;
            _rescode = rescode;
            _position = position;
            _occupancy = occupancy;
            _tempFactor = tempFactor;
            _vanity = vanity;
            _charge = charge;
            _het = het;
        }

        public string getVanity() { return _vanity; }

    }
}
