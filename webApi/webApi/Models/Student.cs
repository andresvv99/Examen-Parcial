

namespace webApi.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    public class Student
    {
        [Key]
        public int FairyID { get; set; }
        [Required]
        [Display(Name = "Nombre Completo")]
        [StringLength(24, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        public Lista Wishes { get; set; }
        [DataType(DataType.EmailAddress, ErrorMessage = "Direccion de correo no valida")]
        public string Email { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Birthdate { get; set; }



    }
    public enum Lista {
        Amor,
        Alas,
        Alma 
    }
}