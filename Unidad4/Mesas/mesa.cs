using System;

namespace Mesas {
  class Mesa {
    string fabricante, material;
    float costo;

    public string Fabricante {
      get { return fabricante;  }
      set { fabricante = value; }
    } public string Material {
      get { return material;  }
      set { material = value; }
    } public float Costo {
      get { return costo;  }
      set { costo = value; }
    } // Fin de getters y setters

    public Mesa() {}
    public Mesa(string f, string m, float c) {
      fabricante = f; material = m; costo = c;
    } // Fin de constructor sobrecargado

    virtual public void Imprimir() {
      Console.WriteLine("La mesa fue fabricada por {0}", fabricante);
      Console.WriteLine("Está hecha de {0} y cuesta {1:C2}."
        ,material, costo);
      Console.WriteLine("---------------------------------");
    } // Fin de método virtual para mostrar datos
  } // Fin de clase Mesa

  class MesaCircular : Mesa, IMostrar {
    float diametro;

    public float Diametro {
      get { return diametro;  }
      set { diametro = value; }
    } // Fin de getters y setters

    public MesaCircular():base() {}
    public MesaCircular(string f, string m, float c, float d)
    :base(f, m, c) { diametro = d; }

    public float Superficie() {
      const float PI = 3.14159f;

      return PI * (diametro / 2) * (diametro / 2);
    } // Fin de calcular el área

    public override void Imprimir() {
      base.Imprimir();
      Console.WriteLine("Diámetro: {0} - Área: {1}",
        diametro, Superficie());
      Console.WriteLine("Ésta es una mesa circular.\n");
    } // Fin de método para mostrar datos específicos
  } // Fin de clase MesaCircular

  class MesaRectangular : Mesa, IMostrar {
    float ancho, largo;

    public float Ancho {
      get { return ancho;  }
      set { ancho = value; }
    } public float Largo {
      get { return largo;  }
      set { largo = value; }
    } // Fin de getters y setters

    public MesaRectangular():base() {}
    public MesaRectangular(string f, string m, float c, float a, float l)
    :base(f, m, c) { ancho = a; largo = l; }

    public float Superficie() {
      return ancho * largo;
    } // Fin de calcular el área

    public  override void Imprimir() {
      base.Imprimir();
      Console.WriteLine("Medidas: {0} x {1} - Área: {2}",
        largo, ancho, Superficie());
      Console.WriteLine("Ésta es una mesa rectangular.\n");
    } // Fin de método para mostrar datos específicos
  } // Fin de clase MesaRectangular
} // Fin de espacio de nombre