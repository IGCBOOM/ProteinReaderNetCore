namespace PDBReader.TitleSec
{
    class Header
    {

        private string _classification;
        private string _date;
        private string _id;

        public Header(string classification, string date, string id)
        {
            _classification = classification;
            _date = date;
            _id = id;
        }

        public string GetClassification() { return _classification; }
        public string GetDate() { return _date; }
        public string GetId() { return _id; }

    }
}
