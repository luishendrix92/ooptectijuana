using System;
using System.Collections.Generic;
using System.Globalization;

namespace Carros {
  abstract class Vehiculo {
    string color, placas;
    int modelo;

    public string Color {
      get { return color;  }
      set { color = value; }
    } public string Placas {
      get { return placas;  }
      set { placas = value; }
    } public int Modelo {
      get { return modelo;  }
      set { modelo = value; }
    } // Fin de getters y setters

    public Vehiculo() {}
    public Vehiculo(string c, string p, int m) {
      color = c; placas = p; modelo = m;
    } // Fin de constructor sobrecargado

    public abstract void Imprime();
  } // Fin de clase Vehiculo
} // Fin de espacio de nombre