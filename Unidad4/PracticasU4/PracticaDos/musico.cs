using System;

namespace AsociacionMusical {
  interface IIdentificable {
    bool yTuCantas();
  } // Fin de interfaz Identificable
  
  abstract class Musico {
    string nombre;
    
    public string Nombre {
      get { return nombre;  }
      set { nombre = value; }
    } // Fin de getters y setters
    
    public Musico() {}
    public Musico(string nombre) {
      this.nombre = nombre;
    } // Fin de constructore sobrecargado
    
    public string ComoTeLlamas() {
      return nombre;
    } // Fin de conocer el nombre del músico
    
    abstract public bool yTuCantas();
    abstract public void ImprimirDatos();
  } // Fin de clase Musico
} // Fin de espacio de nombre