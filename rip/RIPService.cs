using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace rip
{
    public partial class RIPService : ServiceBase
    {
        private Hook hooker;
        public RIPService()
        {
            InitializeComponent();
            hooker = new Hook();
        }

        protected override void OnStart(string[] args)
        {
            hooker.Register();
        }

        protected override void OnStop()
        {
            hooker.Unregister();
        }
    }
}
