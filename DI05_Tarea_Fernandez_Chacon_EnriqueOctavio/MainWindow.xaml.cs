using DI05_Modelo.Modelos;
using DI05_Tarea_Fernandez_Chacon_EnriqueOctavio.Services;
using DI05_Tarea_Fernandez_Chacon_EnriqueOctavio.Vistas;
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

namespace DI05_Tarea_Fernandez_Chacon_EnriqueOctavio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ClinicaContext context;
        public MainWindow()
        {
            InitializeComponent();
            context = new ClinicaContext();
        }

        public void VerCitas_Click(object sender, RoutedEventArgs e)
        {
            WindowListaCitas windowListaCitas = new WindowListaCitas();
            windowListaCitas.Owner = this;
            windowListaCitas.Show();
            Hide();
        }

        public void VerClientes_Click(object sender, RoutedEventArgs e)
        {
            WindowListaClientes windowListaClientes = new WindowListaClientes();
            windowListaClientes.Owner = this;
            windowListaClientes.Show();
            Hide();                
        }

        public void VerEmpleados_Click(object sender, RoutedEventArgs e)
        {
            WindowListaEmpleados windowListaEmpleados = new WindowListaEmpleados();
            windowListaEmpleados.Owner = this;
            windowListaEmpleados.Show();
            Hide();            
        }

        public void VerTratamientos_Click(object sender, RoutedEventArgs e)
        { 
            WindowListaTratamientos windowListaTratamientos = new WindowListaTratamientos();
            windowListaTratamientos.Owner = this;
            windowListaTratamientos.Show();
            Hide();            
        }

        public void VerAplicacionTratamientos_Click(object sender, RoutedEventArgs e)
        {
            WindowListaAplicacionesTratamiento windowListaAplicacionTratamientos = new WindowListaAplicacionesTratamiento();
            windowListaAplicacionTratamientos.Owner = this;
            windowListaAplicacionTratamientos.Show();
            Hide();                        
        }

        private void NuevaCita_Click(object sender, RoutedEventArgs e)
        {
            WindowNuevaCita windowNuevaCita = new WindowNuevaCita();
            windowNuevaCita.Owner = this;
            windowNuevaCita.Show();
            Hide();            
        }

        private void NuevoCliente_Click(object sender, RoutedEventArgs e)
        {
            WindowNuevoCliente windowNuevoCliente = new WindowNuevoCliente();
            windowNuevoCliente.Owner = this;
            windowNuevoCliente.Show();
            Hide();
        }

        private void NuevoEmpleado_Click(object sender, RoutedEventArgs e)
        {
            WindowNuevoEmpleado windowNuevoEmpleado = new WindowNuevoEmpleado();
            windowNuevoEmpleado.Owner = this;
            windowNuevoEmpleado.Show();
            Hide();
        }

        private void NuevoTratamiento_Click(object sender, RoutedEventArgs e)
        {
            WindowNuevoTratamiento windowNuevoTratamiento = new WindowNuevoTratamiento();
            windowNuevoTratamiento.Owner = this;
            windowNuevoTratamiento.Show();
            Hide();
        }

        private void NuevaAplicacionTratamiento_Click(object sender, RoutedEventArgs e)
        {
            WindowNuevaAplicacion windowNuevaAplicacionTratamiento = new WindowNuevaAplicacion();
            windowNuevaAplicacionTratamiento.Owner = this;
            windowNuevaAplicacionTratamiento.Show();
            Hide();
        }

        private void AcercaDe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Aplicación de gestión de citas creada por Enrique Octavio Fernández Chacón para la tarea online 5 de Diseño de Interfaces", "Acerca de", MessageBoxButton.OK, MessageBoxImage.Information);
        }


    }
}
