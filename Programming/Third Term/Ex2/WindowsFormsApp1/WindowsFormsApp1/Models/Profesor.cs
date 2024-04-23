using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2.Models
{
    public class Profesor
    {
        // Miembros
        private string _Dni, _Nombre, _Apellidos, _Tlf, _EMail;

        // Propiedades
        public string Dni
        {
            get { return _Dni; }
            set { _Dni = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        // Otra posible forma de hacer la propiedad
        public string Apellidos
        {
            get => _Apellidos;
            set => _Apellidos = value;
        }
        public string Tlf
        {
            get => _Tlf;
            set => _Tlf = value;
        }
        public string eMail
        {
            get => _EMail;
            set => _EMail = value;
        }

        // Constructor
        public Profesor(string Dni, string Nombre, string Apellidos,
        string Tlf, string eMail)
        {
            _Dni = Dni;
            _Nombre = Nombre;
            _Apellidos = Apellidos;
            _Tlf = Tlf;
            _EMail = eMail;
        }
    }
}
