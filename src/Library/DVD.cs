using System;

namespace Library
{
    public class DVD : IMaterial
    {
        public string Titulo {get;set;}
        public string Documento {get;set;}
        public DVD(string titulo, string documento)
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


