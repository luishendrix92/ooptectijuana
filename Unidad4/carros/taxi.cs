using System;
using System.Collections.Generic;
using System.Globalization;

namespace Carros {
  class Taxi : Vehiculo, IProp {
    string ruta;
    int numTaxi;
    float tarifa;

    public string Ruta {
      get { return ruta;  }
      set { ruta = value; }
    } public int NumTaxi {
      get { return numTaxi;  }
      set { numTaxi = value; }
    } public float Tarifa {
      get { return tarifa;  }
      set { tarifa = value; }
    } // Fin de getters y setters

    public Taxi():base() {}
    public Taxi(
      string c, string p, int m,
      string r, int n, float t
    ):base(c, p, m) {
      ruta = r; numTaxi = n; tarifa = t;
    } // Fin de constructor sobrecargado

    public void MuestraRuta() {
      Console.WriteLine("La ruta del taxi es: {0}", ruta);
    } // Fin de mostrar la ruta del taxi

    public override void Imprime() {
      Console.WriteLine("================================");
      Console.WriteLine("SISTEMA DE TAXIS MEXICANO");
      Console.WriteLine("--------------------------------");
      Console.WriteLine("       Datos del vehículo       ");
      Console.WriteLine("--------------------------------");
      Console.WriteLine("Color: {0}", Color);
      Console.WriteLine("Placas: {0}", Placas);
      Console.WriteLine("Modelo: {0}", Modelo);
      Console.WriteLine("--------------------------------");
      Console.WriteLine("      Información del Taxi      ");
      Console.WriteLine("--------------------------------");
      MuestraRuta();
      Console.WriteLine("Número de Taxi: {0}", numTaxi);
      Console.WriteLine("Tarifa por persona: {0:C2}", tarifa);
      Console.WriteLine("--------------------------------\n");
    } // Fin de mostrar datos del taxi
  } // Fin de clase Taxi
} // Fin de espacio de nombre