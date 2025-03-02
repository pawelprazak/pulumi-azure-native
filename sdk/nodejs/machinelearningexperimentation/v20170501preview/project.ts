// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../../utilities";

/**
 * An object that represents a machine learning project.
 */
export class Project extends pulumi.CustomResource {
    /**
     * Get an existing Project resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Project {
        return new Project(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:machinelearningexperimentation/v20170501preview:Project';

    /**
     * Returns true if the given object is an instance of Project.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Project {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Project.__pulumiType;
    }

    /**
     * The immutable id of the team account which contains this project.
     */
    public /*out*/ readonly accountId!: pulumi.Output<string>;
    /**
     * The creation date of the project in ISO8601 format.
     */
    public /*out*/ readonly creationDate!: pulumi.Output<string>;
    /**
     * The description of this project.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The friendly name for this project.
     */
    public readonly friendlyName!: pulumi.Output<string>;
    /**
     * The reference to git repo for this project.
     */
    public readonly gitrepo!: pulumi.Output<string | undefined>;
    /**
     * The location of the resource. This cannot be changed after the resource is created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the resource.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The immutable id of this project.
     */
    public /*out*/ readonly projectId!: pulumi.Output<string>;
    /**
     * The current deployment state of project resource. The provisioningState is to indicate states for resource provisioning.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The tags of the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * The immutable id of the workspace which contains this project.
     */
    public /*out*/ readonly workspaceId!: pulumi.Output<string>;

    /**
     * Create a Project resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ProjectArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.accountName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'accountName'");
            }
            if ((!args || args.friendlyName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'friendlyName'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.workspaceName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'workspaceName'");
            }
            resourceInputs["accountName"] = args ? args.accountName : undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["friendlyName"] = args ? args.friendlyName : undefined;
            resourceInputs["gitrepo"] = args ? args.gitrepo : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["projectName"] = args ? args.projectName : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["workspaceName"] = args ? args.workspaceName : undefined;
            resourceInputs["accountId"] = undefined /*out*/;
            resourceInputs["creationDate"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["projectId"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["workspaceId"] = undefined /*out*/;
        } else {
            resourceInputs["accountId"] = undefined /*out*/;
            resourceInputs["creationDate"] = undefined /*out*/;
            resourceInputs["description"] = undefined /*out*/;
            resourceInputs["friendlyName"] = undefined /*out*/;
            resourceInputs["gitrepo"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["projectId"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["workspaceId"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:machinelearningexperimentation:Project" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(Project.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Project resource.
 */
export interface ProjectArgs {
    /**
     * The name of the machine learning team account.
     */
    accountName: pulumi.Input<string>;
    /**
     * The description of this project.
     */
    description?: pulumi.Input<string>;
    /**
     * The friendly name for this project.
     */
    friendlyName: pulumi.Input<string>;
    /**
     * The reference to git repo for this project.
     */
    gitrepo?: pulumi.Input<string>;
    /**
     * The location of the resource. This cannot be changed after the resource is created.
     */
    location?: pulumi.Input<string>;
    /**
     * The name of the machine learning project under a team account workspace.
     */
    projectName?: pulumi.Input<string>;
    /**
     * The name of the resource group to which the machine learning team account belongs.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The tags of the resource.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the machine learning team account workspace.
     */
    workspaceName: pulumi.Input<string>;
}
