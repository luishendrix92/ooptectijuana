using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System;

namespace Saldo {
  class Programa {
    static void Main(string[] args) {
      float saldo = 0;
      float monto = 0;
      
      Console.Clear();
      
      try {
        Console.WriteLine("Cuánto tiene la cuenta?");
        saldo = float.Parse(Console.ReadLine());
        Console.WriteLine("Cuánto quieres retirar?");
        monto = float.Parse(Console.ReadLine());
        
        // Comprobar si el monto excede el saldo
        if (saldo < monto)
        { throw new OverflowException("Saldo insuficiente"); }
        
        saldo -= monto;
        Console.WriteLine("Se retiraron {0:C2}, quedan {1:C2}.",
          monto, saldo);
      } catch (OverflowException err) {
        Console.WriteLine(err.Message);
      } catch (FormatException) {
        Console.WriteLine("No se introdujo un número válido.");
      } // Fin de atrapar errores
      
      Console.ReadKey();
    } // Fin de Método Main
  } // Fin de clase Programa
} // Fin de espacio de nombre