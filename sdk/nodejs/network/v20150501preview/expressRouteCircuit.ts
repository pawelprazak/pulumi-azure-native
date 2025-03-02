// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * ExpressRouteCircuit resource
 *
 * @deprecated Version 2015-05-01-preview will be removed in v2 of the provider.
 */
export class ExpressRouteCircuit extends pulumi.CustomResource {
    /**
     * Get an existing ExpressRouteCircuit resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ExpressRouteCircuit {
        pulumi.log.warn("ExpressRouteCircuit is deprecated: Version 2015-05-01-preview will be removed in v2 of the provider.")
        return new ExpressRouteCircuit(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:network/v20150501preview:ExpressRouteCircuit';

    /**
     * Returns true if the given object is an instance of ExpressRouteCircuit.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ExpressRouteCircuit {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ExpressRouteCircuit.__pulumiType;
    }

    /**
     * Gets or sets list of authorizations
     */
    public readonly authorizations!: pulumi.Output<outputs.network.v20150501preview.ExpressRouteCircuitAuthorizationResponse[] | undefined>;
    /**
     * Gets or sets CircuitProvisioningState state of the resource 
     */
    public readonly circuitProvisioningState!: pulumi.Output<string | undefined>;
    /**
     * Gets a unique read-only string that changes whenever the resource is updated
     */
    public /*out*/ readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource name
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Gets or sets list of peerings
     */
    public readonly peerings!: pulumi.Output<outputs.network.v20150501preview.ExpressRouteCircuitPeeringResponse[] | undefined>;
    /**
     * Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
     */
    public readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets ServiceKey
     */
    public readonly serviceKey!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets ServiceProviderNotes
     */
    public readonly serviceProviderNotes!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets ServiceProviderProperties
     */
    public readonly serviceProviderProperties!: pulumi.Output<outputs.network.v20150501preview.ExpressRouteCircuitServiceProviderPropertiesResponse | undefined>;
    /**
     * Gets or sets ServiceProviderProvisioningState state of the resource 
     */
    public readonly serviceProviderProvisioningState!: pulumi.Output<string | undefined>;
    /**
     * Gets or sets sku
     */
    public readonly sku!: pulumi.Output<outputs.network.v20150501preview.ExpressRouteCircuitSkuResponse | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a ExpressRouteCircuit resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2015-05-01-preview will be removed in v2 of the provider. */
    constructor(name: string, args: ExpressRouteCircuitArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("ExpressRouteCircuit is deprecated: Version 2015-05-01-preview will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.circuitName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'circuitName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["authorizations"] = args ? args.authorizations : undefined;
            resourceInputs["circuitName"] = args ? args.circuitName : undefined;
            resourceInputs["circuitProvisioningState"] = args ? args.circuitProvisioningState : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["peerings"] = args ? args.peerings : undefined;
            resourceInputs["provisioningState"] = args ? args.provisioningState : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["serviceKey"] = args ? args.serviceKey : undefined;
            resourceInputs["serviceProviderNotes"] = args ? args.serviceProviderNotes : undefined;
            resourceInputs["serviceProviderProperties"] = args ? args.serviceProviderProperties : undefined;
            resourceInputs["serviceProviderProvisioningState"] = args ? args.serviceProviderProvisioningState : undefined;
            resourceInputs["sku"] = args ? args.sku : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["authorizations"] = undefined /*out*/;
            resourceInputs["circuitProvisioningState"] = undefined /*out*/;
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["peerings"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["serviceKey"] = undefined /*out*/;
            resourceInputs["serviceProviderNotes"] = undefined /*out*/;
            resourceInputs["serviceProviderProperties"] = undefined /*out*/;
            resourceInputs["serviceProviderProvisioningState"] = undefined /*out*/;
            resourceInputs["sku"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:network:ExpressRouteCircuit" }, { type: "azure-native:network/v20150615:ExpressRouteCircuit" }, { type: "azure-native:network/v20160330:ExpressRouteCircuit" }, { type: "azure-native:network/v20160601:ExpressRouteCircuit" }, { type: "azure-native:network/v20160901:ExpressRouteCircuit" }, { type: "azure-native:network/v20161201:ExpressRouteCircuit" }, { type: "azure-native:network/v20170301:ExpressRouteCircuit" }, { type: "azure-native:network/v20170601:ExpressRouteCircuit" }, { type: "azure-native:network/v20170801:ExpressRouteCircuit" }, { type: "azure-native:network/v20170901:ExpressRouteCircuit" }, { type: "azure-native:network/v20171001:ExpressRouteCircuit" }, { type: "azure-native:network/v20171101:ExpressRouteCircuit" }, { type: "azure-native:network/v20180101:ExpressRouteCircuit" }, { type: "azure-native:network/v20180201:ExpressRouteCircuit" }, { type: "azure-native:network/v20180401:ExpressRouteCircuit" }, { type: "azure-native:network/v20180601:ExpressRouteCircuit" }, { type: "azure-native:network/v20180701:ExpressRouteCircuit" }, { type: "azure-native:network/v20180801:ExpressRouteCircuit" }, { type: "azure-native:network/v20181001:ExpressRouteCircuit" }, { type: "azure-native:network/v20181101:ExpressRouteCircuit" }, { type: "azure-native:network/v20181201:ExpressRouteCircuit" }, { type: "azure-native:network/v20190201:ExpressRouteCircuit" }, { type: "azure-native:network/v20190401:ExpressRouteCircuit" }, { type: "azure-native:network/v20190601:ExpressRouteCircuit" }, { type: "azure-native:network/v20190701:ExpressRouteCircuit" }, { type: "azure-native:network/v20190801:ExpressRouteCircuit" }, { type: "azure-native:network/v20190901:ExpressRouteCircuit" }, { type: "azure-native:network/v20191101:ExpressRouteCircuit" }, { type: "azure-native:network/v20191201:ExpressRouteCircuit" }, { type: "azure-native:network/v20200301:ExpressRouteCircuit" }, { type: "azure-native:network/v20200401:ExpressRouteCircuit" }, { type: "azure-native:network/v20200501:ExpressRouteCircuit" }, { type: "azure-native:network/v20200601:ExpressRouteCircuit" }, { type: "azure-native:network/v20200701:ExpressRouteCircuit" }, { type: "azure-native:network/v20200801:ExpressRouteCircuit" }, { type: "azure-native:network/v20201101:ExpressRouteCircuit" }, { type: "azure-native:network/v20210201:ExpressRouteCircuit" }, { type: "azure-native:network/v20210301:ExpressRouteCircuit" }, { type: "azure-native:network/v20210501:ExpressRouteCircuit" }, { type: "azure-native:network/v20210801:ExpressRouteCircuit" }, { type: "azure-native:network/v20220101:ExpressRouteCircuit" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(ExpressRouteCircuit.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a ExpressRouteCircuit resource.
 */
export interface ExpressRouteCircuitArgs {
    /**
     * Gets or sets list of authorizations
     */
    authorizations?: pulumi.Input<pulumi.Input<inputs.network.v20150501preview.ExpressRouteCircuitAuthorizationArgs>[]>;
    /**
     * The name of the circuit.
     */
    circuitName: pulumi.Input<string>;
    /**
     * Gets or sets CircuitProvisioningState state of the resource 
     */
    circuitProvisioningState?: pulumi.Input<string>;
    /**
     * Resource location
     */
    location?: pulumi.Input<string>;
    /**
     * Gets or sets list of peerings
     */
    peerings?: pulumi.Input<pulumi.Input<inputs.network.v20150501preview.ExpressRouteCircuitPeeringArgs>[]>;
    /**
     * Gets or sets Provisioning state of the PublicIP resource Updating/Deleting/Failed
     */
    provisioningState?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Gets or sets ServiceKey
     */
    serviceKey?: pulumi.Input<string>;
    /**
     * Gets or sets ServiceProviderNotes
     */
    serviceProviderNotes?: pulumi.Input<string>;
    /**
     * Gets or sets ServiceProviderProperties
     */
    serviceProviderProperties?: pulumi.Input<inputs.network.v20150501preview.ExpressRouteCircuitServiceProviderPropertiesArgs>;
    /**
     * Gets or sets ServiceProviderProvisioningState state of the resource 
     */
    serviceProviderProvisioningState?: pulumi.Input<string | enums.network.v20150501preview.ServiceProviderProvisioningState>;
    /**
     * Gets or sets sku
     */
    sku?: pulumi.Input<inputs.network.v20150501preview.ExpressRouteCircuitSkuArgs>;
    /**
     * Resource tags
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
