using ESTM.Common.Model;
using ESTM.Service.IBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ESTM.Service.WCF
{
    public class CSOAService:ICSOAService
    {
        [Import("Users")]
        public IServiceUser Service { set; get; }

        public CSOAService()
        {
            regisgterAll().ComposeParts(this);
        }

        public List<DTO_USERS> GetAllUsers()
        {
            return Service.GetAllUser();
        }

        public CompositionContainer regisgterAll()
        {
            AggregateCatalog aggregateCatalog = new AggregateCatalog();
            var thisAssembly = new DirectoryCatalog(AppDomain.CurrentDomain.BaseDirectory, "*.dll");
            aggregateCatalog.Catalogs.Add(thisAssembly);
            var _container = new CompositionContainer(aggregateCatalog);

            return _container;
        }
    }
}
