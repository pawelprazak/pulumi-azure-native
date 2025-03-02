// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Image template is an ARM resource managed by Microsoft.VirtualMachineImages provider
 */
export class VirtualMachineImageTemplate extends pulumi.CustomResource {
    /**
     * Get an existing VirtualMachineImageTemplate resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): VirtualMachineImageTemplate {
        return new VirtualMachineImageTemplate(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:virtualmachineimages/v20200214:VirtualMachineImageTemplate';

    /**
     * Returns true if the given object is an instance of VirtualMachineImageTemplate.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VirtualMachineImageTemplate {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VirtualMachineImageTemplate.__pulumiType;
    }

    /**
     * Maximum duration to wait while building the image template. Omit or specify 0 to use the default (4 hours).
     */
    public readonly buildTimeoutInMinutes!: pulumi.Output<number | undefined>;
    /**
     * Specifies the properties used to describe the customization steps of the image, like Image source etc
     */
    public readonly customize!: pulumi.Output<(outputs.virtualmachineimages.v20200214.ImageTemplateFileCustomizerResponse | outputs.virtualmachineimages.v20200214.ImageTemplatePowerShellCustomizerResponse | outputs.virtualmachineimages.v20200214.ImageTemplateRestartCustomizerResponse | outputs.virtualmachineimages.v20200214.ImageTemplateShellCustomizerResponse | outputs.virtualmachineimages.v20200214.ImageTemplateWindowsUpdateCustomizerResponse)[] | undefined>;
    /**
     * The distribution targets where the image output needs to go to.
     */
    public readonly distribute!: pulumi.Output<(outputs.virtualmachineimages.v20200214.ImageTemplateManagedImageDistributorResponse | outputs.virtualmachineimages.v20200214.ImageTemplateSharedImageDistributorResponse | outputs.virtualmachineimages.v20200214.ImageTemplateVhdDistributorResponse)[]>;
    /**
     * The identity of the image template, if configured.
     */
    public readonly identity!: pulumi.Output<outputs.virtualmachineimages.v20200214.ImageTemplateIdentityResponse>;
    /**
     * State of 'run' that is currently executing or was last executed.
     */
    public /*out*/ readonly lastRunStatus!: pulumi.Output<outputs.virtualmachineimages.v20200214.ImageTemplateLastRunStatusResponse>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Provisioning error, if any
     */
    public /*out*/ readonly provisioningError!: pulumi.Output<outputs.virtualmachineimages.v20200214.ProvisioningErrorResponse>;
    /**
     * Provisioning state of the resource
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Specifies the properties used to describe the source image.
     */
    public readonly source!: pulumi.Output<outputs.virtualmachineimages.v20200214.ImageTemplateManagedImageSourceResponse | outputs.virtualmachineimages.v20200214.ImageTemplatePlatformImageSourceResponse | outputs.virtualmachineimages.v20200214.ImageTemplateSharedImageVersionSourceResponse>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Describes how virtual machine is set up to build images
     */
    public readonly vmProfile!: pulumi.Output<outputs.virtualmachineimages.v20200214.ImageTemplateVmProfileResponse | undefined>;

    /**
     * Create a VirtualMachineImageTemplate resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualMachineImageTemplateArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.distribute === undefined) && !opts.urn) {
                throw new Error("Missing required property 'distribute'");
            }
            if ((!args || args.identity === undefined) && !opts.urn) {
                throw new Error("Missing required property 'identity'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.source === undefined) && !opts.urn) {
                throw new Error("Missing required property 'source'");
            }
            resourceInputs["buildTimeoutInMinutes"] = (args ? args.buildTimeoutInMinutes : undefined) ?? 0;
            resourceInputs["customize"] = args ? args.customize : undefined;
            resourceInputs["distribute"] = args ? args.distribute : undefined;
            resourceInputs["identity"] = args ? args.identity : undefined;
            resourceInputs["imageTemplateName"] = args ? args.imageTemplateName : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["source"] = args ? args.source : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["vmProfile"] = args ? (args.vmProfile ? pulumi.output(args.vmProfile).apply(inputs.virtualmachineimages.v20200214.imageTemplateVmProfileArgsProvideDefaults) : undefined) : undefined;
            resourceInputs["lastRunStatus"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["provisioningError"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["buildTimeoutInMinutes"] = undefined /*out*/;
            resourceInputs["customize"] = undefined /*out*/;
            resourceInputs["distribute"] = undefined /*out*/;
            resourceInputs["identity"] = undefined /*out*/;
            resourceInputs["lastRunStatus"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["provisioningError"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["source"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["vmProfile"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:virtualmachineimages:VirtualMachineImageTemplate" }, { type: "azure-native:virtualmachineimages/v20180201preview:VirtualMachineImageTemplate" }, { type: "azure-native:virtualmachineimages/v20190201preview:VirtualMachineImageTemplate" }, { type: "azure-native:virtualmachineimages/v20190501preview:VirtualMachineImageTemplate" }, { type: "azure-native:virtualmachineimages/v20211001:VirtualMachineImageTemplate" }, { type: "azure-native:virtualmachineimages/v20220214:VirtualMachineImageTemplate" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(VirtualMachineImageTemplate.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a VirtualMachineImageTemplate resource.
 */
export interface VirtualMachineImageTemplateArgs {
    /**
     * Maximum duration to wait while building the image template. Omit or specify 0 to use the default (4 hours).
     */
    buildTimeoutInMinutes?: pulumi.Input<number>;
    /**
     * Specifies the properties used to describe the customization steps of the image, like Image source etc
     */
    customize?: pulumi.Input<pulumi.Input<inputs.virtualmachineimages.v20200214.ImageTemplateFileCustomizerArgs | inputs.virtualmachineimages.v20200214.ImageTemplatePowerShellCustomizerArgs | inputs.virtualmachineimages.v20200214.ImageTemplateRestartCustomizerArgs | inputs.virtualmachineimages.v20200214.ImageTemplateShellCustomizerArgs | inputs.virtualmachineimages.v20200214.ImageTemplateWindowsUpdateCustomizerArgs>[]>;
    /**
     * The distribution targets where the image output needs to go to.
     */
    distribute: pulumi.Input<pulumi.Input<inputs.virtualmachineimages.v20200214.ImageTemplateManagedImageDistributorArgs | inputs.virtualmachineimages.v20200214.ImageTemplateSharedImageDistributorArgs | inputs.virtualmachineimages.v20200214.ImageTemplateVhdDistributorArgs>[]>;
    /**
     * The identity of the image template, if configured.
     */
    identity: pulumi.Input<inputs.virtualmachineimages.v20200214.ImageTemplateIdentityArgs>;
    /**
     * The name of the image Template
     */
    imageTemplateName?: pulumi.Input<string>;
    /**
     * Resource location
     */
    location?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Specifies the properties used to describe the source image.
     */
    source: pulumi.Input<inputs.virtualmachineimages.v20200214.ImageTemplateManagedImageSourceArgs | inputs.virtualmachineimages.v20200214.ImageTemplatePlatformImageSourceArgs | inputs.virtualmachineimages.v20200214.ImageTemplateSharedImageVersionSourceArgs>;
    /**
     * Resource tags
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Describes how virtual machine is set up to build images
     */
    vmProfile?: pulumi.Input<inputs.virtualmachineimages.v20200214.ImageTemplateVmProfileArgs>;
}
