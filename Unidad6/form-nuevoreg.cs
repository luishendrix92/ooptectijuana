using System;
using System.Text;
using System.IO;
using System.Globalization;
using System.ComponentModel;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ArchivosBinarios {
  public class VentanaRegNuevo : Form {
    Label bienvenida, nombre, ocupacion, edad, altura;
    TextBox nombreTB, ocupacionTB, edadTB, alturaTB;
    RadioButton vivo, fallecido;
    Button insertarBtn;
    CheckBox limpiar;
    string ruta;
    
    // ===========================================================
    // CONSTRUCTOR QUE CREA Y DIBUJA LOS ELEMENTOS DEL FORM
    // ===========================================================
    public VentanaRegNuevo(string ruta) {
      this.ruta = ruta;
            
      // CONTROLES DE VENTANA PARA INSERTAR REGISTROS
      // ETIQUETAS ----------------------------------
      bienvenida          = new Label();
      bienvenida.Size     = new Size(437, 55);
      bienvenida.Location = new Point(13, 9);
      bienvenida.Text     = "Estás a punto de insertar un registro de una persona en el archivo binario que leíste recientemente. Si no has leído ningún archivo hazlo en la ventana principal. Procura que los datos sean correctos o se te avisará de lo contrario.";
      this.Controls.Add(bienvenida);
      // --------------------------------------------
      nombre          = new Label();
      nombre.Size     = new Size(50, 20);
      nombre.Location = new Point(13, 109);
      nombre.Text     = "Nombre";
      this.Controls.Add(nombre);
      // --------------------------------------------
      ocupacion          = new Label();
      ocupacion.Size     = new Size(67, 20);
      ocupacion.Location = new Point(13, 146);
      ocupacion.Text     = "Ocupación";
      this.Controls.Add(ocupacion);
      // --------------------------------------------
      edad          = new Label();
      edad.Size     = new Size(34, 20);
      edad.Location = new Point(13, 183);
      edad.Text     = "Edad";
      this.Controls.Add(edad);
      // --------------------------------------------
      altura          = new Label();
      altura.Size     = new Size(39, 20);
      altura.Location = new Point(13, 220);
      altura.Text     = "Altura";
      this.Controls.Add(altura);
      // BOTONES ------------------------------------
      insertarBtn          = new Button();
      insertarBtn.Size     = new Size(146, 25);
      insertarBtn.Location = new Point(305, 263);
      insertarBtn.Text     = "Insertar registro";
      insertarBtn.Click   += new EventHandler(InsertarBtnClick);
      this.Controls.Add(insertarBtn);
      // OPCIONES -----------------------------------
      vivo          = new RadioButton();
      fallecido     = new RadioButton();
      vivo.Size     = new Size(50, 24);
      vivo.Location = new Point(13, 73);
      vivo.Text     = "Vivo";
      vivo.Checked  = true;
      fallecido.Size      = new Size(74, 24);
      fallecido.Location  = new Point(78, 73);
      fallecido.Text      = "Fallecido";
      this.Controls.Add(vivo);
      this.Controls.Add(fallecido);
      // CHECKBOXES ---------------------------------
      limpiar = new CheckBox();
      limpiar.Checked  = false;
      limpiar.Size     = new Size(111, 24);
      limpiar.Location = new Point(158, 263);
      limpiar.Text     = "Limpiar archivo";
      this.Controls.Add(limpiar);
      // CAJAS DE TEXTO -----------------------------
      nombreTB          = new TextBox();
      nombreTB.Size     = new Size(260, 22);
      nombreTB.Location = new Point(106, 107);
      this.Controls.Add(nombreTB);
      // --------------------------------------------
      ocupacionTB          = new TextBox();
      ocupacionTB.Size     = new Size(260, 22);
      ocupacionTB.Location = new Point(106, 144);
      this.Controls.Add(ocupacionTB);
      // --------------------------------------------
      edadTB          = new TextBox();
      edadTB.Size     = new Size(150, 22);
      edadTB.Location = new Point(106, 181);
      this.Controls.Add(edadTB);
      // --------------------------------------------
      alturaTB          = new TextBox();
      alturaTB.Size     = new Size(150, 22);
      alturaTB.Location = new Point(106, 218);
      this.Controls.Add(alturaTB);
      // ------------------------------------------->
      this.Text = "Insertar nuevo registro";
      this.Size = new Size(471, 351);
    } // Fin de constructor único
    
    
    
    // ===========================================================
    // MÉTODO PARA EL BOTÓN DE INSERTAR REGISTRO
    // -----------------------------------------------------------
    // Serializa el objeto desde las cajas de texto y verifica
    // si los datos tienen formato coherente, si está activada la
    // checkbox, en vez de agregarlo se sobreescribe el archivo.
    // ===========================================================
    private void InsertarBtnClick(object sender, EventArgs e) {
      try {
        // Serialización del objeto a escribir
        string nombre    = nombreTB.Text;
        string ocupacion = ocupacionTB.Text;
        short  edad      = Int16.Parse(edadTB.Text);
        bool   estaVivo  = vivo.Checked;
        float  altura    = Single.Parse(alturaTB.Text);
        
        if ( /* Realizar comprobaciones preventivas */
          nombre.Length > 0 && ocupacion.Length > 0 &&
          edad > 0          && altura > 0
        ) { /* Sin campos vacíos y edad/altura positivas */
          Persona registro = new Persona(
            nombre, ocupacion, edad, estaVivo, altura
          ); // Fin de instanciar objeto Persona
          
          bool insertado = IOBinario.EscribirRegistro(ruta, limpiar.Checked, registro);
          
          if (insertado) { // Actualizar la vista tras insertar registro
            MessageBox.Show(Form.ActiveForm, "Registro insertado con éxito!");
            nombreTB.Text    = "";
            ocupacionTB.Text = "";
            edadTB.Text      = "";
            alturaTB.Text    = "";
            limpiar.Checked  = false;
          } // Fin de actualizar vista sólo si se insertó el registro
        } else {
          MessageBox.Show(Form.ActiveForm, "La edad y la altura deben ser mayores a 0, tampoco dejes vacío algún campo.");
        } // Fin de realizar validación de datos
      } catch (FormatException) {
        MessageBox.Show(Form.ActiveForm, "Error de formato, escribe números en la edad y la altura.");
      } catch (OverflowException) {
        MessageBox.Show(Form.ActiveForm, "La altura o la edad tienen números muy grandes");
      } // Fin de atrapar posibles errores
    } // Fin de insertar registro en el archivo
  } // Fin de clase para formulario nuevo
} // Fin de espacio de nombre