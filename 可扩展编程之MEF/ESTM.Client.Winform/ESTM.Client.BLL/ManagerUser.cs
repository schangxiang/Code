using ESTM.Client.IBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTM.Client.BLL
{
    [Export("Users",typeof(IManagerUser))]
    public class ManagerUser : IManagerUser
    {

        public List<Common.Model.DTO_USERS> GetAllUser()
        {
            var oWCFService = new ServiceReference_MyWCF.CSOAServiceClient();
            return oWCFService.GetAllUsers().ToList();
        }
    }
}
