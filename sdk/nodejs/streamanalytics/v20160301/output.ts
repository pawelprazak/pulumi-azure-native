// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * An output object, containing all information associated with the named output. All outputs are contained under a streaming job.
 */
export class Output extends pulumi.CustomResource {
    /**
     * Get an existing Output resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Output {
        return new Output(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:streamanalytics/v20160301:Output';

    /**
     * Returns true if the given object is an instance of Output.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Output {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Output.__pulumiType;
    }

    /**
     * Describes the data source that output will be written to. Required on PUT (CreateOrReplace) requests.
     */
    public readonly datasource!: pulumi.Output<outputs.streamanalytics.v20160301.AzureDataLakeStoreOutputDataSourceResponse | outputs.streamanalytics.v20160301.AzureSqlDatabaseOutputDataSourceResponse | outputs.streamanalytics.v20160301.AzureTableOutputDataSourceResponse | outputs.streamanalytics.v20160301.BlobOutputDataSourceResponse | outputs.streamanalytics.v20160301.DocumentDbOutputDataSourceResponse | outputs.streamanalytics.v20160301.EventHubOutputDataSourceResponse | outputs.streamanalytics.v20160301.PowerBIOutputDataSourceResponse | outputs.streamanalytics.v20160301.ServiceBusQueueOutputDataSourceResponse | outputs.streamanalytics.v20160301.ServiceBusTopicOutputDataSourceResponse | undefined>;
    /**
     * Describes conditions applicable to the Input, Output, or the job overall, that warrant customer attention.
     */
    public /*out*/ readonly diagnostics!: pulumi.Output<outputs.streamanalytics.v20160301.DiagnosticsResponse>;
    /**
     * The current entity tag for the output. This is an opaque string. You can use it to detect whether the resource has changed between requests. You can also use it in the If-Match or If-None-Match headers for write operations for optimistic concurrency.
     */
    public /*out*/ readonly etag!: pulumi.Output<string>;
    /**
     * Resource name
     */
    public readonly name!: pulumi.Output<string | undefined>;
    /**
     * Describes how data from an input is serialized or how data is serialized when written to an output. Required on PUT (CreateOrReplace) requests.
     */
    public readonly serialization!: pulumi.Output<outputs.streamanalytics.v20160301.AvroSerializationResponse | outputs.streamanalytics.v20160301.CsvSerializationResponse | outputs.streamanalytics.v20160301.JsonSerializationResponse | undefined>;
    /**
     * Resource type
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Output resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: OutputArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.jobName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'jobName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["datasource"] = args ? args.datasource : undefined;
            resourceInputs["jobName"] = args ? args.jobName : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["outputName"] = args ? args.outputName : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["serialization"] = args ? args.serialization : undefined;
            resourceInputs["diagnostics"] = undefined /*out*/;
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["datasource"] = undefined /*out*/;
            resourceInputs["diagnostics"] = undefined /*out*/;
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["serialization"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:streamanalytics:Output" }, { type: "azure-native:streamanalytics/v20170401preview:Output" }, { type: "azure-native:streamanalytics/v20200301:Output" }, { type: "azure-native:streamanalytics/v20211001preview:Output" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(Output.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Output resource.
 */
export interface OutputArgs {
    /**
     * Describes the data source that output will be written to. Required on PUT (CreateOrReplace) requests.
     */
    datasource?: pulumi.Input<inputs.streamanalytics.v20160301.AzureDataLakeStoreOutputDataSourceArgs | inputs.streamanalytics.v20160301.AzureSqlDatabaseOutputDataSourceArgs | inputs.streamanalytics.v20160301.AzureTableOutputDataSourceArgs | inputs.streamanalytics.v20160301.BlobOutputDataSourceArgs | inputs.streamanalytics.v20160301.DocumentDbOutputDataSourceArgs | inputs.streamanalytics.v20160301.EventHubOutputDataSourceArgs | inputs.streamanalytics.v20160301.PowerBIOutputDataSourceArgs | inputs.streamanalytics.v20160301.ServiceBusQueueOutputDataSourceArgs | inputs.streamanalytics.v20160301.ServiceBusTopicOutputDataSourceArgs>;
    /**
     * The name of the streaming job.
     */
    jobName: pulumi.Input<string>;
    /**
     * Resource name
     */
    name?: pulumi.Input<string>;
    /**
     * The name of the output.
     */
    outputName?: pulumi.Input<string>;
    /**
     * The name of the resource group that contains the resource. You can obtain this value from the Azure Resource Manager API or the portal.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Describes how data from an input is serialized or how data is serialized when written to an output. Required on PUT (CreateOrReplace) requests.
     */
    serialization?: pulumi.Input<inputs.streamanalytics.v20160301.AvroSerializationArgs | inputs.streamanalytics.v20160301.CsvSerializationArgs | inputs.streamanalytics.v20160301.JsonSerializationArgs>;
}
