
namespace Cuenta
{
    /// <summary>
    /// <para>Clase que representa una cuenta corriente</para>
    /// </summary>
    public class Cuenta
    {
        /// <summary>
        /// Tiene el campo saldo que representa el saldo de la cuenta, en euros
        /// </summary>
        private decimal saldo;

        /// <summary>
        /// La propiedad saldo devuelve el saldo que hay en la cuenta
        /// </summary>
        /// <value>saldo</value>
        public decimal Saldo
        {
            get { return saldo; }
        }


        /// <summary>
        /// <para>Calcula el ingreso de dinero a la cuenta.</para>
        /// <para>Sumara la cantidad ingresada al saldo de la cuenta.</para>
        /// </summary>
        /// <param>El valor del parámetro <paramref name="cantidad"/> debe ser mayor a 0</param>
        /// <returns>No devuelve ningun valor.</returns>
        public void ingresar (decimal cantidad)
        {
            if (cantidad > 0)
                saldo = saldo + cantidad;
        }

        /// <summary>
        /// Metodo utilizado para retirar dinero de la cuenta corriente.
        /// </summary>
        /// <param>El valor del parámetro <paramref name="cantidad"/> debe ser menor que <see cref="saldo"/> y mayor a 0</param>
        /// <returns>Devolverá la cantidad de dinero a retirar.</returns>
        public decimal retirar (decimal cantidad)
        {
            decimal retirado = 0;
            if (cantidad > 0 && cantidad <= saldo)
            {
                retirado = cantidad;
                saldo = saldo - cantidad;
            }

            return retirado;
        }
    }
}
