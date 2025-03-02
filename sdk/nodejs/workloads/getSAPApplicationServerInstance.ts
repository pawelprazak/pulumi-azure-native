// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * Define the SAP Application Server Instance.
 * API Version: 2021-12-01-preview.
 */
export function getSAPApplicationServerInstance(args: GetSAPApplicationServerInstanceArgs, opts?: pulumi.InvokeOptions): Promise<GetSAPApplicationServerInstanceResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:workloads:getSAPApplicationServerInstance", {
        "applicationInstanceName": args.applicationInstanceName,
        "resourceGroupName": args.resourceGroupName,
        "sapVirtualInstanceName": args.sapVirtualInstanceName,
    }, opts);
}

export interface GetSAPApplicationServerInstanceArgs {
    /**
     * The name of SAP Application Server instance.
     */
    applicationInstanceName: string;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The name of the Virtual Instances for SAP.
     */
    sapVirtualInstanceName: string;
}

/**
 * Define the SAP Application Server Instance.
 */
export interface GetSAPApplicationServerInstanceResult {
    /**
     * Defines the Application Instance errors.
     */
    readonly errors: outputs.workloads.SAPVirtualInstanceErrorResponse;
    /**
     * The application server gateway Port.
     */
    readonly gatewayPort: number;
    /**
     * Defines the SAP Instance health.
     */
    readonly health: string;
    /**
     * The application server SAP host name.
     */
    readonly hostname: string;
    /**
     * The application server ICM HTTP Port.
     */
    readonly icmHttpPort: number;
    /**
     * The application server ICM HTTPS Port.
     */
    readonly icmHttpsPort: number;
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The application server instance id.
     */
    readonly instanceNo: string;
    /**
     * The application server SAP IP Address.
     */
    readonly ipAddress: string;
    /**
     * The application server SAP kernel patch.
     */
    readonly kernelPatch: string;
    /**
     * The application server SAP kernel version.
     */
    readonly kernelVersion: string;
    /**
     * The geo-location where the resource lives
     */
    readonly location: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Defines the provisioning states.
     */
    readonly provisioningState: string;
    /**
     * Defines the SAP Instance status.
     */
    readonly status: string;
    /**
     * The application server subnet.
     */
    readonly subnet: string;
    /**
     * Azure Resource Manager metadata containing createdBy and modifiedBy information.
     */
    readonly systemData: outputs.workloads.SystemDataResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
    /**
     * The virtual machine.
     */
    readonly virtualMachineId: string;
}

export function getSAPApplicationServerInstanceOutput(args: GetSAPApplicationServerInstanceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSAPApplicationServerInstanceResult> {
    return pulumi.output(args).apply(a => getSAPApplicationServerInstance(a, opts))
}

export interface GetSAPApplicationServerInstanceOutputArgs {
    /**
     * The name of SAP Application Server instance.
     */
    applicationInstanceName: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the Virtual Instances for SAP.
     */
    sapVirtualInstanceName: pulumi.Input<string>;
}
