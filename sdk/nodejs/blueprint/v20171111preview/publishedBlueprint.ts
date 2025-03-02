// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Represents a published Blueprint.
 *
 * @deprecated Version 2017-11-11-preview will be removed in v2 of the provider.
 */
export class PublishedBlueprint extends pulumi.CustomResource {
    /**
     * Get an existing PublishedBlueprint resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PublishedBlueprint {
        pulumi.log.warn("PublishedBlueprint is deprecated: Version 2017-11-11-preview will be removed in v2 of the provider.")
        return new PublishedBlueprint(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:blueprint/v20171111preview:PublishedBlueprint';

    /**
     * Returns true if the given object is an instance of PublishedBlueprint.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PublishedBlueprint {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PublishedBlueprint.__pulumiType;
    }

    /**
     * Name of the Blueprint definition.
     */
    public readonly blueprintName!: pulumi.Output<string | undefined>;
    /**
     * Version-specific change notes
     */
    public /*out*/ readonly changeNotes!: pulumi.Output<string | undefined>;
    /**
     * Multi-line explain this resource.
     */
    public /*out*/ readonly description!: pulumi.Output<string | undefined>;
    /**
     * One-liner string explain this resource.
     */
    public /*out*/ readonly displayName!: pulumi.Output<string | undefined>;
    /**
     * Name of this resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Parameters required by this Blueprint definition.
     */
    public /*out*/ readonly parameters!: pulumi.Output<{[key: string]: outputs.blueprint.v20171111preview.ParameterDefinitionResponse} | undefined>;
    /**
     * Resource group placeholders defined by this Blueprint definition.
     */
    public /*out*/ readonly resourceGroups!: pulumi.Output<{[key: string]: outputs.blueprint.v20171111preview.ResourceGroupDefinitionResponse} | undefined>;
    /**
     * Status of the Blueprint. This field is readonly.
     */
    public /*out*/ readonly status!: pulumi.Output<outputs.blueprint.v20171111preview.BlueprintStatusResponse>;
    /**
     * The scope where this Blueprint can be applied.
     */
    public /*out*/ readonly targetScope!: pulumi.Output<string | undefined>;
    /**
     * Type of this resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a PublishedBlueprint resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2017-11-11-preview will be removed in v2 of the provider. */
    constructor(name: string, args: PublishedBlueprintArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("PublishedBlueprint is deprecated: Version 2017-11-11-preview will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.blueprintName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'blueprintName'");
            }
            if ((!args || args.managementGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'managementGroupName'");
            }
            resourceInputs["blueprintName"] = args ? args.blueprintName : undefined;
            resourceInputs["managementGroupName"] = args ? args.managementGroupName : undefined;
            resourceInputs["versionId"] = args ? args.versionId : undefined;
            resourceInputs["changeNotes"] = undefined /*out*/;
            resourceInputs["description"] = undefined /*out*/;
            resourceInputs["displayName"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["parameters"] = undefined /*out*/;
            resourceInputs["resourceGroups"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
            resourceInputs["targetScope"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["blueprintName"] = undefined /*out*/;
            resourceInputs["changeNotes"] = undefined /*out*/;
            resourceInputs["description"] = undefined /*out*/;
            resourceInputs["displayName"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["parameters"] = undefined /*out*/;
            resourceInputs["resourceGroups"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
            resourceInputs["targetScope"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(PublishedBlueprint.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a PublishedBlueprint resource.
 */
export interface PublishedBlueprintArgs {
    /**
     * name of the blueprint.
     */
    blueprintName: pulumi.Input<string>;
    /**
     * ManagementGroup where blueprint stores.
     */
    managementGroupName: pulumi.Input<string>;
    /**
     * version of the published blueprint.
     */
    versionId?: pulumi.Input<string>;
}
