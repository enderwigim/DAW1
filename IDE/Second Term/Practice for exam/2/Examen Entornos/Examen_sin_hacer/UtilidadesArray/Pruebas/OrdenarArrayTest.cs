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
        [ExpectedException(typeof(ArgumentNullException))]
        public void OrdenarArrayVacio()
        {
            int[] array = {};
            int[] array2;

            UtilidadesArray utilidades = new UtilidadesArray();
            array2 = utilidades.OrdenarArray(array);

            Assert.AreEqual(array2[0], 13);
            
        }
        
    }
}