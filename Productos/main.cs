using System;
using System.Collections.Generic;

namespace LabClase4 {
  class ProgramaConsola {
    public static Producto CapturarProducto() {
      Console.WriteLine("¿Cuál es el nombre del producto?");
      string nombre = Console.ReadLine();

      Console.WriteLine("\nEscríbele una descripción:");
      string descripcion = Console.ReadLine();

      Console.WriteLine("\n¿Cuánto valdrá cada uno?");
      float precioUnit = float.Parse(Console.ReadLine());

      return new Producto(nombre, descripcion, precioUnit);
    } // Fin de método estático

    public static void Main() {
      Console.Clear();
      int numProdParaCapt = 2;
      List<Producto> productos = new List<Producto>();

      for (int i = 0; i < numProdParaCapt; i += 1) {
        Console.WriteLine("=====================================");
        Console.WriteLine("|| CAPTURA EL PRODUCTO #{0}          ||", numProdParaCapt);
        Console.WriteLine("=====================================");
        productos.Add(CapturarProducto());
      } // Fin de iterar para capturar

      foreach (Producto producto in productos)
      { producto.imprimirNota(4); }
    } // Fin de método Main
  } // Fin de clase Programa
} // Fin de nombre de espacio