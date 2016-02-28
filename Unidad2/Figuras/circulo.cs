using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System;

namespace Figuras {
  class Circulo {
    /*-- Propiedades --------*/
    string nombre; float radio;

    /*-- Propiedades estáticas ----*/
    const float PI = (float) Math.PI;

    /*-- Get & Set ------------*/
    public string Nombre {
      get { return nombre;  }
      set { nombre = value; }
    } public float Radio {
      get { return radio;  }
      set { radio = value; }
    } // Fin de getters y setters

    /*-- Constructores ---------------------------*/
    public Circulo() { nombre = "Círculo Anónimo"; }
    public Circulo(string nombre, float radio) {
      this.nombre = nombre;
      this.radio  = radio;
    } public Circulo(float radio) {
      this.radio  = radio;
      nombre      = "Círculo Anónimo";
    } // Fin de métodos constructores

    /*-- Métodos -----------------------------*/
    public float calcularDiametro() {
      return radio * 2;
    } // Fin de regresar el diámetro del círculo

    public float calcularCircunferencia() {
      return 2 * PI * radio;
    } // Fin de calcular el perímetro circular

    public float calcularArea() {
      return PI * (radio * radio);
    } // Fin de calcular el área del círculo

    public void Detalles() {
      Console.Clear();
      Console.WriteLine("###################################");
      Console.WriteLine("## Nombre: {0}", nombre);
      Console.WriteLine("###################################");

      Console.WriteLine("\nEste es un círculo con los");
      Console.WriteLine("siguientes detalles de figura:");

      Console.WriteLine("\nPropiedades:");
      Console.WriteLine("-----------------------------------");
      Console.WriteLine("Radio: {0}", radio);
      Console.WriteLine("Diámetro: {0}", calcularDiametro());
      Console.WriteLine("Área: {0}", calcularArea());
      Console.WriteLine("Circunferencia: {0}",calcularCircunferencia());

      Console.WriteLine("\nPresione cualquier tecla para continuar...");
      Console.ReadKey();
    } // Fin de imprimir ficha del triángulo
  } // Fin de clase Circulo
} // Fin de espacio de nombre