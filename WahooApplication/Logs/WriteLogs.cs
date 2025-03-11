using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WahooApplication.Logs
{
    public class WriteLogs : IWriteLog
    {
        // Método para crear y escribir en un archivo plano
        public void WriteLog(string message)
        {
            string rutaArchivo = "";
            rutaArchivo = ConfigurationManager.AppSettings["Logs:RutaLogs"].ToString();
            try
            {
                // Verifica si el archivo existe, si no, lo crea
                using (StreamWriter sw = new StreamWriter(rutaArchivo, append: false)) // "append: false" indica que se sobrescribe el archivo
                {
                    sw.WriteLine(message); // Escribe el mensaje en el archivo
                }
                Console.WriteLine("Archivo creado y mensaje escrito correctamente.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al crear el archivo: {ex.Message}");
            }
        }
    }
}
