using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public interface IAdministrador
    {
        void Add(object obj);
        void Delete();
        void Update();
    }
}
