namespace PDBReader.TitleSec
{
    class Expdata
    {

        private string _cont;
        private string _tech;

        public Expdata(string cont, string tech)
        {
            _cont = cont;
            _tech = tech;
        }

        public string GetCont() { return _cont; }
        public string GetTech() { return _tech; }

    }
}
