namespace PDBReader.TitleSec
{
    class Title
    {

        private ushort _cont;
        private string _title;

        public Title(ushort cont, string title)
        {
            _cont = cont;
            _title = title;
        }

        public ushort GetCont() { return _cont; }
        public string GetTitle() { return _title; }

    }
}
