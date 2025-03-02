// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20211115

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type AADProperties struct {
	Audience                 *string `pulumi:"audience"`
	Authority                *string `pulumi:"authority"`
	ServicePrincipalClientId *string `pulumi:"servicePrincipalClientId"`
	ServicePrincipalObjectId *string `pulumi:"servicePrincipalObjectId"`
	TenantId                 *string `pulumi:"tenantId"`
}

// AADPropertiesInput is an input type that accepts AADPropertiesArgs and AADPropertiesOutput values.
// You can construct a concrete instance of `AADPropertiesInput` via:
//
//          AADPropertiesArgs{...}
type AADPropertiesInput interface {
	pulumi.Input

	ToAADPropertiesOutput() AADPropertiesOutput
	ToAADPropertiesOutputWithContext(context.Context) AADPropertiesOutput
}

type AADPropertiesArgs struct {
	Audience                 pulumi.StringPtrInput `pulumi:"audience"`
	Authority                pulumi.StringPtrInput `pulumi:"authority"`
	ServicePrincipalClientId pulumi.StringPtrInput `pulumi:"servicePrincipalClientId"`
	ServicePrincipalObjectId pulumi.StringPtrInput `pulumi:"servicePrincipalObjectId"`
	TenantId                 pulumi.StringPtrInput `pulumi:"tenantId"`
}

func (AADPropertiesArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*AADProperties)(nil)).Elem()
}

func (i AADPropertiesArgs) ToAADPropertiesOutput() AADPropertiesOutput {
	return i.ToAADPropertiesOutputWithContext(context.Background())
}

func (i AADPropertiesArgs) ToAADPropertiesOutputWithContext(ctx context.Context) AADPropertiesOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AADPropertiesOutput)
}

func (i AADPropertiesArgs) ToAADPropertiesPtrOutput() AADPropertiesPtrOutput {
	return i.ToAADPropertiesPtrOutputWithContext(context.Background())
}

func (i AADPropertiesArgs) ToAADPropertiesPtrOutputWithContext(ctx context.Context) AADPropertiesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AADPropertiesOutput).ToAADPropertiesPtrOutputWithContext(ctx)
}

// AADPropertiesPtrInput is an input type that accepts AADPropertiesArgs, AADPropertiesPtr and AADPropertiesPtrOutput values.
// You can construct a concrete instance of `AADPropertiesPtrInput` via:
//
//          AADPropertiesArgs{...}
//
//  or:
//
//          nil
type AADPropertiesPtrInput interface {
	pulumi.Input

	ToAADPropertiesPtrOutput() AADPropertiesPtrOutput
	ToAADPropertiesPtrOutputWithContext(context.Context) AADPropertiesPtrOutput
}

type aadpropertiesPtrType AADPropertiesArgs

func AADPropertiesPtr(v *AADPropertiesArgs) AADPropertiesPtrInput {
	return (*aadpropertiesPtrType)(v)
}

func (*aadpropertiesPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**AADProperties)(nil)).Elem()
}

func (i *aadpropertiesPtrType) ToAADPropertiesPtrOutput() AADPropertiesPtrOutput {
	return i.ToAADPropertiesPtrOutputWithContext(context.Background())
}

func (i *aadpropertiesPtrType) ToAADPropertiesPtrOutputWithContext(ctx context.Context) AADPropertiesPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(AADPropertiesPtrOutput)
}

type AADPropertiesOutput struct{ *pulumi.OutputState }

func (AADPropertiesOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*AADProperties)(nil)).Elem()
}

func (o AADPropertiesOutput) ToAADPropertiesOutput() AADPropertiesOutput {
	return o
}

func (o AADPropertiesOutput) ToAADPropertiesOutputWithContext(ctx context.Context) AADPropertiesOutput {
	return o
}

func (o AADPropertiesOutput) ToAADPropertiesPtrOutput() AADPropertiesPtrOutput {
	return o.ToAADPropertiesPtrOutputWithContext(context.Background())
}

func (o AADPropertiesOutput) ToAADPropertiesPtrOutputWithContext(ctx context.Context) AADPropertiesPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v AADProperties) *AADProperties {
		return &v
	}).(AADPropertiesPtrOutput)
}

func (o AADPropertiesOutput) Audience() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AADProperties) *string { return v.Audience }).(pulumi.StringPtrOutput)
}

func (o AADPropertiesOutput) Authority() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AADProperties) *string { return v.Authority }).(pulumi.StringPtrOutput)
}

func (o AADPropertiesOutput) ServicePrincipalClientId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AADProperties) *string { return v.ServicePrincipalClientId }).(pulumi.StringPtrOutput)
}

