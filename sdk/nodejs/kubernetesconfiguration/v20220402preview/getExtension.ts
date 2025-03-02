// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The Extension object.
 */
export function getExtension(args: GetExtensionArgs, opts?: pulumi.InvokeOptions): Promise<GetExtensionResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:kubernetesconfiguration/v20220402preview:getExtension", {
        "clusterName": args.clusterName,
        "clusterResourceName": args.clusterResourceName,
        "clusterRp": args.clusterRp,
        "extensionName": args.extensionName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetExtensionArgs {
    /**
     * The name of the kubernetes cluster.
     */
    clusterName: string;
    /**
     * The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters.
     */
    clusterResourceName: string;
    /**
     * The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService.
     */
    clusterRp: string;
    /**
     * Name of the Extension.
     */
    extensionName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
}

/**
 * The Extension object.
 */
export interface GetExtensionResult {
    /**
     * Identity of the Extension resource in an AKS cluster
     */
    readonly aksAssignedIdentity?: outputs.kubernetesconfiguration.v20220402preview.ExtensionResponseAksAssignedIdentity;
    /**
     * Flag to note if this extension participates in auto upgrade of minor version, or not.
     */
    readonly autoUpgradeMinorVersion?: boolean;
    /**
     * Configuration settings that are sensitive, as name-value pairs for configuring this extension.
     */
    readonly configurationProtectedSettings?: {[key: string]: string};
    /**
     * Configuration settings, as name-value pairs for configuring this extension.
     */
    readonly configurationSettings?: {[key: string]: string};
    /**
     * Custom Location settings properties.
     */
    readonly customLocationSettings: {[key: string]: string};
    /**
     * Error information from the Agent - e.g. errors during installation.
     */
    readonly errorInfo: outputs.kubernetesconfiguration.v20220402preview.ErrorDetailResponse;
    /**
     * Type of the Extension, of which this resource is an instance of.  It must be one of the Extension Types registered with Microsoft.KubernetesConfiguration by the Extension publisher.
     */
    readonly extensionType?: string;
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * Identity of the Extension resource
     */
    readonly identity?: outputs.kubernetesconfiguration.v20220402preview.IdentityResponse;
    /**
     * Installed version of the extension.
     */
    readonly installedVersion: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Uri of the Helm package
     */
    readonly packageUri: string;
    /**
     * The plan information.
     */
    readonly plan?: outputs.kubernetesconfiguration.v20220402preview.PlanResponse;
    /**
     * Status of installation of this extension.
     */
    readonly provisioningState: string;
    /**
     * ReleaseTrain this extension participates in for auto-upgrade (e.g. Stable, Preview, etc.) - only if autoUpgradeMinorVersion is 'true'.
     */
    readonly releaseTrain?: string;
    /**
     * Scope at which the extension is installed.
     */
    readonly scope?: outputs.kubernetesconfiguration.v20220402preview.ScopeResponse;
    /**
     * Status from this extension.
     */
    readonly statuses?: outputs.kubernetesconfiguration.v20220402preview.ExtensionStatusResponse[];
    /**
     * Top level metadata https://github.com/Azure/azure-resource-manager-rpc/blob/master/v1.0/common-api-contracts.md#system-metadata-for-all-azure-resources
     */
    readonly systemData: outputs.kubernetesconfiguration.v20220402preview.SystemDataResponse;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
    /**
     * User-specified version of the extension for this extension to 'pin'. To use 'version', autoUpgradeMinorVersion must be 'false'.
     */
    readonly version?: string;
}

export function getExtensionOutput(args: GetExtensionOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetExtensionResult> {
    return pulumi.output(args).apply(a => getExtension(a, opts))
}

export interface GetExtensionOutputArgs {
    /**
     * The name of the kubernetes cluster.
     */
    clusterName: pulumi.Input<string>;
    /**
     * The Kubernetes cluster resource name - i.e. managedClusters, connectedClusters, provisionedClusters.
     */
    clusterResourceName: pulumi.Input<string>;
    /**
     * The Kubernetes cluster RP - i.e. Microsoft.ContainerService, Microsoft.Kubernetes, Microsoft.HybridContainerService.
     */
    clusterRp: pulumi.Input<string>;
    /**
     * Name of the Extension.
     */
    extensionName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
}
