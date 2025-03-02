// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../types";
import * as utilities from "../utilities";

/**
 * A new Sas token which can be used to access the Maps REST APIs and is controlled by the specified Managed identity permissions on Azure (IAM) Role Based Access Control.
 * API Version: 2021-12-01-preview.
 */
export function listAccountSas(args: ListAccountSasArgs, opts?: pulumi.InvokeOptions): Promise<ListAccountSasResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:maps:listAccountSas", {
        "accountName": args.accountName,
        "expiry": args.expiry,
        "maxRatePerSecond": args.maxRatePerSecond,
        "principalId": args.principalId,
        "regions": args.regions,
        "resourceGroupName": args.resourceGroupName,
        "signingKey": args.signingKey,
        "start": args.start,
    }, opts);
}

export interface ListAccountSasArgs {
    /**
     * The name of the Maps Account.
     */
    accountName: string;
    /**
     * The date time offset of when the token validity expires. For example "2017-05-24T10:42:03.1567373Z"
     */
    expiry: string;
    /**
     * Required parameter which represents the desired maximum request per second to allowed for the given SAS token. This does not guarantee perfect accuracy in measurements but provides application safe guards of abuse with eventual enforcement.
     */
    maxRatePerSecond: number;
    /**
     * The principal Id also known as the object Id of a User Assigned Managed Identity currently assigned to the Map Account. To assign a Managed Identity of the account, use operation Create or Update an assign a User Assigned Identity resource Id.
     */
    principalId: string;
    /**
     * Optional, allows control of which region locations are permitted access to Azure Maps REST APIs with the SAS token. Example: "eastus", "westus2". Omitting this parameter will allow all region locations to be accessible.
     */
    regions?: string[];
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: string;
    /**
     * The Map account key to use for signing.
     */
    signingKey: string | enums.maps.SigningKey;
    /**
     * The date time offset of when the token validity begins. For example "2017-05-24T10:42:03.1567373Z".
     */
    start: string;
}

/**
 * A new Sas token which can be used to access the Maps REST APIs and is controlled by the specified Managed identity permissions on Azure (IAM) Role Based Access Control.
 */
export interface ListAccountSasResult {
    /**
     * The shared access signature access token.
     */
    readonly accountSasToken: string;
}

export function listAccountSasOutput(args: ListAccountSasOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<ListAccountSasResult> {
    return pulumi.output(args).apply(a => listAccountSas(a, opts))
}

export interface ListAccountSasOutputArgs {
    /**
     * The name of the Maps Account.
     */
    accountName: pulumi.Input<string>;
    /**
     * The date time offset of when the token validity expires. For example "2017-05-24T10:42:03.1567373Z"
     */
    expiry: pulumi.Input<string>;
    /**
     * Required parameter which represents the desired maximum request per second to allowed for the given SAS token. This does not guarantee perfect accuracy in measurements but provides application safe guards of abuse with eventual enforcement.
     */
    maxRatePerSecond: pulumi.Input<number>;
    /**
     * The principal Id also known as the object Id of a User Assigned Managed Identity currently assigned to the Map Account. To assign a Managed Identity of the account, use operation Create or Update an assign a User Assigned Identity resource Id.
     */
    principalId: pulumi.Input<string>;
    /**
     * Optional, allows control of which region locations are permitted access to Azure Maps REST APIs with the SAS token. Example: "eastus", "westus2". Omitting this parameter will allow all region locations to be accessible.
     */
    regions?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The Map account key to use for signing.
     */
    signingKey: pulumi.Input<string | enums.maps.SigningKey>;
    /**
     * The date time offset of when the token validity begins. For example "2017-05-24T10:42:03.1567373Z".
     */
    start: pulumi.Input<string>;
}
