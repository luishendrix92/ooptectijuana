using System;

namespace FigurasPoli {
  abstract class Figura {
    string nombre;

    public string Nombre {
      get { return nombre;  }
      set { nombre = value; }
    } // Fin de getters y setters

    public Figura() {}
    public Figura(string n) { nombre = n; }

    public abstract float Area();
    public abstract float Perimetro();

    public virtual void MostrarDatos() {
      Console.WriteLine("Nombre: {0}", nombre);
    } // Fin de mostrar datos en consola
  } // Fin de clase Figura
} // Fin de espacio de nombre