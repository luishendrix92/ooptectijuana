using System;

namespace ProgramaElevador {
  class Elevador {
    int pesoMax, capacidadMax, pisoActual = 0;
    bool puertaCerrada = true, enReparacion = false;

    // Getters y Setters
    public int PesoMax {
      get { return pesoMax;  }
      set { pesoMax = value; }
    } public int CapMax {
      get { return capacidadMax;  }
      set { capacidadMax = value; }
    } // Fin de getters y setters

    // Constructor y su sobrecarga
    public Elevador() {}
    public Elevador(int pesoMax, int capacidadMax) {
      this.pesoMax      = pesoMax;
      this.capacidadMax = capacidadMax;
    } // Fin de constructor propio

    // Métodos privados
    void desplazarElevador(int destino, int dir) {
      string direccion = (dir > 0)? "arriba" : "abajo";

      if (dir > 0) { // Arriba
        for (int i=pisoActual; i <= destino; i += 1) {
          Console.WriteLine("Estamos en el piso {0}", i);
        } // Fin de transladarse hasta cierto límite
      } else       { // Abajo
        for (int j=pisoActual; j >= destino; j -= 1) {
          Console.WriteLine("Estamos en el piso {0}", j);
        } // Fin de transladarse hasta cierto límite
      } // Fin de elegir dirección

      pisoActual = destino;
      Console.WriteLine("Has llegado a tu destino!");
    } // Fin de método para mover el elevador

    // Métodos públicos
    public void cambiarPiso(int pisoDestino) {
      if (pisoDestino == pisoActual)       {
        Console.WriteLine("Estás en el piso al que quieres ir...");
      } else if (pisoDestino > pisoActual) {
        desplazarElevador(pisoDestino, 1);
      } else if (pisoDestino < pisoActual) {
        desplazarElevador(pisoDestino, -1);
      } // Fin de condicionantes para dirección
    } // Fin de cambiar de piso 1 x 1
  } // Fin de clase Elevador
} // Fin de namespace