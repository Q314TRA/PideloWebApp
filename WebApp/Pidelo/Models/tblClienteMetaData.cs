using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace Pidelo.Models
{
    public class tblClienteMetaData
    {
        [Display(Name = "Código Cliente")]
        public int idCliente { get; set; }

        [Display(Name = "Razón Social")]
        [Required(ErrorMessage = "La razón social es obligatoria")]
        public string razonSocial { get; set; }

        [Display(Name = "Nombre Comercial")]
        public string nombreComercial { get; set; }

        [Display(Name = "Tipo Documento")]
        [Required(ErrorMessage = "El tipo documento es obligatorio")]
        public int idTipoDocumento { get; set; }

        [Display(Name = "Documento")]
        [Required(ErrorMessage = "El documento es obligatorio")]
        public string documento { get; set; }
    }

    [MetadataType(typeof(tblClienteMetaData))]
    public partial class tblCliente
    {
    }
}