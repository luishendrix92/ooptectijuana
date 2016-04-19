using System;
using System.Globalization;

namespace InterfacesClase2 {
  class Programa {
    static void Main(string[] args) {
      Console.Clear();

      CCuenta c = new CCuenta(
        12345, "Cuenta de Ahorros", DateTime.Today, 1500
      ); // Fin de instanciar cuenta

      Console.WriteLine("No.Cta: {0}", c.NoCta);
      Console.WriteLine("Tipo de Cta: {0}", c.TipoCta);
      Console.WriteLine("Balance: {0:C2}", c.Balance());
      Console.WriteLine("--------------------------> Apertura");
      Console.WriteLine("Día: {0}", c.dia());
      Console.WriteLine("Mes: {0}", c.NombreMes());
      Console.WriteLine("Año: {0}", c.año());

      Console.ReadKey();
    } // Fin de método principal
  } // Fin de clase Programa
} // Fin de espacio de nombre