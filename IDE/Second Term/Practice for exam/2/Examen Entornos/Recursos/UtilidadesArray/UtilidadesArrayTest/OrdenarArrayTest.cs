namespace UtilidadesArrayTest
{
    using UtilidadesArray;

    [TestClass]
    public class OrdenarArrayTest
    {
        [TestMethod]
        public void OrdenarArrayConNumeros()
        {
            int[] array = { 78, 55, 45, 98, 13 };
            int[] array2;

            UtilidadesArray utilidades = new UtilidadesArray();
            array2 = utilidades.OrdenarArray(array);

            Assert.AreEqual(array2[0], 13);
            Assert.AreEqual(array2[1], 45);
            Assert.AreEqual(array2[2], 55);
            Assert.AreEqual(array2[3], 78);
            Assert.AreEqual(array2[4], 98);
        }
        [TestMethod]
        public void OrdenarArrayConNegativosIncluidos()
        {
            int[] array = { -5, 55, -8, 98, -1 };
            int[] array2;

            UtilidadesArray utilidades = new UtilidadesArray();
            array2 = utilidades.OrdenarArray(array);

            Assert.AreEqual(array2[0], -8);
            Assert.AreEqual(array2[1], -5);
            Assert.AreEqual(array2[2], -1);
            Assert.AreEqual(array2[3], 55);
            Assert.AreEqual(array2[4], 98);
        }
        [TestMethod]
        public void OrdenarArrayConMayorAlInicio()
        {
            int[] array = { 98, 55, 45, 78, 13 };
            int[] array2;

            UtilidadesArray utilidades = new UtilidadesArray();
            array2 = utilidades.OrdenarArray(array);

            Assert.AreEqual(array2[0], 13);
            Assert.AreEqual(array2[1], 45);
            Assert.AreEqual(array2[2], 55);
            Assert.AreEqual(array2[3], 78);
            Assert.AreEqual(array2[4], 98);
        }
        [TestMethod]
        public void OrdenarArrayConMayorAlFinal()
        {
            int[] array = { 13, 55, 45, 78, 98 };
            int[] array2;

            UtilidadesArray utilidades = new UtilidadesArray();
            array2 = utilidades.OrdenarArray(array);

            Assert.AreEqual(array2[0], 13);
            Assert.AreEqual(array2[1], 45);
            Assert.AreEqual(array2[2], 55);
            Assert.AreEqual(array2[3], 78);
            Assert.AreEqual(array2[4], 98);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void OrdenarArrayVacio()
        {
            int[] array = { };
            int[] array2;

            UtilidadesArray utilidades = new UtilidadesArray();
            array2 = utilidades.OrdenarArray(array);

            Assert.AreEqual(array2[0], 13);

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void OrdenarArrayNulo()
        {
            int[] array = null;
            int[] array2;

            UtilidadesArray utilidades = new UtilidadesArray();
            array2 = utilidades.OrdenarArray(array);

            Assert.AreEqual(array2[0], 13);
        }
        

    }
}