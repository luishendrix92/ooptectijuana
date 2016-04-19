using System;

namespace Interfaces {
  class Programa {
    static void Main() {
      Console.Clear();

      Documento D = new Documento("Ésta es la frase");

      D.Imprimir();
      D.Cambiar();
      D.Imprimir();
    } // Fin de método principal
  } // Fin de clase Programa
} // Fin de espacio de nombre
