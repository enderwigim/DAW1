using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilidadesArrayTest
{
    using UtilidadesArray;
    internal class BuscarElementoTest
    {
        [TestMethod]
        public void TestBuscarElementoSeEncuentra()
        {
            int[] array = { 78, 55, 45, 98, 13 };
            int salida;

            UtilidadesArray utilidades = new UtilidadesArray();
            salida = utilidades.BuscarElementoArray(array, 78);

            Assert.AreEqual(salida, 1);
        }
        [TestMethod]
        public void TestBuscarElementoNoSeEncuentra()
        {
            int[] array = { 78, 55, 45, 98, 13 };
            int salida;

            UtilidadesArray utilidades = new UtilidadesArray();
            salida = utilidades.BuscarElementoArray(array, 19);

            Assert.AreEqual(salida, -1);
        }
        [TestMethod]
        public void TestArrayNulo()
        {
            int[] array = null;

            UtilidadesArray utilidades = new UtilidadesArray();

            Assert.ThrowsException<ArgumentNullException>(() => utilidades.BuscarElementoArray(array, 5));
        }

        [TestMethod]
        public void TestArrayVacio()
        {
            int[] array = { };
            int[] arraySalida;

            UtilidadesArray utilidades = new UtilidadesArray();
            arraySalida = utilidades.OrdenarArray(array);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => utilidades.BuscarElementoArray(array, 7));
        }
    }
}
