using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    public class Profesor : Persona
    {
        public List<Curso> CursosQueDicta { get; set; }

        public Profesor()
        {
            this.CursosQueDicta = new List<Curso>();
        }

        public override void Imprimir()
        {
            Console.WriteLine("Profesor");
            base.Imprimir();
            Console.WriteLine("Cursos:");
            this.CursosQueDicta.ForEach(curso => {
                curso.Imprimir();
            });
        }

    }
}
