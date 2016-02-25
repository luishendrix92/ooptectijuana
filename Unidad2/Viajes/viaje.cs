using System;
using System.Collections.Generic;

namespace ViajesListas {
  class Programa {
    public static void Main() {
      Console.Clear();
      Viaje acapulco = new Viaje(
        "Tijuana", "Acapulco",
        DateTime.Parse(Console.ReadLine()),
        DateTime.Parse(Console.ReadLine())
      ); // Fin de constructor

      acapulco.ImprimirBoleto();
    } // Fin de Método Main
  } // Fin de clase Programa
} // Fin de namespace