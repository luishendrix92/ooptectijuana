using System;

namespace PatrullaHerencia {
  class Patrulla : Vehiculo {
    bool sirena; // true -> Encendida | false -> Apagada

    public bool Sirena     {
      get { return sirena;  }
    } // Sólo lectura

    public Patrulla() {}
    public Patrulla(
      string mat, string mod
    ):base(mat, mod, "Patrulla") {
      sirena = false;
      Console.WriteLine("Se creó una nueva patrulla");
    } // Fin de constructor sobrecargado

    public void PrenderApagarSirena() {
      sirena = !sirena;

      if(sirena)
      { Console.WriteLine("WEEE UUUU WEEEE UUUU"); }
      else
      { Console.WriteLine("Weeeoooou..uu.... [Sirena Apagada]"); }
    } // Fin de apagar o prender la sirena
  } // Fin de clase Vehiculo
} // Fin de espacio de nombre
