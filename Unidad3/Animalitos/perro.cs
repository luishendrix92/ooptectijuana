using System;
using System.Collections.Generic;
using System.Globalization;

namespace Animalitos {
  class Perro : Animalito {
    string tipo;

    public string Tipo {
      get { return tipo;  }
      set { tipo = value; }
    } // Fin de getters y setters

    public Perro():base() {}
    public Perro(string n, string t):base(n) {
      tipo = t;
    } // Fin de constructor sobrecargado

    public void Hablar() {
      if(tipo.ToLower() == "bravo") {
        Console.WriteLine("Grrrr!!!");
      } else if(tipo.ToLower() == "manso") {
        Console.WriteLine("Guau Guau ;)");
      } else {
        Console.WriteLine("...");
      } // Fin de condicionante
    } // Fin de gruñir o hablar
  } // Fin de clase Perro
} // Fin de espacio de nombre