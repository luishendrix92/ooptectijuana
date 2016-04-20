using System;

namespace PracticaUno {
  class Mesa : Mueble {
    public Mesa() {}
    public Mesa(string f, string m, float p, float c, float a)
    :base(f, m, p, c, a) {}
  } // Fin de clase Mesa

  class MesaCircular : Mesa {
    float diametro;

    public float Diametro {
      get { return diametro;  }
      set { diametro = value; }
    } // Fin de getters y setters

    public MesaCircular():base() {}
    public MesaCircular(string f, string m, float p, float c, float a, float d)
    :base(f, m, p, c, a) {
      diametro = d;
    } // Fin de constructor sobrecargado

    private float Superficie() {
      const float PI = 3.14159f;

      return PI * (diametro / 2) * (diametro / 2);
    } // Fin de calcular el área

    public void Imprimir() {
      base.Imprime();
      Console.WriteLine("Esta mesa circular tiene {0}m de diámetro.", diametro);
      Console.WriteLine("Tiene un área de {0} metros cuadrados.", Superficie());
    } // Fin de método para mostrar datos específicos
  } // Fin de clase MesaCircular

  class MesaRectangular : Mesa {
    float ancho, largo;

    public float Ancho {
      get { return ancho;  }
      set { ancho = value; }
    } public float Largo {
      get { return largo;  }
      set { largo = value; }
    } // Fin de getters y setters

    public MesaRectangular():base() {}
    public MesaRectangular(string f, string m, float p, float c, float a, float w, float l)
    :base(f, m, p, c, a) {
      ancho = w; largo = l;
    } // Fin de constructor sobrecargado

    private float Superficie() {
      return ancho * largo;
    } // Fin de calcular el área

    public void Imprimir() {
      base.Imprime();
      Console.WriteLine("Esta mesa rectangular mide {0}x{1} metros."
        , ancho, largo);
      Console.WriteLine("Tiene un área de {0} metros cuadrados.", Superficie());
    } // Fin de método para mostrar datos específicos
  } // Fin de clase MesaRectangular
} // Fin de espacio de nombre