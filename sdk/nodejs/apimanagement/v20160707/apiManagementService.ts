// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Description of an API Management service resource.
 *
 * @deprecated Version 2016-07-07 will be removed in v2 of the provider.
 */
export class ApiManagementService extends pulumi.CustomResource {
    /**
     * Get an existing ApiManagementService resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): ApiManagementService {
        pulumi.log.warn("ApiManagementService is deprecated: Version 2016-07-07 will be removed in v2 of the provider.")
        return new ApiManagementService(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:apimanagement/v20160707:ApiManagementService';

    /**
     * Returns true if the given object is an instance of ApiManagementService.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ApiManagementService {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ApiManagementService.__pulumiType;
    }

    /**
     * Additional datacenter locations of the API Management service.
     */
    public readonly additionalLocations!: pulumi.Output<outputs.apimanagement.v20160707.AdditionalRegionResponse[] | undefined>;
    /**
     * Addresser email.
     */
    public readonly addresserEmail!: pulumi.Output<string | undefined>;
    /**
     * Creation UTC date of the API Management service.The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
     */
    public /*out*/ readonly createdAtUtc!: pulumi.Output<string>;
    /**
     * Custom properties of the API Management service, like disabling TLS 1.0.
     */
    public readonly customProperties!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * ETag of the resource.
     */
    public /*out*/ readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Custom hostname configuration of the API Management service.
     */
    public readonly hostnameConfigurations!: pulumi.Output<outputs.apimanagement.v20160707.HostnameConfigurationResponse[] | undefined>;
    /**
     * Datacenter location of the API Management service.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Management API endpoint URL of the API Management service.
     */
    public /*out*/ readonly managementApiUrl!: pulumi.Output<string>;
    /**
     * Name of the API Management service.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Publisher portal endpoint Url of the API Management service.
     */
    public /*out*/ readonly portalUrl!: pulumi.Output<string>;
    /**
     * The current provisioning state of the API Management service which can be one of the following: Created/Activating/Succeeded/Updating/Failed/Stopped/Terminating/TerminationFailed/Deleted.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Publisher email.
     */
    public readonly publisherEmail!: pulumi.Output<string>;
    /**
     * Publisher name.
     */
    public readonly publisherName!: pulumi.Output<string>;
    /**
     * Proxy endpoint URL of the API Management service.
     */
    public /*out*/ readonly runtimeUrl!: pulumi.Output<string>;
    /**
     * SCM endpoint URL of the API Management service.
     */
    public /*out*/ readonly scmUrl!: pulumi.Output<string>;
    /**
     * SKU properties of the API Management service.
     */
    public readonly sku!: pulumi.Output<outputs.apimanagement.v20160707.ApiManagementServiceSkuPropertiesResponse>;
    /**
     * Static IP addresses of the API Management service virtual machines. Available only for Standard and Premium SKU.
     */
    public /*out*/ readonly staticIPs!: pulumi.Output<string[]>;
    /**
     * API Management service tags. A maximum of 10 tags can be provided for a resource, and each tag must have a key no greater than 128 characters (and a value no greater than 256 characters).
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The provisioning state of the API Management service, which is targeted by the long running operation started on the service.
     */
    public /*out*/ readonly targetProvisioningState!: pulumi.Output<string>;
    /**
     * Resource type of the API Management service.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The type of VPN in which API Management service needs to be configured in. None (Default Value) means the API Management service is not part of any Virtual Network, External means the API Management deployment is set up inside a Virtual Network having an Internet Facing Endpoint, and Internal means that API Management deployment is setup inside a Virtual Network having an Intranet Facing Endpoint only.
     */
    public readonly vpnType!: pulumi.Output<string | undefined>;
    /**
     * Virtual network configuration of the API Management service.
     */
    public readonly vpnconfiguration!: pulumi.Output<outputs.apimanagement.v20160707.VirtualNetworkConfigurationResponse | undefined>;

