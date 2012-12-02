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
    public partial class Page5 : PhoneApplicationPage
    {
        public Page5()
        {
            InitializeComponent();
        }

        private void BtnGuardarI_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Los datos Fueron Guardados");
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
            
        }

        private void BtnCancelarI_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Los datos no se guardarán");
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }
    }
}