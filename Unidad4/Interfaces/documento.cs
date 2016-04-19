using System;

namespace Interfaces {
  class Documento : Folder, IMostrarDatos, ICambiar, IProp {
    string frase;

    public string Doc {
      get { return frase; }
      set { fraase = value; }
    } // Fin de implementación

    //public string Frase {
    //  get { return frase; }
    //  set { frase = value; }
    //} // Fin de getters y setters

    public Documento() {}
    public Documento(string d) {
      frase = d;
    } // Fin de constructor sobrecargado

    public void Imprimir() {
      Console.WriteLine(frase);
    } // Fin de método para imprimir frase

    public void Cambiar() {
      frase = "Es la nueva clase";
    } // Fin de método cambiar frase
  } // Fin de clase Documento

  interface IMostrarDatos {
    void Imprimir();
  } // Fin de interface
} // Fin de espacio de nombre
