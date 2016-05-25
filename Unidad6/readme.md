# Documentación del programa de ejemplo

El propósito de este programa es demostrar dos cosas muy importantes: demostrar lo que es en sí un **archivo** en general y cómo se relaciona con el tema de la lectura y escritura de *bytes* (conjuntos variables de *bits*, normalmente 8) así como el uso del lenguaje de programación **C#** para la creación, lectura y escritura de archivos en formato binario, para qué sirven y cómo utilizar las clases del lenguaje que nos permiten realizar operaciones con ellos.

No es muy sabido qué es un archivo a nivel binario y tampoco cómo es que el sistema operativo y el software es capaz de interpretar diferentes tipos y extensiones de archivos a su conveniencia para mostrar cosas útiles o utilizarlos para el funcionamiento de dicho software. Un **archivo** está constituído de uno a más bytes (octeto, aunque algunos bytes pueden tener sólo 7 bits o variar de tamaño) y la extensión determina el uso o propósito que tiene dentro del sistema operativo; al fin de cuentas todos están formados por bytes y es cuestión del programa o sistema que los lea (o escriba en ellos) el determinar su estructura para así saber qué leer y para qué usar los tipos de datos y sus valores que fueron interpretados. Tomando de ejemplo un archivo de vídeo .mkv, el archivo tiene una cabecera de tamaño variable con campos y valores como el número de fotogramas por segundo, la resolución, la duración del vídeo, entre otros; estos son los metadatos del archivo y los puedes ver dentro del visor de propiedades de archivo de tu sistema operativo; después, vienen los fotogramas con un tamaño establecido de bytes por cada uno el cuál es interpretado por el reproductor de turno determinado primero por el códec que se vaya a usar. Así pues podemos afirmar que todo archivo es un archivo binario.

En los archivos, los digitos binarios tienen **estructuras** variantes, en este programa se tiene la metodología de escribir un objeto de clase *persona* con los siguientes campos: nombre, ocupación, edad, si está vivo o muerto y la altura en metros cuyos tipos de dato son *string*, *string*, *int16* (short integer), *boolean* y *float* (single) respectivamente. Cada uno de esos tipos de datos y otros que existen abarcan una cantidad específica de bytes en memoria, recordando que una cadena de texto es un arreglo de caracteres que requiere uno o más bytes de 7 bits que indiquen el tamaño de esa cadena de texto ya que a la hora de querer leer dicha cadena, se leerán los caracteres que el tamaño indique.

