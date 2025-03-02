// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A host name binding object
 *
 * @deprecated Version 2015-08-01 will be removed in v2 of the provider.
 */
export class SiteHostNameBinding extends pulumi.CustomResource {
    /**
     * Get an existing SiteHostNameBinding resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SiteHostNameBinding {
        pulumi.log.warn("SiteHostNameBinding is deprecated: Version 2015-08-01 will be removed in v2 of the provider.")
        return new SiteHostNameBinding(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:web/v20150801:SiteHostNameBinding';

    /**
     * Returns true if the given object is an instance of SiteHostNameBinding.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SiteHostNameBinding {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SiteHostNameBinding.__pulumiType;
    }

    /**
     * Azure resource name
     */
    public readonly azureResourceName!: pulumi.Output<string | undefined>;
    /**
     * Azure resource type
     */
    public readonly azureResourceType!: pulumi.Output<string | undefined>;
    /**
     * Custom DNS record type
     */
    public readonly customHostNameDnsRecordType!: pulumi.Output<string | undefined>;
    /**
     * Fully qualified ARM domain resource URI
     */
    public readonly domainId!: pulumi.Output<string | undefined>;
    /**
     * Host name type
     */
    public readonly hostNameType!: pulumi.Output<string | undefined>;
    /**
     * Kind of resource
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource Location
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Resource Name
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * Web app name
     */
    public readonly siteName!: pulumi.Output<string | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public readonly type!: pulumi.Output<string | undefined>;

    /**
     * Create a SiteHostNameBinding resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2015-08-01 will be removed in v2 of the provider. */
    constructor(name: string, args: SiteHostNameBindingArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("SiteHostNameBinding is deprecated: Version 2015-08-01 will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.name === undefined) && !opts.urn) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["azureResourceName"] = args ? args.azureResourceName : undefined;
            resourceInputs["azureResourceType"] = args ? args.azureResourceType : undefined;
            resourceInputs["customHostNameDnsRecordType"] = args ? args.customHostNameDnsRecordType : undefined;
            resourceInputs["domainId"] = args ? args.domainId : undefined;
            resourceInputs["hostName"] = args ? args.hostName : undefined;
            resourceInputs["hostNameType"] = args ? args.hostNameType : undefined;
            resourceInputs["id"] = args ? args.id : undefined;
            resourceInputs["kind"] = args ? args.kind : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["siteName"] = args ? args.siteName : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
        } else {
            resourceInputs["azureResourceName"] = undefined /*out*/;
            resourceInputs["azureResourceType"] = undefined /*out*/;
            resourceInputs["customHostNameDnsRecordType"] = undefined /*out*/;
            resourceInputs["domainId"] = undefined /*out*/;
            resourceInputs["hostNameType"] = undefined /*out*/;
            resourceInputs["kind"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["siteName"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:web:SiteHostNameBinding" }, { type: "azure-native:web/v20160801:SiteHostNameBinding" }, { type: "azure-native:web/v20180201:SiteHostNameBinding" }, { type: "azure-native:web/v20181101:SiteHostNameBinding" }, { type: "azure-native:web/v20190801:SiteHostNameBinding" }, { type: "azure-native:web/v20200601:SiteHostNameBinding" }, { type: "azure-native:web/v20200901:SiteHostNameBinding" }, { type: "azure-native:web/v20201001:SiteHostNameBinding" }, { type: "azure-native:web/v20201201:SiteHostNameBinding" }, { type: "azure-native:web/v20210101:SiteHostNameBinding" }, { type: "azure-native:web/v20210115:SiteHostNameBinding" }, { type: "azure-native:web/v20210201:SiteHostNameBinding" }, { type: "azure-native:web/v20210301:SiteHostNameBinding" }, { type: "azure-native:web/v20220301:SiteHostNameBinding" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(SiteHostNameBinding.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a SiteHostNameBinding resource.
 */
export interface SiteHostNameBindingArgs {
    /**
     * Azure resource name
     */
    azureResourceName?: pulumi.Input<string>;
    /**
     * Azure resource type
     */
    azureResourceType?: pulumi.Input<enums.web.v20150801.AzureResourceType>;
    /**
     * Custom DNS record type
     */
    customHostNameDnsRecordType?: pulumi.Input<enums.web.v20150801.CustomHostNameDnsRecordType>;
    /**
     * Fully qualified ARM domain resource URI
     */
    domainId?: pulumi.Input<string>;
    /**
     * Name of host
     */
    hostName?: pulumi.Input<string>;
    /**
     * Host name type
     */
    hostNameType?: pulumi.Input<enums.web.v20150801.HostNameType>;
    /**
     * Resource Id
     */
    id?: pulumi.Input<string>;
    /**
     * Kind of resource
     */
    kind?: pulumi.Input<string>;
    /**
     * Resource Location
     */
    location?: pulumi.Input<string>;
    /**
     * Resource Name
     */
    name: pulumi.Input<string>;
    /**
     * Name of resource group
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Web app name
     */
    siteName?: pulumi.Input<string>;
    /**
     * Resource tags
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Resource type
     */
    type?: pulumi.Input<string>;
}
