// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

// Export members:
export * from "./cassandraCluster";
export * from "./cassandraDataCenter";
export * from "./cassandraResourceCassandraKeyspace";
export * from "./cassandraResourceCassandraTable";
export * from "./databaseAccount";
export * from "./getCassandraCluster";
export * from "./getCassandraDataCenter";
export * from "./getCassandraResourceCassandraKeyspace";
export * from "./getCassandraResourceCassandraTable";
export * from "./getDatabaseAccount";
export * from "./getGremlinResourceGremlinDatabase";
export * from "./getGremlinResourceGremlinGraph";
export * from "./getMongoDBResourceMongoDBCollection";
export * from "./getMongoDBResourceMongoDBDatabase";
export * from "./getNotebookWorkspace";
export * from "./getPrivateEndpointConnection";
export * from "./getService";
export * from "./getSqlResourceSqlContainer";
export * from "./getSqlResourceSqlDatabase";
export * from "./getSqlResourceSqlRoleAssignment";
export * from "./getSqlResourceSqlRoleDefinition";
export * from "./getSqlResourceSqlStoredProcedure";
export * from "./getSqlResourceSqlTrigger";
export * from "./getSqlResourceSqlUserDefinedFunction";
export * from "./getTableResourceTable";
export * from "./gremlinResourceGremlinDatabase";
export * from "./gremlinResourceGremlinGraph";
export * from "./listDatabaseAccountConnectionStrings";
export * from "./listDatabaseAccountKeys";
export * from "./listNotebookWorkspaceConnectionInfo";
export * from "./mongoDBResourceMongoDBCollection";
export * from "./mongoDBResourceMongoDBDatabase";
export * from "./notebookWorkspace";
export * from "./privateEndpointConnection";
export * from "./service";
export * from "./sqlResourceSqlContainer";
export * from "./sqlResourceSqlDatabase";
export * from "./sqlResourceSqlRoleAssignment";
export * from "./sqlResourceSqlRoleDefinition";
export * from "./sqlResourceSqlStoredProcedure";
export * from "./sqlResourceSqlTrigger";
export * from "./sqlResourceSqlUserDefinedFunction";
export * from "./tableResourceTable";

// Export enums:
export * from "../../types/enums/documentdb/v20220515";

// Import resources to register:
import { CassandraCluster } from "./cassandraCluster";
import { CassandraDataCenter } from "./cassandraDataCenter";
import { CassandraResourceCassandraKeyspace } from "./cassandraResourceCassandraKeyspace";
import { CassandraResourceCassandraTable } from "./cassandraResourceCassandraTable";
import { DatabaseAccount } from "./databaseAccount";
import { GremlinResourceGremlinDatabase } from "./gremlinResourceGremlinDatabase";
import { GremlinResourceGremlinGraph } from "./gremlinResourceGremlinGraph";
import { MongoDBResourceMongoDBCollection } from "./mongoDBResourceMongoDBCollection";
import { MongoDBResourceMongoDBDatabase } from "./mongoDBResourceMongoDBDatabase";
import { NotebookWorkspace } from "./notebookWorkspace";
import { PrivateEndpointConnection } from "./privateEndpointConnection";
import { Service } from "./service";
import { SqlResourceSqlContainer } from "./sqlResourceSqlContainer";
import { SqlResourceSqlDatabase } from "./sqlResourceSqlDatabase";
import { SqlResourceSqlRoleAssignment } from "./sqlResourceSqlRoleAssignment";
import { SqlResourceSqlRoleDefinition } from "./sqlResourceSqlRoleDefinition";
import { SqlResourceSqlStoredProcedure } from "./sqlResourceSqlStoredProcedure";
import { SqlResourceSqlTrigger } from "./sqlResourceSqlTrigger";
import { SqlResourceSqlUserDefinedFunction } from "./sqlResourceSqlUserDefinedFunction";
import { TableResourceTable } from "./tableResourceTable";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:documentdb/v20220515:CassandraCluster":
                return new CassandraCluster(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:CassandraDataCenter":
                return new CassandraDataCenter(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:CassandraResourceCassandraKeyspace":
                return new CassandraResourceCassandraKeyspace(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:CassandraResourceCassandraTable":
                return new CassandraResourceCassandraTable(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:DatabaseAccount":
                return new DatabaseAccount(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:GremlinResourceGremlinDatabase":
                return new GremlinResourceGremlinDatabase(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:GremlinResourceGremlinGraph":
                return new GremlinResourceGremlinGraph(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:MongoDBResourceMongoDBCollection":
                return new MongoDBResourceMongoDBCollection(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:MongoDBResourceMongoDBDatabase":
                return new MongoDBResourceMongoDBDatabase(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:NotebookWorkspace":
                return new NotebookWorkspace(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:PrivateEndpointConnection":
                return new PrivateEndpointConnection(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:Service":
                return new Service(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:SqlResourceSqlContainer":
                return new SqlResourceSqlContainer(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:SqlResourceSqlDatabase":
                return new SqlResourceSqlDatabase(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:SqlResourceSqlRoleAssignment":
                return new SqlResourceSqlRoleAssignment(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:SqlResourceSqlRoleDefinition":
                return new SqlResourceSqlRoleDefinition(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:SqlResourceSqlStoredProcedure":
                return new SqlResourceSqlStoredProcedure(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:SqlResourceSqlTrigger":
                return new SqlResourceSqlTrigger(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:SqlResourceSqlUserDefinedFunction":
                return new SqlResourceSqlUserDefinedFunction(name, <any>undefined, { urn })
            case "azure-native:documentdb/v20220515:TableResourceTable":
                return new TableResourceTable(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "documentdb/v20220515", _module)
