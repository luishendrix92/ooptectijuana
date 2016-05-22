using System;

namespace MinutosValidos {
  class Programa {
    static void Main(string[] args) {
      Console.Clear();
      
      // INICIA EL PROGRAMA ---->
      float minuto = 0; // Segundos
      
      try {
        Console.WriteLine("¿Cuántos segundos tiene tu minuto?");
        minuto = float.Parse(Console.ReadLine());
        if (minuto > 60 || minuto < 0)
        { throw new InvalidTimeZoneException("Segundos negativos o mayor a 60!"); }
      } catch(InvalidTimeZoneException error) {
        Console.WriteLine(error.Message); minuto = 0;
      } finally {
        Console.WriteLine("El minuto tiene {0} segundos.", minuto);
      } // Fin de capturar la excepción de minuto inválido
      
      Console.WriteLine("\nPresione cualquier tecla para finalizar...");
      // <--- TERMINA EL PROGRAMA
      
      Console.ReadKey();
      Console.Clear();
    } // Fin de Método Main
  } // Fin de clase Programa
} // Fin de espacio de nombre

