using System;
using System.Collections.Generic;
using System.Globalization;

namespace Carros {
  class Programa {
    static void Main() {
      Console.Clear();

      // INICIA EL PROGRAMA ------>
      Taxi eltaxi = new Taxi(
        "Amarillo", "KMD4564", 32, "El Florido", 99, 5
      ); // Fin de instanciación
      Uber black = new Uber(
        "Negro", "UBL9222", 23, "Luis Felipe", 9.4f, 7
      ); // Fin de instanciación

      eltaxi.Imprime();
      black.Imprime() ;
      // <----- TERMINA EL PROGRAMA

      Console.ReadKey();
    } // Fin de método principal
  } // Fin de clase Programa
} // Fin de espacio de nombre