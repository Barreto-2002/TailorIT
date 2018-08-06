using System;


namespace TailorIT.UserTools.Domain.Entities
{
    public class User : Entity
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public int IdSexo { get; set; }
        public virtual Sexo Sexo { get; set; }
        public bool Active { get; set; }
        public string Senha { get; set; }
    }
}
