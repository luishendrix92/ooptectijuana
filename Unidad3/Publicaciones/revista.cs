using System;

namespace Publicaciones {
  class Revista : Publicacion {
    int numero, volumen;
    string mes, editorial;

    public int Numero {
      get { return numero;  }
      set { numero = value; }
    } public int Volumen {
      get { return volumen;  }
      set { volumen = value; }
    } public string Mes {
      get { return mes;  }
      set { mes = value; }
    } public string Editorial {
      get { return editorial;  }
      set { editorial = value; }
    } // Fin de getters y setters

    public Revista():base() {}
    public Revista(
      string t, int n, float p,
      int num, int v, string m, string e
    ):base(t, n, p) {
      numero = num; volumen = v; mes = m; editorial = e;
    } // Fin de constructor sobrecargado

    public void MostrarDatos() {
      Console.WriteLine("DATOS GENERALES DE LA PUBLICACIÓN ->");
      Console.WriteLine("====================================");
      Console.WriteLine("Título: {0}", Titulo);
      Console.WriteLine("Número de páginas: {0}", NumPag);
      Console.WriteLine("Precio: {0:C2}", Precio);
      Console.WriteLine("------------------------------------");
      Console.WriteLine("Número de publicación: {0}", numero);
      Console.WriteLine("Volumen: {0}", volumen);
      Console.WriteLine("Mes de publicación: {0}", mes);
      Console.WriteLine("Editorial: {0}\n", editorial);
    } // Fin de desplegar datos de la revista
  } // Fin de clase Revista
} // Fin de espacio de nombre