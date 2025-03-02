// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.VirtualMachineImages.V20200214
{
    public static class GetVirtualMachineImageTemplate
    {
        /// <summary>
        /// Image template is an ARM resource managed by Microsoft.VirtualMachineImages provider
        /// </summary>
        public static Task<GetVirtualMachineImageTemplateResult> InvokeAsync(GetVirtualMachineImageTemplateArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVirtualMachineImageTemplateResult>("azure-native:virtualmachineimages/v20200214:getVirtualMachineImageTemplate", args ?? new GetVirtualMachineImageTemplateArgs(), options.WithDefaults());

        /// <summary>
        /// Image template is an ARM resource managed by Microsoft.VirtualMachineImages provider
        /// </summary>
        public static Output<GetVirtualMachineImageTemplateResult> Invoke(GetVirtualMachineImageTemplateInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetVirtualMachineImageTemplateResult>("azure-native:virtualmachineimages/v20200214:getVirtualMachineImageTemplate", args ?? new GetVirtualMachineImageTemplateInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVirtualMachineImageTemplateArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the image Template
        /// </summary>
        [Input("imageTemplateName", required: true)]
        public string ImageTemplateName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetVirtualMachineImageTemplateArgs()
        {
        }
    }

    public sealed class GetVirtualMachineImageTemplateInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the image Template
        /// </summary>
        [Input("imageTemplateName", required: true)]
        public Input<string> ImageTemplateName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetVirtualMachineImageTemplateInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetVirtualMachineImageTemplateResult
    {
        /// <summary>
        /// Maximum duration to wait while building the image template. Omit or specify 0 to use the default (4 hours).
        /// </summary>
        public readonly int? BuildTimeoutInMinutes;
        /// <summary>
        /// Specifies the properties used to describe the customization steps of the image, like Image source etc
        /// </summary>
        public readonly ImmutableArray<object> Customize;
        /// <summary>
        /// The distribution targets where the image output needs to go to.
        /// </summary>
        public readonly ImmutableArray<object> Distribute;
        /// <summary>
        /// Resource Id
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The identity of the image template, if configured.
        /// </summary>
        public readonly Outputs.ImageTemplateIdentityResponse Identity;
        /// <summary>
        /// State of 'run' that is currently executing or was last executed.
        /// </summary>
        public readonly Outputs.ImageTemplateLastRunStatusResponse LastRunStatus;
        /// <summary>
        /// Resource location
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// Resource name
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Provisioning error, if any
        /// </summary>
        public readonly Outputs.ProvisioningErrorResponse ProvisioningError;
        /// <summary>
        /// Provisioning state of the resource
        /// </summary>
        public readonly string ProvisioningState;
        /// <summary>
        /// Specifies the properties used to describe the source image.
        /// </summary>
        public readonly object Source;
        /// <summary>
        /// Resource tags
        /// </summary>
        public readonly ImmutableDictionary<string, string>? Tags;
        /// <summary>
        /// Resource type
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Describes how virtual machine is set up to build images
        /// </summary>
        public readonly Outputs.ImageTemplateVmProfileResponse? VmProfile;

        [OutputConstructor]
        private GetVirtualMachineImageTemplateResult(
            int? buildTimeoutInMinutes,

            ImmutableArray<object> customize,

            ImmutableArray<object> distribute,

            string id,

            Outputs.ImageTemplateIdentityResponse identity,

            Outputs.ImageTemplateLastRunStatusResponse lastRunStatus,

            string location,

            string name,

            Outputs.ProvisioningErrorResponse provisioningError,

            string provisioningState,

            object source,

            ImmutableDictionary<string, string>? tags,

            string type,

            Outputs.ImageTemplateVmProfileResponse? vmProfile)
        {
            BuildTimeoutInMinutes = buildTimeoutInMinutes;
            Customize = customize;
            Distribute = distribute;
            Id = id;
            Identity = identity;
            LastRunStatus = lastRunStatus;
            Location = location;
            Name = name;
            ProvisioningError = provisioningError;
            ProvisioningState = provisioningState;
            Source = source;
            Tags = tags;
            Type = type;
            VmProfile = vmProfile;
        }
    }
}
