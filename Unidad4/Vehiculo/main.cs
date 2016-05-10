using System;
using System.Collections.Generic;
using System.Globalization;

namespace Vehiculos {
  class Programa {
    static void Main() {
      Console.Clear();
      // INICIA PROGRAMA -->
      Taxi taxi = new Taxi("CDBE4", "SUV", "3", "433");
      // <-- TERMINA PROGRAMA
      Console.ReadKey();
    } // Fin de método principal
  } // Fin de clase Programa
} // Fin de espacio de nombre