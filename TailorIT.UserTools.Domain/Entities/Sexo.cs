using System.Collections.Generic;

namespace TailorIT.UserTools.Domain.Entities
{
    public class Sexo : Entity
    {
        public string Description { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
