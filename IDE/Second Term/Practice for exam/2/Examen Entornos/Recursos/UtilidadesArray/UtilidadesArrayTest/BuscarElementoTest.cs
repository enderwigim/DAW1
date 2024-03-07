using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilidadesArrayTest
{
    using UtilidadesArray;

    [TestClass]
    public class BuscarArrayTest
    {
        [TestMethod]
        public void BuscarElementoExistenteArray()
        {
            int[] array = { 33, 66, 99 };
            int posicion;

            UtilidadesArray utilidades = new UtilidadesArray();
            posicion = utilidades.BuscarElementoArray(array, 33);

            Assert.AreEqual(posicion, 0);
        }
        [TestMethod]
        public void BuscarElementoNoExistenteArray()
        {
            int[] array = { 33, 66, 99 };
            int posicion;

            UtilidadesArray utilidades = new UtilidadesArray();
            posicion = utilidades.BuscarElementoArray(array, 88);

            Assert.AreEqual(posicion, -1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void BuscarElementoArrayVacio()
        {
            int[] array = { };
            int posicion;

            UtilidadesArray utilidades = new UtilidadesArray();
            posicion = utilidades.BuscarElementoArray(array, 88);

            Assert.AreEqual(posicion, -1);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void BuscarElementoArrayNulo()
        {
            int[] array = null;
            int posicion;

            UtilidadesArray utilidades = new UtilidadesArray();
            posicion = utilidades.BuscarElementoArray(array, 88);

            Assert.AreEqual(posicion, -1);
        }
    }
}
