namespace PDBReader.TitleSec
{
    class Compnd
    {

        private ushort _cont;
        private string _comp;

        public Compnd(ushort cont, string comp)
        {
            _cont = cont;
            _comp = comp;
        }

        public ushort GetCont() { return _cont; }
        public string GetComp() { return _comp; }

    }
}
