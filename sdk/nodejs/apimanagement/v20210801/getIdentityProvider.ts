// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Identity Provider details.
 */
export function getIdentityProvider(args: GetIdentityProviderArgs, opts?: pulumi.InvokeOptions): Promise<GetIdentityProviderResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:apimanagement/v20210801:getIdentityProvider", {
        "identityProviderName": args.identityProviderName,
        "resourceGroupName": args.resourceGroupName,
        "serviceName": args.serviceName,
    }, opts);
}

export interface GetIdentityProviderArgs {
    /**
     * Identity Provider Type identifier.
     */
    identityProviderName: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
    /**
     * The name of the API Management service.
     */
    serviceName: string;
}

/**
 * Identity Provider details.
 */
export interface GetIdentityProviderResult {
    /**
     * List of Allowed Tenants when configuring Azure Active Directory login.
     */
    readonly allowedTenants?: string[];
    /**
     * OpenID Connect discovery endpoint hostname for AAD or AAD B2C.
     */
    readonly authority?: string;
    /**
     * Client Id of the Application in the external Identity Provider. It is App ID for Facebook login, Client ID for Google login, App ID for Microsoft.
     */
    readonly clientId: string;
    /**
     * Client secret of the Application in external Identity Provider, used to authenticate login request. For example, it is App Secret for Facebook login, API Key for Google login, Public Key for Microsoft. This property will not be filled on 'GET' operations! Use '/listSecrets' POST request to get the value.
     */
    readonly clientSecret?: string;
    /**
     * Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
     */
    readonly id: string;
    /**
     * The name of the resource
     */
    readonly name: string;
    /**
     * Password Reset Policy Name. Only applies to AAD B2C Identity Provider.
     */
    readonly passwordResetPolicyName?: string;
    /**
     * Profile Editing Policy Name. Only applies to AAD B2C Identity Provider.
     */
    readonly profileEditingPolicyName?: string;
    /**
     * Signin Policy Name. Only applies to AAD B2C Identity Provider.
     */
    readonly signinPolicyName?: string;
    /**
     * The TenantId to use instead of Common when logging into Active Directory
     */
    readonly signinTenant?: string;
    /**
     * Signup Policy Name. Only applies to AAD B2C Identity Provider.
     */
    readonly signupPolicyName?: string;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    readonly type: string;
}

export function getIdentityProviderOutput(args: GetIdentityProviderOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetIdentityProviderResult> {
    return pulumi.output(args).apply(a => getIdentityProvider(a, opts))
}

export interface GetIdentityProviderOutputArgs {
    /**
     * Identity Provider Type identifier.
     */
    identityProviderName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the API Management service.
     */
    serviceName: pulumi.Input<string>;
}
