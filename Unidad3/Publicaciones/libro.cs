using System;

namespace Publicaciones {
  class Libro : Publicacion {
    string tipoPortada, autor, editorial;
    long isbn;

    public long ISBN {
      get { return isbn;  }
      set { isbn = value; }
    } public string Autor {
      get { return autor;  }
      set { autor = value; }
    } public string Editorial {
      get { return editorial;  }
      set { editorial = value; }
    } public string TipoPortada {
      get { return tipoPortada;  }
      set { tipoPortada = value; }
    } // Fin de getters y setters

    public Libro():base() {}
    public Libro(
      string t, int n, float p,
      long i, string a, string e, string tp
    ):base(t, n, p) {
      isbn = i; autor = a; editorial = e; tipoPortada = tp;
    } // Fin de constructor sobrecargado

    public void MostrarDatos() {
      Console.WriteLine("DATOS GENERALES DE LA PUBLICACIÓN ->");
      Console.WriteLine("====================================");
      Console.WriteLine("Título: {0}", Titulo);
      Console.WriteLine("Número de páginas: {0}", NumPag);
      Console.WriteLine("Precio: {0:C2}", Precio);
      Console.WriteLine("------------------------------------");
      Console.WriteLine("ISBN: {0}", isbn);
      Console.WriteLine("Autor: {0}", autor);
      Console.WriteLine("Editorial: {0}", editorial);
      Console.WriteLine("Tipo de Portada: {0}\n", tipoPortada);
    } // Fin de desplegar datos del libro
  } // Fin de clase Libro
} // Fin de espacio de nombre