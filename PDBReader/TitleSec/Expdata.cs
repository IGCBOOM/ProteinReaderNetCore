namespace PDBReader.TitleSec
{
    class Expdata
    {

        private ushort _cont;
        private string _tech;

        public Expdata(ushort cont, string tech)
        {
            _cont = cont;
            _tech = tech;
        }

        public ushort GetCont() { return _cont; }
        public string GetTech() { return _tech; }

    }
}
