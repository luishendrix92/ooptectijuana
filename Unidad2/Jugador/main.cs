using System;

namespace JugadorDeFutbol {
  class Programa {
    public static void Main() {
      Console.Clear();
      Jugador chicharito = new Jugador(
        "Javier Hernandez", 118, 290, 7
      ); // Fin de instanciación

      chicharito.Imprimir();
    } // Fin de Método Main
  } // Fin de clase Programa
} // Fin de namespace