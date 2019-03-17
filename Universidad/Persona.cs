using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    public class Persona
    {
        public string Documento { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }

        public string NombreComplete { get {
                return $"{ApellidoPaterno} {ApellidoMaterno}, {Nombres}";
            }
        }

        virtual public void Imprimir()
        {
            Console.WriteLine($"Nombre Completo : {this.NombreComplete}");
            Console.WriteLine($"DNI             : {this.Documento}");
        }
    }
}
