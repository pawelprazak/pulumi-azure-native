// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A favorite process identifier.
 *
 * @deprecated Version 2020-12-16-preview will be removed in v2 of the provider.
 */
export class FavoriteProcess extends pulumi.CustomResource {
    /**
     * Get an existing FavoriteProcess resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): FavoriteProcess {
        pulumi.log.warn("FavoriteProcess is deprecated: Version 2020-12-16-preview will be removed in v2 of the provider.")
        return new FavoriteProcess(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:testbase/v20201216preview:FavoriteProcess';

    /**
     * Returns true if the given object is an instance of FavoriteProcess.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FavoriteProcess {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FavoriteProcess.__pulumiType;
    }

    /**
     * The actual name of the favorite process. It will be equal to resource name except for the scenario that the process name contains characters that are not allowed in the resource name.
     */
    public readonly actualProcessName!: pulumi.Output<string>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The system metadata relating to this resource
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.testbase.v20201216preview.SystemDataResponse>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a FavoriteProcess resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2020-12-16-preview will be removed in v2 of the provider. */
    constructor(name: string, args: FavoriteProcessArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("FavoriteProcess is deprecated: Version 2020-12-16-preview will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.actualProcessName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'actualProcessName'");
            }
            if ((!args || args.packageName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'packageName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.testBaseAccountName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'testBaseAccountName'");
            }
            resourceInputs["actualProcessName"] = args ? args.actualProcessName : undefined;
            resourceInputs["favoriteProcessResourceName"] = args ? args.favoriteProcessResourceName : undefined;
            resourceInputs["packageName"] = args ? args.packageName : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["testBaseAccountName"] = args ? args.testBaseAccountName : undefined;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["actualProcessName"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:testbase:FavoriteProcess" }, { type: "azure-native:testbase/v20220401preview:FavoriteProcess" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(FavoriteProcess.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a FavoriteProcess resource.
 */
export interface FavoriteProcessArgs {
    /**
     * The actual name of the favorite process. It will be equal to resource name except for the scenario that the process name contains characters that are not allowed in the resource name.
     */
    actualProcessName: pulumi.Input<string>;
    /**
     * The resource name of a favorite process in a package. If the process name contains characters that are not allowed in Azure Resource Name, we use 'actualProcessName' in request body to submit the name.
     */
    favoriteProcessResourceName?: pulumi.Input<string>;
    /**
     * The resource name of the Test Base Package.
     */
    packageName: pulumi.Input<string>;
    /**
     * The name of the resource group that contains the resource.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The resource name of the Test Base Account.
     */
    testBaseAccountName: pulumi.Input<string>;
}
