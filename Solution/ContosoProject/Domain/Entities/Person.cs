using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Person
    {
        string firstName;
        string middleName;
        string lastName;

        public string FirstName
        {
            get
            {
                return firstName; 
            }
        }
      public string MiddleName 
      { 
          get 
          { 
              return middleName; 
          } 
      }
      public string LastName 
      { 
          get 
          { 
              return lastName; 
          } 
      }

     

    }
}
