// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * An environment for hosting container apps
 */
export class ManagedEnvironment extends pulumi.CustomResource {
    /**
     * Get an existing ManagedEnvironment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ManagedEnvironment {
        return new ManagedEnvironment(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:app/v20220301:ManagedEnvironment';

    /**
     * Returns true if the given object is an instance of ManagedEnvironment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ManagedEnvironment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ManagedEnvironment.__pulumiType;
    }

    /**
     * Cluster configuration which enables the log daemon to export
     * app logs to a destination. Currently only "log-analytics" is
     * supported
     */
    public readonly appLogsConfiguration!: pulumi.Output<outputs.app.v20220301.AppLogsConfigurationResponse | undefined>;
    /**
     * Application Insights connection string used by Dapr to export Service to Service communication telemetry
     */
    public readonly daprAIConnectionString!: pulumi.Output<string | undefined>;
    /**
     * Azure Monitor instrumentation key used by Dapr to export Service to Service communication telemetry
     */
    public readonly daprAIInstrumentationKey!: pulumi.Output<string | undefined>;
    /**
     * Default Domain Name for the cluster
     */
    public /*out*/ readonly defaultDomain!: pulumi.Output<string>;
    /**
     * Any errors that occurred during deployment or deployment validation
     */
    public /*out*/ readonly deploymentErrors!: pulumi.Output<string>;
    /**
     * The geo-location where the resource lives
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Provisioning state of the Environment.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Static IP of the Environment
     */
    public /*out*/ readonly staticIp!: pulumi.Output<string>;
    /**
     * Azure Resource Manager metadata containing createdBy and modifiedBy information.
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.app.v20220301.SystemDataResponse>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Vnet configuration for the environment
     */
    public readonly vnetConfiguration!: pulumi.Output<outputs.app.v20220301.VnetConfigurationResponse | undefined>;
    /**
     * Whether or not this Managed Environment is zone-redundant.
     */
    public readonly zoneRedundant!: pulumi.Output<boolean | undefined>;

    /**
     * Create a ManagedEnvironment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ManagedEnvironmentArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["appLogsConfiguration"] = args ? args.appLogsConfiguration : undefined;
            resourceInputs["daprAIConnectionString"] = args ? args.daprAIConnectionString : undefined;
            resourceInputs["daprAIInstrumentationKey"] = args ? args.daprAIInstrumentationKey : undefined;
            resourceInputs["environmentName"] = args ? args.environmentName : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["vnetConfiguration"] = args ? args.vnetConfiguration : undefined;
            resourceInputs["zoneRedundant"] = args ? args.zoneRedundant : undefined;
            resourceInputs["defaultDomain"] = undefined /*out*/;
            resourceInputs["deploymentErrors"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["staticIp"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["appLogsConfiguration"] = undefined /*out*/;
            resourceInputs["daprAIConnectionString"] = undefined /*out*/;
            resourceInputs["daprAIInstrumentationKey"] = undefined /*out*/;
            resourceInputs["defaultDomain"] = undefined /*out*/;
            resourceInputs["deploymentErrors"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["staticIp"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["vnetConfiguration"] = undefined /*out*/;
            resourceInputs["zoneRedundant"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:app:ManagedEnvironment" }, { type: "azure-native:app/v20220101preview:ManagedEnvironment" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(ManagedEnvironment.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a ManagedEnvironment resource.
 */
export interface ManagedEnvironmentArgs {
    /**
     * Cluster configuration which enables the log daemon to export
     * app logs to a destination. Currently only "log-analytics" is
     * supported
     */
    appLogsConfiguration?: pulumi.Input<inputs.app.v20220301.AppLogsConfigurationArgs>;
    /**
     * Application Insights connection string used by Dapr to export Service to Service communication telemetry
     */
    daprAIConnectionString?: pulumi.Input<string>;
    /**
     * Azure Monitor instrumentation key used by Dapr to export Service to Service communication telemetry
     */
    daprAIInstrumentationKey?: pulumi.Input<string>;
    /**
     * Name of the Environment.
     */
    environmentName?: pulumi.Input<string>;
    /**
     * The geo-location where the resource lives
     */
    location?: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Vnet configuration for the environment
     */
    vnetConfiguration?: pulumi.Input<inputs.app.v20220301.VnetConfigurationArgs>;
    /**
     * Whether or not this Managed Environment is zone-redundant.
     */
    zoneRedundant?: pulumi.Input<boolean>;
}
