using System;

namespace PersonaInterfaces {
  class Detective : Persona, IMostrar {
    int noPlaca;

    public int NoPlaca {
      get { return noPlaca;  }
      set { noPlaca = value; }
    } // Fin de getters y setters

    public Detective():base() {}
    public Detective(string n, string a, string o, int p)
    :base(n, a, o) {
      noPlaca = p;
    } // Fin de constructor sobrecargado

    public override void ModificaOcupacion() {
      Ocupacion = "Jefe";
    } // Fin de método para cambiar ocupación

    public void Imprimir() {
      Console.Write("Me llamo {0} {1}, soy {2} y ",
        Nombre, Apellido, Ocupacion);
      Console.Write("mi placa es: {0}!\n", noPlaca);
    } // Fin de método para mostrar datos
  } // Fin de clase Detective
} // Fin de espacio de nombre