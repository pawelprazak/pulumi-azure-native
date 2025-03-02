// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Registration assignment.
 *
 * @deprecated Version 2018-06-01-preview will be removed in v2 of the provider.
 */
export class RegistrationAssignment extends pulumi.CustomResource {
    /**
     * Get an existing RegistrationAssignment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): RegistrationAssignment {
        pulumi.log.warn("RegistrationAssignment is deprecated: Version 2018-06-01-preview will be removed in v2 of the provider.")
        return new RegistrationAssignment(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:managedservices/v20180601preview:RegistrationAssignment';

    /**
     * Returns true if the given object is an instance of RegistrationAssignment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is RegistrationAssignment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === RegistrationAssignment.__pulumiType;
    }

    /**
     * Name of the registration assignment.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Properties of a registration assignment.
     */
    public readonly properties!: pulumi.Output<outputs.managedservices.v20180601preview.RegistrationAssignmentPropertiesResponse>;
    /**
     * Type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a RegistrationAssignment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2018-06-01-preview will be removed in v2 of the provider. */
    constructor(name: string, args: RegistrationAssignmentArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("RegistrationAssignment is deprecated: Version 2018-06-01-preview will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.scope === undefined) && !opts.urn) {
                throw new Error("Missing required property 'scope'");
            }
            resourceInputs["properties"] = args ? args.properties : undefined;
            resourceInputs["registrationAssignmentId"] = args ? args.registrationAssignmentId : undefined;
            resourceInputs["scope"] = args ? args.scope : undefined;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["properties"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:managedservices:RegistrationAssignment" }, { type: "azure-native:managedservices/v20190401preview:RegistrationAssignment" }, { type: "azure-native:managedservices/v20190601:RegistrationAssignment" }, { type: "azure-native:managedservices/v20190901:RegistrationAssignment" }, { type: "azure-native:managedservices/v20200201preview:RegistrationAssignment" }, { type: "azure-native:managedservices/v20220101preview:RegistrationAssignment" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(RegistrationAssignment.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a RegistrationAssignment resource.
 */
export interface RegistrationAssignmentArgs {
    /**
     * Properties of a registration assignment.
     */
    properties?: pulumi.Input<inputs.managedservices.v20180601preview.RegistrationAssignmentPropertiesArgs>;
    /**
     * Guid of the registration assignment.
     */
    registrationAssignmentId?: pulumi.Input<string>;
    /**
     * Scope of the resource.
     */
    scope: pulumi.Input<string>;
}
