namespace PDBReader.TitleSec
{
    class Author
    {

        private ushort _cont;
        private string _auth;

        public Author(ushort cont, string auth)
        {
            _cont = cont;
            _auth = auth;
        }

        public ushort GetCont() { return _cont; }
        public string GetAuth() { return _auth; }

    }
}
