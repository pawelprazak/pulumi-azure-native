// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Azure Firewall resource.
 */
export class AzureFirewall extends pulumi.CustomResource {
    /**
     * Get an existing AzureFirewall resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): AzureFirewall {
        return new AzureFirewall(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:network/v20190801:AzureFirewall';

    /**
     * Returns true if the given object is an instance of AzureFirewall.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AzureFirewall {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AzureFirewall.__pulumiType;
    }

    /**
     * Collection of application rule collections used by Azure Firewall.
     */
    public readonly applicationRuleCollections!: pulumi.Output<outputs.network.v20190801.AzureFirewallApplicationRuleCollectionResponse[] | undefined>;
    /**
     * A unique read-only string that changes whenever the resource is updated.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * The firewallPolicy associated with this azure firewall.
     */
    public readonly firewallPolicy!: pulumi.Output<outputs.network.v20190801.SubResourceResponse | undefined>;
    /**
     * IP addresses associated with AzureFirewall.
     */
    public /*out*/ readonly hubIpAddresses!: pulumi.Output<outputs.network.v20190801.HubIPAddressesResponse>;
    /**
     * IP configuration of the Azure Firewall resource.
     */
    public readonly ipConfigurations!: pulumi.Output<outputs.network.v20190801.AzureFirewallIPConfigurationResponse[] | undefined>;
    /**
     * Resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Collection of NAT rule collections used by Azure Firewall.
     */
    public readonly natRuleCollections!: pulumi.Output<outputs.network.v20190801.AzureFirewallNatRuleCollectionResponse[] | undefined>;
    /**
     * Collection of network rule collections used by Azure Firewall.
     */
    public readonly networkRuleCollections!: pulumi.Output<outputs.network.v20190801.AzureFirewallNetworkRuleCollectionResponse[] | undefined>;
    /**
     * The provisioning state of the Azure firewall resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The Azure Firewall Resource SKU.
     */
    public readonly sku!: pulumi.Output<outputs.network.v20190801.AzureFirewallSkuResponse | undefined>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The operation mode for Threat Intelligence.
     */
    public readonly threatIntelMode!: pulumi.Output<string | undefined>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The virtualHub to which the firewall belongs.
     */
    public readonly virtualHub!: pulumi.Output<outputs.network.v20190801.SubResourceResponse | undefined>;
    /**
     * A list of availability zones denoting where the resource needs to come from.
     */
    public readonly zones!: pulumi.Output<string[] | undefined>;

    /**
     * Create a AzureFirewall resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AzureFirewallArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["applicationRuleCollections"] = args ? args.applicationRuleCollections : undefined;
            resourceInputs["azureFirewallName"] = args ? args.azureFirewallName : undefined;
            resourceInputs["firewallPolicy"] = args ? args.firewallPolicy : undefined;
            resourceInputs["id"] = args ? args.id : undefined;
            resourceInputs["ipConfigurations"] = args ? args.ipConfigurations : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["natRuleCollections"] = args ? args.natRuleCollections : undefined;
            resourceInputs["networkRuleCollections"] = args ? args.networkRuleCollections : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["sku"] = args ? args.sku : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["threatIntelMode"] = args ? args.threatIntelMode : undefined;
            resourceInputs["virtualHub"] = args ? args.virtualHub : undefined;
            resourceInputs["zones"] = args ? args.zones : undefined;
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["hubIpAddresses"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["applicationRuleCollections"] = undefined /*out*/;
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["firewallPolicy"] = undefined /*out*/;
            resourceInputs["hubIpAddresses"] = undefined /*out*/;
            resourceInputs["ipConfigurations"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["natRuleCollections"] = undefined /*out*/;
            resourceInputs["networkRuleCollections"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["sku"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["threatIntelMode"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["virtualHub"] = undefined /*out*/;
            resourceInputs["zones"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:network:AzureFirewall" }, { type: "azure-native:network/v20180401:AzureFirewall" }, { type: "azure-native:network/v20180601:AzureFirewall" }, { type: "azure-native:network/v20180701:AzureFirewall" }, { type: "azure-native:network/v20180801:AzureFirewall" }, { type: "azure-native:network/v20181001:AzureFirewall" }, { type: "azure-native:network/v20181101:AzureFirewall" }, { type: "azure-native:network/v20181201:AzureFirewall" }, { type: "azure-native:network/v20190201:AzureFirewall" }, { type: "azure-native:network/v20190401:AzureFirewall" }, { type: "azure-native:network/v20190601:AzureFirewall" }, { type: "azure-native:network/v20190701:AzureFirewall" }, { type: "azure-native:network/v20190901:AzureFirewall" }, { type: "azure-native:network/v20191101:AzureFirewall" }, { type: "azure-native:network/v20191201:AzureFirewall" }, { type: "azure-native:network/v20200301:AzureFirewall" }, { type: "azure-native:network/v20200401:AzureFirewall" }, { type: "azure-native:network/v20200501:AzureFirewall" }, { type: "azure-native:network/v20200601:AzureFirewall" }, { type: "azure-native:network/v20200701:AzureFirewall" }, { type: "azure-native:network/v20200801:AzureFirewall" }, { type: "azure-native:network/v20201101:AzureFirewall" }, { type: "azure-native:network/v20210201:AzureFirewall" }, { type: "azure-native:network/v20210301:AzureFirewall" }, { type: "azure-native:network/v20210501:AzureFirewall" }, { type: "azure-native:network/v20210801:AzureFirewall" }, { type: "azure-native:network/v20220101:AzureFirewall" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(AzureFirewall.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a AzureFirewall resource.
 */
export interface AzureFirewallArgs {
    /**
     * Collection of application rule collections used by Azure Firewall.
     */
    applicationRuleCollections?: pulumi.Input<pulumi.Input<inputs.network.v20190801.AzureFirewallApplicationRuleCollectionArgs>[]>;
    /**
     * The name of the Azure Firewall.
     */
    azureFirewallName?: pulumi.Input<string>;
    /**
     * The firewallPolicy associated with this azure firewall.
     */
    firewallPolicy?: pulumi.Input<inputs.network.v20190801.SubResourceArgs>;
    /**
     * Resource ID.
     */
    id?: pulumi.Input<string>;
    /**
     * IP configuration of the Azure Firewall resource.
     */
    ipConfigurations?: pulumi.Input<pulumi.Input<inputs.network.v20190801.AzureFirewallIPConfigurationArgs>[]>;
    /**
     * Resource location.
     */
    location?: pulumi.Input<string>;
    /**
     * Collection of NAT rule collections used by Azure Firewall.
     */
    natRuleCollections?: pulumi.Input<pulumi.Input<inputs.network.v20190801.AzureFirewallNatRuleCollectionArgs>[]>;
    /**
     * Collection of network rule collections used by Azure Firewall.
     */
    networkRuleCollections?: pulumi.Input<pulumi.Input<inputs.network.v20190801.AzureFirewallNetworkRuleCollectionArgs>[]>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The Azure Firewall Resource SKU.
     */
    sku?: pulumi.Input<inputs.network.v20190801.AzureFirewallSkuArgs>;
    /**
     * Resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The operation mode for Threat Intelligence.
     */
    threatIntelMode?: pulumi.Input<string | enums.network.v20190801.AzureFirewallThreatIntelMode>;
    /**
     * The virtualHub to which the firewall belongs.
     */
    virtualHub?: pulumi.Input<inputs.network.v20190801.SubResourceArgs>;
    /**
     * A list of availability zones denoting where the resource needs to come from.
     */
    zones?: pulumi.Input<pulumi.Input<string>[]>;
}
