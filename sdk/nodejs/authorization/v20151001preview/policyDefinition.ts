// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The policy definition.
 *
 * @deprecated Version 2015-10-01-preview will be removed in v2 of the provider.
 */
export class PolicyDefinition extends pulumi.CustomResource {
    /**
     * Get an existing PolicyDefinition resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): PolicyDefinition {
        pulumi.log.warn("PolicyDefinition is deprecated: Version 2015-10-01-preview will be removed in v2 of the provider.")
        return new PolicyDefinition(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:authorization/v20151001preview:PolicyDefinition';

    /**
     * Returns true if the given object is an instance of PolicyDefinition.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is PolicyDefinition {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === PolicyDefinition.__pulumiType;
    }

    /**
     * The policy definition description.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The display name of the policy definition.
     */
    public readonly displayName!: pulumi.Output<string | undefined>;
    /**
     * The name of the policy definition. If you do not specify a value for name, the value is inferred from the name value in the request URI.
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * The policy rule.
     */
    public readonly policyRule!: pulumi.Output<any | undefined>;
    /**
     * The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
     */
    public readonly policyType!: pulumi.Output<string | undefined>;

    /**
     * Create a PolicyDefinition resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated Version 2015-10-01-preview will be removed in v2 of the provider. */
    constructor(name: string, args?: PolicyDefinitionArgs, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("PolicyDefinition is deprecated: Version 2015-10-01-preview will be removed in v2 of the provider.")
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["displayName"] = args ? args.displayName : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["policyDefinitionName"] = args ? args.policyDefinitionName : undefined;
            resourceInputs["policyRule"] = args ? args.policyRule : undefined;
            resourceInputs["policyType"] = args ? args.policyType : undefined;
        } else {
            resourceInputs["description"] = undefined /*out*/;
            resourceInputs["displayName"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["policyRule"] = undefined /*out*/;
            resourceInputs["policyType"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:authorization:PolicyDefinition" }, { type: "azure-native:authorization/v20160401:PolicyDefinition" }, { type: "azure-native:authorization/v20161201:PolicyDefinition" }, { type: "azure-native:authorization/v20180301:PolicyDefinition" }, { type: "azure-native:authorization/v20180501:PolicyDefinition" }, { type: "azure-native:authorization/v20190101:PolicyDefinition" }, { type: "azure-native:authorization/v20190601:PolicyDefinition" }, { type: "azure-native:authorization/v20190901:PolicyDefinition" }, { type: "azure-native:authorization/v20200301:PolicyDefinition" }, { type: "azure-native:authorization/v20200901:PolicyDefinition" }, { type: "azure-native:authorization/v20210601:PolicyDefinition" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(PolicyDefinition.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a PolicyDefinition resource.
 */
export interface PolicyDefinitionArgs {
    /**
     * The policy definition description.
     */
    description?: pulumi.Input<string>;
    /**
     * The display name of the policy definition.
     */
    displayName?: pulumi.Input<string>;
    /**
     * The name of the policy definition. If you do not specify a value for name, the value is inferred from the name value in the request URI.
     */
    name?: pulumi.Input<string>;
    /**
     * The name of the policy definition to create.
     */
    policyDefinitionName?: pulumi.Input<string>;
    /**
     * The policy rule.
     */
    policyRule?: any;
    /**
     * The type of policy definition. Possible values are NotSpecified, BuiltIn, and Custom.
     */
    policyType?: pulumi.Input<string | enums.authorization.v20151001preview.PolicyType>;
}
