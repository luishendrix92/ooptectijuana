using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System;

namespace Figuras {
  class Trapecio {
    /*-- Propiedades ----------------*/
    float baseMenor, baseMayor, altura;
    string nombre;

    /*-- Get & Set ------------*/
    public float BaseMenor {
      get { return baseMenor;  }
      set { baseMenor = value; }
    } public float BaseMayor {
      get { return baseMayor;  }
      set { baseMayor = value; }
    } public float Altura {
      get { return altura;  }
      set { altura = value; }
    } public string Nombre {
      get { return nombre;  }
      set { nombre = value; }
    } // Fin de getters y setters

    /*-- Constructores -------------------------------------*/
    public Trapecio() { nombre = "Trapecio Anónimo"; }
    public Trapecio(string n, float bme, float bma, float h) {
      nombre    = n;
      baseMenor = bme;
      baseMayor = bma;
      altura    = h;
    } public Trapecio(float bme, float bma, float h) {
      nombre    = "Trapecio Anónimo";
      baseMenor = bme;
      baseMayor = bma;
      altura    = h;
    } // Fin de métodos constructores

    /*-- Métodos estáticos -----------------*/
    static float pitagoras(float b, float h) {
      return (float) Math.Sqrt((b*b) + (h*h));
    } // Fin de calcular hipotenusa

    /*-- Métodos -----------------------------------------------------*/
    float calcularPerimetro() {
      float b = (baseMayor - baseMenor) / 2;
      float lado = pitagoras(b, altura);

      return baseMenor + baseMayor + (lado * 2);
    } // Fin de calcular perímetro

    float calcularArea() {
      return ((baseMenor + baseMayor) * altura) / 2;
    } // Fin de calcular área

    public void Detalles() {
      Console.Clear();
      Console.WriteLine("###################################");
      Console.WriteLine("## Nombre: {0}", nombre);
      Console.WriteLine("###################################");

      Console.WriteLine("\nEste es un trapecio regular con los");
      Console.WriteLine("siguientes detalles de figura:");

      Console.WriteLine("\nPropiedades:");
      Console.WriteLine("-----------------------------------");
      Console.WriteLine("Altura: {0}", altura);
      Console.WriteLine("Base Menor: {0}", baseMenor);
      Console.WriteLine("Base Mayor: {0}", baseMayor);
      Console.WriteLine("Área: {0}", calcularArea());
      Console.WriteLine("Perímetro: {0}", calcularPerimetro());

      Console.WriteLine("\nPresione cualquier tecla para continuar...");
      Console.ReadKey();
    } // Fin de imprimir ficha del triángulo
  } // Fin de clase Trapecio
} // Fin de espacio de nombre