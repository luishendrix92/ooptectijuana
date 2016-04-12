using System;
using System.Collections.Generic;
using System.Globalization;

namespace Animalitos {
  class Loro : Animalito {
    public Loro():base() {}
    public Loro(string n):base(n) {}

    static string FraseRandom() {
      List<string> frases = new List<string>() {
        "Lorito Bonito!", "Viva mi dueño!"
      }; // Fin de frases que puede decir
      Random rnd = new Random();
      return frases[rnd.Next(frases.Count)];
    } // Fin de devolver frase aleatoria

    public void Cantar() {
      Console.WriteLine(FraseRandom());
    } // Fin de método para cantar frases
  } // Fin de clase Loro
} // Fin de espacio de nombre