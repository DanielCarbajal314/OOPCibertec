using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Universidad
{
    public class Alumno : Persona
    {
        public List<CursoMatriculado> HistoricoDeCursos { get; set; } = new List<CursoMatriculado>();

        public void AgregarCurso(Curso curso, double nota)
        {
            this.HistoricoDeCursos.Add(new CursoMatriculado()
            {
                Curso = curso,
                NotaFinal = nota
            });
        }

        public override void Imprimir()
        {
            Console.WriteLine("Alumno");
            base.Imprimir();
            Console.WriteLine("Notas de Cursos");
            this.HistoricoDeCursos.ForEach(cursoLLevado =>
            {
                Console.WriteLine($"{cursoLLevado.Curso.Rotulacion} / Nota:{cursoLLevado.NotaFinal}");
            });

        }
    }
}
