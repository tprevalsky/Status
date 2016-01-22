using System.Collections.ObjectModel;
using System.Windows.Controls;

namespace Status
{
    /// <summary>
    /// Interaction logic for ucStatList.xaml
    /// </summary>
    public partial class ucStatList : UserControl
    {
        public ucStatList()
        {
            InitializeComponent();
            this.DataContext = this;

            m_sample.Add(new DataStub("The first one"));
            m_sample.Add(new DataStub("The second one"));
        }

        private ObservableCollection<DataStub> p_sample = new ObservableCollection<DataStub>();
        public ObservableCollection<DataStub> m_sample
        {
            get
            {
                return p_sample;
            }
            set
            {
                p_sample = value;
            }
        }
    }
}
