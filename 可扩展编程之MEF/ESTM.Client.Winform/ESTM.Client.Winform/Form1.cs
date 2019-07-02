using ESTM.Client.IBLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTM.Client.Winform
{
    public partial class Form1 : Form
    {

        [Import("Users")]
        public IManagerUser Manager { set; get; }
       
        public Form1()
        {
            InitializeComponent();
            regisgterAll().ComposeParts(this);

            this.dataGridView1.DataSource = Manager.GetAllUser();
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
