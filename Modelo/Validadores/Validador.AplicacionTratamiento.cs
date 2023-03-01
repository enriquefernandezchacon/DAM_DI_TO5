using System.ComponentModel;

namespace DI05_Modelo.Modelos
{
    public partial class AplicacionTratamiento : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        public string Error => throw new System.NotImplementedException();

        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;
                switch (columnName)
                {
                    case "IdCliente":
                        if (IdCliente <= 0)
                            result = "El cliente no puede estar vacío";
                        break;
                    case "IdTratamiento":
                        if (IdTratamiento <= 0)
                            result = "El tratamiento no puede estar vacío";
                        break;
                    case "IdTrabajador":
                        if (IdTrabajador <= 0)
                            result = "El trabajador no puede estar vacío";
                        break;
                    case "Coste":
                        if (Coste <= 0)
                            result = "El coste debe ser mayor que 0";
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
