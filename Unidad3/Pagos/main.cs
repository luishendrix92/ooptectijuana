using System;
using System.Globalization;

namespace Pagos {
  class Programa {
    static void Main() {
      Console.Clear();

      Efectivo pago1 = new Efectivo("dólares", 475.5f, 500);
      Credito  pago2 = new Credito(
        "pesos", 45.98f, "5579005412128534", "Luis Felipe L.", 5000
      ); // Fin de instanciar pago a crédito

      Console.WriteLine("Se pagó {0:C2} {1} con {2:C2} en efectivo...",
        pago1.Cantidad, pago1.Moneda, pago1.CantidadEfectivo);
      Console.WriteLine("El pago se realizó el día: {0}",
        pago1.Fecha.ToLongDateString());
      Console.WriteLine("Cambio devuelto: {0:C2}", pago1.CalcularCambio());

      Console.WriteLine("\n----------------------------------------\n");

      Console.WriteLine("Cuenta: {0} - Saldo Actual: {1:C2}.",
        pago2.Tarjeta, pago2.Saldo);
      Console.WriteLine("Se pagó {0:C2} {1} a crédito quedando un balance de {2:C2}.",
        pago2.Cantidad, pago2.Moneda, pago2.Balance());
      Console.WriteLine("El pago se realizó el día: {0}",
        pago2.Fecha.ToLongDateString());
      Console.WriteLine("Es hora de recuperar algo de saldo...");
      pago2.CargarSaldo(50);
      Console.WriteLine("Ahora tienes: {0:C2} en tu cuenta.", pago2.Balance());
    } // Fin de método principal
  } // Fin de clase Programa
} // Fin de espacio de nombre