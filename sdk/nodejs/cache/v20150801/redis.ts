// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A Redis item in CreateOrUpdate Operation response.
 *
 * @deprecated Version 2015-08-01 will be removed in v2 of the provider.
 */
export class Redis extends pulumi.CustomResource {
    /**
     * Get an existing Redis resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Redis {
        pulumi.log.warn("Redis is deprecated: Version 2015-08-01 will be removed in v2 of the provider.")
        return new Redis(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:cache/v20150801:Redis';

    /**
     * Returns true if the given object is an instance of Redis.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Redis {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Redis.__pulumiType;
    }

    /**
     * Redis cache access keys.
     */
    public /*out*/ readonly accessKeys!: pulumi.Output<outputs.cache.v20150801.RedisAccessKeysResponse | undefined>;
    /**
     * If the value is true, then the non-SLL Redis server port (6379) will be enabled.
     */
    public readonly enableNonSslPort!: pulumi.Output<boolean | undefined>;
    /**
     * Redis host name.
     */
    public /*out*/ readonly hostName!: pulumi.Output<string | undefined>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource name.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Redis non-SSL port.
     */
    public /*out*/ readonly port!: pulumi.Output<number | undefined>;
    /**
     * Redis instance provisioning status.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string | undefined>;
    /**
     * All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc.
     */
    public readonly redisConfiguration!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * RedisVersion parameter has been deprecated. As such, it is no longer necessary to provide this parameter and any value specified is ignored.
     */
    public readonly redisVersion!: pulumi.Output<string | undefined>;
    /**
     * The number of shards to be created on a Premium Cluster Cache.
     */
    public readonly shardCount!: pulumi.Output<number | undefined>;
    /**
     * What SKU of Redis cache to deploy.
     */
    public readonly sku!: pulumi.Output<outputs.cache.v20150801.SkuResponse>;
    /**
     * Redis SSL port.
     */
    public /*out*/ readonly sslPort!: pulumi.Output<number | undefined>;
    /**
     * Required when deploying a Redis cache inside an existing Azure Virtual Network.
     */
    public readonly staticIP!: pulumi.Output<string | undefined>;
    /**
     * Required when deploying a Redis cache inside an existing Azure Virtual Network.
     */
    public readonly subnet!: pulumi.Output<string | undefined>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * tenantSettings
     */
    public readonly tenantSettings!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The exact ARM resource ID of the virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.ClassicNetwork/VirtualNetworks/vnet1
     */
    public readonly virtualNetwork!: pulumi.Output<string | undefined>;

    /**
     * Create a Redis resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2015-08-01 will be removed in v2 of the provider. */
    constructor(name: string, args: RedisArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Redis is deprecated: Version 2015-08-01 will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.sku === undefined) && !opts.urn) {
                throw new Error("Missing required property 'sku'");
            }
            resourceInputs["enableNonSslPort"] = args ? args.enableNonSslPort : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["redisConfiguration"] = args ? args.redisConfiguration : undefined;
            resourceInputs["redisVersion"] = args ? args.redisVersion : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["shardCount"] = args ? args.shardCount : undefined;
            resourceInputs["sku"] = args ? args.sku : undefined;
            resourceInputs["staticIP"] = args ? args.staticIP : undefined;
            resourceInputs["subnet"] = args ? args.subnet : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["tenantSettings"] = args ? args.tenantSettings : undefined;
            resourceInputs["virtualNetwork"] = args ? args.virtualNetwork : undefined;
            resourceInputs["accessKeys"] = undefined /*out*/;
            resourceInputs["hostName"] = undefined /*out*/;
            resourceInputs["port"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["sslPort"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["accessKeys"] = undefined /*out*/;
            resourceInputs["enableNonSslPort"] = undefined /*out*/;
            resourceInputs["hostName"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["port"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["redisConfiguration"] = undefined /*out*/;
            resourceInputs["redisVersion"] = undefined /*out*/;
            resourceInputs["shardCount"] = undefined /*out*/;
            resourceInputs["sku"] = undefined /*out*/;
            resourceInputs["sslPort"] = undefined /*out*/;
            resourceInputs["staticIP"] = undefined /*out*/;
            resourceInputs["subnet"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["tenantSettings"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["virtualNetwork"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:cache:Redis" }, { type: "azure-native:cache/v20160401:Redis" }, { type: "azure-native:cache/v20170201:Redis" }, { type: "azure-native:cache/v20171001:Redis" }, { type: "azure-native:cache/v20180301:Redis" }, { type: "azure-native:cache/v20190701:Redis" }, { type: "azure-native:cache/v20200601:Redis" }, { type: "azure-native:cache/v20201201:Redis" }, { type: "azure-native:cache/v20210601:Redis" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(Redis.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Redis resource.
 */
export interface RedisArgs {
    /**
     * If the value is true, then the non-SLL Redis server port (6379) will be enabled.
     */
    enableNonSslPort?: pulumi.Input<boolean>;
    /**
     * Resource location.
     */
    location?: pulumi.Input<string>;
    /**
     * The name of the Redis cache.
     */
    name?: pulumi.Input<string>;
    /**
     * All Redis Settings. Few possible keys: rdb-backup-enabled,rdb-storage-connection-string,rdb-backup-frequency,maxmemory-delta,maxmemory-policy,notify-keyspace-events,maxmemory-samples,slowlog-log-slower-than,slowlog-max-len,list-max-ziplist-entries,list-max-ziplist-value,hash-max-ziplist-entries,hash-max-ziplist-value,set-max-intset-entries,zset-max-ziplist-entries,zset-max-ziplist-value etc.
     */
    redisConfiguration?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * RedisVersion parameter has been deprecated. As such, it is no longer necessary to provide this parameter and any value specified is ignored.
     */
    redisVersion?: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The number of shards to be created on a Premium Cluster Cache.
     */
    shardCount?: pulumi.Input<number>;
    /**
     * What SKU of Redis cache to deploy.
     */
    sku: pulumi.Input<inputs.cache.v20150801.SkuArgs>;
    /**
     * Required when deploying a Redis cache inside an existing Azure Virtual Network.
     */
    staticIP?: pulumi.Input<string>;
    /**
     * Required when deploying a Redis cache inside an existing Azure Virtual Network.
     */
    subnet?: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * tenantSettings
     */
    tenantSettings?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The exact ARM resource ID of the virtual network to deploy the Redis cache in. Example format: /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/Microsoft.ClassicNetwork/VirtualNetworks/vnet1
     */
    virtualNetwork?: pulumi.Input<string>;
}
