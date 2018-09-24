namespace Nutanix.Powershell
{
    using static Microsoft.Rest.ClientRuntime.Extensions;
    using SignalDelegateI = System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>;
    using SignalDelegate = System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task>;
    using GetParameterDelegate = System.Func<string, string, System.Collections.Generic.Dictionary<string,object>, string, object>;
    using SendAsyncStepDelegate = System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Func<System.Net.Http.HttpRequestMessage, System.Threading.CancellationToken, System.Action, System.Func<string, System.Threading.CancellationToken, System.Func<System.EventArgs>, System.Threading.Tasks.Task>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>, System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage>>;
    /// <summary>A class that contains the module-common code and data.</summary>
    public partial class Module
    {
        /// <summary>FIXME: Field _handler is MISSING DESCRIPTION</summary>
        public System.Net.Http.HttpClientHandler _handler = new System.Net.Http.HttpClientHandler();
        /// <summary>the ISendAsync pipeline instance</summary>
         private Microsoft.Rest.ClientRuntime.HttpPipeline _pipeline;
        /// <summary>the ISendAsync pipeline instance (when proxy is enabled)</summary>
         private Microsoft.Rest.ClientRuntime.HttpPipeline _pipelineWithProxy;
        /// <summary>FIXME: Field _webProxy is MISSING DESCRIPTION</summary>
        public System.Net.WebProxy _webProxy = new System.Net.WebProxy();
        /// <summary>The instance of the Client API</summary>
        public Nutanix.Powershell.NutanixIntentfulAPI ClientAPI {get;set;}
        /// <summary>Backing field for Instance property</summary>
        private static Nutanix.Powershell.Module _instance;

        /// <summary>the singleton of this module class</summary>
        public static Nutanix.Powershell.Module Instance => Nutanix.Powershell.Module._instance?? (Nutanix.Powershell.Module._instance = new Nutanix.Powershell.Module());
        /// <summary>FIXME: Method AfterCreatePipeline is MISSING DESCRIPTION</summary>
        /// <param name="boundParams">FIXME: Parameter boundParams is MISSING DESCRIPTION</param>
        /// <param name="pipeline">FIXME: Parameter pipeline is MISSING DESCRIPTION</param>
        partial void AfterCreatePipeline(System.Collections.Generic.Dictionary<string,object> boundParams, ref Microsoft.Rest.ClientRuntime.HttpPipeline pipeline);
        /// <summary>FIXME: Method BeforeCreatePipeline is MISSING DESCRIPTION</summary>
        /// <param name="boundParams">FIXME: Parameter boundParams is MISSING DESCRIPTION</param>
        /// <param name="pipeline">FIXME: Parameter pipeline is MISSING DESCRIPTION</param>
        partial void BeforeCreatePipeline(System.Collections.Generic.Dictionary<string,object> boundParams, ref Microsoft.Rest.ClientRuntime.HttpPipeline pipeline);
        /// <summary>FIXME: Method CustomInit is MISSING DESCRIPTION</summary>

        partial void CustomInit();
        /// <summary>Creates an instance of the HttpPipeline for each call.</summary>
        /// <param name="boundParameters">The bound parameters from the cmdlet call.</param>
        /// <returns>An instance of Microsoft.Rest.ClientRuntime.HttpPipeline for the remote call.</returns>
        public Microsoft.Rest.ClientRuntime.HttpPipeline CreatePipeline(System.Collections.Generic.Dictionary<string,object> boundParameters)
        {
            Microsoft.Rest.ClientRuntime.HttpPipeline pipeline = null;
            BeforeCreatePipeline(boundParameters, ref pipeline);
            pipeline = (pipeline ?? (_handler.UseProxy ? _pipelineWithProxy : _pipeline)).Clone();
            AfterCreatePipeline(boundParameters, ref pipeline);
            return pipeline;
        }
        /// <summary>Initialization steps performed after the module is loaded.</summary>

        public void Init()
        {
            // called at module init time...
            CustomInit();
        }
        /// <summary>Creates the module instance.</summary>
        private Module()
        {
            /// constructor
            ClientAPI = new Nutanix.Powershell.NutanixIntentfulAPI();
            _handler.Proxy = _webProxy;
            _pipeline = new Microsoft.Rest.ClientRuntime.HttpPipeline(new Microsoft.Rest.ClientRuntime.HttpClientFactory(new System.Net.Http.HttpClient()));
            _pipelineWithProxy = new Microsoft.Rest.ClientRuntime.HttpPipeline(new Microsoft.Rest.ClientRuntime.HttpClientFactory(new System.Net.Http.HttpClient(_handler)));
        }
        /// <summary>FIXME: Method SetProxyConfiguration is MISSING DESCRIPTION</summary>
        /// <param name="proxy">FIXME: Parameter proxy is MISSING DESCRIPTION</param>
        /// <param name="proxyCredential">FIXME: Parameter proxyCredential is MISSING DESCRIPTION</param>
        /// <param name="proxyUseDefaultCredentials">FIXME: Parameter proxyUseDefaultCredentials is MISSING DESCRIPTION</param>
        public void SetProxyConfiguration(System.Uri proxy, System.Management.Automation.PSCredential proxyCredential, bool proxyUseDefaultCredentials)
        {
            // set the proxy configuration
            _webProxy.Address = proxy;
            _webProxy.BypassProxyOnLocal = false;
            _webProxy.Credentials = proxyCredential ?.GetNetworkCredential();
            _webProxy.UseDefaultCredentials = proxyUseDefaultCredentials;
            _handler.UseProxy = proxy != null;
        }
    }
}