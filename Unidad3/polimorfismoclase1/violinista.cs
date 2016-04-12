using System;

namespace u4c1 {
  class Violinista : Musico {
    string marca;

    public string Marca {
      get { return marca;  }
      set { marca = value; }
    } // Fin de getters y setters

    public Violinista(string m)
    :base() { marca = m; }

    public override void AfinarInstrumento() {
      base.AfinarInstrumento();
      Console.WriteLine("El Violinista afina el violín.");
    } // Fin de método para afinar instrumento

    public override void Imprimir() {
      Console.WriteLine("adasd");
    }
  } // Fin de clase Violinista
} // Fin de espacio de nombre