using System;

namespace ControlAlumnos {
  class Programa {
    public static void Main() {
      Console.Clear();

      Console.WriteLine("Dame tu nombre.");
      string nombre = Console.ReadLine();

      Console.WriteLine("Cuàl fue tu primer calificaciòn?");
      float cal1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Cuàl fue tu segunda calificaciòn?");
      float cal2 = float.Parse(Console.ReadLine());

      Console.WriteLine("Cuàl fue tu tercer calificaciòn?");
      float cal3 = float.Parse(Console.ReadLine());

      float promedio = (cal1 + cal2 + cal3) / 3;

      Console.WriteLine("Tu nombre es {0} y tu promedio es {1}.", nombre, promedio);
    } // Fin de mètodo Main
  } // Fin de clase principal
} // Fin de nombre de espacio

// Nom sem calif1 calif2 calif3 numctrl
