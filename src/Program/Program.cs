//------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//------------------------------------------------------------------------------

using System;
using Library;

namespace Ucu.Poo.Ejercicio103
{
    /// <summary>
    /// Programa principal.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        static void Main(string[] args)
        {
            RegistroBiblioteca registro = RegistroBiblioteca.ObtenerInstancia();
            Libro libro1 = new Libro("Luna de Pluton", "L001");
            Libro libro2 = new Libro("Padre rico Padre pobre", "L002");
            DVD dvd1 = new DVD("Toy story 2", "D001");
            Revista revista1 = new Revista("Kanzenban", "R001");
            registro.AgregarMaterial(libro1);
            registro.AgregarMaterial(libro2);
            registro.AgregarMaterial(dvd1);
            registro.AgregarMaterial(revista1);
            InspectorMateriales inspector = new InspectorMateriales();
            Console.WriteLine("===Inspección de Materiales===");
            foreach (IMaterial material in registro.ObtenerMateriales())
            {
                material.Aceptar(inspector);
            }
            RegistroBiblioteca registro1 = RegistroBiblioteca.ObtenerInstancia();
            RegistroBiblioteca registro2 = RegistroBiblioteca.ObtenerInstancia();
            bool MismoRegistro = (registro1 == registro2);
            Console.WriteLine($"¿Es el mismo registro? {MismoRegistro}");
        }
    }
}