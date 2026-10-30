using System;
namespace Library
{
    public class InspectorMateriales : IVisitanteMaterial
    {
        public void Visitar(Libro libro)
        {
            Console.WriteLine("(Libro): Revisando estado de las páginas...");
        }
        public void Visitar(Revista revista)
        {
            Console.WriteLine("(Revista): Revisando estado de las páginas...");
        }
        public void Visitar(DVD dvd)
        {
            Console.WriteLine("(DVD): Revisando estado de las páginas...");
        }
    }
}
