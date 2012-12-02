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
            
            

          

            this.LblCedula.Visibility = Visibility.Collapsed;
            this.TxtCedula.Visibility = Visibility.Collapsed;
            this.LblNombre.Visibility = Visibility.Collapsed;
            this.TxtNomEmpleado.Visibility = Visibility.Collapsed;
            this.LblSalario.Visibility = Visibility.Collapsed;
            this.TxtSalario.Visibility = Visibility.Collapsed;
            this.LblVlrDia.Visibility = Visibility.Collapsed;
            this.TxtVlrDia.Visibility = Visibility.Collapsed;
            this.LblVlrHora.Visibility = Visibility.Collapsed;
            this.TxtVlrHora.Visibility = Visibility.Collapsed;
        }


        private void BtnGuardar_Click(object sender, System.EventArgs e)
        {

            using (BaseDatosDataContext contexto
                = new BaseDatosDataContext(App.cadenaConexion))
                
            
            


            
            
            if (RbnEmpleado.IsChecked==true)
            {
                Persona perfil = new Persona();
                TipoTrabajador trabajador = new TipoTrabajador();
                var consulta = (from p in contexto.TipoTrabajador
                                select p).ToList();

                if (consulta.Count ==0)
                {
                    trabajador.ID = "1";
                    trabajador.Descripcion = "Empleado";
                    contexto.TipoTrabajador.InsertOnSubmit(trabajador);
                    contexto.SubmitChanges();
                }
                perfil.Cedula = Convert.ToString(TxtCedula.Text);
                perfil.Nombre = Convert.ToString(TxtNomEmpleado.Text);
                perfil.Salario = Convert.ToInt32(TxtSalario.Text);
                perfil.IdTipoTrabajador = "1";
                contexto.Persona.InsertOnSubmit(perfil);
                contexto.SubmitChanges();
                MessageBox.Show("la cedula es: " + perfil.Cedula);
                MessageBox.Show("el Id es:" + perfil.IdTipoTrabajador);

                
            }

            using (BaseDatosDataContext contexto
               = new BaseDatosDataContext(App.cadenaConexion))

            if (RbnIndependiente.IsChecked==true)
            {
                Persona perfil = new Persona();
                TipoTrabajador trabajador = new TipoTrabajador();
                var consulta = (from p in contexto.TipoTrabajador
                                select p).ToList();

                if (consulta.Count == 0)
                {
                    trabajador.ID = "2";
                    trabajador.Descripcion = "Independiente";
                    contexto.TipoTrabajador.InsertOnSubmit(trabajador);
                    contexto.SubmitChanges();
                }
                perfil.Cedula = Convert.ToString(TxtCedula);
                perfil.Nombre = Convert.ToString(TxtNomEmpleado);
                perfil.VlrDia = Convert.ToInt32(TxtVlrDia.Text);
                perfil.VlrHora = Convert.ToInt32(TxtVlrHora.Text);
                trabajador.ID = Convert.ToString("2");
                trabajador.Descripcion = Convert.ToString("Independiente");
                contexto.TipoTrabajador.InsertOnSubmit(trabajador);
                contexto.Persona.InsertOnSubmit(perfil);
                contexto.SubmitChanges();
            }
           
            MessageBox.Show("Los Datos fueron Guardados");
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));

        }

        private void BtnCancelar_Click(object sender, System.EventArgs e)
        {
            MessageBox.Show("Los Datos no se Guardaron");
            NavigationService.Navigate(new Uri("/MainPage.xaml", UriKind.Relative));
        }

        private void RbnEmpleado_Click(object sender, RoutedEventArgs e)
        {

            this.LblCedula.Visibility = Visibility.Visible;
            this.TxtCedula.Visibility = Visibility.Visible;
            this.LblNombre.Visibility = Visibility.Visible;
            this.TxtNomEmpleado.Visibility = Visibility.Visible;
            this.LblSalario.Visibility = Visibility.Visible;
            this.TxtSalario.Visibility = Visibility.Visible;

            this.LblVlrDia.Visibility = Visibility.Collapsed;
            this.TxtVlrDia.Visibility = Visibility.Collapsed;
            this.LblVlrHora.Visibility = Visibility.Collapsed;
            this.TxtVlrHora.Visibility = Visibility.Collapsed;


        }

        private void RbnIndependiente_Click(object sender, RoutedEventArgs e)
        {

            this.LblCedula.Visibility = Visibility.Visible;
            this.TxtCedula.Visibility = Visibility.Visible;
            this.LblNombre.Visibility = Visibility.Visible;
            this.TxtNomEmpleado.Visibility = Visibility.Visible;
            this.LblVlrDia.Visibility = Visibility.Visible;
            this.TxtVlrDia.Visibility = Visibility.Visible;
            this.LblVlrHora.Visibility = Visibility.Visible;
            this.TxtVlrHora.Visibility = Visibility.Visible;

            this.LblSalario.Visibility = Visibility.Collapsed;
            this.TxtSalario.Visibility = Visibility.Collapsed;
            


        }

    }
}