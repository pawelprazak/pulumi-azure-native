// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Friendly Rules name mapping to the any Rules or secret related information.
 */
export class Rule extends pulumi.CustomResource {
    /**
     * Get an existing Rule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Rule {
        return new Rule(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:cdn/v20210601:Rule';

    /**
     * Returns true if the given object is an instance of Rule.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Rule {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Rule.__pulumiType;
    }

    /**
     * A list of actions that are executed when all the conditions of a rule are satisfied.
     */
    public readonly actions!: pulumi.Output<(outputs.cdn.v20210601.DeliveryRuleCacheExpirationActionResponse | outputs.cdn.v20210601.DeliveryRuleCacheKeyQueryStringActionResponse | outputs.cdn.v20210601.DeliveryRuleRequestHeaderActionResponse | outputs.cdn.v20210601.DeliveryRuleResponseHeaderActionResponse | outputs.cdn.v20210601.DeliveryRuleRouteConfigurationOverrideActionResponse | outputs.cdn.v20210601.OriginGroupOverrideActionResponse | outputs.cdn.v20210601.UrlRedirectActionResponse | outputs.cdn.v20210601.UrlRewriteActionResponse | outputs.cdn.v20210601.UrlSigningActionResponse)[]>;
    /**
     * A list of conditions that must be matched for the actions to be executed
     */
    public readonly conditions!: pulumi.Output<(outputs.cdn.v20210601.DeliveryRuleClientPortConditionResponse | outputs.cdn.v20210601.DeliveryRuleCookiesConditionResponse | outputs.cdn.v20210601.DeliveryRuleHostNameConditionResponse | outputs.cdn.v20210601.DeliveryRuleHttpVersionConditionResponse | outputs.cdn.v20210601.DeliveryRuleIsDeviceConditionResponse | outputs.cdn.v20210601.DeliveryRulePostArgsConditionResponse | outputs.cdn.v20210601.DeliveryRuleQueryStringConditionResponse | outputs.cdn.v20210601.DeliveryRuleRemoteAddressConditionResponse | outputs.cdn.v20210601.DeliveryRuleRequestBodyConditionResponse | outputs.cdn.v20210601.DeliveryRuleRequestHeaderConditionResponse | outputs.cdn.v20210601.DeliveryRuleRequestMethodConditionResponse | outputs.cdn.v20210601.DeliveryRuleRequestSchemeConditionResponse | outputs.cdn.v20210601.DeliveryRuleRequestUriConditionResponse | outputs.cdn.v20210601.DeliveryRuleServerPortConditionResponse | outputs.cdn.v20210601.DeliveryRuleSocketAddrConditionResponse | outputs.cdn.v20210601.DeliveryRuleSslProtocolConditionResponse | outputs.cdn.v20210601.DeliveryRuleUrlFileExtensionConditionResponse | outputs.cdn.v20210601.DeliveryRuleUrlFileNameConditionResponse | outputs.cdn.v20210601.DeliveryRuleUrlPathConditionResponse)[] | undefined>;
    public /*out*/ readonly deploymentStatus!: pulumi.Output<string>;
    /**
     * If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults to Continue.
     */
    public readonly matchProcessingBehavior!: pulumi.Output<string | undefined>;
    /**
     * Resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition and actions listed in it will always be applied.
     */
    public readonly order!: pulumi.Output<number>;
    /**
     * Provisioning status
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The name of the rule set containing the rule.
     */
    public readonly ruleSetName!: pulumi.Output<string>;
    /**
     * Read only system data
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.cdn.v20210601.SystemDataResponse>;
    /**
     * Resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Rule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RuleArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.actions === undefined) && !opts.urn) {
                throw new Error("Missing required property 'actions'");
            }
            if ((!args || args.order === undefined) && !opts.urn) {
                throw new Error("Missing required property 'order'");
            }
            if ((!args || args.profileName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'profileName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.ruleSetName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'ruleSetName'");
            }
            resourceInputs["actions"] = args ? args.actions : undefined;
            resourceInputs["conditions"] = args ? args.conditions : undefined;
            resourceInputs["matchProcessingBehavior"] = args ? args.matchProcessingBehavior : undefined;
            resourceInputs["order"] = args ? args.order : undefined;
            resourceInputs["profileName"] = args ? args.profileName : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["ruleName"] = args ? args.ruleName : undefined;
            resourceInputs["ruleSetName"] = args ? args.ruleSetName : undefined;
            resourceInputs["deploymentStatus"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["actions"] = undefined /*out*/;
            resourceInputs["conditions"] = undefined /*out*/;
            resourceInputs["deploymentStatus"] = undefined /*out*/;
            resourceInputs["matchProcessingBehavior"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["order"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["ruleSetName"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:cdn:Rule" }, { type: "azure-native:cdn/v20200901:Rule" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(Rule.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Rule resource.
 */
export interface RuleArgs {
    /**
     * A list of actions that are executed when all the conditions of a rule are satisfied.
     */
    actions: pulumi.Input<pulumi.Input<inputs.cdn.v20210601.DeliveryRuleCacheExpirationActionArgs | inputs.cdn.v20210601.DeliveryRuleCacheKeyQueryStringActionArgs | inputs.cdn.v20210601.DeliveryRuleRequestHeaderActionArgs | inputs.cdn.v20210601.DeliveryRuleResponseHeaderActionArgs | inputs.cdn.v20210601.DeliveryRuleRouteConfigurationOverrideActionArgs | inputs.cdn.v20210601.OriginGroupOverrideActionArgs | inputs.cdn.v20210601.UrlRedirectActionArgs | inputs.cdn.v20210601.UrlRewriteActionArgs | inputs.cdn.v20210601.UrlSigningActionArgs>[]>;
    /**
     * A list of conditions that must be matched for the actions to be executed
     */
    conditions?: pulumi.Input<pulumi.Input<inputs.cdn.v20210601.DeliveryRuleClientPortConditionArgs | inputs.cdn.v20210601.DeliveryRuleCookiesConditionArgs | inputs.cdn.v20210601.DeliveryRuleHostNameConditionArgs | inputs.cdn.v20210601.DeliveryRuleHttpVersionConditionArgs | inputs.cdn.v20210601.DeliveryRuleIsDeviceConditionArgs | inputs.cdn.v20210601.DeliveryRulePostArgsConditionArgs | inputs.cdn.v20210601.DeliveryRuleQueryStringConditionArgs | inputs.cdn.v20210601.DeliveryRuleRemoteAddressConditionArgs | inputs.cdn.v20210601.DeliveryRuleRequestBodyConditionArgs | inputs.cdn.v20210601.DeliveryRuleRequestHeaderConditionArgs | inputs.cdn.v20210601.DeliveryRuleRequestMethodConditionArgs | inputs.cdn.v20210601.DeliveryRuleRequestSchemeConditionArgs | inputs.cdn.v20210601.DeliveryRuleRequestUriConditionArgs | inputs.cdn.v20210601.DeliveryRuleServerPortConditionArgs | inputs.cdn.v20210601.DeliveryRuleSocketAddrConditionArgs | inputs.cdn.v20210601.DeliveryRuleSslProtocolConditionArgs | inputs.cdn.v20210601.DeliveryRuleUrlFileExtensionConditionArgs | inputs.cdn.v20210601.DeliveryRuleUrlFileNameConditionArgs | inputs.cdn.v20210601.DeliveryRuleUrlPathConditionArgs>[]>;
    /**
     * If this rule is a match should the rules engine continue running the remaining rules or stop. If not present, defaults to Continue.
     */
    matchProcessingBehavior?: pulumi.Input<string | enums.cdn.v20210601.MatchProcessingBehavior>;
    /**
     * The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition and actions listed in it will always be applied.
     */
    order: pulumi.Input<number>;
    /**
     * Name of the Azure Front Door Standard or Azure Front Door Premium profile which is unique within the resource group.
     */
    profileName: pulumi.Input<string>;
    /**
     * Name of the Resource group within the Azure subscription.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Name of the delivery rule which is unique within the endpoint.
     */
    ruleName?: pulumi.Input<string>;
    /**
     * Name of the rule set under the profile.
     */
    ruleSetName: pulumi.Input<string>;
}
