// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import { input as inputs, output as outputs, enums } from "../../types";
import * as utilities from "../../utilities";

/**
 * Describes a node type in the cluster, each node type represents sub set of nodes in the cluster.
 */
export class NodeType extends pulumi.CustomResource {
    /**
     * Get an existing NodeType resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, opts?: pulumi.CustomResourceOptions): NodeType {
        return new NodeType(name, undefined as any, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure-native:servicefabric/v20211101preview:NodeType';

    /**
     * Returns true if the given object is an instance of NodeType.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is NodeType {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === NodeType.__pulumiType;
    }

    /**
     * Additional managed data disks.
     */
    public readonly additionalDataDisks!: pulumi.Output<outputs.servicefabric.v20211101preview.VmssDataDiskResponse[] | undefined>;
    /**
     * The range of ports from which cluster assigned port to Service Fabric applications.
     */
    public readonly applicationPorts!: pulumi.Output<outputs.servicefabric.v20211101preview.EndpointRangeDescriptionResponse | undefined>;
    /**
     * The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has.
     */
    public readonly capacities!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Managed data disk letter. It can not use the reserved letter C or D and it can not change after created.
     */
    public readonly dataDiskLetter!: pulumi.Output<string | undefined>;
    /**
     * Disk size for the managed disk attached to the vms on the node type in GBs.
     */
    public readonly dataDiskSizeGB!: pulumi.Output<number | undefined>;
    /**
     * Managed data disk type. Specifies the storage account type for the managed disk
     */
    public readonly dataDiskType!: pulumi.Output<string | undefined>;
    /**
     * Specifies whether the network interface is accelerated networking-enabled.
     */
    public readonly enableAcceleratedNetworking!: pulumi.Output<boolean | undefined>;
    /**
     * Enable or disable the Host Encryption for the virtual machines on the node type. This will enable the encryption for all the disks including Resource/Temp disk at host itself. Default: The Encryption at host will be disabled unless this property is set to true for the resource.
     */
    public readonly enableEncryptionAtHost!: pulumi.Output<boolean | undefined>;
    /**
     * The range of ephemeral ports that nodes in this node type should be configured with.
     */
    public readonly ephemeralPorts!: pulumi.Output<outputs.servicefabric.v20211101preview.EndpointRangeDescriptionResponse | undefined>;
    /**
     * Indicates the node type uses its own frontend configurations instead of the default one for the cluster. This setting can only be specified for non-primary node types and can not be added or removed after the node type is created.
     */
    public readonly frontendConfigurations!: pulumi.Output<outputs.servicefabric.v20211101preview.FrontendConfigurationResponse[] | undefined>;
    /**
     * Indicates the Service Fabric system services for the cluster will run on this node type. This setting cannot be changed once the node type is created.
     */
    public readonly isPrimary!: pulumi.Output<boolean>;
    /**
     * Indicates if the node type can only host Stateless workloads.
     */
    public readonly isStateless!: pulumi.Output<boolean | undefined>;
    /**
     * Indicates if scale set associated with the node type can be composed of multiple placement groups.
     */
    public readonly multiplePlacementGroups!: pulumi.Output<boolean | undefined>;
    /**
     * Azure resource name.
     */
    public /*out*/ readonly name!: pulumi.Output<string>;
    /**
     * The Network Security Rules for this node type. This setting can only be specified for node types that are configured with frontend configurations.
     */
    public readonly networkSecurityRules!: pulumi.Output<outputs.servicefabric.v20211101preview.NetworkSecurityRuleResponse[] | undefined>;
    /**
     * The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run.
     */
    public readonly placementProperties!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The provisioning state of the node type resource.
     */
    public /*out*/ readonly provisioningState!: pulumi.Output<string>;
    /**
     * The node type sku.
     */
    public readonly sku!: pulumi.Output<outputs.servicefabric.v20211101preview.NodeTypeSkuResponse | undefined>;
    /**
     * Metadata pertaining to creation and last modification of the resource.
     */
    public /*out*/ readonly systemData!: pulumi.Output<outputs.servicefabric.v20211101preview.SystemDataResponse>;
    /**
     * Azure resource tags.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Azure resource type.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;
    /**
     * Specifies whether the use public load balancer. If not specified and the node type doesn't have its own frontend configuration, it will be attached to the default load balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is true, then the frontend has to be an Internal Load Balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is false or not set, then the custom load balancer must include a public load balancer to provide outbound connectivity.
     */
    public readonly useDefaultPublicLoadBalancer!: pulumi.Output<boolean | undefined>;
    /**
     * Specifies whether to use the temporary disk for the service fabric data root, in which case no managed data disk will be attached and the temporary disk will be used. It is only allowed for stateless node types.
     */
    public readonly useTempDataDisk!: pulumi.Output<boolean | undefined>;
    /**
     * Set of extensions that should be installed onto the virtual machines.
     */
    public readonly vmExtensions!: pulumi.Output<outputs.servicefabric.v20211101preview.VMSSExtensionResponse[] | undefined>;
    /**
     * The offer type of the Azure Virtual Machines Marketplace image. For example, UbuntuServer or WindowsServer.
     */
    public readonly vmImageOffer!: pulumi.Output<string | undefined>;
    /**
     * The publisher of the Azure Virtual Machines Marketplace image. For example, Canonical or MicrosoftWindowsServer.
     */
    public readonly vmImagePublisher!: pulumi.Output<string | undefined>;
    /**
     * The SKU of the Azure Virtual Machines Marketplace image. For example, 14.04.0-LTS or 2012-R2-Datacenter.
     */
    public readonly vmImageSku!: pulumi.Output<string | undefined>;
    /**
     * The version of the Azure Virtual Machines Marketplace image. A value of 'latest' can be specified to select the latest version of an image. If omitted, the default is 'latest'.
     */
    public readonly vmImageVersion!: pulumi.Output<string | undefined>;
    /**
     * The number of nodes in the node type. <br /><br />**Values:** <br />-1 - Use when auto scale rules are configured or sku.capacity is defined <br /> 0 - Not supported <br /> >0 - Use for manual scale.
     */
    public readonly vmInstanceCount!: pulumi.Output<number>;
    /**
     * Identities to assign to the virtual machine scale set under the node type.
     */
    public readonly vmManagedIdentity!: pulumi.Output<outputs.servicefabric.v20211101preview.VmManagedIdentityResponse | undefined>;
    /**
     * The secrets to install in the virtual machines.
     */
    public readonly vmSecrets!: pulumi.Output<outputs.servicefabric.v20211101preview.VaultSecretGroupResponse[] | undefined>;
    /**
     * The size of virtual machines in the pool. All virtual machines in a pool are the same size. For example, Standard_D3.
     */
    public readonly vmSize!: pulumi.Output<string | undefined>;

