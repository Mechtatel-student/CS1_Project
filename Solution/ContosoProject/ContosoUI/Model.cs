﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Design;

namespace ContosoUI
{
    public abstract class Model
    {
        protected IRepositoryFacade Facade;
        protected Model()
        {
            Facade = new EFRepositoryFacade();
        }
    }
}
