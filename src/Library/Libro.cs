using System;
namespace Library
{
    public class Libro : IMaterial
    {
        public string Titulo {get;set;}
        public string Documento {get;set;}
        public Libro(string titulo, string documento)
        {
            Titulo = titulo;
            Documento = documento;
        }
        public void Aceptar(IVisitanteMaterial visitante)
        {
            visitante.Visitar(this);
        }
    }

}
