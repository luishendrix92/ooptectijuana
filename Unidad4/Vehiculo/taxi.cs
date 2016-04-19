using System;
using System.Collections.Generic;
using System.Globalization;

namespace Vehiculos {
  class Taxi : Vehiculo {
    int numero, noLicencia;

    public int Numero {
      get { return numero;  }
      set { numero = value; }
    } public int Licencia {
      get { return noLicencia;  }
      set { noLicencia = value; }
    } // Fin de getters y setters

    public Taxi():base() {}
    public Taxi(string ma, int mo, int n, int l)
    :base(ma, mo) {
      numero = n; noLicencia = l;
    } // Fin de constructor sobrecargado

    public void CambiaNum() {
      numero = 666666;
      Console.WriteLine("Cambiado número del taxi a {0}!!", numero);
    } // Fin de cambiar el número de taxi

    public override void Imprimir() {
      base.Imprimir();
      Console.WriteLine("--------------------------------");
      Console.WriteLine("Licencia: {0}", noLicencia);
      Console.WriteLine("Número de Taxi: {0}", numero);
    } // Fin de imprimir datos del taxi

    public override void CondicionVehiculo() {
      Console.WriteLine("Está en muy buenas condiciones ;)");
    } // Fin de ver cómo está el taxi
  } // Fin de clase Taxi
} // Fin de espacio de nombre