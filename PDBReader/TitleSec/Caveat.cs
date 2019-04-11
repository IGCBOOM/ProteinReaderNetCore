namespace PDBReader.TitleSec
{
    class Caveat
    {

        private string _cont;
        private string _id;
        private string _comment;

        public Caveat(string cont, string id, string comment)
        {
            _cont = cont;
            _id = id;
            _comment = comment;
        }

        public string GetCont() { return _cont; }
        public string GetId() { return _id; }
        public string GetComment() { return _comment; }

    }
}
