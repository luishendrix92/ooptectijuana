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
  } // Fin de clase Cuadrado
} // Fin de espacio de nombre