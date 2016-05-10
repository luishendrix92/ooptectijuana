using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System;

namespace Tabla {
  class Programa {
    static int CapturarNumero() {
      int valor = 0, index = 0;
      
      while (true) {
        try { valor = int.Parse(Console.ReadLine()); break;                     }
        catch(OverflowException)
        { Console.WriteLine("El número es muy grande, captúralo de nuevo:");    }
        catch(FormatException)
        { Console.WriteLine("Formato de número inválido, captúralo de nuevo:"); }
      } // Fin de ciclo infinito
      
      return valor;
    } // Fin de capturar un número válido
    
    static void Main(string[] args) {
      Console.Clear();
      
      List<int> Tabla = new List<int>();
      
      for (int i = 0; i < 5; i++) {
        Console.WriteLine("Escribe {0}° número:", i);
        Tabla.Add(CapturarNumero());
      } // Fin de contar 5 veces
      
      for (int i = 0; i < Tabla.Count; i++) {
        Console.WriteLine("Tabla[{0}] = {1}", i, Tabla[i]);
      } // Fin de iterar la tabla
      
      while (true) {
        try {
          Console.WriteLine("Qué elemento de la tabla quieres ver?");
          index = CapturarNumero();
          break;
        } catch(ArgumentOutOfRangeException) {
          Console.WriteLine("No se pudo leer el valor, de nuevo:");
        } // Fin de capturar error de rango
      } // Fin de ciclo infinito
      
      Console.WriteLine(Tabla[5]);
      
      Console.ReadKey();
      Console.Clear();
    } // Fin de Método Main
  } // Fin de clase Programa
} // Fin de espacio de nombre