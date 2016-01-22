using System;

using System.Windows.Media.Imaging;
namespace Status
{
    public class DataStub
    {
        private string _localAlias = "Local Alias sample data";
        public string localAlias
        {
            get
            {
                return _localAlias;
            }
            set
            {
                _localAlias = value;
            }
        }

        private string _netAlias = "Network Alias sample data";
        public string netAlias
        {
            get
            {
                return _netAlias;
            }
            set
            {
                _netAlias = value;
            }
        }

        private string _lastAction = "Last Action sample data";
        public string lastAction
        {
            get
            {
                return _lastAction;
            }
            set
            {
                _lastAction = value;
            }
        }

        private DateTime _lastDateTime = DateTime.Now;
        public DateTime lastDateTime
        {
            get
            {
                return _lastDateTime;
            }
            set
            {
                _lastDateTime = value;
            }
        }
        public string imagefile = "../images/dev.png";

        public DataStub(string _id)
        {
            _localAlias = _id;
        }

        public BitmapImage theImage
        {
            get
            {
                return new BitmapImage(new Uri(imagefile, UriKind.Relative));
            }
        }
    }
}
