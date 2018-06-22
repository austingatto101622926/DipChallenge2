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
    /// Interaction logic for Clients.xaml
    /// </summary>
    public partial class Clients : Page
    {
        Control Control;
        Client SelectedClient;
        public Clients(Control control)
        {
            InitializeComponent();
            Control = control;
            PopulateElements();
        }

        private async void PopulateElements()
        {
            ClientsListView.ItemsSource = await Control.DH.Client.GET();
        }

        private async void Edit_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            SelectedClient = await Control.DH.Client.GET(int.Parse(button.Tag.ToString()));

            ClientID.Text = SelectedClient.ClientID.ToString();
            GivenName.Text = SelectedClient.GivenName.ToString();
            Surname.Text = SelectedClient.Surname.ToString();
            Gender.Text = SelectedClient.Gender.ToString();
        }

        private void New_Click(object sender, RoutedEventArgs e)
        {
            SelectedClient = null;

            ClientID.Text = "";
            GivenName.Text = "";
            Surname.Text = "";
            Gender.Text = "";
        }

        private async void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (SelectedClient == null)
            {
                SelectedClient = new Client();

                SelectedClient.ClientID = int.Parse(ClientID.Text);
                SelectedClient.GivenName = GivenName.Text;
                SelectedClient.Surname = Surname.Text;
                SelectedClient.Gender = Gender.Text;

                await Control.DH.Client.POST(SelectedClient);
            }
            else
            {
                SelectedClient.ClientID = int.Parse(ClientID.Text);
                SelectedClient.GivenName = GivenName.Text;
                SelectedClient.Surname = Surname.Text;
                SelectedClient.Gender = Gender.Text;

                Control.DH.Client.PUT(SelectedClient.ClientID,SelectedClient);
            }
            PopulateElements();
        }

        private async void Delete_Click(object sender, RoutedEventArgs e)
        {
            await Control.DH.Client.DELETE(SelectedClient.ClientID);
            PopulateElements();
        }
    }
}
