using System;
using System.Collections.Generic;
using System.Globalization;

namespace Animalitos {
  class Programa {
    static void Main() {
      Console.Clear();

      Ballena Will = new Ballena("Will");
      Loro Cantor = new Loro("Cantor");
      Pinguino Adela = new Pinguino("Adela");
      Perro Cain = new Perro("Caín", "Bravo");
      Perro Abel = new Perro("Abel", "Manso");

      Cantor.Cantar();
      Cain.Hablar();
      Abel.Hablar();

      // Los otros 2 animales no dicen nada
      Console.ReadKey();
    } // Fin de método principal
  } // Fin de clase Programa
} // Fin de espacio de nombre