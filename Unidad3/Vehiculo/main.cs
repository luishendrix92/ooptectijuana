using System;

namespace U3L2 {
  class Programa {
    public static void Main() {
      Console.Clear();
      Vehiculo carro = new Vehiculo(
        "54ABD9C", "Ford", "Fiesta", "Compacto", 245.53f, 4
      ); // Fin de instanciar un vehículo
      Vehiculo speedy = new Vehiculo(
        "SP33DY1", "Honda", "Civic", "Sedán", 123.98f, 7
      ); // Fin de instanciar un vehículo

      carro.Imprimir();
      speedy.Imprimir();
    } // Fin de Método Main
  } // Fin de clase Programa
} // Fin de espacio de nombre