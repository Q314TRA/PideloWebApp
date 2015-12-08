using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pidelo.Models
{
    public class tblUsuarioMetaData
    {
        public int idUsuario { get; set; }
        [Required(ErrorMessage = "Por favor ingrese un usuario valido.", AllowEmptyStrings = false)]
        public string usuario { get; set; }
        [Required(ErrorMessage = "Por favor ingrese una contraseña valido.", AllowEmptyStrings = false)]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string contrasenia { get; set; }
        public string contraseniaSalt { get; set; }
    }
    [MetadataType(typeof(tblUsuarioMetaData))]
    public partial class tblUsuario
    {
    }
}