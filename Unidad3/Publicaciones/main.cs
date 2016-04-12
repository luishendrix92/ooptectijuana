using System.Collections.Generic;
using System;

namespace Publicaciones {
  class Programa {
    static void Main() {
      Console.Clear();

      Periodico mexi = new Periodico(
        "El Mexicano", 45, 10.9f,
        new List<string>() {"Policial", "Clasificados", "Socialité"}
      ); // Fin de instanciación
      Revista cine   = new Revista(
        "Cine Premiere", 96, 45,
        244, 5, "Enero 2015", "iasa Comunication"
      ); // Fin de instanciación
      Libro tronos   = new Libro(
        "Juego de Tronos", 800, 234.05f,
        0307951189, "George R. R. Martin", "Vintage", "Paperback"
      ); // Fin de instanciación

      cine.MostrarDatos();
      tronos.MostrarDatos();
      mexi.MostrarDatos();
    } // Fin de método principal
  } // Fin de clase Programa
} // Fin de espacio de nombre