func (o AADPropertiesOutput) ServicePrincipalObjectId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AADProperties) *string { return v.ServicePrincipalObjectId }).(pulumi.StringPtrOutput)
}

func (o AADPropertiesOutput) TenantId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v AADProperties) *string { return v.TenantId }).(pulumi.StringPtrOutput)
}

type AADPropertiesPtrOutput struct{ *pulumi.OutputState }

func (AADPropertiesPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**AADProperties)(nil)).Elem()
}

func (o AADPropertiesPtrOutput) ToAADPropertiesPtrOutput() AADPropertiesPtrOutput {
	return o
}

func (o AADPropertiesPtrOutput) ToAADPropertiesPtrOutputWithContext(ctx context.Context) AADPropertiesPtrOutput {
	return o
}

func (o AADPropertiesPtrOutput) Elem() AADPropertiesOutput {
	return o.ApplyT(func(v *AADProperties) AADProperties {
		if v != nil {
			return *v
		}
		var ret AADProperties
		return ret
	}).(AADPropertiesOutput)
}

func (o AADPropertiesPtrOutput) Audience() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AADProperties) *string {
		if v == nil {
			return nil
		}
		return v.Audience
	}).(pulumi.StringPtrOutput)
}

func (o AADPropertiesPtrOutput) Authority() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AADProperties) *string {
		if v == nil {
			return nil
		}
		return v.Authority
	}).(pulumi.StringPtrOutput)
}

func (o AADPropertiesPtrOutput) ServicePrincipalClientId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AADProperties) *string {
		if v == nil {
			return nil
		}
		return v.ServicePrincipalClientId
	}).(pulumi.StringPtrOutput)
}

func (o AADPropertiesPtrOutput) ServicePrincipalObjectId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AADProperties) *string {
		if v == nil {
			return nil
		}
		return v.ServicePrincipalObjectId
	}).(pulumi.StringPtrOutput)
}

func (o AADPropertiesPtrOutput) TenantId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *AADProperties) *string {
		if v == nil {
			return nil
		}
		return v.TenantId
	}).(pulumi.StringPtrOutput)
}

type WorkloadCrrAccessTokenResponse struct {
	// Access token used for authentication
	AccessTokenString *string `pulumi:"accessTokenString"`
	// Active region name of BMS Stamp
	BMSActiveRegion *string `pulumi:"bMSActiveRegion"`
	// Backup Management Type
	BackupManagementType *string `pulumi:"backupManagementType"`
	// Container Id
	ContainerId *string `pulumi:"containerId"`
	// Container Unique name
	ContainerName *string `pulumi:"containerName"`
	// Container Type
	ContainerType *string `pulumi:"containerType"`
	// CoordinatorServiceStampId to be used by BCM in restore call
	CoordinatorServiceStampId *string `pulumi:"coordinatorServiceStampId"`
	// CoordinatorServiceStampUri to be used by BCM in restore call
	CoordinatorServiceStampUri *string `pulumi:"coordinatorServiceStampUri"`
	// Datasource Container Unique Name
	DatasourceContainerName *string `pulumi:"datasourceContainerName"`
	// Datasource Id
	DatasourceId *string `pulumi:"datasourceId"`
	// Datasource Friendly Name
	DatasourceName *string `pulumi:"datasourceName"`
	// Datasource Type
	DatasourceType *string `pulumi:"datasourceType"`
	// Type of the specific object - used for deserializing
	// Expected value is 'WorkloadCrrAccessToken'.
	ObjectType string `pulumi:"objectType"`
	// Policy Id
	PolicyId *string `pulumi:"policyId"`
	// Policy Name
	PolicyName                                  *string `pulumi:"policyName"`
	ProtectableObjectContainerHostOsName        *string `pulumi:"protectableObjectContainerHostOsName"`
	ProtectableObjectFriendlyName               *string `pulumi:"protectableObjectFriendlyName"`
	ProtectableObjectParentLogicalContainerName *string `pulumi:"protectableObjectParentLogicalContainerName"`
	ProtectableObjectProtectionState            *string `pulumi:"protectableObjectProtectionState"`
	ProtectableObjectUniqueName                 *string `pulumi:"protectableObjectUniqueName"`
	ProtectableObjectWorkloadType               *string `pulumi:"protectableObjectWorkloadType"`
	// Protected item container id
	ProtectionContainerId *float64 `pulumi:"protectionContainerId"`
	// ProtectionServiceStampId to be used by BCM in restore call
	ProtectionServiceStampId *string `pulumi:"protectionServiceStampId"`
	// ProtectionServiceStampUri to be used by BCM in restore call
	ProtectionServiceStampUri *string `pulumi:"protectionServiceStampUri"`
	// Recovery Point Id
	RecoveryPointId *string `pulumi:"recoveryPointId"`
	// Recovery Point Time
	RecoveryPointTime *string `pulumi:"recoveryPointTime"`
	// Resource Group name of the source vault
	ResourceGroupName *string `pulumi:"resourceGroupName"`
	// Resource Id of the source vault
	ResourceId *string `pulumi:"resourceId"`
	// Resource Name of the source vault
	ResourceName *string `pulumi:"resourceName"`
	// Recovery point information: Managed virtual machine
	RpIsManagedVirtualMachine *bool `pulumi:"rpIsManagedVirtualMachine"`
	// Recovery point information: Original SA option
	RpOriginalSAOption *bool `pulumi:"rpOriginalSAOption"`
	// Recovery point Tier Information
	RpTierInformation map[string]string `pulumi:"rpTierInformation"`
	// Recovery point information: VM size description
	RpVMSizeDescription *string `pulumi:"rpVMSizeDescription"`
	// Subscription Id of the source vault
	SubscriptionId *string `pulumi:"subscriptionId"`
	// Extended Information about the token like FileSpec etc.
	TokenExtendedInformation *string `pulumi:"tokenExtendedInformation"`
}

