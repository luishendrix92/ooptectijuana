using System;

namespace u3l1 {
  class Programa {
    static void Main() {
      Console.Clear();

      Violinista alguno = new Violinista(
        "Algun Violín", "Violín", 64, "Stradivarius"
      ); // Fin de instanciar violinista

      alguno.TocarViolin();
      alguno.AfinarInstrumento(alguno.MarcaViolin);
    } // Fin de
  } // Fin de
} // Fin de