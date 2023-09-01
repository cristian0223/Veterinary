using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veterinary.Shared.Entities
{
    public class Owner
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El documento es requerido")]
        public string Documento { get; set; } = string.Empty;

        [Required(ErrorMessage = "El nombre es requerido")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "El apellido es requerido")]
        public string LastName { get; set; } = string.Empty;
        public string FixedPhone {  get; set; } = string.Empty;

        [Required(ErrorMessage = "El numero celular es requerido")]
        public string CellPhone {  get; set; } = string.Empty;

        public string Adress {  get; set; } = string.Empty;
        public string FullName => $"{FirstName}{LastName}";

    }
}
