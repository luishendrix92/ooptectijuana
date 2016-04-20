using System;

namespace PracticaTres {
  class Programa {
    static void Main() {
      Console.Clear();

      // INICIA EL PROGRAMA ======>
      Cliente panasonic = new Cliente(
        "Takuya Hirashima", "Panasonic AVC Networks"
      ); // Fin de instanciación
      Ejecutivo jefe    = new Ejecutivo(
        "Salvador González", "5579279", 4, 3684.14f, "Ingeniería"
      ); // Fin de instanciación
      Operador yo       = new Operador(
        "Luis Felipe", "1541412", 7, 179.45f, "Atornilladora"
      ); // Fin de instanciación

      panasonic.ComprarMercancia(26424);
      jefe.ReciboPago();
      yo.ReciboPago();
      // <===== TERMINA EL PROGRAMA

      Console.ReadKey(true);
    } // Fin de método principal
  } // Fin de clase Programa
} // Fin de espacio de nombre