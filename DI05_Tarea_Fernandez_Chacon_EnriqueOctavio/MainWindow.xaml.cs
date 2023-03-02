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
        private CitasContext context;
        public MainWindow()
        {
            InitializeComponent();
            context = new CitasContext();
        }

        public void VerClientes_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void NuevaCita_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void NuevoCliente_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AcercaDe_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Aplicación de gestión de citas creada por Enrique Octavio Fernández Chacón para la tarea online 5 de Diseño de Interfaces", "Acerca de", MessageBoxButton.OK, MessageBoxImage.Information);
        }


    }
}
