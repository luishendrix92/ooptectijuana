using System;

namespace PersonaInterfaces {
  class Programa {
    static void Main() {
      Console.Clear();
      // INICIA EL PROGRAMA >>>>>>>>>>>>>>>>>>>>
      Mafioso capone = new Mafioso(
        "Al", "Capone", "Mafioso"
      ); // Fin de instanciación
      Detective holmes = new Detective(
        "Sherlock", "Holmes", "Detective", 4123
      ); // Fin de instanciación

      capone.Imprimir();
      holmes.Imprimir();
      capone.ModificaOcupacion();
      holmes.ModificaOcupacion();
      capone.Imprimir();
      holmes.Imprimir();
      // <<<<<<<<<<<<<<<<<<< TERMINA EL PROGRAMA
      Console.ReadKey();
    } // Fin de método principal
  } // Fin de clase Programa
} // Fin de espacio de nombre