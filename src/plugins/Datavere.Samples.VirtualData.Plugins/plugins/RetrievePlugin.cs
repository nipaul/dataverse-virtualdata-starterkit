
namespace Dataverse.Samples.VirtualData.Plugins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class RetrievePlugin : PluginBase
    {
        protected string _unsecureConfiguration;
        protected string _secureConfiguration;

        public RetrievePlugin(Type pluginClassName) : base(pluginClassName)
        {
        }

        public RetrievePlugin(string unsecureConfiguration, string secureConfiguration) : base(typeof(RetrievePlugin))
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
