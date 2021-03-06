﻿using System;
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

namespace DipChallenge2_WPF
{
    /// <summary>
    /// Interaction logic for Home.xaml
    /// </summary>
    public partial class Home : Page
    {
        Control Control;
        public Home()
        {
            InitializeComponent();
            Control = new Control(this);
        }

        private void Events_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Control.Events);
        }

        private void Bookings_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Control.Bookings);
        }

        private void Clients_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(Control.Clients);
        }
    }
}
