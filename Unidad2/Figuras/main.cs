using System;

namespace Figuras {
  class Programa {
    static void Main() {
      Console.ForegroundColor = ConsoleColor.White;
      Console.BackgroundColor = ConsoleColor.Blue;

      // Instanciación de figuras
      Triangulo recto  = new Triangulo(
        new float[3] {1,1,(float)Math.Sqrt(2)}
      ); // Fin de construir triángulo
      Triangulo equi   = new Triangulo(
        "Equilaterito", 50
      ); // Fin de construir triángulo
      Triangulo irregu = new Triangulo(
        new float[3] {7,8,9}
      ); // Fin de construir triángulo

      Circulo redondo  = new Circulo("Redondín", 7);
      Cuadrado ventana = new Cuadrado(94);
      Rectangulo palo  = new Rectangulo("Palito", 2, 50);
      Trapecio rampa   = new Trapecio(5, 13, 6);

      // Imprimir los detalles de cada figura
      recto.Detalles() ;
      equi.Detalles()  ;
      equi.LadoB = 25  ; // Mitad
      equi.Detalles()  ;
      irregu.Detalles();

      redondo.Detalles();
      ventana.Detalles();
      palo.Detalles()   ;
      rampa.Detalles()  ;

      // Limpiar pantalla y terminar programa
      Console.Clear();
    } // Fin de Método Main
  } // Fin de clase Programa
} // Fin de espacio de nombre