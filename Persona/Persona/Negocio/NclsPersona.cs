using Persona.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace Persona.Negocio
{
    class NclsPersona
    {
        public String Hablar(ClsPersona persona)
        {
            persona.Nombre = " Jose ";

            return " La persona " + persona.Nombre + " esta hablando ";
        }
        public String  Caminar(ClsPersona persona)
        {
            persona.Nombre = " Jose ";
            return " la persona llamada " + persona.Nombre + " esta caminando ";
        }
        public String Reir(ClsPersona persona)
        {
            persona.Nombre = "Jose ";
            return " la persona de nombre " + persona.Nombre + "se esta riendo ";
        }
        public String  Observar(ClsPersona persona)
        {
            persona.Nombre = " Jose ";
            return " la persona llamada " + persona.Nombre + " te esta observando ";

        }
    }
}
