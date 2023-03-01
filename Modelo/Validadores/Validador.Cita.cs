using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DI05_Modelo.Modelos
{
    public partial class Cita : INotifyPropertyChanged, ICloneable, IDataErrorInfo
    {
        public string Error => throw new NotImplementedException();

        public event PropertyChangedEventHandler? PropertyChanged;

        public object Clone()
        {
            return MemberwiseClone();
        }

        public string this[string columnName]
        {
            get
            {
                string result = string.Empty;
                switch (columnName)
                {
                    case "Fecha":
                        if (Fecha == null)
                            result = "La fecha no puede estar vacía";
                        break;
                    case "Hora":
                        if (Hora == null)
                            result = "La hora no puede estar vacía";
                        else if (Hora < new TimeSpan(9, 0, 0) || Hora > new TimeSpan(20, 0, 0))
                            result = "La hora no es válida";
                        break;
                    case "FormaPago":
                        if (string.IsNullOrEmpty(FormaPago))
                            result = "La forma de pago no puede estar vacía";
                        else if (FormaPago != "Efectivo" && FormaPago != "Tarjeta" && FormaPago != "Transferencia")
                            result = "La forma de pago no es válida";
                        break;
                    case "IdCliente":
                        if (IdCliente == 0)
                            result = "El cliente no puede estar vacío";
                        break;
                    case "IdTratamiento":
                        if (IdTratamiento == 0)
                            result = "El tratamiento no puede estar vacío";
                        break;
                }
                return result;
            }
        }   
    }
}
