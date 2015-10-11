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

      public Person()
      {
      }
     public Person(string firstName1, string middleName1, string lastName1)
      {
          firstName = firstName1;
          middleName = middleName1;
          lastName = lastName1;
      }

    }
}
