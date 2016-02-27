using System;

namespace Figuras {
  class Programa {
    public static void Main() {
      Console.Clear();

      Triangulo triangu = new Triangulo(
        //new float[3] {1,1,(float)Math.Sqrt(2)}
        "Fulano", 40, 20
      ); // Fin de construir triángulo

      float[] angus = triangu.angulos();

      foreach (float angulo in angus)
      { Console.WriteLine(angulo); }

      foreach (float lado in triangu.Lados)
      { Console.WriteLine(lado); }

      Console.WriteLine(triangu.altura());
      Console.WriteLine(triangu.calcularArea());
      Console.WriteLine(triangu.determinarTipo());

    } // Fin de Método Main
  } // Fin de clase Programa
} // Fin de espacio de nombre