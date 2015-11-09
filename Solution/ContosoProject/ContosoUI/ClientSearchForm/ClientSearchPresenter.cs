using Data.Design;
using Domain.DAO;
using Domain.Entities.Clients;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ContosoUI.ClientSearchForm
{
    public class ClientSearchPresenter : Presenter, ISearchPresenter
    {        
        private readonly IClientSearchView _view;
        private readonly ClientSearchModel _model;

        private readonly IClientRepository _clientRepository;

        private BindingList<Client> clientsList = new BindingList<Client>();

        public ClientSearchPresenter(IClientSearchView view, ClientSearchModel model)
        {            
            _view = view;
            _model = model;
            _clientRepository = _model.ClientRepository;
        }

        private string city;
        public string City 
        {
            get { return city; }
            set
            {
                this.city = value;
                NotifyPropertyChanged();
            }
        }

        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set
            {
                this.firstName = value;
                NotifyPropertyChanged();
            }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set
            {
                this.lastName = value;
                NotifyPropertyChanged();             
            }
        }

        public BindingList<Client> Clients
        {
            get { return clientsList; }
            set
            {
                this.clientsList = value;
                NotifyPropertyChanged();
            }
        }

        public void Edit(int id)
        {
            ClientForm.ClientView editClientForm = new ClientForm.ClientView(id) { Text = "Client editing.."};
            editClientForm.MdiParent = Program.MainForm;
            editClientForm.Show();
        }

        public void Search()
        {
            List<Client> clients;
            if (City != null && FirstName != null && LastName != null)
                clients = _clientRepository.FindBy(FirstName, LastName, City).ToList();
            else
                clients = _clientRepository.GetAll().ToList();

            Clients = new BindingList<Client>(clients);
        }

        public void Clear()
        {
            City = "";
            FirstName = "";
            LastName = "";
            Clients.Clear();
        }


        public override void Stop()
        {
            _model.Dispose();
        }
    }
}
