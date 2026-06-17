using System;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

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
            string T_servidor = Interaction.InputBox("Ingrese servidor", "DATOS DE INSTALACIÓN MySQL", "localhost");
            string T_puerto = Interaction.InputBox("Ingrese puerto", "DATOS DE INSTALACIÓN MySQL", "3306");
            string T_usuario = Interaction.InputBox("Ingrese usuario", "DATOS DE INSTALACIÓN MySQL", "root");
            string T_clave = Interaction.InputBox("Ingrese clave", "DATOS DE INSTALACIÓN MySQL", "");

            this._baseDatos = "Proyecto"; // O el nombre que tenga tu base
            this._servidor = T_servidor;
            this._puerto = T_puerto;
            this._usuario = T_usuario;
            this._clave = T_clave;
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