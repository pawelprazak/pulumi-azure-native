// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Service resource.
 */
export function getService(args: GetServiceArgs, opts?: pulumi.InvokeOptions): Promise<GetServiceResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:mobilenetwork/v20220301preview:getService", {
        "mobileNetworkName": args.mobileNetworkName,
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
    }, opts);
}

export interface GetServiceArgs {
    /**
     * The name of the mobile network.
     */
    mobileNetworkName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The name of the service. You must not use any of the following reserved strings - `default`, `requested` or `service`
     */
    serviceName: string;
}

/**
 * Service resource.
 */
export interface GetServiceResult {
    /**
     * The timestamp of resource creation (UTC).
     */
    readonly createdAt?: string;
    /**
     * The identity that created the resource.
     */
    readonly createdBy?: string;
    /**
     * The type of identity that created the resource.
     */
    readonly createdByType?: string;
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The timestamp of resource last modification (UTC)
     */
    readonly lastModifiedAt?: string;
    /**
     * The identity that last modified the resource.
     */
    readonly lastModifiedBy?: string;
    /**
     * The type of identity that last modified the resource.
     */
    readonly lastModifiedByType?: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * The set of PCC Rules that make up this service.
     */
    readonly pccRules: outputs.mobilenetwork.v20220301preview.PccRuleConfigurationResponse[];
    /**
     * The provisioning state of the service resource.
     */
    readonly provisioningState: string;
    /**
     * A precedence value that is used to decide between services when identifying the QoS values to use for a particular Sim. A lower value means a higher priority. This value should be unique among all services configured in the Mobile Network.
     */
    readonly servicePrecedence: number;
    /**
     * The QoS policy to use for packets matching this service. This can be overridden for particular flows using the ruleQosPolicy field in a PccRuleConfiguration. If this field is null then the UE's simPolicy will define the QoS settings.
     */
    readonly serviceQosPolicy?: outputs.mobilenetwork.v20220301preview.QosPolicyResponse;
    /**
     * Azure Resource Manager metadata containing createdBy and modifiedBy information.
     */
    readonly systemData: outputs.mobilenetwork.v20220301preview.SystemDataResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getServiceOutput(args: GetServiceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetServiceResult> {
    return pulumi.output(args).apply(a => getService(a, opts))
}

export interface GetServiceOutputArgs {
    /**
     * The name of the mobile network.
     */
    mobileNetworkName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the service. You must not use any of the following reserved strings - `default`, `requested` or `service`
     */
    serviceName: pulumi.Input<string>;
}
