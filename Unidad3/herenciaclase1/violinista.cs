using System;

namespace u3l1 {
  class Violinista : Musico {
    string marcaViolin;

    public string MarcaViolin {
      get { return marcaViolin;  }
      set { marcaViolin = value; }
    }

    public Violinista(string n, string i, int e, string mv)
    :base(n, i, e) {
      marcaViolin = mv;
      Console.WriteLine("Violinista Creado!!!");
    } // Fin de constructor

    public void TocarViolin() {
      Console.WriteLine("Estoy tocando el {0}!", marcaViolin);
    }
  } // Fin de
} // Fin de