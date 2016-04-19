using System;
using System.Collections.Generic;
using System.Globalization;

namespace Vehiculos {
  class Autobus : Vehiculo {
    int noPlazas;
    string linea;

    public int NoPlazas {
      get { return noPlazas;  }
      set { noPlazas = value; }
    } public string Linea {
      get { return linea;  }
      set { linea = value; }
    } // Fin de getters y setters

    public Autobus():base() {}
    public Autobus(string ma, int mo, int n, string l)
    :base(ma, mo) {
      noPlazas = n; linea = l;
    } // Fin de constructor sobrecargado

    public int EspaciosDisponibles() {
      return noPlazas;
    } // Fin de espacios disponibles

    public override void Imprimir() {
      base.Imprimir();
      Console.WriteLine("------------------------------");
      Console.WriteLine("Quedan {0} espacio(s) disponibles!", EspaciosDisponibles());
      Console.WriteLine("Línea del bus: {0}", linea);
    } // Fin de método para imprimir datos del autobús

    public override void CondicionVehiculo() {
      Console.WriteLine("Está en malas condiciones...");
    } // Fin de ver la condición del vehículo
  } // Fin de clase Autobus
} // Fin de espacio de nombre