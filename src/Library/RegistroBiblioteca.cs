using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
namespace Library
{
    public class RegistroBiblioteca
    {
        private static RegistroBiblioteca UnicaInstancia;
        private List<IMaterial> materiales;
        private RegistroBiblioteca()
        {
            materiales = new List<IMaterial>();
        }
        public static RegistroBiblioteca ObtenerInstancia()
        {
            if (UnicaInstancia == null)
            {
                UnicaInstancia = new RegistroBiblioteca();

            }
            return UnicaInstancia;
        }
        public void AgregarMaterial(IMaterial material)
        {
            materiales.Add(material);
        }
        public List<IMaterial> ObtenerMateriales()
        {
            return materiales;
        }
    }
}
