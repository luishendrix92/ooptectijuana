using System;

namespace Publicaciones {
  class Publicacion {
    string titulo;
    int noPag;
    float precio;

    public string Titulo {
      get { return titulo;  }
      set { titulo = value; }
    } public int NumPag {
      get { return noPag;  }
      set { noPag = value; }
    } public float Precio {
      get { return precio;  }
      set { precio = value; }
    } // Fin de getters y setters

    public Publicacion() {}
    public Publicacion(string t, int n, float p) {
      titulo = t; noPag = n; precio = p;
    } // Fin de constructor sobrecargado
  } // Fin de clase principal
} // Fin de espacio de nombre