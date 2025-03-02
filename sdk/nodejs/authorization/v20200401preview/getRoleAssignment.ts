// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * Role Assignments
 */
export function getRoleAssignment(args: GetRoleAssignmentArgs, opts?: pulumi.InvokeOptions): Promise<GetRoleAssignmentResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:authorization/v20200401preview:getRoleAssignment", {
        "roleAssignmentName": args.roleAssignmentName,
        "scope": args.scope,
        "tenantId": args.tenantId,
    }, opts);
}

export interface GetRoleAssignmentArgs {
    /**
     * The name of the role assignment to get.
     */
    roleAssignmentName: string;
    /**
     * The scope of the role assignment.
     */
    scope: string;
    /**
     * Tenant ID for cross-tenant request
     */
    tenantId?: string;
}

/**
 * Role Assignments
 */
export interface GetRoleAssignmentResult {
    /**
     * The Delegation flag for the role assignment
     */
    readonly canDelegate?: boolean;
    /**
     * The conditions on the role assignment. This limits the resources it can be assigned to. e.g.: @Resource[Microsoft.Storage/storageAccounts/blobServices/containers:ContainerName] StringEqualsIgnoreCase 'foo_storage_container'
     */
    readonly condition?: string;
    /**
     * Version of the condition. Currently accepted value is '2.0'
     */
    readonly conditionVersion?: string;
    /**
     * Id of the user who created the assignment
     */
    readonly createdBy?: string;
    /**
     * Time it was created
     */
    readonly createdOn?: string;
    /**
     * Id of the delegated managed identity resource
     */
    readonly delegatedManagedIdentityResourceId?: string;
    /**
     * Description of role assignment
     */
    readonly description?: string;
    /**
     * The role assignment ID.
     */
    readonly id: string;
    /**
     * The role assignment name.
     */
    readonly name: string;
    /**
     * The principal ID.
     */
    readonly principalId?: string;
    /**
     * The principal type of the assigned principal ID.
     */
    readonly principalType?: string;
    /**
     * The role definition ID.
     */
    readonly roleDefinitionId?: string;
    /**
     * The role assignment scope.
     */
    readonly scope?: string;
    /**
     * The role assignment type.
     */
    readonly type: string;
    /**
     * Id of the user who updated the assignment
     */
    readonly updatedBy?: string;
    /**
     * Time it was updated
     */
    readonly updatedOn?: string;
}

export function getRoleAssignmentOutput(args: GetRoleAssignmentOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetRoleAssignmentResult> {
    return pulumi.output(args).apply(a => getRoleAssignment(a, opts))
}

export interface GetRoleAssignmentOutputArgs {
    /**
     * The name of the role assignment to get.
     */
    roleAssignmentName: pulumi.Input<string>;
    /**
     * The scope of the role assignment.
     */
    scope: pulumi.Input<string>;
    /**
     * Tenant ID for cross-tenant request
     */
    tenantId?: pulumi.Input<string>;
}
