// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Definition of ARM tracked top level resource.
 */
export function getDataCollectionRule(args: GetDataCollectionRuleArgs, opts?: pulumi.InvokeOptions): Promise<GetDataCollectionRuleResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:insights/v20210901preview:getDataCollectionRule", {
        "dataCollectionRuleName": args.dataCollectionRuleName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetDataCollectionRuleArgs {
    /**
     * The name of the data collection rule. The name is case insensitive.
     */
    dataCollectionRuleName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * Definition of ARM tracked top level resource.
 */
export interface GetDataCollectionRuleResult {
    /**
     * The resource ID of the data collection endpoint that this rule can be used with.
     */
    readonly dataCollectionEndpointId?: string;
    /**
     * The specification of data flows.
     */
    readonly dataFlows?: outputs.insights.v20210901preview.DataFlowResponse[];
    /**
     * The specification of data sources. 
     * This property is optional and can be omitted if the rule is meant to be used via direct calls to the provisioned endpoint.
     */
    readonly dataSources?: outputs.insights.v20210901preview.DataCollectionRuleResponseDataSources;
    /**
     * Description of the data collection rule.
     */
    readonly description?: string;
    /**
     * The specification of destinations.
     */
    readonly destinations?: outputs.insights.v20210901preview.DataCollectionRuleResponseDestinations;
    /**
     * Resource entity tag (ETag).
     */
    readonly etag: string;
    /**
     * Fully qualified ID of the resource.
     */
    readonly id: string;
    /**
     * The immutable ID of this data collection rule. This property is READ-ONLY.
     */
    readonly immutableId: string;
    /**
     * The kind of the resource.
     */
    readonly kind?: string;
    /**
     * The geo-location where the resource lives.
     */
    readonly location: string;
    /**
     * Metadata about the resource
     */
    readonly metadata: outputs.insights.v20210901preview.DataCollectionRuleResponseMetadata;
    /**
     * The name of the resource.
     */
    readonly name: string;
    /**
     * The resource provisioning state.
     */
    readonly provisioningState: string;
    /**
     * Declaration of custom streams used in this rule.
     */
    readonly streamDeclarations?: {[key: string]: outputs.insights.v20210901preview.StreamDeclarationResponse};
    /**
     * Metadata pertaining to creation and last modification of the resource.
     */
    readonly systemData: outputs.insights.v20210901preview.DataCollectionRuleResourceResponseSystemData;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource.
     */
    readonly type: string;
}

export function getDataCollectionRuleOutput(args: GetDataCollectionRuleOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDataCollectionRuleResult> {
    return pulumi.output(args).apply(a => getDataCollectionRule(a, opts))
}

export interface GetDataCollectionRuleOutputArgs {
    /**
     * The name of the data collection rule. The name is case insensitive.
     */
    dataCollectionRuleName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
