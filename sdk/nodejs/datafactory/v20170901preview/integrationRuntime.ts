// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Integration runtime resource type.
 *
 * @deprecated Version 2017-09-01-preview will be removed in v2 of the provider.
 */
export class IntegrationRuntime extends pulumi.CustomResource {
    /**
     * Get an existing IntegrationRuntime resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): IntegrationRuntime {
        pulumi.log.warn("IntegrationRuntime is deprecated: Version 2017-09-01-preview will be removed in v2 of the provider.")
        return new IntegrationRuntime(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:datafactory/v20170901preview:IntegrationRuntime';

    /**
     * Returns true if the given object is an instance of IntegrationRuntime.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is IntegrationRuntime {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IntegrationRuntime.__pulumiType;
    }

    /**
     * Etag identifies change in the resource.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * The resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Integration runtime properties.
     */
    public readonly properties!: pulumi.Output<outputs.datafactory.v20170901preview.ManagedIntegrationRuntimeResponse | outputs.datafactory.v20170901preview.SelfHostedIntegrationRuntimeResponse>;
    /**
     * The resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a IntegrationRuntime resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2017-09-01-preview will be removed in v2 of the provider. */
    constructor(name: string, args: IntegrationRuntimeArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("IntegrationRuntime is deprecated: Version 2017-09-01-preview will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.factoryName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'factoryName'");
            }
            if ((!args || args.properties === undefined) && !opts.urn) {
                throw new Error("Missing required property 'properties'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["factoryName"] = args ? args.factoryName : undefined;
            resourceInputs["integrationRuntimeName"] = args ? args.integrationRuntimeName : undefined;
            resourceInputs["properties"] = args ? args.properties : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["properties"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:datafactory:IntegrationRuntime" }, { type: "azure-native:datafactory/v20180601:IntegrationRuntime" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(IntegrationRuntime.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a IntegrationRuntime resource.
 */
export interface IntegrationRuntimeArgs {
    /**
     * The factory name.
     */
    factoryName: pulumi.Input<string>;
    /**
     * The integration runtime name.
     */
    integrationRuntimeName?: pulumi.Input<string>;
    /**
     * Integration runtime properties.
     */
    properties: pulumi.Input<inputs.datafactory.v20170901preview.ManagedIntegrationRuntimeArgs | inputs.datafactory.v20170901preview.SelfHostedIntegrationRuntimeArgs>;
    /**
     * The resource group name.
     */
    resourceGroupName: pulumi.Input<string>;
}
