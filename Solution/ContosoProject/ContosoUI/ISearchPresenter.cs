using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI
{
    interface ISearchPresenter
    {
        void Edit (int id);
        void Search();
        void Clear();
    }
}
