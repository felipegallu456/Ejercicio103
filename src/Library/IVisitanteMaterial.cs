using System;
using System.Runtime.InteropServices;

namespace Library
{
    public interface IVisitanteMaterial
    {
        void Visitar(Libro libro);
        void Visitar(Revista revista);

        void Visitar(DVD dvd);
    }
}


