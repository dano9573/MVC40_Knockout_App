using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVC40_Knockout_App.Models
{
    // Models returned by MeController actions.
    public class GetViewModel
    {
        public string Hometown { get; set; }
    }
}