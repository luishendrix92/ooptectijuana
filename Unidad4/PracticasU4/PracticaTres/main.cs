using System;

namespace PracticaDos {
  class Programa {
    static void Main() {
      Console.Clear();

      // INICIA EL PROGRAMA ======>
      CuentaCorriente cc = new CuentaCorriente(
        123456, "Luis Felipe", 5
      ); // Fin de instanciación
      CuentaAhorroFijo ca = new CuentaAhorroFijo(
        654321, "Juan Velasco", 123, "5/Abril/2017"
      ); // Fin de instanciación
      PlanPensiones pp = new PlanPensiones(
        321456, "Paola Sánchez", 90, "24/Mayo/2030", "Buena"
      ); // Fin de instanciación

      Console.WriteLine("CUENTA CORRIENTE");
      Console.WriteLine("====================================");
      Console.WriteLine("N° {0} de cuenta.", cc.Numero);
      Console.WriteLine("Titular: {0}.", cc.Titular);
      Console.WriteLine("Saldo: {0:C2}.", cc.Saldo);
      cc.Deposito(145);
      cc.Retiro(500);

      Console.WriteLine("\nCUENTA DE AHORRO FIJO");
      Console.WriteLine("====================================");
      Console.WriteLine("N° {0} de cuenta.", ca.Numero);
      Console.WriteLine("Titular: {0}.", ca.Titular);
      Console.WriteLine("Saldo: {0:C2}.", ca.Saldo);
      Console.WriteLine("Vence el: {0}.", ca.Vencimiento);
      Console.WriteLine("Depósito mensual: {0:C2}.", ca.DepositoMes());
      ca.Deposito(ca.DepositoMes());

      Console.WriteLine("\nPLAN DE PENSIONES");
      Console.WriteLine("====================================");
      Console.WriteLine("N° {0} de cuenta.", pp.Origen);
      Console.WriteLine("Titular: {0}.", pp.Titular);
      Console.WriteLine("Saldo: {0:C2}.", pp.Saldo);
      Console.WriteLine("Vence el: {0}.", pp.Vencimiento);
      Console.WriteLine("Cotización: {0}.", pp.Cotizacion);
      // <===== TERMINA EL PROGRAMA

      Console.ReadKey(true);
    } // Fin de método principal
  } // Fin de clase Programa
} // Fin de espacio de nombre