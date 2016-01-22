using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace Status
{
    /// <summary>
    /// Interaction logic for ucStatus.xaml
    /// </summary>
    public partial class ucStatus : UserControl
    {
        public ucStatus()
        {
            try
            {
                InitializeComponent();
            //    m_DataStub = new DataStub();
            //    this.DataContext = m_DataStub;

            //    image.Source = new BitmapImage(new Uri(m_DataStub.imagefile, UriKind.Relative));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

       // public DataStub m_DataStub;
    }
}