    /**
     * Create a ApiManagementService resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2016-07-07 will be removed in v2 of the provider. */
    constructor(name: string, args: ApiManagementServiceArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("ApiManagementService is deprecated: Version 2016-07-07 will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.publisherEmail === undefined) && !opts.urn) {
                throw new Error("Missing required property 'publisherEmail'");
            }
            if ((!args || args.publisherName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'publisherName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.sku === undefined) && !opts.urn) {
                throw new Error("Missing required property 'sku'");
            }
            resourceInputs["additionalLocations"] = args ? args.additionalLocations : undefined;
            resourceInputs["addresserEmail"] = args ? args.addresserEmail : undefined;
            resourceInputs["customProperties"] = args ? args.customProperties : undefined;
            resourceInputs["hostnameConfigurations"] = args ? args.hostnameConfigurations : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["publisherEmail"] = args ? args.publisherEmail : undefined;
            resourceInputs["publisherName"] = args ? args.publisherName : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["serviceName"] = args ? args.serviceName : undefined;
            resourceInputs["sku"] = args ? (args.sku ? pulumi.output(args.sku).apply(inputs.apimanagement.v20160707.apiManagementServiceSkuPropertiesArgsProvideDefaults) : undefined) : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["vpnType"] = (args ? args.vpnType : undefined) ?? "None";
            resourceInputs["vpnconfiguration"] = args ? args.vpnconfiguration : undefined;
            resourceInputs["createdAtUtc"] = undefined /*out*/;
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["managementApiUrl"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["portalUrl"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["runtimeUrl"] = undefined /*out*/;
            resourceInputs["scmUrl"] = undefined /*out*/;
            resourceInputs["staticIPs"] = undefined /*out*/;
            resourceInputs["targetProvisioningState"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["additionalLocations"] = undefined /*out*/;
            resourceInputs["addresserEmail"] = undefined /*out*/;
            resourceInputs["createdAtUtc"] = undefined /*out*/;
            resourceInputs["customProperties"] = undefined /*out*/;
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["hostnameConfigurations"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["managementApiUrl"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["portalUrl"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["publisherEmail"] = undefined /*out*/;
            resourceInputs["publisherName"] = undefined /*out*/;
            resourceInputs["runtimeUrl"] = undefined /*out*/;
            resourceInputs["scmUrl"] = undefined /*out*/;
            resourceInputs["sku"] = undefined /*out*/;
            resourceInputs["staticIPs"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["targetProvisioningState"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["vpnType"] = undefined /*out*/;
            resourceInputs["vpnconfiguration"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:apimanagement:ApiManagementService" }, { type: "azure-native:apimanagement/v20161010:ApiManagementService" }, { type: "azure-native:apimanagement/v20170301:ApiManagementService" }, { type: "azure-native:apimanagement/v20180101:ApiManagementService" }, { type: "azure-native:apimanagement/v20180601preview:ApiManagementService" }, { type: "azure-native:apimanagement/v20190101:ApiManagementService" }, { type: "azure-native:apimanagement/v20191201:ApiManagementService" }, { type: "azure-native:apimanagement/v20191201preview:ApiManagementService" }, { type: "azure-native:apimanagement/v20200601preview:ApiManagementService" }, { type: "azure-native:apimanagement/v20201201:ApiManagementService" }, { type: "azure-native:apimanagement/v20210101preview:ApiManagementService" }, { type: "azure-native:apimanagement/v20210401preview:ApiManagementService" }, { type: "azure-native:apimanagement/v20210801:ApiManagementService" }, { type: "azure-native:apimanagement/v20211201preview:ApiManagementService" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(ApiManagementService.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a ApiManagementService resource.
 */
export interface ApiManagementServiceArgs {
    /**
     * Additional datacenter locations of the API Management service.
     */
    additionalLocations?: pulumi.Input<pulumi.Input<inputs.apimanagement.v20160707.AdditionalRegionArgs>[]>;
    /**
     * Addresser email.
     */
    addresserEmail?: pulumi.Input<string>;
    /**
     * Custom properties of the API Management service, like disabling TLS 1.0.
     */
    customProperties?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Custom hostname configuration of the API Management service.
     */
    hostnameConfigurations?: pulumi.Input<pulumi.Input<inputs.apimanagement.v20160707.HostnameConfigurationArgs>[]>;
    /**
     * Datacenter location of the API Management service.
     */
    location?: pulumi.Input<string>;
    /**
     * Publisher email.
     */
    publisherEmail: pulumi.Input<string>;
    /**
     * Publisher name.
     */
    publisherName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the API Management service.
     */
    serviceName?: pulumi.Input<string>;
    /**
     * SKU properties of the API Management service.
     */
    sku: pulumi.Input<inputs.apimanagement.v20160707.ApiManagementServiceSkuPropertiesArgs>;
    /**
     * API Management service tags. A maximum of 10 tags can be provided for a resource, and each tag must have a key no greater than 128 characters (and a value no greater than 256 characters).
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The type of VPN in which API Management service needs to be configured in. None (Default Value) means the API Management service is not part of any Virtual Network, External means the API Management deployment is set up inside a Virtual Network having an Internet Facing Endpoint, and Internal means that API Management deployment is setup inside a Virtual Network having an Intranet Facing Endpoint only.
     */
    vpnType?: pulumi.Input<enums.apimanagement.v20160707.VirtualNetworkType>;
    /**
     * Virtual network configuration of the API Management service.
     */
    vpnconfiguration?: pulumi.Input<inputs.apimanagement.v20160707.VirtualNetworkConfigurationArgs>;
}
