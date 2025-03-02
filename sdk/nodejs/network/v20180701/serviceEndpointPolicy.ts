// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Service End point policy resource.
 */
export class ServiceEndpointPolicy extends pulumi.CustomResource {
    /**
     * Get an existing ServiceEndpointPolicy resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ServiceEndpointPolicy {
        return new ServiceEndpointPolicy(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:network/v20180701:ServiceEndpointPolicy';

    /**
     * Returns true if the given object is an instance of ServiceEndpointPolicy.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ServiceEndpointPolicy {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ServiceEndpointPolicy.__pulumiType;
    }

    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The provisioning state of the service endpoint policy. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    public readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * The resource GUID property of the service endpoint policy resource.
     */
    public readonly resourceGuid!: pulumi.Output<string | undefined>;
    /**
     * A collection of service endpoint policy definitions of the service endpoint policy.
     */
    public readonly serviceEndpointPolicyDefinitions!: pulumi.Output<outputs.network.v20180701.ServiceEndpointPolicyDefinitionResponse[] | undefined>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a ServiceEndpointPolicy resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServiceEndpointPolicyArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["id"] = args ? args.id : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["provisioningState"] = args ? args.provisioningState : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["resourceGuid"] = args ? args.resourceGuid : undefined;
            resourceInputs["serviceEndpointPolicyDefinitions"] = args ? args.serviceEndpointPolicyDefinitions : undefined;
            resourceInputs["serviceEndpointPolicyName"] = args ? args.serviceEndpointPolicyName : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["resourceGuid"] = undefined /*out*/;
            resourceInputs["serviceEndpointPolicyDefinitions"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:network:ServiceEndpointPolicy" }, { type: "azure-native:network/v20180801:ServiceEndpointPolicy" }, { type: "azure-native:network/v20181001:ServiceEndpointPolicy" }, { type: "azure-native:network/v20181101:ServiceEndpointPolicy" }, { type: "azure-native:network/v20181201:ServiceEndpointPolicy" }, { type: "azure-native:network/v20190201:ServiceEndpointPolicy" }, { type: "azure-native:network/v20190401:ServiceEndpointPolicy" }, { type: "azure-native:network/v20190601:ServiceEndpointPolicy" }, { type: "azure-native:network/v20190701:ServiceEndpointPolicy" }, { type: "azure-native:network/v20190801:ServiceEndpointPolicy" }, { type: "azure-native:network/v20190901:ServiceEndpointPolicy" }, { type: "azure-native:network/v20191101:ServiceEndpointPolicy" }, { type: "azure-native:network/v20191201:ServiceEndpointPolicy" }, { type: "azure-native:network/v20200301:ServiceEndpointPolicy" }, { type: "azure-native:network/v20200401:ServiceEndpointPolicy" }, { type: "azure-native:network/v20200501:ServiceEndpointPolicy" }, { type: "azure-native:network/v20200601:ServiceEndpointPolicy" }, { type: "azure-native:network/v20200701:ServiceEndpointPolicy" }, { type: "azure-native:network/v20200801:ServiceEndpointPolicy" }, { type: "azure-native:network/v20201101:ServiceEndpointPolicy" }, { type: "azure-native:network/v20210201:ServiceEndpointPolicy" }, { type: "azure-native:network/v20210301:ServiceEndpointPolicy" }, { type: "azure-native:network/v20210501:ServiceEndpointPolicy" }, { type: "azure-native:network/v20210801:ServiceEndpointPolicy" }, { type: "azure-native:network/v20220101:ServiceEndpointPolicy" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(ServiceEndpointPolicy.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a ServiceEndpointPolicy resource.
 */
export interface ServiceEndpointPolicyArgs {
    /**
     * Resource ID.
     */
    id?: pulumi.Input<string>;
    /**
     * Resource location.
     */
    location?: pulumi.Input<string>;
    /**
     * The provisioning state of the service endpoint policy. Possible values are: 'Updating', 'Deleting', and 'Failed'.
     */
    provisioningState?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The resource GUID property of the service endpoint policy resource.
     */
    resourceGuid?: pulumi.Input<string>;
    /**
     * A collection of service endpoint policy definitions of the service endpoint policy.
     */
    serviceEndpointPolicyDefinitions?: pulumi.Input<pulumi.Input<inputs.network.v20180701.ServiceEndpointPolicyDefinitionArgs>[]>;
    /**
     * The name of the service endpoint policy.
     */
    serviceEndpointPolicyName?: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
