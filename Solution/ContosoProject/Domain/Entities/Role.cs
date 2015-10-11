using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Role : Entity
    {
        public string Title { get; set; }
        public List<Permission> Permissions { get; set; }
        
        public Role()
        {
            Permissions = new List<Permission>();
        }
    }
}
