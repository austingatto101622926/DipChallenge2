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
    /// Interaction logic for Bookings.xaml
    /// </summary>
    public partial class Bookings : Page
    {
        Control Control;
        public Bookings(Control control, int? id = null)
        {
            InitializeComponent();
            Control = control;
            PopulateElements(id);
        }

        private async void PopulateElements(int? id)
        {
            List<Booking> bookings = await Control.DH.Booking.GET();
            if (id == null)
            {
                BookingsListView.ItemsSource = bookings;
            }
            else
            {
                BookingsListView.ItemsSource = bookings.Where(B => B.EventID == id);
            }
        }
    }
}
