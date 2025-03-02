// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The configuration store along with all resource properties. The Configuration Store will have all information to begin utilizing it.
 *
 * @deprecated Version 2019-11-01-preview will be removed in v2 of the provider.
 */
export class ConfigurationStore extends pulumi.CustomResource {
    /**
     * Get an existing ConfigurationStore resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ConfigurationStore {
        pulumi.log.warn("ConfigurationStore is deprecated: Version 2019-11-01-preview will be removed in v2 of the provider.")
        return new ConfigurationStore(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:appconfiguration/v20191101preview:ConfigurationStore';

    /**
     * Returns true if the given object is an instance of ConfigurationStore.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ConfigurationStore {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ConfigurationStore.__pulumiType;
    }

    /**
     * The creation date of configuration store.
     */
    public /*out*/ readonly creationDate!: pulumi.Output<string>;
    /**
     * The encryption settings of the configuration store.
     */
    public readonly encryption!: pulumi.Output<outputs.appconfiguration.v20191101preview.EncryptionPropertiesResponse | undefined>;
    /**
     * The DNS endpoint where the configuration store API will be available.
     */
    public /*out*/ readonly endpoint!: pulumi.Output<string>;
    /**
     * The managed identity information, if configured.
     */
    public readonly identity!: pulumi.Output<outputs.appconfiguration.v20191101preview.ResourceIdentityResponse | undefined>;
    /**
     * The location of the resource. This cannot be changed after the resource is created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The list of private endpoint connections that are set up for this resource.
     */
    public /*out*/ readonly privateEndpointConnections!: pulumi.Output<outputs.appconfiguration.v20191101preview.PrivateEndpointConnectionReferenceResponse[]>;
    /**
     * The provisioning state of the configuration store.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Control permission for data plane traffic coming from public networks while private endpoint is enabled.
     */
    public readonly publicNetworkAccess!: pulumi.Output<string | undefined>;
    /**
     * The sku of the configuration store.
     */
    public readonly sku!: pulumi.Output<outputs.appconfiguration.v20191101preview.SkuResponse>;
    /**
     * The tags of the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a ConfigurationStore resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2019-11-01-preview will be removed in v2 of the provider. */
    constructor(name: string, args: ConfigurationStoreArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("ConfigurationStore is deprecated: Version 2019-11-01-preview will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.sku === undefined) && !opts.urn) {
                throw new Error("Missing required property 'sku'");
            }
            resourceInputs["configStoreName"] = args ? args.configStoreName : undefined;
            resourceInputs["encryption"] = args ? args.encryption : undefined;
            resourceInputs["identity"] = args ? args.identity : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["publicNetworkAccess"] = args ? args.publicNetworkAccess : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["sku"] = args ? args.sku : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["creationDate"] = undefined /*out*/;
            resourceInputs["endpoint"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["privateEndpointConnections"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["creationDate"] = undefined /*out*/;
            resourceInputs["encryption"] = undefined /*out*/;
            resourceInputs["endpoint"] = undefined /*out*/;
            resourceInputs["identity"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["privateEndpointConnections"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["publicNetworkAccess"] = undefined /*out*/;
            resourceInputs["sku"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:appconfiguration:ConfigurationStore" }, { type: "azure-native:appconfiguration/v20190201preview:ConfigurationStore" }, { type: "azure-native:appconfiguration/v20191001:ConfigurationStore" }, { type: "azure-native:appconfiguration/v20200601:ConfigurationStore" }, { type: "azure-native:appconfiguration/v20200701preview:ConfigurationStore" }, { type: "azure-native:appconfiguration/v20210301preview:ConfigurationStore" }, { type: "azure-native:appconfiguration/v20211001preview:ConfigurationStore" }, { type: "azure-native:appconfiguration/v20220501:ConfigurationStore" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(ConfigurationStore.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a ConfigurationStore resource.
 */
export interface ConfigurationStoreArgs {
    /**
     * The name of the configuration store.
     */
    configStoreName?: pulumi.Input<string>;
    /**
     * The encryption settings of the configuration store.
     */
    encryption?: pulumi.Input<inputs.appconfiguration.v20191101preview.EncryptionPropertiesArgs>;
    /**
     * The managed identity information, if configured.
     */
    identity?: pulumi.Input<inputs.appconfiguration.v20191101preview.ResourceIdentityArgs>;
    /**
     * The location of the resource. This cannot be changed after the resource is created.
     */
    location?: pulumi.Input<string>;
    /**
     * Control permission for data plane traffic coming from public networks while private endpoint is enabled.
     */
    publicNetworkAccess?: pulumi.Input<string | enums.appconfiguration.v20191101preview.PublicNetworkAccess>;
    /**
     * The name of the resource group to which the container registry belongs.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The sku of the configuration store.
     */
    sku: pulumi.Input<inputs.appconfiguration.v20191101preview.SkuArgs>;
    /**
     * The tags of the resource.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
