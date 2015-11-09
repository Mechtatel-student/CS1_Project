using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI.ClientForm
{
    public interface IClientView
    {
        void ShowView(ClientPresenter presenter, int id);
    }
}
