using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace deliveryDrone.App.Frontend.Pages
{
    public class Index3Model : PageModel
    {
    private string[] saludos= {"Index3","Sdrasvitia", "Bon Jorno", "Bon Jour","Hello"}; //atributo de la clase

    public List<string> Lista3EstadoPaquete {get;set;} //propiedad de la clase

    
        public void OnGet()
        {
            Lista3EstadoPaquete = new List<string>();
            Lista3EstadoPaquete.AddRange(saludos);

        }
    
    }
}
