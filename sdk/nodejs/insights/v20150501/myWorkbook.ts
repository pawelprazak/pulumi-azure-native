// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * An Application Insights private workbook definition.
 */
export class MyWorkbook extends pulumi.CustomResource {
    /**
     * Get an existing MyWorkbook resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): MyWorkbook {
        return new MyWorkbook(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:insights/v20150501:MyWorkbook';

    /**
     * Returns true if the given object is an instance of MyWorkbook.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is MyWorkbook {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === MyWorkbook.__pulumiType;
    }

    /**
     * Workbook category, as defined by the user at creation time.
     */
    public readonly category!: pulumi.Output<string>;
    /**
     * The user-defined name of the private workbook.
     */
    public readonly displayName!: pulumi.Output<string>;
    /**
     * The kind of workbook. Choices are user and shared.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * Resource location
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * Azure resource name
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * Configuration of this particular private workbook. Configuration data is a string containing valid JSON
     */
    public readonly serializedData!: pulumi.Output<string>;
    /**
     * Optional resourceId for a source resource.
     */
    public readonly sourceId!: pulumi.Output<string | undefined>;
    /**
     * Resource tags
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Date and time in UTC of the last modification that was made to this private workbook definition.
     */
    public /*out*/ readonly timeModified!: pulumi.Output<string>;
    /**
     * Azure resource type
     */
    public readonly type!: pulumi.Output<string | undefined>;
    /**
     * Unique user id of the specific user that owns this private workbook.
     */
    public /*out*/ readonly userId!: pulumi.Output<string>;
    /**
     * This instance's version of the data model. This can change as new features are added that can be marked private workbook.
     */
    public readonly version!: pulumi.Output<string | undefined>;

    /**
     * Create a MyWorkbook resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: MyWorkbookArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.category === undefined) && !opts.urn) {
                throw new Error("Missing required property 'category'");
            }
            if ((!args || args.displayName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'displayName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.serializedData === undefined) && !opts.urn) {
                throw new Error("Missing required property 'serializedData'");
            }
            resourceInputs["category"] = args ? args.category : undefined;
            resourceInputs["displayName"] = args ? args.displayName : undefined;
            resourceInputs["id"] = args ? args.id : undefined;
            resourceInputs["kind"] = args ? args.kind : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["resourceName"] = args ? args.resourceName : undefined;
            resourceInputs["serializedData"] = args ? args.serializedData : undefined;
            resourceInputs["sourceId"] = args ? args.sourceId : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["type"] = args ? args.type : undefined;
            resourceInputs["version"] = args ? args.version : undefined;
            resourceInputs["timeModified"] = undefined /*out*/;
            resourceInputs["userId"] = undefined /*out*/;
        } else {
            resourceInputs["category"] = undefined /*out*/;
            resourceInputs["displayName"] = undefined /*out*/;
            resourceInputs["kind"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["serializedData"] = undefined /*out*/;
            resourceInputs["sourceId"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["timeModified"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["userId"] = undefined /*out*/;
            resourceInputs["version"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:insights:MyWorkbook" }, { type: "azure-native:insights/v20201020:MyWorkbook" }, { type: "azure-native:insights/v20210308:MyWorkbook" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(MyWorkbook.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a MyWorkbook resource.
 */
export interface MyWorkbookArgs {
    /**
     * Workbook category, as defined by the user at creation time.
     */
    category: pulumi.Input<string>;
    /**
     * The user-defined name of the private workbook.
     */
    displayName: pulumi.Input<string>;
    /**
     * Azure resource Id
     */
    id?: pulumi.Input<string>;
    /**
     * The kind of workbook. Choices are user and shared.
     */
    kind?: pulumi.Input<string | enums.insights.v20150501.SharedTypeKind>;
    /**
     * Resource location
     */
    location?: pulumi.Input<string>;
    /**
     * Azure resource name
     */
    name?: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the Application Insights component resource.
     */
    resourceName?: pulumi.Input<string>;
    /**
     * Configuration of this particular private workbook. Configuration data is a string containing valid JSON
     */
    serializedData: pulumi.Input<string>;
    /**
     * Optional resourceId for a source resource.
     */
    sourceId?: pulumi.Input<string>;
    /**
     * Resource tags
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Azure resource type
     */
    type?: pulumi.Input<string>;
    /**
     * This instance's version of the data model. This can change as new features are added that can be marked private workbook.
     */
    version?: pulumi.Input<string>;
}
