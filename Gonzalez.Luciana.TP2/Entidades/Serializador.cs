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
            JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions();
            jsonSerializerOptions.WriteIndented = true;
            string objetoJson = JsonSerializer.Serialize(objeto, jsonSerializerOptions);
            File.WriteAllText(ruta, objetoJson);
        }

        public static T Leer<T>(string ruta)
        {
            string objetoJson = File.ReadAllText(ruta);

            T objeto = JsonSerializer.Deserialize<T>(objetoJson);

            return objeto;
        }
    }
}
