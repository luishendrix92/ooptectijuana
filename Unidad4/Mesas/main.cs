using System;

namespace Mesas {
  class Programa {
    static void Main() {
      Console.Clear();

      // INICIA EL PROGRAMA ======>
      MesaCircular redonda = new MesaCircular(
        "Hermanos Vázquez", "vidrio", 1453, 0.78f
      ); // Fin de instanciación
      MesaRectangular mesa = new MesaRectangular(
        "IKEA", "madera", 950, 1.7f, 0.6f
      ); // Fin de instanciación

      redonda.Imprimir();
      mesa.Imprimir()   ;
      // <===== TERMINA EL PROGRAMA

      Console.ReadKey(true);
    } // Fin de método principal
  } // Fin de clase Programa
} // Fin de espacio de nombre