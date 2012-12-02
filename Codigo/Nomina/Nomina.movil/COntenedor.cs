using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace Nomina.movil
{
    public class COntenedor:INotifyPropertyChanged
    {

        private ObservableCollection<Persona> listaPersonas = new ObservableCollection<Persona>();

        public ObservableCollection<Persona> ListaPersonas
        {
            get { return listaPersonas; }
            set
            {
                listaPersonas = value;
                NotificarCambio("ListaPersonas");

            }
        }

        private Persona personaSelecc = new Persona();

        public Persona personaSeleccionada
        {
            get { return personaSelecc; }
            set
            {
                personaSelecc = value;
                NotificarCambio("personaSeleccionada");

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotificarCambio(string propiedad)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
        }
    }
}
