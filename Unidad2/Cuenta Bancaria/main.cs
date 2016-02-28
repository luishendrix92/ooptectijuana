using System;

namespace Tarea6 {
  class Programa {
    public static void Main() {
      Console.Clear();
      CuentaBancaria falsa = new CuentaBancaria();
      CuentaBancaria buena = new CuentaBancaria();

      // Cambiar atributos de cuentas
      falsa.Titular = "Menganito Perez";
      falsa.Saldo   = 44.65f;
      buena.Titular = "Luis Felipe López";

      // Manejo de fondos de cuenta
      buena.Deposito(50000);

      // Retirar de buena y abonar a falsa
      falsa.Deposito(buena.Retiro(24500.5f));

      // Tratar de realizar malos movimientos
      falsa.Retiro(40000)  ;
      buena.Deposito(-4.5f);
    } // Fin de Método Main
  } // Fin de clase principal
} // Fin de espacio de nombre