![Tipos de Datos](http://1.bp.blogspot.com/-DX4V0U5TJk4/UE7dSW1zsZI/AAAAAAAAAFM/NcVcESPPkPk/s1600/C%23+types.png)

Para la primera parte del programa se tiene pensado una aplicación muy usada en el campo de la búsqueda de bugs llamado "volcado hexadecimal" (o **Hex Dump**) con su respectiva interpretación en caracteres ASCII, aunque nosotros usaremos también un switch para visualizarlos en codificación UTF-8 (útil para leer archivos de texto con todo y caracteres especiales usando BinaryReader) y Unicode. Un **volcado hexadecimal** es una representación visual del contenido binario de un archivo en bloques de 16 u 8 bits (2 o 4 caracteres hexadecimales del 0 a la letra F) para leer de forma más fácil éstos. Comenzando desde la posición 0 (inicial) hasta el EOF (End of File), es posible utilizar la interpretación de 8 bits para leer cada par de digitos hexadecimales como un byte y así descifrar estructuras de datos, hay muchos programas de este tipo y nuestra intención para la primera parte del programa es recrear uno que lea bloques de 8 bits y los despliegue tanto en su forma hexadecimal como ASCII.

![HexDump Software](http://www.sharewarejunction.com/user-images/image552149.png)

La segunda parte consiste en algo más simple, lo cuál es la lectura y escritura de tipos de datos primitivos (y strings) para la *serialización* y *deserialización* de objetos o registros dentro de archivos binarios, los cuáles para este ejemplo, canalizando los ejemplos de alumnos de la materia de POO, se usan ya sea extensiones .bin o .dat y la clases **BinaryReader** y **BinaryWriter** pasándoles un stream de tipo **FileStream**.

##### ¿Qué es la serialización y deserialización?

En términos simples y de acuerdo a varios sitios web sobre Ciencias de la Computación, la **serialización** es el proceso de transformar objetos o estructuras de datos en un formato específico que pueda ser almacenado e interpretado de nuevo en otro entorno, por eso es que nuestro programa enfoca en guardar un objeto con 5 simples campos como si fuera un registro de una base de datos dentro de un archivo binario, archivo que contendrá ninguno, uno o varios objetos de tipo Persona (sin métodos instanciados, sólo los campos con get-set) cuya estructura sólo nuestro programa podrá ser capaz de leer ya que conocemos la estructura de cada registro e implementamos así la deserialización para mostrar y operar dichos registros desde nuestro programa en forma visual. Ahora bien, la **deserialización** es la parte que leyendo los bytes de nuestro archivo de forma que se transformen de vuelta en lo que alguna vez fueron, un objeto de tipo Persona para así almacenarlos en una lista y posiblemente volverlos a serializar si sufren alguna modificación.

## Concepto del programa

Se pensaron al inicio en tan sólo recrear la herramienta más simple de volcado hexadecimal posible, pero después se pensó en incluir botones para lanzar ventanas que fueran capaces de escribir nuevos registros (o crearlo si no existe, reemplazarlo si ya existe) en archivos binarios y a su vez leer el archivo de principio a final utilizando un ciclo para deserializar todos los objetos que éste contuviera y mostrarlos en forma de lista con todos sus campos a un lado, pudiendo así modificarlos o borrarlos a gusto.

### Volcado Hexadecimal

![Hex Dump](http://i.imgur.com/kjogr18.png)

Ésta es la ventana principal del programa, el cuadro de texto para escribir la ruta de archivo puede ser modificada a conveniencia aunque la intención es que, implementando un botón de Explorar se pueda buscar el archivo en específico si la intención es leer archivos, haciendo ésto, el cuadro de texto se actualiza con la dirección absoluta del archivo seleccionado.

Al presionar el botón de leer se actualizan los cuadros de texto con el contenido de bytes transformados a pares de dígitos hexadecimales y de lado derecho, el texto que se logró convertir a string. Los botones de opción de la parte de abajo sirven para que el texto analizado se pueda mostrar en su codificación UTF-8 y Unicode y no sólo ASCII la cuál hace que algunos caracteres como tildes no se muestren correctamente.

Por último, los botones de hasta abajo sirven para lo que dicen, a excepción de los últimos dos que lanzan otras ventanas, el de Borrar, elimina el archivo que se encuentre en el cuadro de texto actualmente, si no existe tal archivo lanza un error.

### Visualización de objetos serializados

![Leer](http://i.imgur.com/NxfBu5x.png)

Desde aquí se busca que inmediatamente que el usuario abra la ventana, se deserialicen los objetos desde el archivo y se carguen en una lista que es desplegada por el listbox de la izquierda poniendo sólo el campo de nombre, de lado derecho al seleccionar uno de esos nombres se mostrará cada campo en su respectivo control (caja de texto o radiobutton). Desde aquí se puede modificar dichos controles para en caso de presionar el botón de Modificar, todo lo que hay en los campos de texto se reemplace en la lista que flota en la memoria RAM y pase a reemplazar por completo dicho archivo para poder así "modificar el registro" ya que en realidad no modifica el archivo binario en un sector específico sino que se **reemplaza por una lista ligeramente diferente** ya serializada. El botón borrar elimina el elemento de la lista y de nuevo como mencioné, se reemplaza el archivo entero por la lista serializada ya sin el objeto que se borró. Por último, una parte interesante es que como hablamos de un objeto de la clase Persona, se puede invocar un método de la clase, el **método** Saludar() de tipo void que lo que hace es mostrar un mensaje con el saludo construído a partir de sus atributos.

### Escritura de un nuevo registro en el archivo

![Nuevo registro](http://i.imgur.com/0WbHM8u.png)

Aquí se ponen los 5 campos en forma de controles para que el usuario pueda escribir sus propios objetos de tipo Persona para así insertarlos en el archivo actual (el que está en el cuadro de texto de ruta, en la ventana principal) haciendo que el programa lo serialice y lo inserte ya sea al final del archivo utilizando FileMode.Append como 2ndo parámetro del stream pasado al BinaryWriter, o usando FileMode.Create en caso de que se marque el checkbox de "Limpiar archivo" para así sobreescribir el archivo con ese registro.

En el código de esta ventana, tanto en el de la anterior, se implementó una captura de excepciones del tipo Format y Overflow además de unas condiciones extra para la validación de los datos introducidos, los cuáles serán:

- La edad y la altura deben ser números, no menores o iguales a 0.
- Ningún campo de texto debe estar vacío

El botón de insertar registro básicamente manda a llamar la serialización del objeto y su inserción en el archivo, lanzando un aviso cuando este proceso termine.

## Metodología general

Para la realización de este proyecto se tomó en cuenta el potencial de usar Windows Forms en C#, cosa que tomó algo de tiempo aprenderlo en unos días, la implementación de Windows Forms no será cubierta en este documento y será mostrado sólo lo necesario si es que muy poco sobre ello. Cada botón tiene un método asociado que se lanza cuando se da click en él, es en éstos métodos donde se maneja la lógica de la lectura y escritura de archivos binarios y lo que sucede con el programa detrás de cámaras.

![Metodologia](http://i.imgur.com/k3DxmGI.png)

Para tener un control individual de cada ventana y proceso de lectura/escritura se crearon los siguientes archivos:

1. **main.cs**: En éste se encuentra la clase de la ventana principal y los métodos que se ejecutan cuando se le da click a sus botones. También incluye el método Main que se encarga de lanzar la aplicación.
2. **persona.cs**: Aquí se crea la clase Persona, la cuál será utilizada para serializar y deserializar los datos de los registros. El archivo sólo contiene eso, la definición de la clase, sus propiedades y atributos, el constructor y el método Saludo().
3. **binario.cs**: Es en definitiva el archivo clave y el más importante del programa, contiene la clase IOBinario y su finalidad es el de abstraer los procesos de **lectura y escritura en archivos binarios** para usarlos con más confianza y facilidad en métodos que manejan cosas diferentes como los manejadores de los botones y controles de Windows Forms.
4. **form-nuevoreg.cs**: Maneja la ventana para insertar un registro en el archivo binario, sus controles, sus métodos asociados a dichos controles y la serialización del objeto.
5. **form-vermodifreg.cs**: También maneja una ventana individual, la de ver y modificar los registros en el archivo, aquí no sólo se serializa, también se deserializa y contiene el mismo tipo de validación de datos que el otro form.

El código fuente en su totalidad puede ser consultado en la siguiente liga: [https://github.com/luishendrix92/ooptectijuana/tree/master/Unidad6](https://github.com/luishendrix92/ooptectijuana/tree/master/Unidad6). Se puede compilar desde la línea de comandos siguiendo las instrucciones escritas al inicio de main.cs siempre y cuando se tenga instalado .NET Framework en el caso de windows (éste otorga a la consola de Windows la capacidad de ejecutar el comando *csc* para compilar) o MonoDevelop en caso de utilizar Linux o Mac y así ejecutar *dmcs* para compilar, incluyendo los DLL faltantes para el dibujo de componentes en ventanas.

### Volcado Hexadecimal

Para lograrlo, se pensó en una forma de almacenar todos los bytes de un archivo en un arreglo de caracteres, pero para eso, tras haberlo investigado, hay que almacenarlos como un arreglo de bytes (hay un tipo de dato en C# llamado byte) de tamaño indefinido y utilizar un método de la clase **BinaryReader** llamado **ReadBytes()** el cuál tomo como parámetro el número de bytes a leer, en este caso, según el foro StackOverflow, una de las técnicas es pasarle un número muy grande, puede ser el valor máximo de los int32. Otra de las técnicas la cuál se encuentra comentada al final de *binario.cs* y consta de pasarle el stream del BinaryReader al método, copiarlo a una variable de tipo **MemoryStream** y convocar el método **ToArray()**, así, se puede regresar como un arreglo de bytes.

Una vez que se tiene el arreglo, lo devuelve a quien sea que lo necesite; aquello que lo necesita es el método que maneja el botón de Leer en la ventana principal, sucede que ese arreglo de bytes puede ser leído como una cadena de texto codificada en distintas formas, las más comunes siendo ASCII, UTF-8 y Unicode utilizando el método `Encoding.ASCII.GetString(bytesLeidos)` en donde *bytesLeidos* es una variable que contiene un arreglo de bytes. Esta cadena pues, es la que se despliega en el cuadro de texto multilínea de la derecha en la ventana principal, los radiobutton de abajo sirven de switch entre las 3 formas de codificación de texto disponibles.

Para el volcado se utiliza un ciclo que recorre uno por uno los bytes leídos y utilizando el formato "X2" (dos dígitos hexadecimales) y sumándole un espacio después de cada byte, se produce una cadena de texto compuesta de bloques de bytes.

``` Java
// Depositar el volcado hexadecimal en la caja de texto
foreach (byte byteLeido in bytesLeidos) {
  volcadoLeido += (byteLeido.ToString("X2") + " ");
} // Fin de leer arreglo de bytes
```

Para el método de *binary.cs*, al BinaryWriter se le pasa un stream de tipo FileStream con el acceso de lectura (FileAccess.Read) y el modo de abrir (FileMode.Open).
``` Java
public static byte[] LeerArchivo(string rutaDelArchivo) {
  // Bytes con las letras ASCII "ERROR"
  byte[] bytesLeidos = new byte[] { 0x45, 0x52, 0x52, 0x4F, 0x52 };
  
  if (File.Exists(rutaDelArchivo)) {
    try {
      BinaryReader reader = new BinaryReader(
        File.Open(rutaDelArchivo, FileMode.Open, FileAccess.Read)
      ); // Fin de crear un lector binario
      bytesLeidos = reader.ReadBytes(int.MaxValue);
      reader.Close();
    } catch(IOException e) {
      MessageBox.Show(e.Message);
    } catch(ObjectDisposedException e) {
      MessageBox.Show(e.Message);
    } // Fin de atrapar posibles errores al leer
  } else {
    MessageBox.Show(
      "El archivo que quieres leer no existe.",
      "Error de directorio",
      MessageBoxButtons.OK,
      MessageBoxIcon.Warning,
      MessageBoxDefaultButton.Button1
    ); // Fin de mostrar error
  } // Fin de ver si existe el archivo
  
  return bytesLeidos;
} // Fin de método para regresar los bytes de un archivo
```

En este caso, las excepciones manejadas son los errores de Input/Output y el otro fue producto de un error al azar que no tenía esperado obtener, sucede cuando se trata de acceder a un objeto que ya no existe en memoría, aunque estamos seguros que dicho error no saldrá más, no está de más prevenir.

### Borrado de un archivo

No hay mucho que decir al respecto, la **clase File** de C# tiene un método llamado Delete y otro llamado Exists, el cuál usamos demasiado tratando de evitar una excepción de archivo no encontrado. Ambos métodos toman una cadena con la ruta al archivo en cuestión, en nuestro programa, este proceso se desencadena tras presionar el botón de Borrar en la ventana principal.

``` java
public static bool BorrarArchivo(string ruta) {
  if (File.Exists(ruta))
  { File.Delete(ruta); return true; }
  else { return false; }
} // Fin de método para borrar un archivo del sistema
```

### Leer una lista de registros (Deserialización)

Para poder desplegar la lista de registros de personas en el archivo y sus datos, hay que extraer dichos objetos de éste usando el BinaryReader, el método utiliza un ciclo infinito que recorre el stream del archivo y por medio del lector binario, la posición del stream comienza en 0, usando métodos de lectura de tipos de datos primitivos (y ReadString que es algo diferente) se avanza el puntero y se van almacenando los datos leídos en variables del tipo de cada atributo del objeto que va a ser enviado a la lista que ultimadamente regresará este método. Cómo entonces se saldrá del ciclo? Atrapando la excepción que indica que ya no hay más datos por leer en el archivo y se alcanzó su fin.

``` java
List<Persona> registros = new List<Persona>();
BinaryReader br = null; // Declaración del flujo
```

El lector binario se declara como nulo para cerrarlo en el finally en caso de que haya un error con el stream, o al menos así se interpreta la línea de código siguiente en el bloque finally: `if (br != null) br.Close();`. También se declara la lista de personas, lista para que cada que el ciclo de vuelta, se añada un nuevo objeto deserializado.

``` java
br = new BinaryReader(new FileStream(ruta, FileMode.Open, FileAccess.Read));

do { // DES-SERIALIZAR OBJETO
  registros.Add(
    new Persona(
      br.ReadString(), /* Nombre */
      br.ReadString(), /* Ocupación */
      br.ReadInt16(), /* Edad */
      br.ReadBoolean(), /* ¿Está vivo? */
      br.ReadSingle() /* Altura */
    ) /* Fin de crear un objeto Persona */
  ); // Fin de agregar a la persona
} while (true); // Mientras no sea el fin del stream
```

Nótese los métodos ReadString, ReadInt16, ReadBoolean y ReadSingle, cuando se invoca cada uno de ellos, retorna el valor leído y avanza el apuntador en el stream por el número de bytes leídos, ReadString no tiene un tamaño fijo de lectura, primero lee bloques de bytes de 7 bits en busca del número de bytes (caracteres) que debe leer tras haber leído el tamaño de la cadena de texto, entonces, los string tienen tamaño variable.

### Insertar un registro (serialización y escritura)

Para insertar un objeto de tipo persona serializado de los campos de texto, se instancia el objeto y se manda al siguiente método para su inserción:

``` java
public static bool EscribirRegistro(string ruta, bool limpiar, Persona persona) {
  BinaryWriter bw       = null;
  bool insercionExitosa = false;
  
  try { // Buscar errores de lectura y escritura
    if (File.Exists(ruta)) {
      bw = new BinaryWriter(
        new FileStream(
          ruta, /* Archivo a escribir */
          ((limpiar)? FileMode.Create : FileMode.Append),
          FileAccess.Write
        ) /* Fin de creación de stream */
      ); // Fin de creación de lector binario
      
      // Insertando el modelo de datos en el stream
      bw.Write(persona.Nombre);    // String
      bw.Write(persona.Ocupacion); // String
      bw.Write(persona.Edad);      // Int16
      bw.Write(persona.EstaVivo);  // Boolean
      bw.Write(persona.Altura);    // Single
      
      insercionExitosa = true;
    } else { // No existe el archivo
      // Mostrar mensaje de error
    } // Fin de ver si existe o no el archivo
  } catch (IOException e) {
    MessageBox.Show(e.Message);
  } finally { if (bw != null) bw.Close(); }
  
  return insercionExitosa;
} // Fin de capturar error de lectura y escritura
```

La razón por la que este método devuelve un valor **booleano**, es como una confirmación o rechazo de la inserción, este método lo utiliza la ventana de insertar registro, si devuelve un *true*, la vista (lo gráfico) saca un mensaje de éxito y si no, deja que este método se encargue de ello por medio del try-catch.

Este método recibe aparte de la ruta del archivo, un booleano que indica si el archivo debe tener el modo de Create o de Append, en la vista, el usuario tiene la elección de escribir o sobreescribir el archivo, si elige que se sobreescriba, el modo Create (**FileMode.Create**) entra en acción y si el archivo existe, reemplaza su contenido al contrario de **FileMode.Append** que si existe el archivo, comienza a escribir desde el final del archivo; esto sucede si el usuario no marca la casilla de "Limpiar". Por supuesto, el acceso al archivo (**FileAccess.Write**) es de escritura puesto que es lo que haremos, no más.

### Reemplazar por completo el archivo con una lista

Este método lo ocupamos para cuando se modifica o borra un registro en la ventana de "Ver o modificar registros" ya que no se está operando directamente en el archivo, buscando la posición del registro a modificar ya que sería más complicado. Mejor, una vez que se almacena en la memoria RAM una lista de objetos de tipo Persona, cualquier cambio que ocurra en alguno de los objetos, provoca que esta lista sea serializada y escrita en el archivo reemplazando por completo su contenido.

``` java
// Insertando la lista de personas en el stream
foreach (Persona persona in personas) {
  bw.Write(persona.Nombre);    // String
  bw.Write(persona.Ocupacion); // String
  bw.Write(persona.Edad);      // Int16
  bw.Write(persona.EstaVivo);  // Boolean
  bw.Write(persona.Altura);    // Single
} // Fin de iterar la lista de personas
```

Funciona, de hecho, igual que el anterior, el stream es el mismo sólo que el FileMode es únicamente el de *Create* para que se reemplace el archivo. Y en vez de sólo insertar el objeto serializado una vez, se insertan TODOS los que estén en la lista, para eso se usa un ciclo *foreach* qie recorre la lista y va insertando, como en el método anterior, cada atributo de cada objeto en el orden correcto hasta que se agote la lista. Al final, se cierra el stream y se capturan las excepciones que ocurran, devolviendo así un booleano de confirmación o rechazo.

## Conclusión

Aprendimos que todo archivo es binario y que se pueden hacer muchas cosas interesantes con su manipulación a nivel binario, muchos de los programas que convierten tipos de archivo, guardan archivos en formatos especiales y el software en general se rodea del tema de las estructuras de datos y la manipulación de bajo nivel de estos archivos.

El objetivo de este programa es demostrar desde lo más bajo hasta lo más común en cuanto al manejo de archivos binarios, de hecho, podemos crear archivos con extensiones propias, personalizando así nuestro programa y dándole más identidad.