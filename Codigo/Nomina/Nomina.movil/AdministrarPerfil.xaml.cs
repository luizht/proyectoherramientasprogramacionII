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
    public partial class Page1 : PhoneApplicationPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void PhoneApplicationPage_Loaded(object sender, RoutedEventArgs e)
        {
           
        }


        private void BtnGuardar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Los Datos fueron Guardados");
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));

        }

        private void BtnCancelar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Los Datos no se Guardaron");
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

    }
}