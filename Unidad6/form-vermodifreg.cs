using System;
using System.Text;
using System.IO;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArchivosBinarios {
  public class VentanaVMRegs : Form {
    Label nombre, ocupacion, edad, altura;
    TextBox nombreTB, ocupacionTB, edadTB, alturaTB;
    RadioButton vivo, fallecido;
    Button modificarBtn, saludoBtn, borrarBtn;
    ListBox lista;
    List<Persona> personas = new List<Persona>();
    string ruta;
    
    // ===========================================================
    // CONSTRUCTOR QUE CREA Y DIBUJA LOS ELEMENTOS DEL FORM
    // ===========================================================
    public VentanaVMRegs(string ruta) {
      this.ruta = ruta;
      
      // CONTROLES DE VENTANA PARA INSERTAR REGISTROS
      // ETIQUETAS ----------------------------------
      nombre          = new Label();
      nombre.Size     = new Size(50, 20);
      nombre.Location = new Point(218, 14);
      nombre.Text     = "Nombre";
      this.Controls.Add(nombre);
      // --------------------------------------------
      ocupacion          = new Label();
      ocupacion.Size     = new Size(67, 20);
      ocupacion.Location = new Point(218, 69);
      ocupacion.Text     = "Ocupación";
      this.Controls.Add(ocupacion);
      // --------------------------------------------
      edad          = new Label();
      edad.Size     = new Size(34, 20);
      edad.Location = new Point(218, 126);
      edad.Text     = "Edad";
      this.Controls.Add(edad);
      // --------------------------------------------
      altura          = new Label();
      altura.Size     = new Size(39, 20);
      altura.Location = new Point(218, 182);
      altura.Text     = "Altura";
      this.Controls.Add(altura);
      // OPCIONES -----------------------------------
      vivo          = new RadioButton();
      fallecido     = new RadioButton();
      vivo.Size     = new Size(50, 24);
      vivo.Location = new Point(405, 128);
      vivo.Text     = "Vivo";
      vivo.Checked  = true;
      fallecido.Size      = new Size(74, 24);
      fallecido.Location  = new Point(405, 159);
      fallecido.Text      = "Fallecido";
      this.Controls.Add(vivo);
      this.Controls.Add(fallecido);
      // CAJAS DE TEXTO -----------------------------
      nombreTB          = new TextBox();
      nombreTB.Size     = new Size(263, 22);
      nombreTB.Location = new Point(218, 35);
      this.Controls.Add(nombreTB);
      // --------------------------------------------
      ocupacionTB          = new TextBox();
      ocupacionTB.Size     = new Size(263, 22);
      ocupacionTB.Location = new Point(218, 90);
      this.Controls.Add(ocupacionTB);
      // --------------------------------------------
      edadTB          = new TextBox();
      edadTB.Size     = new Size(133, 22);
      edadTB.Location = new Point(218, 147);
      this.Controls.Add(edadTB);
      // --------------------------------------------
      alturaTB          = new TextBox();
      alturaTB.Size     = new Size(133, 22);
      alturaTB.Location = new Point(218, 203);
      this.Controls.Add(alturaTB);
      // BOTONES ------------------------------------
      modificarBtn          = new Button();
      modificarBtn.Size     = new Size(105, 25);
      modificarBtn.Location = new Point(375, 240);
      modificarBtn.Text     = "Modificar";
      modificarBtn.Click   += new EventHandler(ModificarBtnClick);
      this.Controls.Add(modificarBtn);
      // --------------------------------------------
      saludoBtn          = new Button();
      saludoBtn.Size     = new Size(124, 25);
      saludoBtn.Location = new Point(233, 240);
      saludoBtn.Text     = "Mostrar Saludo";
      saludoBtn.Click   += new EventHandler(SaludoBtnClick);
      this.Controls.Add(saludoBtn);
      // --------------------------------------------
      borrarBtn          = new Button();
      borrarBtn.Size     = new Size(105, 25);
      borrarBtn.Location = new Point(109, 240);
      borrarBtn.Text     = "Borrar";
      borrarBtn.Click   += new EventHandler(BorrarBtnClick);
      this.Controls.Add(borrarBtn);
      // LISTA --------------------------------------
      lista = new ListBox();
      lista.Size = new Size(191, 212);
      lista.Location = new Point(11, 13);
      lista.SelectedIndexChanged +=
        new EventHandler(ActualizarValores);
      this.Controls.Add(lista);
      // --------------------------------------------
      this.Text = "Ver y modificar registros";
      this.Size = new Size(496, 330);
      
      // ACTUALIZAR LA LISTA CON LAS PERSONAS LEÍDAS
      lista.BeginUpdate();
      personas = IOBinario.ObtenerRegistros(ruta);
      foreach (Persona persona in personas) {
        lista.Items.Add(persona.Nombre);
      } // Fin de recorrer la lista retornada
      lista.EndUpdate();
    } // Fin de único constructor de la ventana
    
    
    
    // ===========================================================
    // MÉTODO PARA EL BOTÓN DE MODIFICAR REGISTRO SELECCIONADO
    // ===========================================================
    private void ModificarBtnClick(object sender, EventArgs e) {
      if (lista.SelectedIndex >= 0) {
        try {
          // Serialización del objeto modificado
          string nombre    = nombreTB.Text;
          string ocupacion = ocupacionTB.Text;
          short  edad      = Int16.Parse(edadTB.Text);
          bool   estaVivo  = vivo.Checked;
          float  altura    = Single.Parse(alturaTB.Text);
          
          if ( /* Realizar comprobaciones preventivas */
            nombre.Length > 0 && ocupacion.Length > 0 &&
            edad > 0          && altura > 0
          ) { /* Sin campos vacíos y edad/altura positivas */
            personas[lista.SelectedIndex] = new Persona(
              nombre, ocupacion, edad, estaVivo, altura
            ); // Fin de reemplazar el anterior con el modificado
            
            bool modifcacionExitosa = IOBinario.Reescribir(ruta, personas);
            
            if (modifcacionExitosa) {
              MessageBox.Show(Form.ActiveForm, "Registro modificado con éxito!");
            } // Fin de mostrar mensaje trans modificación exitosa
          } else {
            MessageBox.Show(Form.ActiveForm, "La edad y la altura deben ser mayores a 0, tampoco dejes vacío algún campo.");
          } // Fin de realizar validación de datos
        } catch (FormatException) {
          MessageBox.Show(Form.ActiveForm, "Error de formato, escribe números en la edad y la altura.");
        } catch (OverflowException) {
          MessageBox.Show(Form.ActiveForm, "La altura o la edad tienen números muy grandes");
        } // Fin de atrapar posibles errores
      } else { // Aún no se selecciona item
        MessageBox.Show(Form.ActiveForm, "No hay algún registro seleccionado, por favor selecciona uno antes de poder modificarlo.");
      } // Fin de asegurarse que haya algo seleccionado
    } // Fin de manejador para modificar el registro
    
    
    
    // ===========================================================
    // MÉTODO PARA EL BOTÓN DE MOSTRAR SALUDO DE LA CLASE PERSONA
    // ===========================================================
    private void SaludoBtnClick(object sender, EventArgs e) {
      if (lista.SelectedIndex >= 0) {
        string saludo = personas[lista.SelectedIndex].Saludo();
        
        MessageBox.Show(Form.ActiveForm, saludo);
      } else { // Aún no se selecciona item
        MessageBox.Show(Form.ActiveForm, "No hay algún registro seleccionado, por favor selecciona uno antes de querer mostrar su saludo correspondiente.");
      } // Fin de asegurarse que haya algo seleccionado
    } // Fin de manejador para mostrar el saludo de la persona
    
    
    
    // ===========================================================
    // MÉTODO PARA EL BOTÓN DE BORRAR REGISTRO SELECCIONADO
    // ===========================================================
    private void BorrarBtnClick(object sender, EventArgs e) {
      if (lista.SelectedIndex >= 0) {
        // Borrar primero de la lista de personas en memoria
        personas.RemoveAt(lista.SelectedIndex);
        // Proceder a borrarlo del archivo
        bool reemplazoExitoso = IOBinario.Reescribir(ruta, personas);
        
        if (reemplazoExitoso) {
          lista.Items.Remove(lista.SelectedItem);
        } // Sólo borrarlo de la lista si se borra del archivo
      } else { // Aún no se selecciona item
        MessageBox.Show(Form.ActiveForm, "No hay algún registro seleccionado, por favor selecciona uno antes de querer borrarlo.");
      } // Fin de asegurarse que haya algo seleccionado
    } // Fin de manejador para borrar registro actual
    
    
    
    // ===========================================================
    // MANEJADOR DE EVENTO CUANDO CAMBIA EL ITEM SELECCIONADO
    // -----------------------------------------------------------
    // Actualiza la vista, cambiando los valores de las cajas
    // de texto y opciones (radiobutton) cuando el elemento
    // seleccionado cambia en la caja de lista.
    // ===========================================================
    private void ActualizarValores(object sender, EventArgs e) {
      try {
        Persona personaActual = personas[lista.SelectedIndex];
        
        // Actualizar los valores de los controles
        nombreTB.Text       = personaActual.Nombre;
        ocupacionTB.Text    = personaActual.Ocupacion;
        edadTB.Text         = personaActual.Edad.ToString();
        alturaTB.Text       = personaActual.Altura.ToString();
        fallecido.Checked   = !personaActual.EstaVivo;
        vivo.Checked        = personaActual.EstaVivo;
      } catch(ArgumentOutOfRangeException) {
        // Si el index es -1 (algo fue borrado), limpiar
        nombreTB.Text       = "";
        ocupacionTB.Text    = "";
        edadTB.Text         = "";
        alturaTB.Text       = "";
        fallecido.Checked   = false;
        vivo.Checked        = true;
      } // Fin de capturar error de argumento al borrar item
    } // Fin de re-dibujar la vista cuando se seleccione item
  } // Fin de clase para el form de editar o ver registros
} // Fin de espacio de nombre