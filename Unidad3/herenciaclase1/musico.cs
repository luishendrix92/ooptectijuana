using System;

namespace u3l1 {
  class Musico {
    string nombre, instrumento;
    int edad;

    public Musico(string n, string i, int e) {
      nombre = n; instrumento = i; edad = e;
      Console.WriteLine("Se creó un músico.");
    }

    public void AfinarInstrumento(string marca) {
      Console.WriteLine("Estoy afinando mi {0}, marca {1}!!",
      instrumento, marca);
    }

    public void Presentarme() {
      Console.WriteLine("Soy {0}!", nombre);
      Console.WriteLine("Y tengo {0} años.", edad);
    }
  } // Fin de
} // Fin de
