using System;
using System.Collections.Generic;
using Domain.Entities;
using Domain.Entities.Comments;

namespace Data.StoreData
{
    public static partial class Storage
    {
        public static List<Location> Locations = new List<Location>
        {
            new Location{Adress = "pr. Metalurgov, 78", City = "Dnepropetrovsk"},
            new Location{Adress = "ul. Sevastopolskaya, 43", City = "Dnepropetrovsk"},
            new Location{Adress = "ul. Davidova, 3", City = "Dnepropetrovsk"},
            new Location{Adress = "ul. Gogolya, 6", City = "Dnepropetrovsk"}
        }; 

        public static List<List<string>> ClientTelephones = new List<List<string>>
        {
            new List<string>{"+389264093268","+389261000000"},
            new List<string>{"+389261000000","+389263465914"},
            new List<string>{}
        }; 

        public static List<Client> Clients = new List<Client>
        {
            new Client(ClientTelephones[0], new List<Comment>()){ClientLocation = Locations[0], Id = 1, IsActive = true, User = Users[0], Date = new DateTime(2003, 11, 2, 23, 9, 0), Person = new Person{FirstName = "Nik", MiddleName = "Markus", LastName = "Flemigan"}},
            new Client(ClientTelephones[2], new List<Comment>()){ClientLocation = Locations[1], Id = 2, IsActive = true, User = Users[1], Date = new DateTime(2003, 9, 1, 11 , 9, 0), Person = new Person{FirstName = "Serge", MiddleName = "Petros", LastName = "Morgan"}},
            new Client(ClientTelephones[1], new List<Comment>()){ClientLocation = Locations[3], Id = 3, IsActive = true, User = Users[2], Date = new DateTime(2003, 8, 3, 6, 12, 3), Person = new Person{FirstName = "Morgan", MiddleName = "Lukas", LastName = "Plemon"}}
        }; 
    }
}
