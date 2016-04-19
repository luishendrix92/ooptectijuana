using System;

namespace Interfaces {
  class Folder {
    public Folder() {}
  } // Fin de clase Folder

  interface ICambiar {
    void Cambiar();
  } // Fin de interface

  interface IProp {
    string Doc {
      get;
      set;
    } // Fin de getter y setter
  } // Fin de interface
} // Fin de espacio de nombre
