using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio33
{
    class Libro
    {
        List<string> paginas = new List<string>();
        public string this[int index]
        {
            get 
            {
                if (index >= 0 && index < this.paginas.Count)
                    return this.paginas[index];
                else
                    return "";
            }
            set 
            {
                if (index >= 0 && index < this.paginas.Count)
                    this.paginas[index] = value;
                else
                    this.paginas.Add(value);
            }
        }
    }
}
