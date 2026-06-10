using System;
using MySql.Data.MySqlClient; // Referencia OBLIGATORIA a la librería que instalamos en el Paso 2

namespace ClubDeportivo.Datos
{
    public class Conexion   // La clase DEBE ser pública
    {
        // Declaramos las variables privadas con los datos de nuestro servidor
        private string _baseDatos;
        private string _servidor;
        private string _puerto;
        private string _usuario;
        private string _clave;
        private static Conexion _instancia = null;

        private Conexion()  // Constructor: Asignamos valores a las variables
        {
            this._baseDatos = "Proyecto"; // El nombre exacto de la base de datos que creamos
            this._servidor = "localhost";
            this._puerto = "3306"; // Puerto por defecto de MySQL en XAMPP
            this._usuario = "root";
            this._clave = "12345678";
        }

        // Proceso de interacción
        public MySqlConnection CrearConexion()
        {
            // Instanciamos una conexión
            MySqlConnection cadena = new MySqlConnection();

            // El bloque try permite controlar errores
            try
            {
                cadena.ConnectionString = "datasource=" + this._servidor +
                                          ";port=" + this._puerto +
                                          ";username=" + this._usuario +
                                          ";password=" + this._clave +
                                          ";Database=" + this._baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }

        // Para evaluar la instancia de la conectividad (Patrón Singleton)
        public static Conexion GetInstancia()
        {
            if (_instancia == null) // Si la conexión está cerrada o no existe...
            {
                _instancia = new Conexion(); // Se crea una nueva
            }
            return _instancia;
        }
    }
}