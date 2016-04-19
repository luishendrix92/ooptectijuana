using System;

namespace u4c1 {
  class Programa {
    static void Main() {
      Console.Clear();

      Violinista manu = new Violinista(
        "Stradivarius"
      ); // Fin de instanciar violinista
      Guitarrista slash = new Guitarrista(
        "Rockero"
      ); // Fin de intanciar guitarrista

      manu.AfinarInstrumento();
      slash.AfinarInstrumento();
    } // Fin de
  } // Fin de
} // Fin de