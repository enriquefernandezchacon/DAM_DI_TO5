using DI05_Modelo.Modelos;
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
        public MainWindow()
        {
            InitializeComponent();
            CitasContext context = new CitasContext();
            Cliente cliente = new Cliente()
            {
                Id = 1,
                Nombre = "Enrique",
                Apellidos = "Fernandez Chacon",
                Email = "di@dam.com",
                Telefono = "695665665"
            };
            context.Clientes.Add(cliente);
            context.SaveChanges();
        }
    }
}
