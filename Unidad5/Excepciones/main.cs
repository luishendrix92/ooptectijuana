using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System;

namespace Excepciones {
  class Programa {
    public static void Main() {
      Console.Clear();
      
      /* Posibles Excepciones:
      System.FormatException -> Si se escribe nada o
      caracteres que no son números.
      System.OverflowException -> Si se escribe un
      número mayor al tamaño máximo de un entero. */
      
      // INICIO DEL PROGRAMA ====>
      int num = 0, num2 = 0, num3 = 0;
      
      try {
        Console.WriteLine("Dame un número:");
        num = int.Parse(Console.ReadLine());
        num++; // Incrementando 1 al número
      } catch {
        Console.WriteLine("Hubo un error!");
      } finally {
        Console.WriteLine("Tu número es {0}\n", num);
      } // Fin de manejar excepciones
      
      try {
        Console.WriteLine("Dame otro número:");
        num2 = int.Parse(Console.ReadLine());
        num2++; // Incrementando 1 al número
      } catch(OverflowException) {
        Console.WriteLine("El número introducido es demasiado grande!");
      } catch(FormatException) {
        Console.WriteLine("No introdujiste un número...");
      } finally {
        Console.WriteLine("Tu segundo número es {0}\n", num2);
      } // Fin de manejar excepciones
      
      try {
        Console.WriteLine("Dame el último número:");
        num3 = int.Parse(Console.ReadLine());
        num3++; // Incrementando 1 al número
      } catch(FormatException error) {
        Console.WriteLine("Ocurrió lo siguiente: {0}", error.Message);
      } catch(OverflowException error) {
        Console.WriteLine("Ocurrió lo siguiente: {0}", error.Message);
      } finally {
        Console.WriteLine("El último número es: {0}", num3);
      } // Fin de manejar excepciones
      // <======= FIN DEL PROGRAMA
      
      Console.ReadKey(true);
    } // Fin de Método Principal
  } // Fin de clase Programa
} // Fin de espacio de nombre