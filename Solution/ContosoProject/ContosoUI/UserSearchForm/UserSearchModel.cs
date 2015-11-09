using Domain.DAO;

namespace ContosoUI.UserSearchForm
{
    public class UserSearchModel: Model
    {
        public UserSearchModel()
            :base()
        {

        }

        public IUserRepository UserRepository 
        {
            get { return Facade.UserRepository; } 
        }
    }
}
