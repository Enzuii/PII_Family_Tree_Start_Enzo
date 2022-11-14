using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Library
{
    public class PersonNode
    {
        public int Edad;
        private string Nombre;

        public PersonNode(int edad, string nombre)
        {
            this.Edad = edad;
            
            this.Nombre = nombre;
        }

        
    }
}
