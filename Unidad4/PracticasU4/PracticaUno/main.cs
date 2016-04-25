using System;

namespace Zoologico {
  class Programa {
    static void Main(string[] args) {
      Console.Clear();
      
      // INICIA EL PROGRAMA =====>
      Mamifero perro = new Mamifero(
        "perro", "Rufo", 45.34, 12
      ); // Fin de instanciación
      Ave tucan = new Ave(
        "tucán", "Tuki Tuki", 2.45, 4,
        "negro", 124
      ); // Fin de instanciación
      Insecto kabuto = new Insecto(
        "escarabajo", "Kabutops", 0.24, 1, true
      ); // Fin de instanciación
      
      perro.queClaseDeAnimalEres();
      tucan.queClaseDeAnimalEres();
      kabuto.queClaseDeAnimalEres();
      // <==== TERMINA EL PROGRAMA
      
      Console.ReadKey();
    } // Fin de Método Main
  } // Fin de clase Programa
} // Fin de Zoologico