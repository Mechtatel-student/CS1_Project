using Domain.DAO;

namespace ContosoUI.ClientSearchForm
{
    public class ClientSearchModel: Model
    {
        public ClientSearchModel()
            :base()
        {

        }
        public IClientRepository ClientRepository 
        {
            get { return Facade.ClientRepository; }
        }
    }
}
