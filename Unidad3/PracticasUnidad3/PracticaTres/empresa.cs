using System;

namespace PracticaTres {
  // ================================
  // CLASES DERIVADAS - PRIMER NIVEL
  // ================================
  class Empleado : Persona {
    string numEmpleado;
    int diasTrabajados;
    float sueldoDiario;

    public string NumEmpleado {
      get { return numEmpleado;  }
      set { numEmpleado = value; }
    } public int DiasTrabajados {
      get { return diasTrabajados;  }
      set { diasTrabajados = value; }
    } public float SueldoDiario {
      get { return sueldoDiario;  }
      set { sueldoDiario = value; }
    } // Fin de getters and setters

    public float SueldoSemanal() {
      return diasTrabajados * sueldoDiario;
    } // Fin de pre-sueldo antes de bonos

    public Empleado():base() {}
    public Empleado(string n, string num, int d, float s)
    :base(n) {
      numEmpleado = num; diasTrabajados = d; sueldoDiario = s;
    } // Fin de constructor sobrecargado
  } // Fin de clase Empleado

  class Cliente : Persona {
    const float DESCUENTO = 0.12f;
    string empresa;

    public string Empresa {
      get { return empresa;  }
      set { empresa = value; }
    } // Fin de getters and setters

    public Cliente():base() {}
    public Cliente(string nombre, string empresa)
    :base(nombre) {
      this.empresa = empresa;
    } // Fin de constructor sobrecargado

    public void ComprarMercancia(float valor) {
      Console.WriteLine("El cliente {0} de la compañía {1} ha comprado mercancía!",
        Nombre, empresa);
      Console.WriteLine("Por un valor de {0:C2}, nos pagó {1:C2} por un descuento.",
        valor, valor - (valor * DESCUENTO));
    } // Fin de comprarle mercancía a la empresa principal
  } // Fin de clase Cliente

  // =====================================
  // CLASES SUB-DERIVADAS - SEGUNDO NIVEL
  // =====================================
  class Ejecutivo : Empleado {
    const float BONO_ADMON = 0.15f;
    string area;

    public string Area {
      get { return area;  }
      set { area = value; }
    } // Fin de getters y setters

    public Ejecutivo():base() {}
    public Ejecutivo(string n, string num, int d, float s, string area)
    :base(n, num, d, s) { this.area = area; }

    private float SueldoTotal() {
      return SueldoSemanal() + (SueldoSemanal() * BONO_ADMON);
    } // Fin de calcular el sueldo ejecutivo

    public void ReciboPago() {
      Console.WriteLine("\n=====================================");
      Console.WriteLine("RECIBO DE PAGO - ARANDELAS S.A de C.V");
      Console.WriteLine("-------------------------------------");
      Console.WriteLine("Empleado: {0} - #{1}", Nombre, NumEmpleado);
      Console.WriteLine("Área administrativa: {0}", area);
      Console.WriteLine("Días trabajados: {0}", DiasTrabajados);
      Console.WriteLine("Sueldo diario: {0:C2}", SueldoDiario);
      Console.WriteLine("Sueldo antes de bonos: {0:C2}", SueldoSemanal());
      Console.WriteLine("TOTAL A PAGAR: {0:C2}", SueldoTotal());
    } // Fin de imprimir nuestro sueldo en recibo
  } // Fin de clase Ejecutivo

  class Operador : Empleado {
    const float BONO_PROD = 1500;
    string maquina;

    public string Maquina {
      get { return maquina;  }
      set { maquina = value; }
    } // Fin de getters and setters

    public Operador():base() {}
    public Operador(string n, string num, int d, float s, string maquina)
    :base(n, num, d, s) { this.maquina = maquina; }

    private float SueldoTotal() {
      if (DiasTrabajados >= 5) {
        return SueldoSemanal() + BONO_PROD;
      } else { return SueldoSemanal(); }
    } // Fin de calcular el sueldo ejecutivo

    public void ReciboPago() {
      Console.WriteLine("\n=====================================");
      Console.WriteLine("RECIBO DE PAGO - ARANDELAS S.A de C.V");
      Console.WriteLine("-------------------------------------");
      Console.WriteLine("Empleado: {0} - #{1}", Nombre, NumEmpleado);
      Console.WriteLine("Puesto en Máquina: {0}", maquina);
      Console.WriteLine("Días trabajados: {0}", DiasTrabajados);
      Console.WriteLine("Sueldo diario: {0:C2}", SueldoDiario);
      Console.WriteLine("Sueldo antes de bonos: {0:C2}", SueldoSemanal());
      Console.WriteLine("TOTAL A PAGAR: {0:C2}", SueldoTotal());
    } // Fin de imprimir nuestro sueldo en recibo
  } // Fin de clase Operador
} // Fin de espacio de nombre