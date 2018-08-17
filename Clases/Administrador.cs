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

            //var resultado = JsonConvert.SerializeObject(objeto);
            //File.AppendAllText(RutaFinal, resultado);

            List<IObjectos> listObjetos = new List<IObjectos>();
            var array = JsonConvert.DeserializeObject<List<IObjectos>>(tabla);

        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
