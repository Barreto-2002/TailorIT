using System;
using System.ComponentModel.DataAnnotations;

namespace Tailorit.UserTools.MVC.Models
{
    public class UserViewModel
    {

        [Display(Name = "Nome")]
        [Required(ErrorMessage = "Campo nome é obrigatório.")]
        public string Name { get; set; }
        
        [Display(Name = "Data Nascimento")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        [DataType(DataType.DateTime)]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "Campo nome é obrigatório.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        public string Email { get; set; }
        public int IdSexo { get; set; }

        [Display(Name = "Ativo")]
        public bool Active { get; set; }

        [Display(Name = "Senha")]
        [Required(ErrorMessage = "Campo Senha é obrigatório.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Confirmar Senha.")]
        [Required(ErrorMessage = "Campo Confirmar Senha é obrigatório.")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Sexo")]
        public string DescriptionSexo { get; set; }

        [Display(Name = "Ativo")]
        public string DescriptionActive { get; set; }


        public bool ValidatePassword()
        {
            if (Password.Equals(ConfirmPassword))
                return true;

            return false;
        }

    }
}
