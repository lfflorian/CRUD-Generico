using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class Class1
    {

        public string Ruta { get; set; }
        public Administrador()
        {
            Ruta = @"C:\Users\lflorian\source\repos\CRUD-Generico\DataBase";
        }

        public void Actualizar()
        {
        }

        public void Crear(IObjectos O)
        {
            SecondFunction(O);
        }

        public void Eliminar()
        {
        }

        public void Obtener()
        {
        }

        private void SecondFunction(IObjectos objeto)
        {
            string tipoObjecto = objeto.GetType().Name;
            string RutaFinal = Path.Combine(Ruta, tipoObjecto + ".txt");
            var tabla = File.ReadAllText(RutaFinal);

            //var resultado = JsonConvert.SerializeObject(objeto);
            //File.AppendAllText(RutaFinal, resultado);

            List<IObjectos> listObjetos = new List<IObjectos>();
            var array = JsonConvert.DeserializeObject<List<IObjectos>>(tabla);
        }

        private void EscribirEnArchivo(object objeto)
        {
            string tipoObjecto = objeto.GetType().Name;
            string RutaFinal = Path.Combine(Ruta, tipoObjecto + ".txt");
            var tabla = File.ReadAllText(RutaFinal);

            var array = JsonConvert.DeserializeObject<IEnumerable<IObjectos>>(tabla);
            // array.Add((IObjectos)objeto);
            var valores = JsonConvert.SerializeObject(array);

            //var sponsors = JsonConvert.DeserializeObject<List<Vendedor>>(tabla);

            File.AppendAllText(RutaFinal, valores);


            /*
            var jsonText = File.ReadAllText("filepath");
            var sponsors = JsonConvert.DeserializeObject<IList<Producto>>(jsonText);
            */

            /*
            //Obtiene el nombre de la Clase
            string tipoObjecto = ob.GetType().Name;
            //Forma la ruta para abrir la 'Base de datos' adecuada
            string RutaFinal = Path.Combine(Ruta, tipoObjecto + ".txt");


            string resultado = "";

            //recorre las propiedades
            var Propiedades = ob.GetType().GetProperties().ToList();
            Propiedades.ForEach(pro => {
                // $"{pro.Name} {pro.GetValue(ob, null)}"; CON ESTE CODIGO SE OBITENE EL TIPO DE DATO Y SU VALOR, EJEMPLO (Nombre Luis)
                resultado = resultado + $"{pro.Name}:{pro.GetValue(ob, null)}";
            });

            File.AppendAllText(RutaFinal, resultado);*/
        }
    }
}
