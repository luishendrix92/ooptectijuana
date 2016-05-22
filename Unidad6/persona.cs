using System.Collections.Generic;
using System;

namespace ArchivosBinarios {
  class Persona {
    string nombre, ocupacion;
    short edad;
    bool estaVivo;
    float altura;
    
    public string Nombre {
      get { return nombre;  }
      set { nombre = value; }
    } public string Ocupacion {
      get { return ocupacion;  }
      set { ocupacion = value; }
    } public short Edad {
      get { return edad;  }
      set { edad = value; }
    } public bool EstaVivo {
      get { return estaVivo;  }
      set { estaVivo = value; }
    } public float Altura {
      get { return altura;  }
      set { altura = value; }
    } // Fin de getters y setters
    
    public Persona(string n, string o, short e, bool v, float a) {
      nombre = n; ocupacion = o; edad = e;
      estaVivo = v; altura = a;
    } // Fin de único constructor del modelo
    
    public string Saludo() {
      return "Me llamo " + nombre + " y tengo " + edad + " años, soy " + ocupacion + ", estoy " + ((estaVivo)? "vivo" : "muerto") + " y mido " + altura + "m";
    } // Fin de devolver el saludo personalizado de la clase
  } // Fin de clase Animal
} // Fin de espacio de nombre