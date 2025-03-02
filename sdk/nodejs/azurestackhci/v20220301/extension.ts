// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Details of a particular extension in HCI Cluster.
 */
export class Extension extends pulumi.CustomResource {
    /**
     * Get an existing Extension resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Extension {
        return new Extension(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:azurestackhci/v20220301:Extension';

    /**
     * Returns true if the given object is an instance of Extension.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Extension {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Extension.__pulumiType;
    }

    /**
     * Aggregate state of Arc Extensions across the nodes in this HCI cluster.
     */
    public /*out*/ readonly aggregateState!: pulumi.Output<string>;
    /**
     * Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
     */
    public readonly autoUpgradeMinorVersion!: pulumi.Output<boolean | undefined>;
    /**
     * The timestamp of resource creation (UTC).
     */
    public readonly createdAt!: pulumi.Output<string | undefined>;
    /**
     * The identity that created the resource.
     */
    public readonly createdBy!: pulumi.Output<string | undefined>;
    /**
     * The type of identity that created the resource.
     */
    public readonly createdByType!: pulumi.Output<string | undefined>;
    /**
     * How the extension handler should be forced to update even if the extension configuration has not changed.
     */
    public readonly forceUpdateTag!: pulumi.Output<string | undefined>;
    /**
     * The timestamp of resource last modification (UTC)
     */
    public readonly lastModifiedAt!: pulumi.Output<string | undefined>;
    /**
     * The identity that last modified the resource.
     */
    public readonly lastModifiedBy!: pulumi.Output<string | undefined>;
    /**
     * The type of identity that last modified the resource.
     */
    public readonly lastModifiedByType!: pulumi.Output<string | undefined>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * State of Arc Extension in each of the nodes.
     */
    public /*out*/ readonly perNodeExtensionDetails!: pulumi.Output<outputs.azurestackhci.v20220301.PerNodeExtensionStateResponse[]>;
    /**
     * Protected settings (may contain secrets).
     */
    public readonly protectedSettings!: pulumi.Output<any | undefined>;
    /**
     * Provisioning state of the Extension proxy resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The name of the extension handler publisher.
     */
    public readonly publisher!: pulumi.Output<string | undefined>;
    /**
     * Json formatted public settings for the extension.
     */
    public readonly settings!: pulumi.Output<any | undefined>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public readonly type!: pulumi.Output<string>;
    /**
     * Specifies the version of the script handler.
     */
    public readonly typeHandlerVersion!: pulumi.Output<string | undefined>;

    /**
     * Create a Extension resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ExtensionArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.arcSettingName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'arcSettingName'");
            }
            if ((!args || args.clusterName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["arcSettingName"] = args ? args.arcSettingName : undefined;
            resourceInputs["autoUpgradeMinorVersion"] = args ? args.autoUpgradeMinorVersion : undefined;
            resourceInputs["clusterName"] = args ? args.clusterName : undefined;
            resourceInputs["createdAt"] = args ? args.createdAt : undefined;
            resourceInputs["createdBy"] = args ? args.createdBy : undefined;
            resourceInputs["createdByType"] = args ? args.createdByType : undefined;
            resourceInputs["extensionName"] = args ? args.extensionName : undefined;
            resourceInputs["forceUpdateTag"] = args ? args.forceUpdateTag : undefined;
            resourceInputs["lastModifiedAt"] = args ? args.lastModifiedAt : undefined;
            resourceInputs["lastModifiedBy"] = args ? args.lastModifiedBy : undefined;
            resourceInputs["lastModifiedByType"] = args ? args.lastModifiedByType : undefined;
            resourceInputs["protectedSettings"] = args ? args.protectedSettings : undefined;
            resourceInputs["publisher"] = args ? args.publisher : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["settings"] = args ? args.settings : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
            resourceInputs["typeHandlerVersion"] = args ? args.typeHandlerVersion : undefined;
            resourceInputs["aggregateState"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["perNodeExtensionDetails"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
        } else {
            resourceInputs["aggregateState"] = undefined /*out*/;
            resourceInputs["autoUpgradeMinorVersion"] = undefined /*out*/;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["createdBy"] = undefined /*out*/;
            resourceInputs["createdByType"] = undefined /*out*/;
            resourceInputs["forceUpdateTag"] = undefined /*out*/;
            resourceInputs["lastModifiedAt"] = undefined /*out*/;
            resourceInputs["lastModifiedBy"] = undefined /*out*/;
            resourceInputs["lastModifiedByType"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["perNodeExtensionDetails"] = undefined /*out*/;
            resourceInputs["protectedSettings"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["publisher"] = undefined /*out*/;
            resourceInputs["settings"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["typeHandlerVersion"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:azurestackhci:Extension" }, { type: "azure-native:azurestackhci/v20210101preview:Extension" }, { type: "azure-native:azurestackhci/v20210901:Extension" }, { type: "azure-native:azurestackhci/v20220101:Extension" }, { type: "azure-native:azurestackhci/v20220501:Extension" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(Extension.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Extension resource.
 */
export interface ExtensionArgs {
    /**
     * The name of the proxy resource holding details of HCI ArcSetting information.
     */
    arcSettingName: pulumi.Input<string>;
    /**
     * Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true.
     */
    autoUpgradeMinorVersion?: pulumi.Input<boolean>;
    /**
     * The name of the cluster.
     */
    clusterName: pulumi.Input<string>;
    /**
     * The timestamp of resource creation (UTC).
     */
    createdAt?: pulumi.Input<string>;
    /**
     * The identity that created the resource.
     */
    createdBy?: pulumi.Input<string>;
    /**
     * The type of identity that created the resource.
     */
    createdByType?: pulumi.Input<string | enums.azurestackhci.v20220301.CreatedByType>;
    /**
     * The name of the machine extension.
     */
    extensionName?: pulumi.Input<string>;
    /**
     * How the extension handler should be forced to update even if the extension configuration has not changed.
     */
    forceUpdateTag?: pulumi.Input<string>;
    /**
     * The timestamp of resource last modification (UTC)
     */
    lastModifiedAt?: pulumi.Input<string>;
    /**
     * The identity that last modified the resource.
     */
    lastModifiedBy?: pulumi.Input<string>;
    /**
     * The type of identity that last modified the resource.
     */
    lastModifiedByType?: pulumi.Input<string | enums.azurestackhci.v20220301.CreatedByType>;
    /**
     * Protected settings (may contain secrets).
     */
    protectedSettings?: any;
    /**
     * The name of the extension handler publisher.
     */
    publisher?: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Json formatted public settings for the extension.
     */
    settings?: any;
    /**
     * Specifies the type of the extension; an example is "CustomScriptExtension".
     */
    type?: pulumi.Input<string>;
    /**
     * Specifies the version of the script handler.
     */
    typeHandlerVersion?: pulumi.Input<string>;
}
