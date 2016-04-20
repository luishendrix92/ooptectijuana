using System;

namespace PracticaUno {
  class Mueble {
    string fabricante, material;
    float peso, costo, altura;

    public string Fabricante {
      get { return fabricante;  }
      set { fabricante = value; }
    } public string Material {
      get { return material;  }
      set { material = value; }
    } public float Peso {
      get { return peso;  }
      set { peso = value; }
    } public float Costo {
      get { return costo;  }
      set { costo = value; }
    } public float Altura {
      get { return altura;  }
      set { altura = value; }
    } // Fin de getters y setters

    public Mueble() {}
    public Mueble(string f, string m, float p, float c, float a) {
      fabricante = f; material = m;
      peso = p; costo = c; altura = a;
    } // Fin de constructor sobrecargado

    public void Imprime() {
      Console.WriteLine("====================================================");
      Console.WriteLine("Este mueble fue fabricado por: {0}", fabricante);
      Console.WriteLine("Está hecho de {0} y pesa {1} kilo(s), mide {2}m de alto",
        material, peso, altura);
      Console.WriteLine("Comprarlo te costaría unos {0:C2} pesos!", costo);
      Console.WriteLine("----------------------------------------------------");
    } // Fin de mostrar datos del mueble
  } // Fin de clase Mueble
} // Fin de espacio de nombre