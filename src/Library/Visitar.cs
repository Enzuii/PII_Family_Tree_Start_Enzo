using System;

namespace Library
{
    public class Visitar: Visitor
    {
        public static int edades = 0;
        public override void Visit(Node nodo)
        {
            edades += nodo.PersonNode.Edad;
            foreach (Node hijo in nodo.Children)
            {
                hijo.Accept(this);
            }
        }
    }
}