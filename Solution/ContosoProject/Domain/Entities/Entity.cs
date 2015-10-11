using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    abstract class Entity
    {
        public bool IsActive { get; set; }

        protected Entity()
        {
            IsActive = true;
        }
    }
}
