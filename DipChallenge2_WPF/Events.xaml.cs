using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DipChallenge2_DataAccess;

namespace DipChallenge2_WPF
{
    /// <summary>
    /// Interaction logic for Events.xaml
    /// </summary>
    public partial class Events : Page
    {
        Control Control;
        public Events(Control control)
        {
            InitializeComponent();
            Control = control;
            PopulateElements();
        }

        private async void PopulateElements()
        {
            EventsListView.ItemsSource = await Control.DH.Event.GET();
        }

        private void Bookings_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;

        }
    }
}
