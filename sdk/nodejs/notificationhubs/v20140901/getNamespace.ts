// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Description of a Namespace resource.
 */
/** @deprecated Version 2014-09-01 will be removed in v2 of the provider. */
export function getNamespace(args: GetNamespaceArgs, opts?: pulumi.InvokeOptions): Promise<GetNamespaceResult> {
    pulumi.log.warn("getNamespace is deprecated: Version 2014-09-01 will be removed in v2 of the provider.")
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:notificationhubs/v20140901:getNamespace", {
        "namespaceName": args.namespaceName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetNamespaceArgs {
    /**
     * The namespace name.
     */
    namespaceName: string;
    /**
     * The name of the resource group.
     */
    resourceGroupName: string;
}

/**
 * Description of a Namespace resource.
 */
export interface GetNamespaceResult {
    /**
     * Gets or sets the id of the created Namespace.
     */
    readonly id?: string;
    /**
     * Gets or sets datacenter location of the Namespace.
     */
    readonly location?: string;
    /**
     * Gets or sets name of the Namespace.
     */
    readonly name?: string;
    /**
     * Gets or sets properties of the Namespace.
     */
    readonly properties: outputs.notificationhubs.v20140901.NamespacePropertiesResponse;
    /**
     * Gets or sets tags of the Namespace.
     */
    readonly tags?: {[key: string]: string};
    /**
     * Gets or sets resource type of the Namespace.
     */
    readonly type?: string;
}

export function getNamespaceOutput(args: GetNamespaceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetNamespaceResult> {
    return pulumi.output(args).apply(a => getNamespace(a, opts))
}

export interface GetNamespaceOutputArgs {
    /**
     * The namespace name.
     */
    namespaceName: pulumi.Input<string>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
}
