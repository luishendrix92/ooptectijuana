using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System;

namespace Figuras {
  class Cuadrado {
    /*-- Propiedades -*/
    string nombre;
    float lado;

    /*-- Get & Set ------------*/
    public string Nombre {
      get { return nombre;  }
      set { nombre = value; }
    } public float Lado {
      get { return lado;  }
      set { lado = value; }
    } // Fin de getters y setters

    /*-- Constructores ---------------------------*/
    public Cuadrado() { nombre = "Cuadro Anónimo"; }
    public Cuadrado(string nombre, float lado) {
      this.nombre = nombre;
      this.lado   = lado;
    } public Cuadrado(float lado) {
      this.lado = lado;
      nombre    = "Cuadro Anónimo";
    } // Fin de métodos constructores

    /*-- Métodos ---------------*/
    float calcularPerimetro() {
      return lado * 4;
    } // Fin de calcular perímetro

    float calcularArea() {
      return lado * lado;
    } // Fin de calcular área

    public void Detalles() {
      Console.Clear();
      Console.WriteLine("###################################");
      Console.WriteLine("## Nombre: {0}", nombre);
      Console.WriteLine("###################################");

      Console.WriteLine("\nEste es un cuadrado con los");
      Console.WriteLine("siguientes detalles de figura:");

      Console.WriteLine("\nPropiedades:");
      Console.WriteLine("-----------------------------------");
      Console.WriteLine("Lado: {0}", lado);
      Console.WriteLine("Área: {0}", calcularArea());
      Console.WriteLine("Perímetro: {0}", calcularPerimetro());

      Console.WriteLine("\nPresione cualquier tecla para continuar...");
      Console.ReadKey();
    } // Fin de imprimir ficha del triángulo
  } // Fin de clase Cuadrado
} // Fin de espacio de nombre