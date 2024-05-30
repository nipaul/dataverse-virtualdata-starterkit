
namespace Dataverse.Samples.VirtualData.Plugins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class DeletePlugin : PluginBase
    {
        protected string _unsecureConfiguration;
        protected string _secureConfiguration;

        public DeletePlugin(Type pluginClassName) : base(pluginClassName)
        {
        }

        public DeletePlugin(string unsecureConfiguration, string secureConfiguration) : base(typeof(DeletePlugin))
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
