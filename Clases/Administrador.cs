using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Clases
{
    public class Administrador : IAdministrador
    {
        public string Ruta { get; set; }

        public Administrador()
        {
            Ruta = @"C:\Users\lflorian\source\repos\CRUD-Generico\DataBase";
        }

        public void Add(object objeto)
        {
            string tipoObjecto = objeto.GetType().Name;
            string RutaFinal = Path.Combine(Ruta, tipoObjecto + ".txt");
            var tabla = File.ReadAllText(RutaFinal);

            var array = JsonConvert.DeserializeObject<List<object>>(tabla);
            array.Add(objeto);
            var resultado = JsonConvert.SerializeObject(array);
            File.WriteAllText(RutaFinal, resultado);

        }

        public void Delete(object objeto)
        {
            string tipoObjecto = objeto.GetType().Name;
            string RutaFinal = Path.Combine(Ruta, tipoObjecto + ".txt");
            var tabla = File.ReadAllText(RutaFinal);

            var array = JsonConvert.DeserializeObject<List<object>>(tabla);
            var objetoSerealizado = JsonConvert.SerializeObject(objeto);

            //x.ToString() == objetoSerealizado)
            array.ForEach(x => {
            if (x.ToString().Replace("\r\n".ToCharArray()[0],' ') == objetoSerealizado)
                {
                    var ecdfa = 0;
                }
            });

        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
