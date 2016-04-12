using System;

namespace FigurasPoli {
  class Circulo : Figura {
    float radio;
    const float PI = (float) Math.PI;

    public float Radio {
      get { return radio;  }
      set { radio = value; }
    } // Fin de getters y setters

    public Circulo():base("Sin nombre") {}
    public Circulo(string nom, float rad)
    :base(nom) { radio = rad; }

    public override float Area() {
      return PI * radio * radio;
    } // Fin de calcular área del círculo

    public override float Perimetro() {
      return PI * 2 * radio;
    } // Fin de calcular el perímetro

    public override void MostrarDatos() {
      Console.WriteLine("Nombre del círculo: {0}", Nombre);
      Console.WriteLine("Área del círculo: {0}", Area());
      Console.WriteLine("Perímetro del círculo: {0}", Perimetro());
    } // Fin de mostrar datos del círculo en consola
  } // Fin de clase Circulo
} // Fin de espacio de nombre