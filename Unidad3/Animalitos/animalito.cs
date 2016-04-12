using System;
using System.Collections.Generic;
using System.Globalization;

namespace Animalitos {
  class Animalito {
    string nombre;

    public string Nombre {
      get { return nombre;  }
      set { nombre = value; }
    } // Fin de getters y setters

    public Animalito() {}
    public Animalito(string nombre) {
      this.nombre = nombre;
    } // Fin de constructor sobrecargado
  } // Fin de clase Animalito
} // Fin de espacio de nombre