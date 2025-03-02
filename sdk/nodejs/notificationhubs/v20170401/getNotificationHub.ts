// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Description of a NotificationHub Resource.
 */
export function getNotificationHub(args: GetNotificationHubArgs, opts?: pulumi.InvokeOptions): Promise<GetNotificationHubResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:notificationhubs/v20170401:getNotificationHub", {
        "namespaceName": args.namespaceName,
        "notificationHubName": args.notificationHubName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetNotificationHubArgs {
    /**
     * The namespace name.
     */
    namespaceName: string;
    /**
     * The notification hub name.
     */
    notificationHubName: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
}

/**
 * Description of a NotificationHub Resource.
 */
export interface GetNotificationHubResult {
    /**
     * The AdmCredential of the created NotificationHub
     */
    readonly admCredential?: outputs.notificationhubs.v20170401.AdmCredentialResponse;
    /**
     * The ApnsCredential of the created NotificationHub
     */
    readonly apnsCredential?: outputs.notificationhubs.v20170401.ApnsCredentialResponse;
    /**
     * The AuthorizationRules of the created NotificationHub
     */
    readonly authorizationRules?: outputs.notificationhubs.v20170401.SharedAccessAuthorizationRulePropertiesResponse[];
    /**
     * The BaiduCredential of the created NotificationHub
     */
    readonly baiduCredential?: outputs.notificationhubs.v20170401.BaiduCredentialResponse;
    /**
     * The GcmCredential of the created NotificationHub
     */
    readonly gcmCredential?: outputs.notificationhubs.v20170401.GcmCredentialResponse;
    /**
     * Resource Id
     */
    readonly id: string;
    /**
     * Resource location
     */
    readonly location?: string;
    /**
     * The MpnsCredential of the created NotificationHub
     */
    readonly mpnsCredential?: outputs.notificationhubs.v20170401.MpnsCredentialResponse;
    /**
     * Resource name
     */
    readonly name: string;
    /**
     * The RegistrationTtl of the created NotificationHub
     */
    readonly registrationTtl?: string;
    /**
     * The sku of the created namespace
     */
    readonly sku?: outputs.notificationhubs.v20170401.SkuResponse;
    /**
     * Resource tags
     */
    readonly tags?: {[key: string]: string};
    /**
     * Resource type
     */
    readonly type: string;
    /**
     * The WnsCredential of the created NotificationHub
     */
    readonly wnsCredential?: outputs.notificationhubs.v20170401.WnsCredentialResponse;
}

export function getNotificationHubOutput(args: GetNotificationHubOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetNotificationHubResult> {
    return pulumi.output(args).apply(a => getNotificationHub(a, opts))
}

export interface GetNotificationHubOutputArgs {
    /**
     * The namespace name.
     */
    namespaceName: pulumi.Input<string>;
    /**
     * The notification hub name.
     */
    notificationHubName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
}
