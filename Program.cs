using System;

namespace Tp3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioBusqueda tree = new ArbolBinarioBusqueda(5);
            tree.agregar(6);
            tree.agregar(7);
            tree.preorden();

            Console.WriteLine("-------------------------");
            AVL nodoraiz = new AVL(5);
            nodoraiz.agregar(6);
            nodoraiz.agregar(7);
            nodoraiz.agregar(8);
            nodoraiz.agregar(9);
            nodoraiz.agregar(4);
            nodoraiz.agregar(3);

            nodoraiz.preorden();

            
        }
    }
}
