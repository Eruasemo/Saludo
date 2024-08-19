using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saludo
{
    internal class Persona
    {
        private string name;
        private int age;

        public Persona(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public Persona()
        {
            this.name = "Fulanito";
            this.age = 18;
        }

        public string Saludar()
        {
            string saludo = "Hola soy " + this.name + " y tengo " + this.age + " años de edad.";
            return saludo;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return name;
        }

        public string Name
        {
            get { return this.name; }

            set { this.name = value; }
        }

        public override string ToString()
        {
            string saludo = "Hola soy " + this.name + " y tengo " + this.age + " años de edad.";
            return saludo;
        }
    }
}
