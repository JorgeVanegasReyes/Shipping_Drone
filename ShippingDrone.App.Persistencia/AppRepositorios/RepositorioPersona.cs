/*para inplementar una interfaz debemos inplementar todos sus metodos*/
using System.Collections.Generic;
using ShippingDrone.App.Dominio;
using System.Linq;

namespace ShippingDrone.App.Persistencia
{
    public class RepositorioPersona:IRepositorioPersona
    {
        /// <sumary>
        ///  Referencia al contexto de persona
        /// </sumary>

        private readonly AppContext _appContext;
        /// <sumary>
        /// Metodo constructor
        /// Inyeccion de dependencias
        /// </sumary>
        /// <param name="appContext"></param>

        public RepositorioPersona(AppContext appContext)
        {
            _appContext=appContext;
        }

        Persona IRepositorioPersona.AddPersona(Persona persona)
        {
            var personaInsertada= _appContext.Personas.Add(persona);
            _appContext.SaveChanges();
            return personaInsertada.Entity;

        }
        void IRepositorioPersona.DeletePersona(int idPersona)
        {
            var personaEncontrada= _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
            if (personaEncontrada == null){
                return;
            }
            _appContext.Personas.Remove(personaEncontrada);
            _appContext.SaveChanges();
            
        }

        IEnumerable<Persona> IRepositorioPersona.GetAllPersonas()
        {
            return _appContext.Personas;
        }

        Persona IRepositorioPersona.UpdatePersona(Persona persona)
        {
             var personaEncontrada = _appContext.Personas.FirstOrDefault(p => p.Id == persona.Id);
             /*p.id recorre y persona.Id es el parametro*/
             if(personaEncontrada != null){
                 personaEncontrada.Nombre = persona.Nombre; /*y asi es para todos los atributos que tenga*/
                 personaEncontrada.Apellidos = persona.Apellidos;
                 personaEncontrada.Celular = persona.Celular;
                 _appContext.SaveChanges();
             }
             return personaEncontrada;
        }
        
        Persona IRepositorioPersona.GetPersona(int idPersona)
        {
            var personaEncontrada= _appContext.Personas.FirstOrDefault(p => p.Id == idPersona);
            return personaEncontrada;
        }


    }
}