using System.Collections.Generic;
using System.Linq;
using System;

namespace Figuras {
  class Triangulo {
    /*-- Propiedades ----------*/
    string nombre;
    // Nota: El lado [0] siempre
    // será para la base!!
    float[] lados = new float[3];


    /*-- Get & Set --------------------*/
    public string Nombre {
      get { return nombre;  }
      set { nombre = value; }
    } public float LadoA {
      get { return lados[0];  }
      set { // Nuevo tamaño de triángulo
        lados = escalar(0, value, lados);
      } // Fin de escalar los 3 lados
    } public float LadoB {
      get { return lados[1];  }
      set { // Nuevo tamaño de triángulo
        lados = escalar(1, value, lados);
      } // Fin de escalar los 3 lados
    } public float LadoC {
      get { return lados[2];  }
      set { // Nuevo tamaño de triángulo
        lados = escalar(2, value, lados);
      } // Fin de escalar los 3 lados
    } public float[] Lados {
      get { return lados;  }
      set { // Verificar validez
        if (validar(value)) {
          lados = value;
        } else { // Default
          Console.WriteLine("INVÁLIDO!");
          lados = new float[] {1,1,1};
        } // Fin de validar
      } // Fin de re-dimensionar
    }// Fin de getters y setters


    /*-- Constructores -------- 6 sobrecargas --------*/
    public Triangulo() { nombre = "Triángulo Anónimo"; }
    public Triangulo(string nombre) {
      this.nombre = nombre;
      this.lados = new float[] {1,1,1};
    } public Triangulo(string nombre, float[] lados) {
      this.nombre = nombre;
      this.lados  = lados;

      if (validar(lados)) {
        this.lados = lados;
      } else { // Default
        Console.WriteLine("INVÁLIDO!");
        this.lados = new float[] {1,1,1};
      } // Fin de validar
    } public Triangulo(float[] lados) {
      nombre     = "Triángulo Anónimo";
      this.lados = lados;

      if (validar(lados)) {
        this.lados = lados;
      } else { // Default
        Console.WriteLine("INVÁLIDO!");
        this.lados = new float[] {1,1,1};
      } // Fin de validar
    } public Triangulo(string nombre, float lado) {
      // Construye un triángulo equilátero
      this.nombre = nombre;
      lados[0]    = lado;
      lados[1]    = lado;
      lados[2]    = lado;

      if(lado <= 0) {
        Console.WriteLine("SIN TAMAÑO!");
        lados = new float[] {1,1,1};
      } // Fin de asegurarse que haya un lado
    } public Triangulo(float Base, float altura) {
      // Construye un triángulo rectángulo
      this.nombre = "Triángulo Anónimo";
      lados[0]    = Base;
      lados[1]    = (float) Math.Sqrt(((Base/2)
                    *(Base/2))+((altura)*(altura)));
      lados[2]    = (float) Math.Sqrt(((Base/2)
                    *(Base/2))+((altura)*(altura)));
    } public Triangulo(string n, float b, float h) {
      // Construye un triángulo rectángulo
      nombre      = n;
      lados[0]    = b;
      lados[1]    = (float) Math.Sqrt(((b/2)
                    *(b/2))+((h)*(h)));
      lados[2]    = (float) Math.Sqrt(((b/2)
                    *(b/2))+((h)*(h)));
    } // Fin de métodos constructores


    /*-- Métodos estáticos --------------------------*/
    static float pitagoras(float b, float h) {
      return (float) Math.Sqrt((b*b) + (h*h));
    } // Fin de calcular hipotenusa

    static bool validar(float[] lados) {
      if (lados.Length != 3) {
        return false; // Debe tener 3 lados
      } else { // Triángulo tiene 3 lados
        return  (lados[0] + lados[1] > lados[2])&&
                (lados[0] + lados[2] > lados[1])&&
                (lados[1] + lados[2] > lados[0]);
      } // Fin de condicionantes y tests de lados
    } // Fin de teorema de desigualdad de triángulos

    static float[] escalar(int i, float v, float[] l) {
      float factor = v / l[i]; // escala en % decimal

      // Triángulo re-dimensionado equitativamente
      return new float[3] {
        l[0] * factor, l[1] * factor, l[2] * factor
      }; // Fin de construir arreglo
    } // Fin de crecer o achicar triángulo


    /*-- Métodos ----------------------------------------*/
    public float calcularArea() {
      // Utilizando la Fórmula de Herón en la que obtenemos
      // triánngulo conociendo sus 3 lados.
      float semiPerim = (lados[0]+lados[1]+lados[2]) / 2,
            a = semiPerim - lados[0],
            b = semiPerim - lados[1],
            c = semiPerim - lados[2];

      return (float) Math.Sqrt(semiPerim * a * b * c);
    } // Fin de fórmula de Herón

    public float[] angulos() {
      // Ley de cosenos conociendo 3 lados
      float anguloA = (float) Math.Acos(
                      ((lados[1]*lados[1])+
                      (lados[2]*lados[2])-
                      (lados[0]*lados[0]))/
                      (2*lados[1]*lados[2]))*
                      (180 / (float) Math.PI);
      float anguloB = (float) Math.Acos(
                      ((lados[0]*lados[0])+
                      (lados[2]*lados[2])-
                      (lados[1]*lados[1]))/
                      (2*lados[0]*lados[2]))*
                      (180 / (float) Math.PI);
      float anguloC = 180 - anguloA - anguloB;

      return new float[3] {anguloA, anguloB, anguloC};
    } // Fin de obtener ángulos internos

    public float altura() {
      // Despejando la fórmula del área -> h = 2A/b
      return (2 * calcularArea()) / lados[0];
    } // Calcular altura del triángulo

    public string determinarTipo() {
      float a = lados[0],
            b = lados[1],
            c = lados[2];

      if        (a == b && b == c)           {
        return "equilátero";
      } else if (a == b || a == c || c == b) {
        if (angulos().Contains(90)) {
          return "rectángulo";
        } else {
          return "isóceles";
        } // Fin de buscar 90°
      } else if (a != b || a != c || c != b) {
        if (angulos().Contains(90)) {
          return "rectángulo";
        } else {
          return "escaleno";
        } // Fin de buscar 90°
      } else { // Si por alguna extraña razón...
        return "indeterminado";
      }// Fin de revisar y comparar lados
    } // Fin de determinar tipo (Irreg, Rect, Isósceles)
  } // Fin de clase Triángulo
} // Fin de espacio de nombre