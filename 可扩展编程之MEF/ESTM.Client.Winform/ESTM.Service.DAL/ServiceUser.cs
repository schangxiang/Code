using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESTM.Service.DAL
{
    public class ServiceUser:Base
    {
        public List<TB_USERS> GetAllUsers()
        {
            return EntityFramework.Set<TB_USERS>().ToList();
        }
    }
}
