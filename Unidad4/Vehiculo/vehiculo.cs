using System;
using System.Collections.Generic;
using System.Globalization;

namespace Vehiculos {
  abstract class Vehiculo {
    string matricula;
    int modelo;

    public string Matricula {
      get { return matricula;  }
      set { matricula = value; }
    } public int Modelo {
      get { return modelo;  }
      set { modelo = value; }
    } // Fin de getters y setters

    public Vehiculo() {}
    public Vehiculo(string mat, int mod) {
      matricula = mat; modelo = mod;
    } // Fin de constructor sobrecargado

    abstract public void CondicionVehiculo();

    virtual public void Imprimir() {
      Console.WriteLine("Matrícula del Vehículo: {0}", matricula);
      Console.WriteLine("Modelo del Vehículo: {0}", modelo);
    } // Fin de imprimir el modelo y la matrícula
  } // Fin de clase Vehiculo
} // Fin de espacio de nombre