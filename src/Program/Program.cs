using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Node Enzo = new Node(19, "Enzo");
            Node Pepito = new Node(56, "Pepito");
            Node Maria = new Node(10, "Maria");
            Node Juan = new Node(19, "Juan");
            Node Matias = new Node(25, "Matias");
            Node Jose = new Node(90, "Jose");
            Node Paco = new Node(34, "Paco");
            Node Carla = new Node(27, "Carla");

            // visitar el árbol aquí

            Jose.AddChildren(Carla);
            Jose.AddChildren(Paco);
            Jose.AddChildren(Pepito);
            
            Pepito.AddChildren(Enzo);
            Pepito.AddChildren(Maria);
            Pepito.AddChildren(Juan);
            Pepito.AddChildren(Matias);

            Visitor visitor = new Visitar();
            Jose.Accept(visitor);
            Console.WriteLine($"Suma edades: {Visitar.edades}");
            

        }
    }
}
