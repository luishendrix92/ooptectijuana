using System;

namespace PracticaUno {
  class Asiento : Mueble {
    public Asiento() {}
    public Asiento(string f, string m, float p, float c, float a)
    :base(f, m, p, c, a) {}
  } // Fin de clase Asiento

  class Silla : Asiento {
    int numBrazos;

    public int Brazos {
      get { return numBrazos;  }
      set { numBrazos = value; }
    } // Fin de getters y setters

    public Silla():base() {}
    public Silla(string f, string m, float p, float c, float a, int b)
    :base(f, m, p, c, a) {
      numBrazos = b;
    } // Fin de constructor sobrecargado

    public void Imprimir() {
      Imprime();
      Console.WriteLine("Esta silla tiene {0} brazos.", numBrazos);
    } // Fin de método para mostrar datos específicos
  } // Fin de clase Silla

  class Sillon : Asiento {
    int capacidadPersonas;

    public int Capacidad {
      get { return capacidadPersonas;  }
      set { capacidadPersonas = value; }
    } // Fin de getters y setters

    public Sillon():base() {}
    public Sillon(string f, string m, float p, float c, float a, int cp)
    :base(f, m, p, c, a) {
      capacidadPersonas = cp;
    } // Fin de constructor sobrecargado

    public void Imprimir() {
      Imprime();
      Console.WriteLine("Al sillón le caben {0} personas!", capacidadPersonas);
    } // Fin de método para mostrar datos específicos
  } // Fin de clase Sillon

  class Taburete : Asiento {
    int numPatas;

    public int Patas {
      get { return numPatas;  }
      set { numPatas = value; }
    } // Fin de getters y setters

    public Taburete():base() {}
    public Taburete(string f, string m, float p, float c, float a, int np)
    :base(f, m, p, c, a) {
      numPatas = np;
    } // Fin de constructor sobrecargado

    public void Imprimir() {
      Imprime();
      Console.WriteLine("El taburete tiene {0} patas.", numPatas);
    } // Fin de método para mostrar datos específicos
  } // Fin de clase Taburete
} // Fin de espacio de nombre