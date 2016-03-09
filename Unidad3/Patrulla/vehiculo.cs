using System;

namespace PatrullaHerencia {
  class Vehiculo {
    string matricula, modelo, tipo;

    public string Matricula     {
      get { return matricula;  }
      set { matricula = value; }
    } public string Modelo      {
      get { return modelo;     }
      set { modelo = value;    }
    } public string Tipo        {
      get { return tipo;       }
      set { tipo = value;      }
    } // Fin de getters y setters

    public Vehiculo() {}
    public Vehiculo(string mat, string mod, string tip) {
      matricula = mat;
      modelo    = mod;
      tipo      = tip;
    } // Fin de constructor sobrecargado

    public void Imprimir() {
      Console.WriteLine("========================");
      Console.WriteLine("Matrícula: {0}.", matricula);
      Console.WriteLine("Modelo: {0}", modelo);
      Console.WriteLine("Tipo: {0}", tipo);
      Console.WriteLine("------------------------");
    } // Fin de imprimir datos del vehículo
  } // Fin de clase Vehiculo
} // Fin de espacio de nombre

/* No la eh hecho.. pero debemos crear una herencia de la clase vehículo en una clase patrulla, va a tener un atributo y una clase bool que diga si la sirena esta encendida o apagada*/
