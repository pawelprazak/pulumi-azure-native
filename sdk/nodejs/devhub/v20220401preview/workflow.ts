// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Resource representation of a workflow
 */
export class Workflow extends pulumi.CustomResource {
    /**
     * Get an existing Workflow resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): Workflow {
        return new Workflow(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:devhub/v20220401preview:Workflow';

    /**
     * Returns true if the given object is an instance of Workflow.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Workflow {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Workflow.__pulumiType;
    }

    /**
     * Information on the azure container registry
     */
    public readonly acr!: pulumi.Output<outputs.devhub.v20220401preview.ACRResponse | undefined>;
    /**
     * The Azure Kubernetes Cluster Resource the application will be deployed to.
     */
    public readonly aksResourceId!: pulumi.Output<string | undefined>;
    /**
     * Determines the authorization status of requests.
     */
    public /*out*/ readonly authStatus!: pulumi.Output<string>;
    /**
     * Repository Branch Name
     */
    public readonly branchName!: pulumi.Output<string | undefined>;
    public readonly deploymentProperties!: pulumi.Output<outputs.devhub.v20220401preview.DeploymentPropertiesResponse | undefined>;
    /**
     * Path to Dockerfile Build Context within the repository.
     */
    public readonly dockerBuildContext!: pulumi.Output<string | undefined>;
    /**
     * Path to the Dockerfile within the repository.
     */
    public readonly dockerfile!: pulumi.Output<string | undefined>;
    public /*out*/ readonly lastWorkflowRun!: pulumi.Output<outputs.devhub.v20220401preview.WorkflowRunResponse | undefined>;
    /**
     * The geo-location where the resource lives
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the resource
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * Kubernetes namespace the application is deployed to.
     */
    public readonly namespace!: pulumi.Output<string | undefined>;
    /**
     * The fields needed for OIDC with GitHub.
     */
    public readonly oidcCredentials!: pulumi.Output<outputs.devhub.v20220401preview.GitHubWorkflowProfileResponseOidcCredentials | undefined>;
    /**
     * The status of the Pull Request submitted against the users repository.
     */
    public /*out*/ readonly prStatus!: pulumi.Output<string>;
    /**
     * The URL to the Pull Request submitted against the users repository.
     */
    public /*out*/ readonly prURL!: pulumi.Output<string>;
    /**
     * The number associated with the submitted pull request.
     */
    public /*out*/ readonly pullNumber!: pulumi.Output<number>;
    /**
     * Repository Name
     */
    public readonly repositoryName!: pulumi.Output<string | undefined>;
    /**
     * Repository Owner
     */
    public readonly repositoryOwner!: pulumi.Output<string | undefined>;
    /**
     * Azure Resource Manager metadata containing createdBy and modifiedBy information.
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.devhub.v20220401preview.SystemDataResponse>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a Workflow resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WorkflowArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            resourceInputs["acr"] = args ? args.acr : undefined;
            resourceInputs["aksResourceId"] = args ? args.aksResourceId : undefined;
            resourceInputs["branchName"] = args ? args.branchName : undefined;
            resourceInputs["deploymentProperties"] = args ? args.deploymentProperties : undefined;
            resourceInputs["dockerBuildContext"] = args ? args.dockerBuildContext : undefined;
            resourceInputs["dockerfile"] = args ? args.dockerfile : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["namespace"] = args ? args.namespace : undefined;
            resourceInputs["oidcCredentials"] = args ? args.oidcCredentials : undefined;
            resourceInputs["repositoryName"] = args ? args.repositoryName : undefined;
            resourceInputs["repositoryOwner"] = args ? args.repositoryOwner : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["workflowName"] = args ? args.workflowName : undefined;
            resourceInputs["authStatus"] = undefined /*out*/;
            resourceInputs["lastWorkflowRun"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["prStatus"] = undefined /*out*/;
            resourceInputs["prURL"] = undefined /*out*/;
            resourceInputs["pullNumber"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["acr"] = undefined /*out*/;
            resourceInputs["aksResourceId"] = undefined /*out*/;
            resourceInputs["authStatus"] = undefined /*out*/;
            resourceInputs["branchName"] = undefined /*out*/;
            resourceInputs["deploymentProperties"] = undefined /*out*/;
            resourceInputs["dockerBuildContext"] = undefined /*out*/;
            resourceInputs["dockerfile"] = undefined /*out*/;
            resourceInputs["lastWorkflowRun"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["namespace"] = undefined /*out*/;
            resourceInputs["oidcCredentials"] = undefined /*out*/;
            resourceInputs["prStatus"] = undefined /*out*/;
            resourceInputs["prURL"] = undefined /*out*/;
            resourceInputs["pullNumber"] = undefined /*out*/;
            resourceInputs["repositoryName"] = undefined /*out*/;
            resourceInputs["repositoryOwner"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:devhub:Workflow" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(Workflow.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a Workflow resource.
 */
export interface WorkflowArgs {
    /**
     * Information on the azure container registry
     */
    acr?: pulumi.Input<inputs.devhub.v20220401preview.ACRArgs>;
    /**
     * The Azure Kubernetes Cluster Resource the application will be deployed to.
     */
    aksResourceId?: pulumi.Input<string>;
    /**
     * Repository Branch Name
     */
    branchName?: pulumi.Input<string>;
    deploymentProperties?: pulumi.Input<inputs.devhub.v20220401preview.DeploymentPropertiesArgs>;
    /**
     * Path to Dockerfile Build Context within the repository.
     */
    dockerBuildContext?: pulumi.Input<string>;
    /**
     * Path to the Dockerfile within the repository.
     */
    dockerfile?: pulumi.Input<string>;
    /**
     * The geo-location where the resource lives
     */
    location?: pulumi.Input<string>;
    /**
     * Kubernetes namespace the application is deployed to.
     */
    namespace?: pulumi.Input<string>;
    /**
     * The fields needed for OIDC with GitHub.
     */
    oidcCredentials?: pulumi.Input<inputs.devhub.v20220401preview.GitHubWorkflowProfileOidcCredentialsArgs>;
    /**
     * Repository Name
     */
    repositoryName?: pulumi.Input<string>;
    /**
     * Repository Owner
     */
    repositoryOwner?: pulumi.Input<string>;
    /**
     * The name of the resource group. The name is case insensitive.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the workflow resource.
     */
    workflowName?: pulumi.Input<string>;
}
