using System;

namespace u4c1 {
  abstract class Musico {
    public Musico() {}

    public virtual void AfinarInstrumento() {
      Console.WriteLine("Afina Instrumento.");
    } // Fin de método de afinar instrumento

    public abstract void Imprimir();
  } // Fin de clase Músico
} // Fin de espacio de nombre