type WorkloadCrrAccessTokenResponseOutput struct{ *pulumi.OutputState }

func (WorkloadCrrAccessTokenResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WorkloadCrrAccessTokenResponse)(nil)).Elem()
}

func (o WorkloadCrrAccessTokenResponseOutput) ToWorkloadCrrAccessTokenResponseOutput() WorkloadCrrAccessTokenResponseOutput {
	return o
}

func (o WorkloadCrrAccessTokenResponseOutput) ToWorkloadCrrAccessTokenResponseOutputWithContext(ctx context.Context) WorkloadCrrAccessTokenResponseOutput {
	return o
}

// Access token used for authentication
func (o WorkloadCrrAccessTokenResponseOutput) AccessTokenString() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.AccessTokenString }).(pulumi.StringPtrOutput)
}

// Active region name of BMS Stamp
func (o WorkloadCrrAccessTokenResponseOutput) BMSActiveRegion() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.BMSActiveRegion }).(pulumi.StringPtrOutput)
}

// Backup Management Type
func (o WorkloadCrrAccessTokenResponseOutput) BackupManagementType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.BackupManagementType }).(pulumi.StringPtrOutput)
}

// Container Id
func (o WorkloadCrrAccessTokenResponseOutput) ContainerId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.ContainerId }).(pulumi.StringPtrOutput)
}

// Container Unique name
func (o WorkloadCrrAccessTokenResponseOutput) ContainerName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.ContainerName }).(pulumi.StringPtrOutput)
}

// Container Type
func (o WorkloadCrrAccessTokenResponseOutput) ContainerType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.ContainerType }).(pulumi.StringPtrOutput)
}

// CoordinatorServiceStampId to be used by BCM in restore call
func (o WorkloadCrrAccessTokenResponseOutput) CoordinatorServiceStampId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.CoordinatorServiceStampId }).(pulumi.StringPtrOutput)
}

// CoordinatorServiceStampUri to be used by BCM in restore call
func (o WorkloadCrrAccessTokenResponseOutput) CoordinatorServiceStampUri() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.CoordinatorServiceStampUri }).(pulumi.StringPtrOutput)
}

// Datasource Container Unique Name
func (o WorkloadCrrAccessTokenResponseOutput) DatasourceContainerName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.DatasourceContainerName }).(pulumi.StringPtrOutput)
}

// Datasource Id
func (o WorkloadCrrAccessTokenResponseOutput) DatasourceId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.DatasourceId }).(pulumi.StringPtrOutput)
}

// Datasource Friendly Name
func (o WorkloadCrrAccessTokenResponseOutput) DatasourceName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.DatasourceName }).(pulumi.StringPtrOutput)
}

// Datasource Type
func (o WorkloadCrrAccessTokenResponseOutput) DatasourceType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.DatasourceType }).(pulumi.StringPtrOutput)
}

// Type of the specific object - used for deserializing
// Expected value is 'WorkloadCrrAccessToken'.
func (o WorkloadCrrAccessTokenResponseOutput) ObjectType() pulumi.StringOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) string { return v.ObjectType }).(pulumi.StringOutput)
}

