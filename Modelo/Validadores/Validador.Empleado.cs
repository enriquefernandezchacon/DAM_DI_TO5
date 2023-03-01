

using System.ComponentModel;
using System.Text.RegularExpressions;

namespace DI05_Modelo.Modelos
{
    public partial class Empleado : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        public string Error => throw new NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;
                switch (columnName)
                {
                    case "Nombre":
                        if (string.IsNullOrEmpty(Nombre))
                            result = "El nombre no puede estar vacío";
                        break;
                    case "Apellidos":
                        if (string.IsNullOrEmpty(Apellidos))
                            result = "Los apellidos no pueden estar vacíos";
                        break;
                    case "Dni":
                        if (string.IsNullOrEmpty(Dni))
                            result = "El DNI no puede estar vacío";
                        else if (!Regex.IsMatch(Dni, @"^[0-9]{8}[A-Z]$"))
                            result = "El DNI no es válido";
                        break;
                    case "Email":
                        if (string.IsNullOrEmpty(Email))
                            result = "El email no puede estar vacío";
                        else if (!Regex.IsMatch(Email, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
                            result = "El email no es válido";
                        break;
                    case "Telefono":
                        if (string.IsNullOrEmpty(Telefono))
                            result = "El teléfono no puede estar vacío";
                        else if (!Regex.IsMatch(Telefono, @"^[0-9]{9}$"))
                            result = "El teléfono no es válido";
                        break;
                    case "Puesto":
                        if (string.IsNullOrEmpty(Puesto))
                            result = "El puesto no puede estar vacío";
                        break;
                }
                return result;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public object Clone()
        {
            return MemberwiseClone();
        }
    }
}
