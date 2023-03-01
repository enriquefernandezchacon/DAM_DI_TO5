using System.ComponentModel;

namespace DI05_Modelo.Modelos
{
    public partial class Cliente : INotifyPropertyChanged, ICloneable, IDataErrorInfo
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
                    case "Email":
                        if (string.IsNullOrEmpty(Email))
                            result = "El email no puede estar vacío";
                        break;
                    case "Telefono":
                        if (string.IsNullOrEmpty(Telefono))
                            result = "El teléfono no puede estar vacío";
                        break;
                }
                return result;
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
