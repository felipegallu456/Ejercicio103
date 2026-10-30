namespace Library
{
    public interface IMaterial
    {
        void Aceptar(IVisitanteMaterial visitante);

        string Titulo {get; set;}

        string Documento {get; set;}
    }
}

