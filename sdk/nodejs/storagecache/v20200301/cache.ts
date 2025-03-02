// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A Cache instance. Follows Azure Resource Manager standards: https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/resource-api-reference.md
 *
 * @deprecated Version 2020-03-01 will be removed in v2 of the provider.
 */
export class Cache extends pulumi.CustomResource {
    /**
     * Get an existing Cache resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Cache {
        pulumi.log.warn("Cache is deprecated: Version 2020-03-01 will be removed in v2 of the provider.")
        return new Cache(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:storagecache/v20200301:Cache';

    /**
     * Returns true if the given object is an instance of Cache.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Cache {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Cache.__pulumiType;
    }

    /**
     * The size of this Cache, in GB.
     */
    public readonly cacheSizeGB!: pulumi.Output<number | undefined>;
    /**
     * Specifies encryption settings of the cache.
     */
    public readonly encryptionSettings!: pulumi.Output<outputs.storagecache.v20200301.CacheEncryptionSettingsResponse | undefined>;
    /**
     * Health of the Cache.
     */
    public /*out*/ readonly health!: pulumi.Output<outputs.storagecache.v20200301.CacheHealthResponse>;
    /**
     * The identity of the cache, if configured.
     */
    public readonly identity!: pulumi.Output<outputs.storagecache.v20200301.CacheIdentityResponse | undefined>;
    /**
     * Region name string.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Array of IP addresses that can be used by clients mounting this Cache.
     */
    public /*out*/ readonly mountAddresses!: pulumi.Output<string[]>;
    /**
     * Name of Cache.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Specifies network settings of the cache.
     */
    public readonly networkSettings!: pulumi.Output<outputs.storagecache.v20200301.CacheNetworkSettingsResponse | undefined>;
    /**
     * ARM provisioning state, see https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/Addendum.md#provisioningstate-property
     */
    public readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * Specifies security settings of the cache.
     */
    public readonly securitySettings!: pulumi.Output<outputs.storagecache.v20200301.CacheSecuritySettingsResponse | undefined>;
    /**
     * SKU for the Cache.
     */
    public readonly sku!: pulumi.Output<outputs.storagecache.v20200301.CacheResponseSku | undefined>;
    /**
     * Subnet used for the Cache.
     */
    public readonly subnet!: pulumi.Output<string | undefined>;
    /**
     * The system meta data relating to this resource.
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.storagecache.v20200301.SystemDataResponse>;
    /**
     * ARM tags as name/value pairs.
     */
    public readonly tags!: pulumi.Output<any | undefined>;
    /**
     * Type of the Cache; Microsoft.StorageCache/Cache
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Upgrade status of the Cache.
     */
    public /*out*/ readonly upgradeStatus!: pulumi.Output<outputs.storagecache.v20200301.CacheUpgradeStatusResponse | undefined>;

    /**
     * Create a Cache resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2020-03-01 will be removed in v2 of the provider. */
    constructor(name: string, args: CacheArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Cache is deprecated: Version 2020-03-01 will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["cacheName"] = args ? args.cacheName : undefined;
            resourceInputs["cacheSizeGB"] = args ? args.cacheSizeGB : undefined;
            resourceInputs["encryptionSettings"] = args ? args.encryptionSettings : undefined;
            resourceInputs["identity"] = args ? args.identity : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["networkSettings"] = args ? (args.networkSettings ? pulumi.output(args.networkSettings).apply(inputs.storagecache.v20200301.cacheNetworkSettingsArgsProvideDefaults) : undefined) : undefined;
            resourceInputs["provisioningState"] = args ? args.provisioningState : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["securitySettings"] = args ? args.securitySettings : undefined;
            resourceInputs["sku"] = args ? args.sku : undefined;
            resourceInputs["subnet"] = args ? args.subnet : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["health"] = undefined /*out*/;
            resourceInputs["mountAddresses"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["upgradeStatus"] = undefined /*out*/;
        } else {
            resourceInputs["cacheSizeGB"] = undefined /*out*/;
            resourceInputs["encryptionSettings"] = undefined /*out*/;
            resourceInputs["health"] = undefined /*out*/;
            resourceInputs["identity"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["mountAddresses"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["networkSettings"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["securitySettings"] = undefined /*out*/;
            resourceInputs["sku"] = undefined /*out*/;
            resourceInputs["subnet"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["upgradeStatus"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:storagecache:Cache" }, { type: "azure-native:storagecache/v20190801preview:Cache" }, { type: "azure-native:storagecache/v20191101:Cache" }, { type: "azure-native:storagecache/v20201001:Cache" }, { type: "azure-native:storagecache/v20210301:Cache" }, { type: "azure-native:storagecache/v20210501:Cache" }, { type: "azure-native:storagecache/v20210901:Cache" }, { type: "azure-native:storagecache/v20220101:Cache" }, { type: "azure-native:storagecache/v20220501:Cache" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(Cache.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Cache resource.
 */
export interface CacheArgs {
    /**
     * Name of Cache. Length of name must be not greater than 80 and chars must be in list of [-0-9a-zA-Z_] char class.
     */
    cacheName?: pulumi.Input<string>;
    /**
     * The size of this Cache, in GB.
     */
    cacheSizeGB?: pulumi.Input<number>;
    /**
     * Specifies encryption settings of the cache.
     */
    encryptionSettings?: pulumi.Input<inputs.storagecache.v20200301.CacheEncryptionSettingsArgs>;
    /**
     * The identity of the cache, if configured.
     */
    identity?: pulumi.Input<inputs.storagecache.v20200301.CacheIdentityArgs>;
    /**
     * Region name string.
     */
    location?: pulumi.Input<string>;
    /**
     * Specifies network settings of the cache.
     */
    networkSettings?: pulumi.Input<inputs.storagecache.v20200301.CacheNetworkSettingsArgs>;
    /**
     * ARM provisioning state, see https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/Addendum.md#provisioningstate-property
     */
    provisioningState?: pulumi.Input<string | enums.storagecache.v20200301.ProvisioningStateType>;
    /**
     * Target resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Specifies security settings of the cache.
     */
    securitySettings?: pulumi.Input<inputs.storagecache.v20200301.CacheSecuritySettingsArgs>;
    /**
     * SKU for the Cache.
     */
    sku?: pulumi.Input<inputs.storagecache.v20200301.CacheSkuArgs>;
    /**
     * Subnet used for the Cache.
     */
    subnet?: pulumi.Input<string>;
    /**
     * ARM tags as name/value pairs.
     */
    tags?: any;
}
