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
using System.Windows.Shapes;

namespace DI05_Tarea_Fernandez_Chacon_EnriqueOctavio.Vistas
{
    /// <summary>
    /// Lógica de interacción para WindowNuevaAplicacion.xaml
    /// </summary>
    public partial class WindowNuevaAplicacion : Window
    {
        public WindowNuevaAplicacion()
        {
            InitializeComponent();
        }

        public void Window_Closed(object sender, EventArgs e)
        {
            Close();
            Owner.Show();
        }
    }
}
