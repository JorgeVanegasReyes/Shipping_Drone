using System;
using ShippingDrone.App.Dominio;
using ShippingDrone.App.Persistencia;

namespace ShippingDrone.App.Consola
{
    class Program
    {
        private static IRepositorioPersona _repoPaciente =new RepositorioPersona(new Persistencia.AppContext());
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //AddPersona();
            BuscarPersona(1);
        }
        private static void AddPersona()
        {
            var persona = new Persona
            {
                
                Nombre = "Jorge",
                Apellidos = "Vanegas",
                Celular = "320 2306839"
            };
            _repoPaciente.AddPersona(persona); /*agrega a persona*/
        }
        private static void BuscarPersona(int idPersona)
        {
            var persona = _repoPaciente.GetPersona(idPersona);
            Console.WriteLine(persona.Nombre+ "" + persona.Apellidos);
            
                
        }
    }
}
