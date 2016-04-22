using System;
using System.Collections.Generic;
using System.Globalization;

namespace Carros {
  class Uber : Vehiculo, IProp {
    string chofer;
    float tarifaPorKm, kmRecorridos;

    public string Chofer {
      get { return chofer;  }
      set { chofer = value; }
    } public float Tarifa {
      get { return tarifaPorKm;  }
      set { tarifaPorKm = value; }
    } public float Kilometros {
      get { return kmRecorridos;  }
      set { kmRecorridos = value; }
    } // Fin de getters y setters

    public Uber():base() {}
    public Uber(
      string c, string p, int m,
      string ch, float t, float k
    ):base(c, p, m) {
      chofer = ch; tarifaPorKm = t; kmRecorridos = k;
    } // Fin de constructor sobrecargado

    public float CalcularPago() {
      return kmRecorridos * tarifaPorKm;
    } // Fin de calcular costo del viaje

    public override void Imprime() {
      Console.WriteLine("================================");
      Console.WriteLine("UBER INTERNATIONAL - BLACK");
      Console.WriteLine("--------------------------------");
      Console.WriteLine("       Datos del vehículo       ");
      Console.WriteLine("--------------------------------");
      Console.WriteLine("Color: {0}", Color);
      Console.WriteLine("Placas: {0}", Placas);
      Console.WriteLine("Modelo: {0}", Modelo);
      Console.WriteLine("--------------------------------");
      Console.WriteLine("        Recibo del Viaje        ");
      Console.WriteLine("--------------------------------");
      Console.WriteLine("Tu chofer fue: {0}", chofer);
      Console.WriteLine("Kilómetros recorridos: {0}",
        kmRecorridos);
      Console.WriteLine("Costo por kilómetro: {0:C2}",
        tarifaPorKm);
      Console.WriteLine("COSTO TOTAL DEL VIAJE: {0:C2}",
        CalcularPago());
      Console.WriteLine("--------------------------------\n");
    } // Fin de mostrar resumen del viaje
  } // Fin de clase Uber
} // Fin de espacio de nombre