    /**
     * Create a NodeType resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NodeTypeArgs, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (!opts.id) {
            if ((!args || args.clusterName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterName'");
            }
            if ((!args || args.isPrimary === undefined) && !opts.urn) {
                throw new Error("Missing required property 'isPrimary'");
            }
            if ((!args || args.resourceGroupName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if ((!args || args.vmInstanceCount === undefined) && !opts.urn) {
                throw new Error("Missing required property 'vmInstanceCount'");
            }
            resourceInputs["additionalDataDisks"] = args ? args.additionalDataDisks : undefined;
            resourceInputs["applicationPorts"] = args ? args.applicationPorts : undefined;
            resourceInputs["capacities"] = args ? args.capacities : undefined;
            resourceInputs["clusterName"] = args ? args.clusterName : undefined;
            resourceInputs["dataDiskLetter"] = args ? args.dataDiskLetter : undefined;
            resourceInputs["dataDiskSizeGB"] = args ? args.dataDiskSizeGB : undefined;
            resourceInputs["dataDiskType"] = args ? args.dataDiskType : undefined;
            resourceInputs["enableAcceleratedNetworking"] = args ? args.enableAcceleratedNetworking : undefined;
            resourceInputs["enableEncryptionAtHost"] = (args ? args.enableEncryptionAtHost : undefined) ?? false;
            resourceInputs["ephemeralPorts"] = args ? args.ephemeralPorts : undefined;
            resourceInputs["frontendConfigurations"] = args ? args.frontendConfigurations : undefined;
            resourceInputs["isPrimary"] = args ? args.isPrimary : undefined;
            resourceInputs["isStateless"] = (args ? args.isStateless : undefined) ?? false;
            resourceInputs["multiplePlacementGroups"] = (args ? args.multiplePlacementGroups : undefined) ?? false;
            resourceInputs["networkSecurityRules"] = args ? args.networkSecurityRules : undefined;
            resourceInputs["nodeTypeName"] = args ? args.nodeTypeName : undefined;
            resourceInputs["placementProperties"] = args ? args.placementProperties : undefined;
            resourceInputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            resourceInputs["sku"] = args ? args.sku : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["useDefaultPublicLoadBalancer"] = args ? args.useDefaultPublicLoadBalancer : undefined;
            resourceInputs["useTempDataDisk"] = args ? args.useTempDataDisk : undefined;
            resourceInputs["vmExtensions"] = args ? args.vmExtensions : undefined;
            resourceInputs["vmImageOffer"] = args ? args.vmImageOffer : undefined;
            resourceInputs["vmImagePublisher"] = args ? args.vmImagePublisher : undefined;
            resourceInputs["vmImageSku"] = args ? args.vmImageSku : undefined;
            resourceInputs["vmImageVersion"] = args ? args.vmImageVersion : undefined;
            resourceInputs["vmInstanceCount"] = args ? args.vmInstanceCount : undefined;
            resourceInputs["vmManagedIdentity"] = args ? args.vmManagedIdentity : undefined;
            resourceInputs["vmSecrets"] = args ? args.vmSecrets : undefined;
            resourceInputs["vmSize"] = args ? args.vmSize : undefined;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
        } else {
            resourceInputs["additionalDataDisks"] = undefined /*out*/;
            resourceInputs["applicationPorts"] = undefined /*out*/;
            resourceInputs["capacities"] = undefined /*out*/;
            resourceInputs["dataDiskLetter"] = undefined /*out*/;
            resourceInputs["dataDiskSizeGB"] = undefined /*out*/;
            resourceInputs["dataDiskType"] = undefined /*out*/;
            resourceInputs["enableAcceleratedNetworking"] = undefined /*out*/;
            resourceInputs["enableEncryptionAtHost"] = undefined /*out*/;
            resourceInputs["ephemeralPorts"] = undefined /*out*/;
            resourceInputs["frontendConfigurations"] = undefined /*out*/;
            resourceInputs["isPrimary"] = undefined /*out*/;
            resourceInputs["isStateless"] = undefined /*out*/;
            resourceInputs["multiplePlacementGroups"] = undefined /*out*/;
            resourceInputs["name"] = undefined /*out*/;
            resourceInputs["networkSecurityRules"] = undefined /*out*/;
            resourceInputs["placementProperties"] = undefined /*out*/;
            resourceInputs["provisioningState"] = undefined /*out*/;
            resourceInputs["sku"] = undefined /*out*/;
            resourceInputs["systemData"] = undefined /*out*/;
            resourceInputs["tags"] = undefined /*out*/;
            resourceInputs["type"] = undefined /*out*/;
            resourceInputs["useDefaultPublicLoadBalancer"] = undefined /*out*/;
            resourceInputs["useTempDataDisk"] = undefined /*out*/;
            resourceInputs["vmExtensions"] = undefined /*out*/;
            resourceInputs["vmImageOffer"] = undefined /*out*/;
            resourceInputs["vmImagePublisher"] = undefined /*out*/;
            resourceInputs["vmImageSku"] = undefined /*out*/;
            resourceInputs["vmImageVersion"] = undefined /*out*/;
            resourceInputs["vmInstanceCount"] = undefined /*out*/;
            resourceInputs["vmManagedIdentity"] = undefined /*out*/;
            resourceInputs["vmSecrets"] = undefined /*out*/;
            resourceInputs["vmSize"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        const aliasOpts = { aliases: [{ type: "azure-native:servicefabric:NodeType" }, { type: "azure-native:servicefabric/v20200101preview:NodeType" }, { type: "azure-native:servicefabric/v20210101preview:NodeType" }, { type: "azure-native:servicefabric/v20210501:NodeType" }, { type: "azure-native:servicefabric/v20210701preview:NodeType" }, { type: "azure-native:servicefabric/v20210901privatepreview:NodeType" }, { type: "azure-native:servicefabric/v20220101:NodeType" }, { type: "azure-native:servicefabric/v20220201preview:NodeType" }] };
        opts = pulumi.mergeOptions(opts, aliasOpts);
        super(NodeType.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * The set of arguments for constructing a NodeType resource.
 */
export interface NodeTypeArgs {
    /**
     * Additional managed data disks.
     */
    additionalDataDisks?: pulumi.Input<pulumi.Input<inputs.servicefabric.v20211101preview.VmssDataDiskArgs>[]>;
    /**
     * The range of ports from which cluster assigned port to Service Fabric applications.
     */
    applicationPorts?: pulumi.Input<inputs.servicefabric.v20211101preview.EndpointRangeDescriptionArgs>;
    /**
     * The capacity tags applied to the nodes in the node type, the cluster resource manager uses these tags to understand how much resource a node has.
     */
    capacities?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the cluster resource.
     */
    clusterName: pulumi.Input<string>;
    /**
     * Managed data disk letter. It can not use the reserved letter C or D and it can not change after created.
     */
    dataDiskLetter?: pulumi.Input<string>;
    /**
     * Disk size for the managed disk attached to the vms on the node type in GBs.
     */
    dataDiskSizeGB?: pulumi.Input<number>;
    /**
     * Managed data disk type. Specifies the storage account type for the managed disk
     */
    dataDiskType?: pulumi.Input<string | enums.servicefabric.v20211101preview.DiskType>;
    /**
     * Specifies whether the network interface is accelerated networking-enabled.
     */
    enableAcceleratedNetworking?: pulumi.Input<boolean>;
    /**
     * Enable or disable the Host Encryption for the virtual machines on the node type. This will enable the encryption for all the disks including Resource/Temp disk at host itself. Default: The Encryption at host will be disabled unless this property is set to true for the resource.
     */
    enableEncryptionAtHost?: pulumi.Input<boolean>;
    /**
     * The range of ephemeral ports that nodes in this node type should be configured with.
     */
    ephemeralPorts?: pulumi.Input<inputs.servicefabric.v20211101preview.EndpointRangeDescriptionArgs>;
    /**
     * Indicates the node type uses its own frontend configurations instead of the default one for the cluster. This setting can only be specified for non-primary node types and can not be added or removed after the node type is created.
     */
    frontendConfigurations?: pulumi.Input<pulumi.Input<inputs.servicefabric.v20211101preview.FrontendConfigurationArgs>[]>;
    /**
     * Indicates the Service Fabric system services for the cluster will run on this node type. This setting cannot be changed once the node type is created.
     */
    isPrimary: pulumi.Input<boolean>;
    /**
     * Indicates if the node type can only host Stateless workloads.
     */
    isStateless?: pulumi.Input<boolean>;
    /**
     * Indicates if scale set associated with the node type can be composed of multiple placement groups.
     */
    multiplePlacementGroups?: pulumi.Input<boolean>;
    /**
     * The Network Security Rules for this node type. This setting can only be specified for node types that are configured with frontend configurations.
     */
    networkSecurityRules?: pulumi.Input<pulumi.Input<inputs.servicefabric.v20211101preview.NetworkSecurityRuleArgs>[]>;
    /**
     * The name of the node type.
     */
    nodeTypeName?: pulumi.Input<string>;
    /**
     * The placement tags applied to nodes in the node type, which can be used to indicate where certain services (workload) should run.
     */
    placementProperties?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The name of the resource group.
     */
    resourceGroupName: pulumi.Input<string>;
    /**
     * The node type sku.
     */
    sku?: pulumi.Input<inputs.servicefabric.v20211101preview.NodeTypeSkuArgs>;
    /**
     * Azure resource tags.
     */
    tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Specifies whether the use public load balancer. If not specified and the node type doesn't have its own frontend configuration, it will be attached to the default load balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is true, then the frontend has to be an Internal Load Balancer. If the node type uses its own Load balancer and useDefaultPublicLoadBalancer is false or not set, then the custom load balancer must include a public load balancer to provide outbound connectivity.
     */
    useDefaultPublicLoadBalancer?: pulumi.Input<boolean>;
    /**
     * Specifies whether to use the temporary disk for the service fabric data root, in which case no managed data disk will be attached and the temporary disk will be used. It is only allowed for stateless node types.
     */
    useTempDataDisk?: pulumi.Input<boolean>;
    /**
     * Set of extensions that should be installed onto the virtual machines.
     */
    vmExtensions?: pulumi.Input<pulumi.Input<inputs.servicefabric.v20211101preview.VMSSExtensionArgs>[]>;
    /**
     * The offer type of the Azure Virtual Machines Marketplace image. For example, UbuntuServer or WindowsServer.
     */
    vmImageOffer?: pulumi.Input<string>;
    /**
     * The publisher of the Azure Virtual Machines Marketplace image. For example, Canonical or MicrosoftWindowsServer.
     */
    vmImagePublisher?: pulumi.Input<string>;
    /**
     * The SKU of the Azure Virtual Machines Marketplace image. For example, 14.04.0-LTS or 2012-R2-Datacenter.
     */
    vmImageSku?: pulumi.Input<string>;
    /**
     * The version of the Azure Virtual Machines Marketplace image. A value of 'latest' can be specified to select the latest version of an image. If omitted, the default is 'latest'.
     */
    vmImageVersion?: pulumi.Input<string>;
    /**
     * The number of nodes in the node type. <br /><br />**Values:** <br />-1 - Use when auto scale rules are configured or sku.capacity is defined <br /> 0 - Not supported <br /> >0 - Use for manual scale.
     */
    vmInstanceCount: pulumi.Input<number>;
    /**
     * Identities to assign to the virtual machine scale set under the node type.
     */
    vmManagedIdentity?: pulumi.Input<inputs.servicefabric.v20211101preview.VmManagedIdentityArgs>;
    /**
     * The secrets to install in the virtual machines.
     */
    vmSecrets?: pulumi.Input<pulumi.Input<inputs.servicefabric.v20211101preview.VaultSecretGroupArgs>[]>;
    /**
     * The size of virtual machines in the pool. All virtual machines in a pool are the same size. For example, Standard_D3.
     */
    vmSize?: pulumi.Input<string>;
}
