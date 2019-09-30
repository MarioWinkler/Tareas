using System;
using Tareabd.Models;
using System.Linq;
 
namespace Tareabd
{
    class Program
    {
        static void Main(string[] args)
        {var dbContext = new EscuelaContext();
        var personas = dbContext.Persona.ToList();
        foreach(var c in personas)
        {
            System.Console.WriteLine($"idPersona:{c.IdPersona} rfc:{c.Rfc} nombre:{c.Nombre} apellido_paterno:{c.ApellidoPaterno} apellido_materno:{c.ApellidoMaterno} email:{c.Email} ");
        }
        }
    }
}