// Policy Id
func (o WorkloadCrrAccessTokenResponseOutput) PolicyId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.PolicyId }).(pulumi.StringPtrOutput)
}

// Policy Name
func (o WorkloadCrrAccessTokenResponseOutput) PolicyName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.PolicyName }).(pulumi.StringPtrOutput)
}

func (o WorkloadCrrAccessTokenResponseOutput) ProtectableObjectContainerHostOsName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.ProtectableObjectContainerHostOsName }).(pulumi.StringPtrOutput)
}

func (o WorkloadCrrAccessTokenResponseOutput) ProtectableObjectFriendlyName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.ProtectableObjectFriendlyName }).(pulumi.StringPtrOutput)
}

func (o WorkloadCrrAccessTokenResponseOutput) ProtectableObjectParentLogicalContainerName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.ProtectableObjectParentLogicalContainerName }).(pulumi.StringPtrOutput)
}

func (o WorkloadCrrAccessTokenResponseOutput) ProtectableObjectProtectionState() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.ProtectableObjectProtectionState }).(pulumi.StringPtrOutput)
}

func (o WorkloadCrrAccessTokenResponseOutput) ProtectableObjectUniqueName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.ProtectableObjectUniqueName }).(pulumi.StringPtrOutput)
}

func (o WorkloadCrrAccessTokenResponseOutput) ProtectableObjectWorkloadType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.ProtectableObjectWorkloadType }).(pulumi.StringPtrOutput)
}

// Protected item container id
func (o WorkloadCrrAccessTokenResponseOutput) ProtectionContainerId() pulumi.Float64PtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *float64 { return v.ProtectionContainerId }).(pulumi.Float64PtrOutput)
}

// ProtectionServiceStampId to be used by BCM in restore call
func (o WorkloadCrrAccessTokenResponseOutput) ProtectionServiceStampId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.ProtectionServiceStampId }).(pulumi.StringPtrOutput)
}

// ProtectionServiceStampUri to be used by BCM in restore call
func (o WorkloadCrrAccessTokenResponseOutput) ProtectionServiceStampUri() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.ProtectionServiceStampUri }).(pulumi.StringPtrOutput)
}

// Recovery Point Id
func (o WorkloadCrrAccessTokenResponseOutput) RecoveryPointId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.RecoveryPointId }).(pulumi.StringPtrOutput)
}

// Recovery Point Time
func (o WorkloadCrrAccessTokenResponseOutput) RecoveryPointTime() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.RecoveryPointTime }).(pulumi.StringPtrOutput)
}

// Resource Group name of the source vault
func (o WorkloadCrrAccessTokenResponseOutput) ResourceGroupName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.ResourceGroupName }).(pulumi.StringPtrOutput)
}

// Resource Id of the source vault
func (o WorkloadCrrAccessTokenResponseOutput) ResourceId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.ResourceId }).(pulumi.StringPtrOutput)
}

// Resource Name of the source vault
func (o WorkloadCrrAccessTokenResponseOutput) ResourceName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.ResourceName }).(pulumi.StringPtrOutput)
}

// Recovery point information: Managed virtual machine
func (o WorkloadCrrAccessTokenResponseOutput) RpIsManagedVirtualMachine() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *bool { return v.RpIsManagedVirtualMachine }).(pulumi.BoolPtrOutput)
}

// Recovery point information: Original SA option
func (o WorkloadCrrAccessTokenResponseOutput) RpOriginalSAOption() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *bool { return v.RpOriginalSAOption }).(pulumi.BoolPtrOutput)
}

// Recovery point Tier Information
func (o WorkloadCrrAccessTokenResponseOutput) RpTierInformation() pulumi.StringMapOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) map[string]string { return v.RpTierInformation }).(pulumi.StringMapOutput)
}

// Recovery point information: VM size description
func (o WorkloadCrrAccessTokenResponseOutput) RpVMSizeDescription() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.RpVMSizeDescription }).(pulumi.StringPtrOutput)
}

// Subscription Id of the source vault
func (o WorkloadCrrAccessTokenResponseOutput) SubscriptionId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.SubscriptionId }).(pulumi.StringPtrOutput)
}

// Extended Information about the token like FileSpec etc.
func (o WorkloadCrrAccessTokenResponseOutput) TokenExtendedInformation() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkloadCrrAccessTokenResponse) *string { return v.TokenExtendedInformation }).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(AADPropertiesOutput{})
	pulumi.RegisterOutputType(AADPropertiesPtrOutput{})
	pulumi.RegisterOutputType(WorkloadCrrAccessTokenResponseOutput{})
}
