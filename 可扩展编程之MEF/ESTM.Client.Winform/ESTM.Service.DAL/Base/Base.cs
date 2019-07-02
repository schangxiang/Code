using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ESTM.Service.DAL
{
    public class Base
    {
        [Import]
        public DbContext EntityFramework { set; get; }

        public Base()
        {
            //因为这里有Import，所以需要装配MEF
            regisgter().ComposeParts(this);
        }

        public CompositionContainer regisgter()
        {
            var catalog = new AssemblyCatalog(Assembly.GetExecutingAssembly());
            var container = new CompositionContainer(catalog);
            return container;
        }
    }
}
