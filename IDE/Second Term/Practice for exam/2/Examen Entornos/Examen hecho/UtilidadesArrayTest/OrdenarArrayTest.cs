namespace UtilidadesArrayTest
{
    using UtilidadesArray;

    [TestClass]
    public class OrdenarArrayTest
    {
        [TestMethod]
        public void TestExistenLosValores()
        {
            int[] array = { 78, 55, 45, 98, 13 };
            int[] arraySalida;

            UtilidadesArray utilidades = new UtilidadesArray();
            arraySalida = utilidades.OrdenarArray(array);

            Assert.AreEqual(arraySalida[0], 13);
            Assert.AreEqual(arraySalida[1], 45);
            Assert.AreEqual(arraySalida[2], 55);
            Assert.AreEqual(arraySalida[3], 78);
            Assert.AreEqual(arraySalida[4], 98);
        }

        [TestMethod]
        public void TestNoExistenLosValores()
        {
            int[] array = { 78, 55, 45, 98, 13 };
            int[] arraySalida;

            UtilidadesArray utilidades = new UtilidadesArray();
            arraySalida = utilidades.OrdenarArray(array);

            Assert.AreNotEqual(arraySalida[0], 14);
            Assert.AreNotEqual(arraySalida[1], 46);
            Assert.AreNotEqual(arraySalida[2], 56);
            Assert.AreNotEqual(arraySalida[3], 79);
            Assert.AreNotEqual(arraySalida[4], 99);
        }

        [TestMethod]
        public void TestArrayNulo()
        {
            int[] array = null;

            UtilidadesArray utilidades = new UtilidadesArray();

            Assert.ThrowsException<ArgumentNullException>(() => utilidades.OrdenarArray(array));
        }

        [TestMethod]
        public void TestArrayVacio()
        {
            int[] array = { };
            int[] arraySalida;

            UtilidadesArray utilidades = new UtilidadesArray();
            arraySalida = utilidades.OrdenarArray(array);

            Assert.ThrowsException<ArgumentOutOfRangeException>(() => utilidades.OrdenarArray(array));
        }
    }
}