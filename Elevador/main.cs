using System;

namespace ProgramaElevador {
  class Programa {
    public static void Main() {
      Console.Clear();
      Elevador subebaja = new Elevador(900, 5);

      subebaja.cambiarPiso(6);
      subebaja.cambiarPiso(-4);
    } // Fin de Método Main
  } // Fin de clase
} // Fin de namespace