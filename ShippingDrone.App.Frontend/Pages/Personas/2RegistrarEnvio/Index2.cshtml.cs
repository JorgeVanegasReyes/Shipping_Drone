using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deliveryDrone.App.Frontend.Pages
{
    public class Index2Model : PageModel
    {
    private string[] saludos= {"Index2","WHAT´S UP GENIUS","Sdrasvitia", "Bon Jorno", "Bon Jour","Hello"}; //atributo de la clase

    public List<string> Lista2RegistrarEnvio {get;set;} //propiedad de la clase

    
        public void OnGet()
        {
            Lista2RegistrarEnvio = new List<string>();
            Lista2RegistrarEnvio.AddRange(saludos);

        }
    
    }
}