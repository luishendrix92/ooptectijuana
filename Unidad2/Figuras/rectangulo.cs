using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System;

namespace Figuras {
  class Rectangulo {
    /*-- Propiedades -*/
    float ancho, alto;
    string nombre;

    /*-- Get & Set ------------*/
    public string Nombre {
      get { return nombre;  }
      set { nombre = value; }
    } public float Ancho {
      get { return ancho;  }
      set { ancho = value; }
    } public float Alto {
      get { return alto;  }
      set { alto = value; }
    } // Fin de getters y setters

    /*-- Constructores ---------------------------------*/
    public Rectangulo() { nombre = "Rectángulo Anónimo"; }
    public Rectangulo(string nom, float an, float al) {
      nombre = nom; ancho = an; alto = al;
    } public Rectangulo(float ancho, float alto) {
      this.alto  = alto;
      this.ancho = ancho;
      nombre     = "Rectángulo Anónimo";
    } // Fin de métodos constructores

    /*-- Métodos ---------------*/
    float calcularPerimetro() {
      return (ancho + alto) * 2;
    } // Fin de calcular perímetro

    float calcularArea() {
      return ancho * alto;
    } // Fin de calcular área

    public void Detalles() {
      Console.Clear();
      Console.WriteLine("###################################");
      Console.WriteLine("## Nombre: {0}", nombre);
      Console.WriteLine("###################################");

      Console.WriteLine("\nEste es un rectángulo con los");
      Console.WriteLine("siguientes detalles de figura:");

      Console.WriteLine("\nPropiedades:");
      Console.WriteLine("-----------------------------------");
      Console.WriteLine("Altura: {0}", alto);
      Console.WriteLine("Anchura: {0}", ancho);
      Console.WriteLine("Área: {0}", calcularArea());
      Console.WriteLine("Perímetro: {0}", calcularPerimetro());

      Console.WriteLine("\nPresione cualquier tecla para continuar...");
      Console.ReadKey();
    } // Fin de imprimir ficha del triángulo
  } // Fin de clase Rectángulo
} // Fin de espacio de nombre