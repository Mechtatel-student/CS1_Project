using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUI
{
    interface IViewPresenter
    {
        void Save();
        void SaveAndNew();
        void New();
    }
}
