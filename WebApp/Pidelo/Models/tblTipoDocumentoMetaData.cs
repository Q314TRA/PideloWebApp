using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Pidelo.Models
{
    public class tblTipoDocumentoMetaData
    {
        [Display(Name = "Código Tipo Documento")]
        public int idTipoDocumento { get; set; }

        [Display(Name = "Tipo Documento")]
        [Required(ErrorMessage = "El tipo de documento es obligatorio")]
        public string nombre { get; set; }
    }

    [MetadataType(typeof(tblTipoDocumentoMetaData))]
    public partial class tblTipoDocumento
    {
    }
}