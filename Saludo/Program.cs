using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Persona persona = new Persona("Manuel", 38);
            Console.WriteLine(persona.Name);
            persona.Name = "Raul";
            Console.WriteLine(persona);



            Persona persona2 = new Persona();

            persona2.Saludar();
        }
    }
}
