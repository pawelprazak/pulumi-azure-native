// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * IoT Connector definition.
 */
export function getIotConnector(args: GetIotConnectorArgs, opts?: pulumi.InvokeOptions): Promise<GetIotConnectorResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:healthcareapis/v20210601preview:getIotConnector", {
        "iotConnectorName": args.iotConnectorName,
        "resourceGroupName": args.resourceGroupName,
        "workspaceName": args.workspaceName,
    }, opts);
}

export interface GetIotConnectorArgs {
    /**
     * The name of IoT Connector resource.
     */
    iotConnectorName: string;
    /**
     * The name of the resource group that contains the service instance.
     */
    resourceGroupName: string;
    /**
     * The name of workspace resource.
     */
    workspaceName: string;
}

/**
 * IoT Connector definition.
 */
export interface GetIotConnectorResult {
    /**
     * Device Mappings.
     */
    readonly deviceMapping?: outputs.healthcareapis.v20210601preview.IotMappingPropertiesResponse;
    /**
     * An etag associated with the resource, used for optimistic concurrency when editing it.
     */
    readonly etag?: string;
    /**
     * The resource identifier.
     */
    readonly id: string;
    /**
     * Setting indicating whether the service has a managed identity associated with it.
     */
    readonly identity?: outputs.healthcareapis.v20210601preview.ServiceManagedIdentityResponseIdentity;
    /**
     * Source configuration.
     */
    readonly ingestionEndpointConfiguration?: outputs.healthcareapis.v20210601preview.IotEventHubIngestionEndpointConfigurationResponse;
    /**
     * The resource location.
     */
    readonly location?: string;
    /**
     * The resource name.
     */
    readonly name: string;
    /**
     * The provisioning state.
     */
    readonly provisioningState: string;
    /**
     * Metadata pertaining to creation and last modification of the resource.
     */
    readonly systemData: outputs.healthcareapis.v20210601preview.SystemDataResponse;
    /**
     * Resource tags.
     */
    readonly tags?: {[key: string]: string};
    /**
     * The resource type.
     */
    readonly type: string;
}

export function getIotConnectorOutput(args: GetIotConnectorOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetIotConnectorResult> {
    return pulumi.output(args).apply(a => getIotConnector(a, opts))
}

export interface GetIotConnectorOutputArgs {
    /**
     * The name of IoT Connector resource.
     */
    iotConnectorName: pulumi.Input<string>;
    /**
     * The name of the resource group that contains the service instance.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of workspace resource.
     */
    workspaceName: pulumi.Input<string>;
}
