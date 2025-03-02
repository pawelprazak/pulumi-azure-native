// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * String dictionary resource
 *
 * @deprecated Version 2015-08-01 will be removed in v2 of the provider.
 */
export class SiteConnectionStringsSlot extends pulumi.CustomResource {
    /**
     * Get an existing SiteConnectionStringsSlot resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): SiteConnectionStringsSlot {
        pulumi.log.warn("SiteConnectionStringsSlot is deprecated: Version 2015-08-01 will be removed in v2 of the provider.")
        return new SiteConnectionStringsSlot(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:web/v20150801:SiteConnectionStringsSlot';

    /**
     * Returns true if the given object is an instance of SiteConnectionStringsSlot.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SiteConnectionStringsSlot {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SiteConnectionStringsSlot.__pulumiType;
    }

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
     * Connection strings
     */
    public readonly properties!: pulumi.Output<{[key: string]: outputs.web.v20150801.ConnStringValueTypePairResponse}>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Resource type
     */
    public readonly type!: pulumi.Output<string | undefined>;

    /**
     * Create a SiteConnectionStringsSlot resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2015-08-01 will be removed in v2 of the provider. */
    constructor(name: string, args: SiteConnectionStringsSlotArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("SiteConnectionStringsSlot is deprecated: Version 2015-08-01 will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.name === undefined) && !opts.urn) {
                throw new Error("Missing required property 'name'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.slot === undefined) && !opts.urn) {
                throw new Error("Missing required property 'slot'");
            }
            resourceInputs["id"] = args ? args.id : undefined;
            resourceInputs["kind"] = args ? args.kind : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["properties"] = args ? args.properties : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["slot"] = args ? args.slot : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
        } else {
            resourceInputs["kind"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["properties"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:web:SiteConnectionStringsSlot" }, { type: "azure-native:web/v20160801:SiteConnectionStringsSlot" }, { type: "azure-native:web/v20180201:SiteConnectionStringsSlot" }, { type: "azure-native:web/v20181101:SiteConnectionStringsSlot" }, { type: "azure-native:web/v20190801:SiteConnectionStringsSlot" }, { type: "azure-native:web/v20200601:SiteConnectionStringsSlot" }, { type: "azure-native:web/v20200901:SiteConnectionStringsSlot" }, { type: "azure-native:web/v20201001:SiteConnectionStringsSlot" }, { type: "azure-native:web/v20201201:SiteConnectionStringsSlot" }, { type: "azure-native:web/v20210101:SiteConnectionStringsSlot" }, { type: "azure-native:web/v20210115:SiteConnectionStringsSlot" }, { type: "azure-native:web/v20210201:SiteConnectionStringsSlot" }, { type: "azure-native:web/v20210301:SiteConnectionStringsSlot" }, { type: "azure-native:web/v20220301:SiteConnectionStringsSlot" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(SiteConnectionStringsSlot.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a SiteConnectionStringsSlot resource.
 */
export interface SiteConnectionStringsSlotArgs {
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
     * Connection strings
     */
    properties?: pulumi.Input<{[key: string]: pulumi.Input<inputs.web.v20150801.ConnStringValueTypePairArgs>}>;
    /**
     * Name of resource group
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Name of web app slot. If not specified then will default to production slot.
     */
    slot: pulumi.Input<string>;
    /**
     * Resource tags
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Resource type
     */
    type?: pulumi.Input<string>;
}
