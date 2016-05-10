using System.Collections.Generic;
using System.Globalization;
using System.Collections;
using System.Linq;
using System;

namespace DivisionCero {
  class Programa {
    static void MostrarDatos(Exception error) {
      Console.WriteLine("DATOS DEL ERROR");
      Console.WriteLine("=====================================");
      Console.WriteLine("Mensaje: " + error.Message);
      Console.WriteLine("-------------------------------------");
      Console.WriteLine("Origen: " + error.StackTrace);
      Console.WriteLine("-------------------------------------");
      Console.WriteLine("Fuente: " + error.Source);
      Console.WriteLine("-------------------------------------");
      Console.WriteLine("Ayuda en: " + error.HelpLink);
      Console.WriteLine("-------------------------------------");
      if (error.Data.Count > 0) {
        Console.WriteLine("Datos de la colección Data");
        foreach (DictionaryEntry dato in error.Data) {
          Console.WriteLine("Llave: {0,-20} Valor: {1}", dato.Key, dato.Value);
        } // Fin de mostrar datos extra...
      } // Fin de ver si hay datos qué mostrar
    } // Fin de método para mostrar datos del error
    
    static void Main(string[] args) {
      int num = 0;
      int div = 0;
      
      Console.Clear();
      
      try {
        Console.WriteLine("Cuál es el numerador?");
        num = int.Parse(Console.ReadLine());
        Console.WriteLine("Cuál será el denominador?");
        div = int.Parse(Console.ReadLine());
        Console.WriteLine("{0} entre {1} da {2}",
          num, div, num/div);
      } catch(FormatException error) {
        MostrarDatos(error);
      } catch(OverflowException error) {
        MostrarDatos(error);
      } catch(DivideByZeroException error) {
        MostrarDatos(error);
      } finally {
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
      } // Fin de control de errores
    } // Fin de Método Main
  } // Fin de clase Programa
} // Fin de espacio de nombre