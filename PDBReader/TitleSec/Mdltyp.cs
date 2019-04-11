namespace PDBReader.TitleSec
{
    class Mdltyp
    {

        private string _cont;
        private string _comment;

        public Mdltyp(string cont, string comment)
        {
            _cont = cont;
            _comment = comment;
        }

        public string GetCont() { return _cont; }
        public string GetComment() { return _comment; }

    }
}
