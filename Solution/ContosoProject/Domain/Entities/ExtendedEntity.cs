using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace Domain.Entities
{
    abstract class ExtendedEntity : Entity
    {
        public User User { get; set; }
        public DateTime Date { get; set; }

        protected ExtendedEntity()
        {
            Date = DateTime.Now;
        }

     } 
}
