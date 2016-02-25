using System.Collections.Generic;
using System.Globalization;
using System;

namespace JugadorDeFutbol {
  class Jugador {
    int numeroJugador, goles, partidos;
    float promedioGoles;
    string nombre;

    public int NumeroJugador {
      get { return numeroJugador;  }
      set { numeroJugador = value; }
    } public int Goles {
      get { return goles;  }
      set { goles = value; }
    } public int Partidos {
      get { return partidos;  }
      set { partidos = value; }
    } public float Promedio {
      get { return promedioGoles;  }
      set { promedioGoles = value; }
    } public string Nombre {
      get { return nombre;  }
      set { nombre = value; }
    } // Fin de getters y setters

    public Jugador() {}
    public Jugador(string nom, int gol, int part, int num) {
      nombre        = nom ;
      goles         = gol ;
      partidos      = part;
      numeroJugador = num ;
    } // Fin de sobrecarga de constructor

    public float CalcularPromedio() {
      promedioGoles = goles / partidos;
      return promedioGoles;
    } // Fin de calcular promedio de goles x partido

    public void Imprimir() {
      Console.WriteLine("texto");
    } // Fin de imprimir datos del jugador
  } // Fin de clase Jugador
} // Fin de namespace