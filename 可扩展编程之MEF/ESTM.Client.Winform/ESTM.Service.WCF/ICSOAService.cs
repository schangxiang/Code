using ESTM.Common.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ESTM.Service.WCF
{
    [ServiceContract]
    public interface ICSOAService
    {
        [OperationContract]
        List<DTO_USERS> GetAllUsers();
    }
}
