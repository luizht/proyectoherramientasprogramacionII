using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace Nomina.movil
{
    public partial class PanoramaPage1 : PhoneApplicationPage
    {
        public PanoramaPage1()
        {
            InitializeComponent();
        }

        private void BtnGuardarV_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Los Datos fueron Guardados");
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void BtnCancelarV_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Los Datos no se Guardaron");
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void BtnGuardarI_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Los Datos fueron Guardados");
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));

        }

        private void BtnCancelarI_Click(object sender, RoutedEventArgs e)

        {
            MessageBox.Show("Los Datos no se Guardaron");
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

    }
}