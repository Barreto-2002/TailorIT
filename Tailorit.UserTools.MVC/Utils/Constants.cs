using System.Collections.Generic;
using Tailorit.UserTools.MVC.Models;

namespace Tailorit.UserTools.MVC.Utils
{
    public static class Constants
    {
        public static List<UserViewModel> Sexo()
        {
            return new List<UserViewModel>()
            {
                 new UserViewModel {IdSexo = 1,DescriptionSexo = "Masculino"},
                 new UserViewModel {IdSexo = 2,DescriptionSexo = "Feminino"},
            };
        }

        public const string validatePassword = "Senhas Não conferem";
    }
}
