namespace PDBReader.TitleSec
{
    class Caveat
    {

        private ushort _cont;
        private string _id;
        private string _comment;

        public Caveat(ushort cont, string id, string comment)
        {
            _cont = cont;
            _id = id;
            _comment = comment;
        }

        public ushort GetCont() { return _cont; }
        public string GetId() { return _id; }
        public string GetComment() { return _comment; }

    }
}
