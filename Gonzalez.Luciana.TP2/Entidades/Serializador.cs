using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public class Serializador
    {
        public static void Guardar<T>(string ruta, T objeto)
        {
            try
            {
                JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
                jsonSerializerOptions.WriteIndented = true;
                string objetoJson = JsonSerializer.Serialize(objeto, jsonSerializerOptions);
                File.WriteAllText(ruta, objetoJson);
            }
            catch(Exception exc)
            {
                throw new Exception("Ocurrio un problema al guardar las cartas", exc);
            }
        }

        public static T Leer<T>(string ruta)
        {
            try
            {
                string objetoJson = File.ReadAllText(ruta);
                T objeto = JsonSerializer.Deserialize<T>(objetoJson);

                return objeto;
            }
            catch (Exception exc)
            {
                throw new Exception("Ocurrio un problema al cargar las cartas", exc);
            }
        }
    }
}
