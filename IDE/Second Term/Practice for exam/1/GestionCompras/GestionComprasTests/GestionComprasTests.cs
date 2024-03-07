using Gestion;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace GestionComprasTests
{
    [TestClass]
    public class GestionComprasTests
    {
        [TestMethod]
        public void RegistrarCompraAgregaProductoInventario()
        {
            // Preparacion
            GestionCompras gestionCompras = new GestionCompras();

            // Actuacion
            gestionCompras.RegistrarCompra("ProductoA", 5);

            // Comprobacion
            Assert.AreEqual(5, gestionCompras.ObtenerInventario("ProductoA"));
        }
        [TestMethod]
        public void RegistrarCompraProductoNoExiste()
        {
            GestionCompras gestionCompras = new GestionCompras();


            gestionCompras.RegistrarCompra("ProductoABC", 5);

            Assert.AreEqual(5, gestionCompras.ObtenerInventario("ProductoABC"));
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RegistrarCompraNegativaProductoInventario()
        {
            GestionCompras gestionCompras = new GestionCompras();

            gestionCompras.RegistrarCompra("ProductoA", -1);

            Assert.AreEqual(-1, gestionCompras.ObtenerInventario("ProductoA"));
        }
        [TestMethod]
        public void DevolucionCompraProductoInventario()
        {
            GestionCompras gestionCompras = new GestionCompras();

            gestionCompras.RegistrarCompra("ProductoA", 5);
            gestionCompras.RegistrarDevolucion("ProductoA", 4);

            Assert.AreEqual(1, gestionCompras.ObtenerInventario("ProductoA"));

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DevolucionCompraProductoInventarioCantidadMayorAStock()
        {
            GestionCompras gestionCompras = new GestionCompras();

            gestionCompras.RegistrarCompra("ProductoA", 5);
            gestionCompras.RegistrarDevolucion("ProductoA", 6);

            Assert.AreEqual(-1, gestionCompras.ObtenerInventario("ProductoA"));

        }
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void DevolucionCompraProductoInventarioNoExiste()
        {
            GestionCompras gestionCompras = new GestionCompras();

            
            gestionCompras.RegistrarDevolucion("ProductoABC", 6);

            Assert.AreEqual(6, gestionCompras.ObtenerInventario("ProductoABC"));

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void DevolucionCompraProductoInventarioCantidadCero()
        {
            GestionCompras gestionCompras = new GestionCompras();

            gestionCompras.RegistrarCompra("ProductoA", 5);
            gestionCompras.RegistrarDevolucion("ProductoA", -1);

            Assert.AreEqual(5, gestionCompras.ObtenerInventario("ProductoA"));

        }

        [TestMethod]
        public void ObtenerInventarioProductoExiste()
        {
            GestionCompras gestionCompras = new GestionCompras();

            gestionCompras.RegistrarCompra("ProductoA", 5);
            int cantidad = gestionCompras.ObtenerInventario("ProductoA");

            Assert.AreEqual(5, cantidad);
        }
        [TestMethod]
        public void ObtenerInventarioProductoNoExiste()
        {
            GestionCompras gestionCompras = new GestionCompras();

            int cantidad = gestionCompras.ObtenerInventario("ProductoA");

            Assert.AreEqual(0, cantidad);
        }
    }
}
