using System;

namespace PracticaUno {
  class Programa {
    static void Main() {
      Console.Clear();

      // INICIA EL PROGRAMA ======>
      Silla silla   = new Silla(
        "IKEA", "ébano", 2, 134.54f, 0.6f, 2
      ); // Fin de instanciación
      Sillon sillon = new Sillon(
        "Hnos. Vászquez", "caoba", 30, 453.9f, 0.9f, 2
      ); // Fin de instanciación
      Taburete tabu = new Taburete(
        "Furnimax", "madera", 1, 45.18f, 0.45f, 4
      ); // Fin de instanciación

      MesaCircular redonda = new MesaCircular(
        "Coppel", "vidrio", 25, 1453, 0.78f, 1.5f
      ); // Fin de instanciación
      MesaRectangular mesa = new MesaRectangular(
        "Furnimax", "madera", 37, 950, 0.6f, 1.7f, 0.6f
      ); // Fin de instanciación

      silla.Imprimir()  ;
      sillon.Imprimir() ;
      tabu.Imprimir()   ;
      redonda.Imprimir();
      mesa.Imprimir()   ;
      // <===== TERMINA EL PROGRAMA

      Console.ReadKey(true);
    } // Fin de método principal
  } // Fin de clase Programa
} // Fin de espacio de nombre