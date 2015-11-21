using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Pidelo.Models
{
    public class tblZonaMetaData
    {
        [Display(Name = "Código Zona")]
        public int idZona { get; set; }

        [Display(Name = "Zona")]
        [Required(ErrorMessage = "El nombre de la zona es obligatorio")]
        public string nombre { get; set; }
    }

    [MetadataType(typeof(tblZonaMetaData))]
    public partial class tblZona
    {
    }
}