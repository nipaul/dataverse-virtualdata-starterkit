
namespace Dataverse.Samples.VirtualData.Plugins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class CreatePlugin : PluginBase
    {
        protected string _unsecureConfiguration;
        protected string _secureConfiguration;

        public CreatePlugin(Type pluginClassName) : base(pluginClassName)
        {
        }

        public CreatePlugin(string unsecureConfiguration, string secureConfiguration) : base(typeof(CreatePlugin))
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
