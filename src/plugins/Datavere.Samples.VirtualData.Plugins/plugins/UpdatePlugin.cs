
namespace Dataverse.Samples.VirtualData.Plugins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class UpdatePlugin : PluginBase
    {
        protected string _unsecureConfiguration;
        protected string _secureConfiguration;

        public UpdatePlugin(Type pluginClassName) : base(pluginClassName)
        {
        }

        public UpdatePlugin(string unsecureConfiguration, string secureConfiguration) : base(typeof(UpdatePlugin))
        {
            _unsecureConfiguration = unsecureConfiguration;
            _secureConfiguration = secureConfiguration;
        }

        protected override void ExecuteDataversePlugin(ILocalPluginContext localPluginContext)
        {
            base.ExecuteDataversePlugin(localPluginContext);
        }
    }
}
