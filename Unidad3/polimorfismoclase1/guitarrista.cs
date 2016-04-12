using System;

namespace u4c1 {
  class Guitarrista : Musico {
    string tipo;

    public string Tipo {
      get { return tipo;  }
      set { tipo = value; }
    } // Fin de getters y setters

    public Guitarrista(string t)
    :base() { tipo = t; }

    public override void AfinarInstrumento() {
      base.AfinarInstrumento();
      Console.WriteLine("El Guitarrista afina la Guitarra.");
    } // Fin de método polimórfico

    public override void Imprimir() {
      Console.WriteLine("Soy un guitarrista.");
    } // Fin de método sobre-escrito
  } // Fin de clase Guitarrista
} // Fin de espacio de nombre