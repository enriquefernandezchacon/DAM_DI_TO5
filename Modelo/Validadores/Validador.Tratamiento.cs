using System.ComponentModel;

namespace DI05_Modelo.Modelos
{
    public partial class Tratamiento : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        public string Error => throw new System.NotImplementedException();

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
                    case "Tipo":
                        if (string.IsNullOrEmpty(Tipo))
                            result = "El tipo no puede estar vacío";
                        break;
                    case "Descripcion":
                        if (string.IsNullOrEmpty(Descripcion))
                            result = "La descripción no puede estar vacía";
                        break;
                    case "Precio":
                        if (Precio <= 0)
                            result = "El precio debe ser mayor que 0";
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
