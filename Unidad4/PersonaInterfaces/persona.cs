using System;

namespace PersonaInterfaces {
  abstract class Persona {
    string nombre, apellido, ocupacion;

    public string Nombre {
      get { return nombre;  }
      set { nombre = value; }
    } public string Apellido {
      get { return apellido;  }
      set { apellido = value; }
    } public string Ocupacion {
      get { return ocupacion;  }
      set { ocupacion = value; }
    } // Fin de getters y setters

    public Persona() {}
    public Persona(string n, string a, string o) {
      nombre = n; apellido = a; ocupacion = o;
    } // Fin de constructor sobrecargado

    abstract public void ModificaOcupacion();
  } // Fin de clase Persona
} // Fin de espacio de nombre