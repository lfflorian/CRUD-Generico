using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Clases
{
    public class Administrador<T> : IAdministrador<T> where T : class
    {
        public string Ruta { get; set; }

        public Administrador()
        {
            Ruta = @"C:\Users\lflorian\source\repos\CRUD-Generico\DataBase";
        }

        public void Add(T entity)
        {
            string tipoObjecto = entity.GetType().Name;
            string RutaFinal = Path.Combine(Ruta, tipoObjecto + ".txt");
            var tabla = File.ReadAllText(RutaFinal);
        
            var array = JsonConvert.DeserializeObject<List<T>>(tabla);
            var rr = 0;
        }

        public IEnumerable<T> All()
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
