using System;

namespace Login {  
  public class LoginIncorrecto : Exception {
    static string mensajeDefault = "Tu nombre de usuario o contraseña no coinciden con nuestros registros.";
    
    public LoginIncorrecto():base(mensajeDefault) {}
    public LoginIncorrecto(string mensaje)
    :base(mensaje) {}
    public LoginIncorrecto(string mensaje, Exception innerException)
    :base(mensaje, innerException) {}
  } // Fin de excepción de password erroneo
  
  public class CamposVacios : Exception {
    static string mensajeDefault = "Olvidaste escribir o diste ENTER sin poner algo.";
    
    public CamposVacios():base(mensajeDefault) {}
    public CamposVacios(string mensaje)
    :base(mensaje) {}
    public CamposVacios(string mensaje, Exception innerException)
    :base(mensaje, innerException) {}
  } // Fin de excepción de password erroneo
} // Fin de espacio de nombre