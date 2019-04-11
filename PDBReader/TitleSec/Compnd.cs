namespace PDBReader.TitleSec
{
    class Compnd
    {

        private string _cont;
        private string _comp;

        public Compnd(string cont, string comp)
        {
            _cont = cont;
            _comp = comp;
        }

        public string GetCont() { return _cont; }
        public string GetComp() { return _comp; }

    }
}
