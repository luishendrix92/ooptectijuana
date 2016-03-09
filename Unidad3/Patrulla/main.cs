using System;

namespace PatrullaHerencia {
  class Programa {
    public static void Main() {
      Console.Clear();
      Patrulla sirenitas = new Patrulla(
        "54ABD9C", "Nissan Sentra"
      ); // Fin de instanciar un vehículo

      sirenitas.Imprimir();
      sirenitas.PrenderApagarSirena();
      sirenitas.PrenderApagarSirena();
    } // Fin de Método Main
  } // Fin de clase Programa
} // Fin de espacio de nombre
