using System;
using System.Collections.Generic;

namespace Colores {
  class Programa {
    static void RecorrerLista(List<string> lista) {
      foreach (string color in lista) {
        Console.WriteLine("El color es: {0}", color);
      } // Fin de recorrer la lista
    } // Fin de método RecorrerLista

    static void Main() {
      Console.Clear();

      List<string> color = new List<string>() {
        "Rojo", "Verde", "Azul", "Amarillo"
      }; // Instanciación de lista

      // Añade un elemento al final de la lista
      Console.WriteLine("Agregando un color a la lista...");
      color.Add("Blanco");

      // Acceso a los elementos de la lista
      RecorrerLista(color);
      Console.WriteLine("El color {0} está en la posición 1.", color[1]);

      // Cambiar el valor del elemento usando el índice.
      Console.WriteLine("Cambiando el color de la posición 1 a Negro...");
      color[1] = "Negro";
      RecorrerLista(color);

      // Método insertar -> añade un nuevo elemento en una ubicación
      // específica de la y recibe 2 argumentos, un entero que indica
      // el índice de localización de la inserción y el elemento a insertar.
      Console.WriteLine("Insertando el color rosa en la posición 2...");
      color.Insert(2, "Rosa");
      RecorrerLista(color);

      // Ordenar listas
      Console.WriteLine("Ordenando la lista...");
      color.Sort();
      RecorrerLista(color);

      // Buscar elemento -> IndexOf devuelve el valor de un
      // índice de un elemento de la lista.
      Console.WriteLine("Posición del color negro -> {0}.",
      color.IndexOf("Negro"));

      // También se puede utilizar para reemplazar un valor con otro.
      Console.WriteLine("Reemplazar color negro por verde");
      color[color.IndexOf("Negro")] = "Verde";
      RecorrerLista(color);

      // .Count indica cuántos elementos hay almacenados en la lista
      Console.WriteLine("Hay {0} elementos en la lista", color.Count);

      // Propiedad que indica el tamaño actual de la lista
      Console.WriteLine("Tamaño de la lista = {0}", color.Capacity);

      // Cortar el exceso de capacidad en la lista
      color.TrimExcess();
      Console.WriteLine("Tamaño de la lista = {0} al quitar exceso.",
      color.Capacity);

      // Remover el color verde de la lista
      Console.WriteLine("Remover el color verde...");
      color.Remove("Verde");
      RecorrerLista(color);

      // Método Clear para borrar TODOS los elementos de la lista
      Console.WriteLine("Limpiar la lista...");
      color.Clear();
      RecorrerLista(color);
    } // Fin de método Main
  } // Fin de clase Programa
} // Fin de espacio de nombre