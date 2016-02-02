using System;

namespace TareaUno {
  class Programa {
    public static void Main() {
      /* Capturar 5 alumnos, para cada 1, caputrar
      sus 3 calificaciones e imprimir su promedio.
      ¿Qué alumno sacó menor calificación?
      ¿Qué alumno sacó mayor calificación?
      ¿Cuántos alumnos reprobaron?              */
      int numAlumnos = 5, numCalificaciones = 3;
      int[] promedios;
      promedios = new int[numAlumnos];
      int mayor = 0, menor = 0;

      for (int i = 0; i < numAlumnos; i += 1) {
        int[] calificaciones;
        int sumaCalif = 0;
        calificaciones = new int[numCalificaciones];

        for (int j = 0; i < numCalificaciones; j += 1) {
          calificaciones[j] = int.Parse(Console.ReadLine());
        } // Fin de pedir calificaciones

        foreach(int calificacion in calificaciones) {
          sumaCalif += calificacion;
        } // Fin de iterar sobre calificaciones

        Console.WriteLine("El alumno #{0} sacó {1} de promedio.",
        i, sumaCalif / numCalificaciones);

        promedios[i] = sumaCalif / numCalificaciones;
      } // Fin de capturar promedios

      // SORTING ALGORITHM

      Console.WriteLine("El alumno con el mayor promedio obtuvo: {0}", mayor);
      Console.WriteLine("El alumno con el menor promedio obtuvo: {0}", menor);
    } // Fin de Método Main
  } // Fin de clase
} // Fin de namespace