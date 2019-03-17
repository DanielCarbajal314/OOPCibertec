using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universidad;

namespace MiPrimerProyectoDeConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Curso visionComputacion = new Curso()
            {
                Nombre = "Vision Computacional",
                Categoria = "Ciencias de la Computacion"
            };
            Curso machineLearning = new Curso()
            {
                Nombre = "Machine learning",
                Categoria = "Ciencias de la Computacion"
            };


            Profesor profesor = new Profesor()
            {
                Nombres = "Daniel",
                ApellidoPaterno = "Carbajal",
                Documento = "70007800",
                ApellidoMaterno = "Lopez"
            };
            profesor.CursosQueDicta.Add(visionComputacion);
            profesor.CursosQueDicta.Add(machineLearning);

            Alumno alumno = new Alumno()
            {
                Documento = "1231212312",
                Nombres = "Gian Carlo",
                ApellidoMaterno = "Braga",
                ApellidoPaterno = "Euguren"
            };

            alumno.AgregarCurso(machineLearning, 20);
            alumno.AgregarCurso(visionComputacion, 15);


            List<Persona> personasDeLaUniversidad = new List<Persona>();
            personasDeLaUniversidad.Add(profesor);
            personasDeLaUniversidad.Add(alumno);
            visionComputacion.Nombre = "Deep Learning";

            personasDeLaUniversidad.ForEach(persona => persona.Imprimir());
            Console.ReadKey();
        }
    }
}
