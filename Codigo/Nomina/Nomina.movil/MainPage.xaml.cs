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
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnAdministrar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/AdministrarPerfil.xaml", UriKind.Relative));
        }

        private void BtnValores_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/IngresarValores.xaml", UriKind.Relative));
        }

        private void BtnInformes_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/GenerarInforme.xaml", UriKind.Relative));
        }

        private void BtnAcercade_Click(object sender, System.EventArgs e)
        {
            NavigationService.Navigate(new Uri("/AcercaDe.xaml", UriKind.Relative));
        }


    }
}