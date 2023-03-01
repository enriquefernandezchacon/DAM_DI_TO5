using DI05_Modelo.Modelos;
using DI05_Tarea_Fernandez_Chacon_EnriqueOctavio.Services;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace DI05_Tarea_Fernandez_Chacon_EnriqueOctavio.Vistas
{
    /// <summary>
    /// Lógica de interacción para WindowClienteNuevo.xaml
    /// </summary>
    public partial class WindowClienteNuevo : Window
    {
        private CitasContext context;
        private ClientesService service;
        private Cliente cliente;
        private int errores;
        public WindowClienteNuevo(CitasContext context)
        {
            InitializeComponent();
            cliente = new Cliente();
            service = new ClientesService(context);
            errores = 0;
            this.context = context;
            DataContext = cliente;
        }

        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
                errores++;
            else
                errores--;

            if (errores == 0)
                btAceptar.IsEnabled = true;
            else
                btAceptar.IsEnabled = false;

        }

        //Comprobacion del nombre
        private void TextBoxNombre_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxNombre.Text))
            {
                MessageBox.Show("Debes completar el campo nombre", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //Comprobacion de los apellidos
        private void TextBoxApellidos_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TextBoxApellidos.Text))
            {
                MessageBox.Show("Debes completar el campo apellido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //Comprobacion de email
        private void TextBoxEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            //Que no este vacío
            if (string.IsNullOrEmpty(TextBoxEmail.Text))
            {
                MessageBox.Show("Debes completar el campo email", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else if (!Regex.IsMatch(TextBoxEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                MessageBox.Show("El email no es válido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //Comprobacion de telefono
        private void TextBoxTelefono_LostFocus(object sender, RoutedEventArgs e)
        {
            //Que no este vacío
            if (string.IsNullOrEmpty(TextBoxTelefono.Text))
            {
                MessageBox.Show("Debes completar el campo telefono", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            } else if (!Regex.IsMatch(TextBoxTelefono.Text, @"^[0-9]{9}$"))
            {
                MessageBox.Show("El telefono no es válido", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BTAceptarClick(object sender, RoutedEventArgs e)
        {
            service.Add(cliente);
            Close();
        }

        private void BTCancelarClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        //Cuando se cierra la ventana, se muestra la ventana padre
        private void Window_Closed(object sender, EventArgs e)
        {
            Owner.Show();
        }
    }
}
