namespace PDBReader.TitleSec
{
    class Source
    {

        private ushort _cont;
        private string _src;

        public Source(ushort cont, string src)
        {
            _cont = cont;
            _src = src;
        }

        public ushort GetCont() { return _cont; }
        public string GetSrc() { return _src; }

    }
}
