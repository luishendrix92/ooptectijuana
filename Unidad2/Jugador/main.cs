using System;

namespace JugadorDeFutbol {
  class Programa {
    public static void Main() {
      Console.Clear();
      Jugador chicharito = new Jugador(
        "Javier Hernández", 118, 290, 7
      ); // Fin de instanciación

      Console.WriteLine("============================");
      chicharito.Imprimir();
      Console.WriteLine("============================");
    } // Fin de Método Main
  } // Fin de clase Programa
} // Fin de namespace