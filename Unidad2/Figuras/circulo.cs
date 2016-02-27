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
  } // Fin de clase Circulo
} // Fin de espacio de nombre