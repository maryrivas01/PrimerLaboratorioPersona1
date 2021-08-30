using Persona.Entidades;
using System;

namespace Persona
{
    class Program
    {
        static void Main(string[] args)
            {
                Entidades.ClsPersona clspersona = new ClsPersona();
                NClsPersona nclspersona = new NClsPersona();

                clspersona.Nombre = "Jose";

                Console.WriteLine(nclspersona.Hablar(clspersona));

                Console.ReadLine();
            }
        }
    }

