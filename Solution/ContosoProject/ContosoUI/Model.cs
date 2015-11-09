using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Design;

namespace ContosoUI
{
    public abstract class Model: IDisposable
    {
        private bool _disposed;

        protected IRepositoryFacade Facade;
        protected Model()
        {
            Facade = new EFRepositoryFacade();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed)
                return;

            if (disposing)
                Facade.Dispose();
            
            _disposed = true;
        }
    }
}
