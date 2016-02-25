using System;
using System.Collections.Generic;

namespace ViajesListas {
  class Viaje {
    string origen, destino;
    DateTime fechaSalida, fechaLlegada;

    public string Origen {
      get { return origen;  }
      set { origen = value; }
    } public string Destino {
      get { return destino;  }
      set { destino = value; }
    } public DateTime Salida {
      get { return fechaSalida;  }
      set { fechaSalida = value; }
    } public DateTime Llegada {
      get { return fechaLlegada;  }
      set { fechaLlegada = value; }
    } // Fin de getters y setters

    public Viaje() {}
    public Viaje(string ori, string dest, DateTime fs, DateTime fl) {
      fechaLlegada = fl;
      fechaSalida  = fs;
      destino      = dest;
      origen       = ori;
    } // Fin de constructor sobrecargado

    public void ImprimirBoleto() {
      Console.WriteLine("==================================");
      Console.WriteLine("Tu vuelo desde {0} hasta {1} sale el:", origen, destino);
      Console.WriteLine(fechaSalida.ToLongDateString());
      Console.WriteLine("Y regresarás el día:");
      Console.WriteLine(fechaLlegada.ToLongDateString());
      Console.WriteLine("==================================");
    } // Fin de método imprimir boleto
  } // Fin de clase Viaje
} // Fin de namespace