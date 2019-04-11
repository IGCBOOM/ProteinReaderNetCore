

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
        private Color _col;

        public Atom(uint atomserial, string atomname, char altpos, string resname, char chainid, uint resseq, char rescode, Vector3 position, double occupancy, double tempFactor, string vanity, int charge, bool het, Color col)
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
            _col = col;
        }

        public uint GetAtomSerial() { return _atomserial; }
        public string GetAtomName() { return _atomname; }
        public char GetAltPos() { return _altpos; }
        public string GetResName() { return _resname; }
        public char GetChainId() { return _chainid; }
        public uint GetResSeq() { return _resseq; }
        public char GetResCode() { return _rescode; }
        public Vector3 GetPosition() { return _position; }
        public double GetOccupancy() { return _occupancy; }
        public double GetTempFactor() { return _tempFactor; }
        public string GetVanity() { return _vanity; }
        public int GetCharge() { return _charge; }
        public bool GetHet() { return _het; }
        public Color GetCol() { return _col; }

    }
}
