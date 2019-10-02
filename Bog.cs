using System;

namespace ObligatoriskOpgave
{
    public class Bog
    {
        private string _titel;
        private string _forfatter;
        private int _sidetal;
        private string _isbn13;

        public Bog(string titel, string forfatter, int sidetal, string isbn13)
        {
            _titel = titel;
            _forfatter = forfatter;
            _sidetal = sidetal;
            _isbn13 = isbn13;
        }

        public string Titel
        {
            get { return _titel; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _titel = value;
            }
        }
        public string Forfatter
        {
            get { return _forfatter; }
            set { _forfatter = value; }
        }

        public int Sidetal
        {
            get { return _sidetal; }
            set
            {
                if (value < 10 || value > 1000)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _sidetal = value;
            }
        }

        public string Isbn13
        {
            get { return _isbn13; }
            set
            {
                if (value.Length != 13)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _isbn13 = value;
            }
        } 
    }
}
