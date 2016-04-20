using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace PracticaTres {
  class Persona {
    string nombre;

    public string Nombre {
      get { return nombre;  }
      set { nombre = value; }
    } // Fin de getters and setters

    public Persona() {}
    public Persona(string nombre) {
      this.nombre = nombre;
    } // Fin de constructor sobrecargado
  } // Fin de clase Persona
} // Fin de espacio de nombre