using System;

namespace PersonaInterfaces {
  class Mafioso : Persona, IMostrar {
    public Mafioso():base() {}
    public Mafioso(string n, string a, string o)
    :base(n, a, o) {
      // NADA POR AQUÍ AÚN...
    } // Fin de constructor sobrecargado

    public bool Investigado() {
      return false;
    } // Fin de cambiar status de investigado

    public override void ModificaOcupacion() {
      Ocupacion = "vendedor de droga";
    } // Fin de método para cambiar ocupación

    public void Imprimir() {
      Console.Write("Me llamo {0} {1}, soy {2} y ",
        Nombre, Apellido, Ocupacion);
      if(Investigado()) {
        Console.Write("estoy siendo buscado :(");
      } else { // Libre de problemas
        Console.Write("NO estoy siendo buscado!\n");
      } // Fin de imprimir datos
    } // Fin de método para mostrar datos
  } // Fin de clase Mafioso
} // Fin de espacio de nombre