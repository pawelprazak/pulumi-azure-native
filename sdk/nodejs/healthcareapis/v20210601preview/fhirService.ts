// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * The description of Fhir Service
 */
export class FhirService extends pulumi.CustomResource {
    /**
     * Get an existing FhirService resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): FhirService {
        return new FhirService(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:healthcareapis/v20210601preview:FhirService';

    /**
     * Returns true if the given object is an instance of FhirService.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FhirService {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FhirService.__pulumiType;
    }

    /**
     * Fhir Service access policies.
     */
    public readonly accessPolicies!: pulumi.Output<outputs.healthcareapis.v20210601preview.FhirServiceAccessPolicyEntryResponse[] | undefined>;
    /**
     * Fhir Service Azure container registry configuration.
     */
    public readonly acrConfiguration!: pulumi.Output<outputs.healthcareapis.v20210601preview.FhirServiceAcrConfigurationResponse | undefined>;
    /**
     * Fhir Service authentication configuration.
     */
    public readonly authenticationConfiguration!: pulumi.Output<outputs.healthcareapis.v20210601preview.FhirServiceAuthenticationConfigurationResponse | undefined>;
    /**
     * Fhir Service Cors configuration.
     */
    public readonly corsConfiguration!: pulumi.Output<outputs.healthcareapis.v20210601preview.FhirServiceCorsConfigurationResponse | undefined>;
    /**
     * An etag associated with the resource, used for optimistic concurrency when editing it.
     */
    public /*out*/ readonly etag!: pulumi.Output<string | undefined>;
    /**
     * Fhir Service export configuration.
     */
    public readonly exportConfiguration!: pulumi.Output<outputs.healthcareapis.v20210601preview.FhirServiceExportConfigurationResponse | undefined>;
    /**
     * Setting indicating whether the service has a managed identity associated with it.
     */
    public readonly identity!: pulumi.Output<outputs.healthcareapis.v20210601preview.ServiceManagedIdentityResponseIdentity | undefined>;
    /**
     * The kind of the service.
     */
    public readonly kind!: pulumi.Output<string | undefined>;
    /**
     * The resource location.
     */
    public readonly location!: pulumi.Output<string | undefined>;
    /**
     * The resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The provisioning state.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * Metadata pertaining to creation and last modification of the resource.
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.healthcareapis.v20210601preview.SystemDataResponse>;
    /**
     * Resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a FhirService resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FhirServiceArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.workspaceName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'workspaceName'");
            }
            resourceInputs["accessPolicies"] = args ? args.accessPolicies : undefined;
            resourceInputs["acrConfiguration"] = args ? args.acrConfiguration : undefined;
            resourceInputs["authenticationConfiguration"] = args ? args.authenticationConfiguration : undefined;
            resourceInputs["corsConfiguration"] = args ? args.corsConfiguration : undefined;
            resourceInputs["exportConfiguration"] = args ? args.exportConfiguration : undefined;
            resourceInputs["fhirServiceName"] = args ? args.fhirServiceName : undefined;
            resourceInputs["identity"] = args ? args.identity : undefined;
            resourceInputs["kind"] = args ? args.kind : undefined;
            resourceInputs["location"] = args ? args.location : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["workspaceName"] = args ? args.workspaceName : undefined;
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["accessPolicies"] = undefined /*out*/;
            resourceInputs["acrConfiguration"] = undefined /*out*/;
            resourceInputs["authenticationConfiguration"] = undefined /*out*/;
            resourceInputs["corsConfiguration"] = undefined /*out*/;
            resourceInputs["etag"] = undefined /*out*/;
            resourceInputs["exportConfiguration"] = undefined /*out*/;
            resourceInputs["identity"] = undefined /*out*/;
            resourceInputs["kind"] = undefined /*out*/;
            resourceInputs["location"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:healthcareapis:FhirService" }, { type: "azure-native:healthcareapis/v20211101:FhirService" }, { type: "azure-native:healthcareapis/v20220131preview:FhirService" }, { type: "azure-native:healthcareapis/v20220515:FhirService" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(FhirService.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a FhirService resource.
 */
export interface FhirServiceArgs {
    /**
     * Fhir Service access policies.
     */
    accessPolicies?: pulumi.Input<pulumi.Input<inputs.healthcareapis.v20210601preview.FhirServiceAccessPolicyEntryArgs>[]>;
    /**
     * Fhir Service Azure container registry configuration.
     */
    acrConfiguration?: pulumi.Input<inputs.healthcareapis.v20210601preview.FhirServiceAcrConfigurationArgs>;
    /**
     * Fhir Service authentication configuration.
     */
    authenticationConfiguration?: pulumi.Input<inputs.healthcareapis.v20210601preview.FhirServiceAuthenticationConfigurationArgs>;
    /**
     * Fhir Service Cors configuration.
     */
    corsConfiguration?: pulumi.Input<inputs.healthcareapis.v20210601preview.FhirServiceCorsConfigurationArgs>;
    /**
     * Fhir Service export configuration.
     */
    exportConfiguration?: pulumi.Input<inputs.healthcareapis.v20210601preview.FhirServiceExportConfigurationArgs>;
    /**
     * The name of FHIR Service resource.
     */
    fhirServiceName?: pulumi.Input<string>;
    /**
     * Setting indicating whether the service has a managed identity associated with it.
     */
    identity?: pulumi.Input<inputs.healthcareapis.v20210601preview.ServiceManagedIdentityIdentityArgs>;
    /**
     * The kind of the service.
     */
    kind?: pulumi.Input<string | enums.healthcareapis.v20210601preview.FhirServiceKind>;
    /**
     * The resource location.
     */
    location?: pulumi.Input<string>;
    /**
     * The name of the resource group that contains the service instance.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * Resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of workspace resource.
     */
    workspaceName: pulumi.Input<string>;
}
