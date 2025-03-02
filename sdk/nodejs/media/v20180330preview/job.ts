// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * A Job resource type. The progress and state can be obtained by polling a Job or subscribing to events using EventGrid.
 */
export class Job extends pulumi.CustomResource {
    /**
     * Get an existing Job resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Job {
        return new Job(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:media/v20180330preview:Job';

    /**
     * Returns true if the given object is an instance of Job.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Job {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Job.__pulumiType;
    }

    /**
     * The UTC date and time when the Job was created, in 'YYYY-MM-DDThh:mm:ssZ' format.
     */
    public /*out*/ readonly created!: pulumi.Output<string>;
    /**
     * Optional customer supplied description of the Job.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The inputs for the Job.
     */
    public readonly input!: pulumi.Output<outputs.media.v20180330preview.JobInputAssetResponse | outputs.media.v20180330preview.JobInputClipResponse | outputs.media.v20180330preview.JobInputHttpResponse | outputs.media.v20180330preview.JobInputsResponse>;
    /**
     * The UTC date and time when the Job was last updated, in 'YYYY-MM-DDThh:mm:ssZ' format.
     */
    public /*out*/ readonly lastModified!: pulumi.Output<string>;
    /**
     * The name of the resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The outputs for the Job.
     */
    public readonly outputs!: pulumi.Output<outputs.media.v20180330preview.JobOutputAssetResponse[]>;
    /**
     * Priority with which the job should be processed. Higher priority jobs are processed before lower priority jobs. If not set, the default is normal.
     */
    public readonly priority!: pulumi.Output<string | undefined>;
    /**
     * The current state of the job.
     */
    public /*out*/ readonly state!: pulumi.Output<string>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Job resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: JobArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.accountName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'accountName'");
            }
            if ((!args || args.input === undefined) && !opts.urn) {
                throw new Error("Missing required property 'input'");
            }
            if ((!args || args.outputs === undefined) && !opts.urn) {
                throw new Error("Missing required property 'outputs'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.transformName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'transformName'");
            }
            resourceInputs["accountName"] = args ? args.accountName : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["input"] = args ? args.input : undefined;
            resourceInputs["jobName"] = args ? args.jobName : undefined;
            resourceInputs["outputs"] = args ? args.outputs : undefined;
            resourceInputs["priority"] = args ? args.priority : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["transformName"] = args ? args.transformName : undefined;
            resourceInputs["created"] = undefined /*out*/;
            resourceInputs["lastModified"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["state"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["created"] = undefined /*out*/;
            resourceInputs["description"] = undefined /*out*/;
            resourceInputs["input"] = undefined /*out*/;
            resourceInputs["lastModified"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["outputs"] = undefined /*out*/;
            resourceInputs["priority"] = undefined /*out*/;
            resourceInputs["state"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:media:Job" }, { type: "azure-native:media/v20180601preview:Job" }, { type: "azure-native:media/v20180701:Job" }, { type: "azure-native:media/v20200501:Job" }, { type: "azure-native:media/v20210601:Job" }, { type: "azure-native:media/v20211101:Job" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(Job.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Job resource.
 */
export interface JobArgs {
    /**
     * The Media Services account name.
     */
    accountName: pulumi.Input<string>;
    /**
     * Optional customer supplied description of the Job.
     */
    description?: pulumi.Input<string>;
    /**
     * The inputs for the Job.
     */
    input: pulumi.Input<inputs.media.v20180330preview.JobInputAssetArgs | inputs.media.v20180330preview.JobInputClipArgs | inputs.media.v20180330preview.JobInputHttpArgs | inputs.media.v20180330preview.JobInputsArgs>;
    /**
     * The Job name.
     */
    jobName?: pulumi.Input<string>;
    /**
     * The outputs for the Job.
     */
    outputs: pulumi.Input<pulumi.Input<inputs.media.v20180330preview.JobOutputAssetArgs>[]>;
    /**
     * Priority with which the job should be processed. Higher priority jobs are processed before lower priority jobs. If not set, the default is normal.
     */
    priority?: pulumi.Input<string | enums.media.v20180330preview.Priority>;
    /**
     * The name of the resource group within the Azure subscription.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The Transform name.
     */
    transformName: pulumi.Input<string>;
}
