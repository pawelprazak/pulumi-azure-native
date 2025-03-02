// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * An ADP Data Pool.
 *
 * @deprecated Version 2020-07-01-preview will be removed in v2 of the provider.
 */
export class DataPool extends pulumi.CustomResource {
    /**
     * Get an existing DataPool resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): DataPool {
        pulumi.log.warn("DataPool is deprecated: Version 2020-07-01-preview will be removed in v2 of the provider.")
        return new DataPool(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:autonomousdevelopmentplatform/v20200701preview:DataPool';

    /**
     * Returns true if the given object is an instance of DataPool.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DataPool {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DataPool.__pulumiType;
    }

    /**
     * The Data Pool's data-plane ID
     */
    public /*out*/ readonly dataPoolId!: pulumi.Output<string>;
    /**
     * Gets or sets the collection of locations where Data Pool resources should be created.
     */
    public readonly locations!: pulumi.Output<outputs.autonomousdevelopmentplatform.v20200701preview.DataPoolLocationResponse[]>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Gets the status of the data pool at the time the operation was called.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The system meta data relating to this resource.
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.autonomousdevelopmentplatform.v20200701preview.SystemDataResponse>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a DataPool resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2020-07-01-preview will be removed in v2 of the provider. */
    constructor(name: string, args: DataPoolArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("DataPool is deprecated: Version 2020-07-01-preview will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.accountName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'accountName'");
            }
            if ((!args || args.locations === undefined) && !opts.urn) {
                throw new Error("Missing required property 'locations'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["accountName"] = args ? args.accountName : undefined;
            resourceInputs["dataPoolName"] = args ? args.dataPoolName : undefined;
            resourceInputs["locations"] = args ? args.locations : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["dataPoolId"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["dataPoolId"] = undefined /*out*/;
            resourceInputs["locations"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:autonomousdevelopmentplatform:DataPool" }, { type: "azure-native:autonomousdevelopmentplatform/v20210201preview:DataPool" }, { type: "azure-native:autonomousdevelopmentplatform/v20211101preview:DataPool" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(DataPool.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a DataPool resource.
 */
export interface DataPoolArgs {
    /**
     * The name of the ADP account.
     */
    accountName: pulumi.Input<string>;
    /**
     * The name of the Data Pool.
     */
    dataPoolName?: pulumi.Input<string>;
    /**
     * Gets or sets the collection of locations where Data Pool resources should be created.
     */
    locations: pulumi.Input<pulumi.Input<inputs.autonomousdevelopmentplatform.v20200701preview.DataPoolLocationArgs>[]>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
