/*esta es la interface y se definen los metodos del CRUD*/

using System.Collections.Generic;
using ShippingDrone.App.Dominio;

namespace ShippingDrone.App.Persistencia
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> GetAllPersonas();  /*retorna una lista*/
        Persona AddPersona(Persona persona); /*metodos CRUD*/
        Persona UpdatePersona(Persona persona);
        void DeletePersona(int idPersona);
        Persona GetPersona(int idPersona);
    }
}