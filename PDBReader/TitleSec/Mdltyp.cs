namespace PDBReader.TitleSec
{
    class Mdltyp
    {

        private ushort _cont;
        private string _comment;

        public Mdltyp(ushort cont, string comment)
        {
            _cont = cont;
            _comment = comment;
        }

        public ushort GetCont() { return _cont; }
        public string GetComment() { return _comment; }

    }
}
