using System.Collections.Generic;
using System;

namespace Publicaciones {
  class Periodico : Publicacion {
    List<string> secciones;

    public List<string> Secciones {
      get { return secciones;  }
      set { secciones = value; }
    } // Fin de getters y setters

    public Periodico():base() {}
    public Periodico(
      string t, int n, float p,
      List<string> s
    ):base(t, n, p) { secciones = s; }

    public int ContarSecciones() {
      return secciones.Count;
    } // Fin de contar cuántas secciones hay

    public void MostrarDatos() {
      Console.WriteLine("DATOS GENERALES DE LA PUBLICACIÓN ->");
      Console.WriteLine("====================================");
      Console.WriteLine("Título: {0}", Titulo);
      Console.WriteLine("Número de páginas: {0}", NumPag);
      Console.WriteLine("Precio: {0:C2}", Precio);
      Console.WriteLine("------------------------------------");
      Console.WriteLine("Secciones: Hay {0} y son...", ContarSecciones());
      foreach (string seccion in secciones) {
        Console.WriteLine("- " + seccion);
      } // Fin de mostrar secciones una por una
    } // Fin de desplegar datos del periodico
  } // Fin de clase Periodico
} // Fin de espacio de nombre