using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deliveryDrone.App.Frontend.Pages
{
    public class Index1Model : PageModel
    {
    private string[] saludos= {"Index1","Sdrasvitia", "Bon Jorno", "Bon Jour","Hello"}; //atributo de la clase

    public List<string> Lista1DatosPersonales {get;set;} //propiedad de la clase

    
        public void OnGet()
        {
            Lista1DatosPersonales = new List<string>();
            Lista1DatosPersonales.AddRange(saludos);

        }
    
    }
}
