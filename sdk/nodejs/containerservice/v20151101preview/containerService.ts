// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Container service
 *
 * @deprecated Version 2015-11-01-preview will be removed in v2 of the provider.
 */
export class ContainerService extends pulumi.CustomResource {
    /**
     * Get an existing ContainerService resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ContainerService {
        pulumi.log.warn("ContainerService is deprecated: Version 2015-11-01-preview will be removed in v2 of the provider.")
        return new ContainerService(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:containerservice/v20151101preview:ContainerService';

    /**
     * Returns true if the given object is an instance of ContainerService.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ContainerService {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ContainerService.__pulumiType;
    }

    /**
     * Properties of agent pools
     */
    public readonly agentPoolProfiles!: pulumi.Output<outputs.containerservice.v20151101preview.ContainerServiceAgentPoolProfileResponse[]>;
    /**
     * Properties for Diagnostic Agent
     */
    public readonly diagnosticsProfile!: pulumi.Output<outputs.containerservice.v20151101preview.ContainerServiceDiagnosticsProfileResponse | undefined>;
    /**
     * Properties for Linux VMs
     */
    public readonly linuxProfile!: pulumi.Output<outputs.containerservice.v20151101preview.ContainerServiceLinuxProfileResponse>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Properties of master agents
     */
    public readonly masterProfile!: pulumi.Output<outputs.containerservice.v20151101preview.ContainerServiceMasterProfileResponse>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Properties of orchestrator
     */
    public readonly orchestratorProfile!: pulumi.Output<outputs.containerservice.v20151101preview.ContainerServiceOrchestratorProfileResponse | undefined>;
    /**
     * Gets the provisioning state, which only appears in the response.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Properties of Windows VMs
     */
    public readonly windowsProfile!: pulumi.Output<outputs.containerservice.v20151101preview.ContainerServiceWindowsProfileResponse | undefined>;

    /**
     * Create a ContainerService resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2015-11-01-preview will be removed in v2 of the provider. */
    constructor(name: string, args: ContainerServiceArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("ContainerService is deprecated: Version 2015-11-01-preview will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.agentPoolProfiles === undefined) && !opts.urn) {
                throw new Error("Missing required property 'agentPoolProfiles'");
            }
            if ((!args || args.linuxProfile === undefined) && !opts.urn) {
                throw new Error("Missing required property 'linuxProfile'");
            }
            if ((!args || args.masterProfile === undefined) && !opts.urn) {
                throw new Error("Missing required property 'masterProfile'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["agentPoolProfiles"] = args ? args.agentPoolProfiles : undefined;
            resourceInputs["containerServiceName"] = args ? args.containerServiceName : undefined;
            resourceInputs["diagnosticsProfile"] = args ? args.diagnosticsProfile : undefined;
            resourceInputs["linuxProfile"] = args ? args.linuxProfile : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["masterProfile"] = args ? args.masterProfile : undefined;
            resourceInputs["orchestratorProfile"] = args ? args.orchestratorProfile : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["windowsProfile"] = args ? args.windowsProfile : undefined;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["agentPoolProfiles"] = undefined /*out*/;
            resourceInputs["diagnosticsProfile"] = undefined /*out*/;
            resourceInputs["linuxProfile"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["masterProfile"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["orchestratorProfile"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["windowsProfile"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:containerservice/v20160330:ContainerService" }, { type: "azure-native:containerservice/v20160930:ContainerService" }, { type: "azure-native:containerservice/v20170131:ContainerService" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(ContainerService.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a ContainerService resource.
 */
export interface ContainerServiceArgs {
    /**
     * Properties of agent pools
     */
    agentPoolProfiles: pulumi.Input<pulumi.Input<inputs.containerservice.v20151101preview.ContainerServiceAgentPoolProfileArgs>[]>;
    /**
     * The name of the container service within the given subscription and resource group.
     */
    containerServiceName?: pulumi.Input<string>;
    /**
     * Properties for Diagnostic Agent
     */
    diagnosticsProfile?: pulumi.Input<inputs.containerservice.v20151101preview.ContainerServiceDiagnosticsProfileArgs>;
    /**
     * Properties for Linux VMs
     */
    linuxProfile: pulumi.Input<inputs.containerservice.v20151101preview.ContainerServiceLinuxProfileArgs>;
    /**
     * Resource location
     */
    location?: pulumi.Input<string>;
    /**
     * Properties of master agents
     */
    masterProfile: pulumi.Input<inputs.containerservice.v20151101preview.ContainerServiceMasterProfileArgs>;
    /**
     * Properties of orchestrator
     */
    orchestratorProfile?: pulumi.Input<inputs.containerservice.v20151101preview.ContainerServiceOrchestratorProfileArgs>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Properties of Windows VMs
     */
    windowsProfile?: pulumi.Input<inputs.containerservice.v20151101preview.ContainerServiceWindowsProfileArgs>;
}
