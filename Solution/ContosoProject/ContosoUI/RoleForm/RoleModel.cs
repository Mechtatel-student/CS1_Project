using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.DummyData;
using Data.EFRepository;
using DevExpress.XtraRichEdit.Commands;
using Domain.DAO;
using Domain.Entities.Users;

namespace ContosoUI.RoleForm
{
    internal class RoleModel:Model
    {
        public RoleModel()
            :base()
        {

        }

        public IRoleRepository RoleRepository
        {
            get { return Facade.RoleRepository; }
        }
        public IPermissionRepository PermissionRepository
        {
            get { return Facade.PermissionRepository; }
        }

        public void Save(Role currentRole)
        {
            RoleRepository.Update(currentRole);
        }

        public void Create(Role currentRole)
        {
            RoleRepository.Create(currentRole);
        }

        public Role Find(int id)
        {
            return RoleRepository.Read(id);
        }
    }
}