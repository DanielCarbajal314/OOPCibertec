using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    public class Curso
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Rotulacion { get {
                return $"    {this.Nombre} - {this.Categoria}";
            }
        }

        public void Imprimir()
        {
            Console.WriteLine(Rotulacion);
        }

    }
}
