namespace PDBReader.TitleSec
{
    class Jrnl
    {

        private string _text;

        public Jrnl(string text)
        {
            _text = text;
        }

        public string GetText() { return _text; }

    }
}
