namespace PDBReader.TitleSec
{
    class Keywds
    {

        private ushort _cont;
        private string _keywds;

        public Keywds(ushort cont, string keywds)
        {
            _cont = cont;
            _keywds = keywds;
        }

        public ushort GetCont() { return _cont; }
        public string GetKeywds() { return _keywds; }

    }
}
