using System;

namespace Escritura {
  class Programa {
    static void Main() {
      Console.Clear();
      // Inicia el programa ---->
      Teclado logi = new Teclado("Logitech", 40);

      Console.WriteLine("Bienvenido al teclado {0} de {1} teclas.",
        logi.Marca, logi.NumTeclas                                );
      Console.WriteLine("Presione teclas a ver que ocurre ;)"     );
      Console.WriteLine("----------------------------------------");

      logi.Teclazo();
    } // Fin de método principal
  } // Fin de clase Programa
} // Fin de espacio de nombre
