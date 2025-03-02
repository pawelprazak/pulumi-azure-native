// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Result of on demand test probe
 */
export function getApplicationGatewayBackendHealthOnDemand(args: GetApplicationGatewayBackendHealthOnDemandArgs, opts?: pulumi.InvokeOptions): Promise<GetApplicationGatewayBackendHealthOnDemandResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:network/v20190201:getApplicationGatewayBackendHealthOnDemand", {
        "applicationGatewayName": args.applicationGatewayName,
        "backendAddressPool": args.backendAddressPool,
        "backendHttpSettings": args.backendHttpSettings,
        "expand": args.expand,
        "host": args.host,
        "match": args.match,
        "path": args.path,
        "pickHostNameFromBackendHttpSettings": args.pickHostNameFromBackendHttpSettings,
        "protocol": args.protocol,
        "resourceGroupName": args.resourceGroupName,
        "timeout": args.timeout,
    }, opts);
}

export interface GetApplicationGatewayBackendHealthOnDemandArgs {
    /**
     * The name of the application gateway.
     */
    applicationGatewayName: string;
    /**
     * Reference of backend pool of application gateway to which probe request will be sent.
     */
    backendAddressPool?: inputs.network.v20190201.SubResource;
    /**
     * Reference of backend http setting of application gateway to be used for test probe.
     */
    backendHttpSettings?: inputs.network.v20190201.SubResource;
    /**
     * Expands BackendAddressPool and BackendHttpSettings referenced in backend health.
     */
    expand?: string;
    /**
     * Host name to send the probe to.
     */
    host?: string;
    /**
     * Criterion for classifying a healthy probe response.
     */
    match?: inputs.network.v20190201.ApplicationGatewayProbeHealthResponseMatch;
    /**
     * Relative path of probe. Valid path starts from '/'. Probe is sent to <Protocol>://<host>:<port><path>
     */
    path?: string;
    /**
     * Whether the host header should be picked from the backend http settings. Default value is false.
     */
    pickHostNameFromBackendHttpSettings?: boolean;
    /**
     * The protocol used for the probe.
     */
    protocol?: string | enums.network.v20190201.ApplicationGatewayProtocol;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
    /**
     * The probe timeout in seconds. Probe marked as failed if valid response is not received with this timeout period. Acceptable values are from 1 second to 86400 seconds.
     */
    timeout?: number;
}

/**
 * Result of on demand test probe
 */
export interface GetApplicationGatewayBackendHealthOnDemandResult {
    /**
     * Reference of an ApplicationGatewayBackendAddressPool resource.
     */
    readonly backendAddressPool?: outputs.network.v20190201.ApplicationGatewayBackendAddressPoolResponse;
    /**
     * Application gateway BackendHealthHttp settings.
     */
    readonly backendHealthHttpSettings?: outputs.network.v20190201.ApplicationGatewayBackendHealthHttpSettingsResponse;
}

export function getApplicationGatewayBackendHealthOnDemandOutput(args: GetApplicationGatewayBackendHealthOnDemandOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetApplicationGatewayBackendHealthOnDemandResult> {
    return pulumi.output(args).apply(a => getApplicationGatewayBackendHealthOnDemand(a, opts))
}

export interface GetApplicationGatewayBackendHealthOnDemandOutputArgs {
    /**
     * The name of the application gateway.
     */
    applicationGatewayName: pulumi.Input<string>;
    /**
     * Reference of backend pool of application gateway to which probe request will be sent.
     */
    backendAddressPool?: pulumi.Input<inputs.network.v20190201.SubResourceArgs>;
    /**
     * Reference of backend http setting of application gateway to be used for test probe.
     */
    backendHttpSettings?: pulumi.Input<inputs.network.v20190201.SubResourceArgs>;
    /**
     * Expands BackendAddressPool and BackendHttpSettings referenced in backend health.
     */
    expand?: pulumi.Input<string>;
    /**
     * Host name to send the probe to.
     */
    host?: pulumi.Input<string>;
    /**
     * Criterion for classifying a healthy probe response.
     */
    match?: pulumi.Input<inputs.network.v20190201.ApplicationGatewayProbeHealthResponseMatchArgs>;
    /**
     * Relative path of probe. Valid path starts from '/'. Probe is sent to <Protocol>://<host>:<port><path>
     */
    path?: pulumi.Input<string>;
    /**
     * Whether the host header should be picked from the backend http settings. Default value is false.
     */
    pickHostNameFromBackendHttpSettings?: pulumi.Input<boolean>;
    /**
     * The protocol used for the probe.
     */
    protocol?: pulumi.Input<string | enums.network.v20190201.ApplicationGatewayProtocol>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The probe timeout in seconds. Probe marked as failed if valid response is not received with this timeout period. Acceptable values are from 1 second to 86400 seconds.
     */
    timeout?: pulumi.Input<number>;
}
