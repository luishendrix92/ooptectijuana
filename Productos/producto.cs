using System;

namespace LabClase4 {
  class Producto {
    int noProd, iva = 15;
    string nombre, descripcion;
    float precioUnit;
    static int numProductos;

    // Constructores
    public Producto() {
      numProductos += 1;
      noProd = numProductos;
    } public Producto(string nom, string desc, float precio) {
      numProductos += 1;
      noProd = numProductos;
      nombre = nom;
      descripcion = desc;
      precioUnit = precio;
    } // Fin de constructores

    public float calculaVta(int cant) {
      return cant * precioUnit;
    } public float calculaIVA(int cant) {
      return calculaVta(cant) * (iva/100f);
    } public float vtaTotal(int cant) {
      return calculaVta(cant) + calculaIVA(cant);
    } public void imprimirNota(int cant) {
      Console.WriteLine("Nombre del producto:");
      Console.WriteLine("\t" + nombre + "\n");

      Console.WriteLine("La descripción:");
      Console.WriteLine("\t" + descripcion + "\n");

      Console.WriteLine("Número de producto");
      Console.WriteLine("\t" + noProd);

      Console.WriteLine("--------------------------------");
      Console.WriteLine("Compraste {0} {1}s cuyo IVA individual siendo del {2}%, se impusieron {3:c3} al precio sin IVA de {4:c2} quedando una cuenta final a pagar de {5:c2} pesos.", cant, nombre, iva, calculaIVA(cant), calculaVta(cant), vtaTotal(cant));
    }
  }
}