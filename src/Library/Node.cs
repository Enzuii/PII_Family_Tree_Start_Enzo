using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public class Node
    {
        private int number;

        private PersonNode personNode;

        private List<Node> children = new List<Node>();

        public PersonNode PersonNode
        {
            get
            {
                return this.personNode;
            }
        }
        
        public Node(int edad, string nombre)
        {
            this.personNode = new PersonNode(edad, nombre);
        }

        public int Number {
            get
            {
                return this.number;
            }
        }

        public ReadOnlyCollection<Node> Children { 
            get
            {
                return this.children.AsReadOnly();
            }
        }

        public Node(int number)
        {
            this.number = number;
        }

        public void AddChildren(Node n)
        {
            this.children.Add(n);
        }
        
        public void Accept(Visitor visit)
        {
            visit.Visit(this);
        }
    }
}