using System;

namespace PracticaTres {
  class Programa {
    static void Main() {
      Console.Clear();

      // INICIA EL PROGRAMA ======>
      CuentaCorriente cc = new CuentaCorriente(
        123456, "Luis Felipe", 5, 6.7
      ); // Fin de instanciación
      CuentaAhorroFijo ca = new CuentaAhorroFijo(
        654321, "Juan Velasco", 123, 10, "5/Abril/2017"
      ); // Fin de instanciación
      PlanPensiones pp = new PlanPensiones(
        321456, "Paola Sánchez", 90, 2.4, "24/Mayo/2030", "Buena"
      ); // Fin de instanciación

      cc.PresentarDatos();
      cc.Deposito(145);

      ca.PresentarDatos();
      ca.Deposito(ca.DepositoMes());

      pp.PresentarDatos();
      // <===== TERMINA EL PROGRAMA

      Console.ReadKey(true);
    } // Fin de método principal
  } // Fin de clase Programa
  
  interface IPresentar {
    void PresentarDatos();
  } // Fin de interface
} // Fin de espacio de nombre