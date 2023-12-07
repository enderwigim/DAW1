using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jarra
{
    public class Jarra
    {
        private int _capacity;
        private int _cantidad;

        public Jarra()
        {
            _capacity = 100;
            _cantidad = 20;
        }
        public int GetCapacidadMaxima()
        {
            return _capacity;
        }
        public void SetCapacidadMaxima(int capacity)
        {
            _capacity = capacity;
            
        }
        public void AumentarCapacidadMaxima(int capacity)
        {
            _capacity += capacity;
        }
        public int GetCantidad()
        {
            return _cantidad;
        }
        public void SetCantidad(int newValue)
        {
            _cantidad = newValue;
        }
        public void AumentarCantidad(int cantidad)
        {
            _cantidad += cantidad;
        }
        public string GetPercentage()
        {
            string percentage = "";
            double resultado;

            resultado = (_cantidad * 100) / _capacity;

            percentage = resultado + "%";
            return percentage;
        }

    }

    
}
