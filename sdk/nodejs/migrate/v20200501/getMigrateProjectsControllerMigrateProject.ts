// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Migrate project.
 */
export function getMigrateProjectsControllerMigrateProject(args: GetMigrateProjectsControllerMigrateProjectArgs, opts?: pulumi.InvokeOptions): Promise<GetMigrateProjectsControllerMigrateProjectResult> {
    if (!opts) {
        opts = {}
    }

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
    return pulumi.runtime.invoke("azure-native:migrate/v20200501:getMigrateProjectsControllerMigrateProject", {
        "migrateProjectName": args.migrateProjectName,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

export interface GetMigrateProjectsControllerMigrateProjectArgs {
    /**
     * Migrate project name.
     */
    migrateProjectName: string;
    /**
     * Name of the Azure Resource Group that project is part of.
     */
    resourceGroupName: string;
}

/**
 * Migrate project.
 */
export interface GetMigrateProjectsControllerMigrateProjectResult {
    /**
     * For optimistic concurrency control.
     */
    readonly eTag?: string;
    /**
     * Path reference to this project /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/migrateProjects/{projectName}
     */
    readonly id: string;
    /**
     * Azure location in which project is created.
     */
    readonly location?: string;
    /**
     * Name of the project.
     */
    readonly name: string;
    /**
     * Properties of a migrate project.
     */
    readonly properties: outputs.migrate.v20200501.MigrateProjectPropertiesResponse;
    /**
     * Metadata pertaining to creation and last modification of the resource.
     */
    readonly systemData: outputs.migrate.v20200501.SystemDataResponse;
    /**
     * Type of the object = [Microsoft.Migrate/migrateProjects].
     */
    readonly type: string;
}

export function getMigrateProjectsControllerMigrateProjectOutput(args: GetMigrateProjectsControllerMigrateProjectOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetMigrateProjectsControllerMigrateProjectResult> {
    return pulumi.output(args).apply(a => getMigrateProjectsControllerMigrateProject(a, opts))
}

export interface GetMigrateProjectsControllerMigrateProjectOutputArgs {
    /**
     * Migrate project name.
     */
    migrateProjectName: pulumi.Input<string>;
    /**
     * Name of the Azure Resource Group that project is part of.
     */
    resourceGroupName: pulumi.Input<string>;
}
