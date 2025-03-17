
namespace Dataverse.Samples.VirtualData.Plugins
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;


    public class RetrieveMultiplePlugin : PluginBase
    {
        protected string _unsecureConfiguration;
        protected string _secureConfiguration;

        public RetrieveMultiplePlugin(Type pluginClassName) : base(pluginClassName)
        {
        }

        public RetrieveMultiplePlugin(string unsecureConfiguration, string secureConfiguration) : base(typeof(RetrieveMultiplePlugin))
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
