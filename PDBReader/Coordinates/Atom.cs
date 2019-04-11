

namespace PDBReader.Coordinates
{
    class Atom
    {

        uint AtomSerial;
        string AtomName;
        char AltPos;
        string ResName;
        char ChainID;
        uint ResSeq;
        char ResCode;
        Vector3 Position;
        float Occupancy;
        float TempFactor;
        string Vanity;
        int Charge;

        public Atom(uint atomSerial, string atomName, char altPos, string resName, char chainID, uint resSeq, char resCode, Vector3 position, float occupancy, float tempFactor, string vanity, int charge)
        {
            AtomSerial = atomSerial;
            AtomName = atomName;
            AltPos = altPos;
            ResName = resName;
            ChainID = chainID;
            ResSeq = resSeq;
            ResCode = resCode;
            Position = position;
            Occupancy = occupancy;
            TempFactor = tempFactor;
            Vanity = vanity;
            Charge = charge;
        }

    }
}
