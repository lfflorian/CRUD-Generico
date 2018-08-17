using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clases;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            Listados listado = new Listados();
            /*Administrador<Task> administrador = new Administrador();

            var p = listado.GetProductos();
            
            p.ForEach(pr => {
                Console.WriteLine(
                        $"{pr.Id}, {pr.Nombre}, {pr.Precio}"
                    );
                administrador.Crear(pr);
            });*/
            
            Console.ReadKey();
        }
    }
}
