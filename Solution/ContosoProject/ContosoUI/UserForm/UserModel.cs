using Data.Design;
using Data.DummyData;
using Data.EFRepository;
using Domain.DAO;
using Domain.Entities.Users;

namespace ContosoUI.UserForm
{
    public class UserModel: Model
    {        
        public UserModel()
            :base()
        {

        }

        public IRoleRepository RoleRepository
        {
            get { return Facade.RoleRepository; }
        }
        public IUserRepository UserRepository 
        {
            get { return Facade.UserRepository; }
        }

        public void Save(User currentUser)
        {
            UserRepository.Update(currentUser);
        }

        public void Create(User currentUser)
        {
            UserRepository.Create(currentUser);
        }

        public User Find(int id)
        {
            return UserRepository.Read(id);
        }
    }
}
