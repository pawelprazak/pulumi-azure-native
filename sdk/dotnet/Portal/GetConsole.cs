// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Portal
{
    public static class GetConsole
    {
        /// <summary>
        /// Cloud shell console
        /// API Version: 2018-10-01.
        /// </summary>
        public static Task<GetConsoleResult> InvokeAsync(GetConsoleArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetConsoleResult>("azure-native:portal:getConsole", args ?? new GetConsoleArgs(), options.WithDefaults());

        /// <summary>
        /// Cloud shell console
        /// API Version: 2018-10-01.
        /// </summary>
        public static Output<GetConsoleResult> Invoke(GetConsoleInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetConsoleResult>("azure-native:portal:getConsole", args ?? new GetConsoleInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetConsoleArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the console
        /// </summary>
        [Input("consoleName", required: true)]
        public string ConsoleName { get; set; } = null!;

        public GetConsoleArgs()
        {
        }
    }

    public sealed class GetConsoleInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the console
        /// </summary>
        [Input("consoleName", required: true)]
        public Input<string> ConsoleName { get; set; } = null!;

        public GetConsoleInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetConsoleResult
    {
        /// <summary>
        /// Cloud shell console properties.
        /// </summary>
        public readonly Outputs.ConsolePropertiesResponse Properties;

        [OutputConstructor]
        private GetConsoleResult(Outputs.ConsolePropertiesResponse properties)
        {
            Properties = properties;
        }
    }
}
