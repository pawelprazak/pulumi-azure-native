// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./databaseMigrationsSqlDb";
export * from "./file";
export * from "./getDatabaseMigrationsSqlDb";
export * from "./getFile";
export * from "./getProject";
export * from "./getService";
export * from "./getServiceTask";
export * from "./getSqlMigrationService";
export * from "./getTask";
export * from "./listSqlMigrationServiceAuthKeys";
export * from "./listSqlMigrationServiceMonitoringData";
export * from "./project";
export * from "./service";
export * from "./serviceTask";
export * from "./sqlMigrationService";
export * from "./task";

// Export enums:
export * from "../../types/enums/datamigration/v20220330preview";

// Import resources to register:
import { DatabaseMigrationsSqlDb } from "./databaseMigrationsSqlDb";
import { File } from "./file";
import { Project } from "./project";
import { Service } from "./service";
import { ServiceTask } from "./serviceTask";
import { SqlMigrationService } from "./sqlMigrationService";
import { Task } from "./task";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:datamigration/v20220330preview:DatabaseMigrationsSqlDb":
                return new DatabaseMigrationsSqlDb(name, <any>undefined, { urn })
            case "azure-native:datamigration/v20220330preview:File":
                return new File(name, <any>undefined, { urn })
            case "azure-native:datamigration/v20220330preview:Project":
                return new Project(name, <any>undefined, { urn })
            case "azure-native:datamigration/v20220330preview:Service":
                return new Service(name, <any>undefined, { urn })
            case "azure-native:datamigration/v20220330preview:ServiceTask":
                return new ServiceTask(name, <any>undefined, { urn })
            case "azure-native:datamigration/v20220330preview:SqlMigrationService":
                return new SqlMigrationService(name, <any>undefined, { urn })
            case "azure-native:datamigration/v20220330preview:Task":
                return new Task(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "datamigration/v20220330preview", _module)
