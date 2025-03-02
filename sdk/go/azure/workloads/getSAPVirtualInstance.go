// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package workloads

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Define the Virtual Instance for SAP.
// API Version: 2021-12-01-preview.
func LookupSAPVirtualInstance(ctx *pulumi.Context, args *LookupSAPVirtualInstanceArgs, opts ...pulumi.InvokeOption) (*LookupSAPVirtualInstanceResult, error) {
	var rv LookupSAPVirtualInstanceResult
	err := ctx.Invoke("azure-native:workloads:getSAPVirtualInstance", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupSAPVirtualInstanceArgs struct {
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the Virtual Instances for SAP.
	SapVirtualInstanceName string `pulumi:"sapVirtualInstanceName"`
}

// Define the Virtual Instance for SAP.
type LookupSAPVirtualInstanceResult struct {
	// Defines if an existing SAP system is being registered or a new SAP system is being created
	Configuration interface{} `pulumi:"configuration"`
	// Defines the environment type - Production/Non Production.
	Environment string `pulumi:"environment"`
	// Defines the Virtual Instance for SAP errors.
	Errors SAPVirtualInstanceErrorResponse `pulumi:"errors"`
	// Defines the SAP Instance health.
	Health string `pulumi:"health"`
	// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
	Id string `pulumi:"id"`
	// Managed service identity (user assigned identities)
	Identity *UserAssignedServiceIdentityResponse `pulumi:"identity"`
	// The geo-location where the resource lives
	Location string `pulumi:"location"`
	// Managed resource group configuration
	ManagedResourceGroupConfiguration *ManagedRGConfigurationResponse `pulumi:"managedResourceGroupConfiguration"`
	// The name of the resource
	Name string `pulumi:"name"`
	// Defines the provisioning states.
	ProvisioningState string `pulumi:"provisioningState"`
	// Defines the SAP Product type.
	SapProduct string `pulumi:"sapProduct"`
	// Defines the Virtual Instance for SAP state.
	State string `pulumi:"state"`
	// Defines the SAP Instance status.
	Status string `pulumi:"status"`
	// Azure Resource Manager metadata containing createdBy and modifiedBy information.
	SystemData SystemDataResponse `pulumi:"systemData"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}

func LookupSAPVirtualInstanceOutput(ctx *pulumi.Context, args LookupSAPVirtualInstanceOutputArgs, opts ...pulumi.InvokeOption) LookupSAPVirtualInstanceResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupSAPVirtualInstanceResult, error) {
			args := v.(LookupSAPVirtualInstanceArgs)
			r, err := LookupSAPVirtualInstance(ctx, &args, opts...)
			var s LookupSAPVirtualInstanceResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupSAPVirtualInstanceResultOutput)
}

type LookupSAPVirtualInstanceOutputArgs struct {
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput `pulumi:"resourceGroupName"`
	// The name of the Virtual Instances for SAP.
	SapVirtualInstanceName pulumi.StringInput `pulumi:"sapVirtualInstanceName"`
}

func (LookupSAPVirtualInstanceOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupSAPVirtualInstanceArgs)(nil)).Elem()
}

// Define the Virtual Instance for SAP.
type LookupSAPVirtualInstanceResultOutput struct{ *pulumi.OutputState }

func (LookupSAPVirtualInstanceResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupSAPVirtualInstanceResult)(nil)).Elem()
}

func (o LookupSAPVirtualInstanceResultOutput) ToLookupSAPVirtualInstanceResultOutput() LookupSAPVirtualInstanceResultOutput {
	return o
}

func (o LookupSAPVirtualInstanceResultOutput) ToLookupSAPVirtualInstanceResultOutputWithContext(ctx context.Context) LookupSAPVirtualInstanceResultOutput {
	return o
}

// Defines if an existing SAP system is being registered or a new SAP system is being created
func (o LookupSAPVirtualInstanceResultOutput) Configuration() pulumi.AnyOutput {
	return o.ApplyT(func(v LookupSAPVirtualInstanceResult) interface{} { return v.Configuration }).(pulumi.AnyOutput)
}

// Defines the environment type - Production/Non Production.
func (o LookupSAPVirtualInstanceResultOutput) Environment() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSAPVirtualInstanceResult) string { return v.Environment }).(pulumi.StringOutput)
}

// Defines the Virtual Instance for SAP errors.
func (o LookupSAPVirtualInstanceResultOutput) Errors() SAPVirtualInstanceErrorResponseOutput {
	return o.ApplyT(func(v LookupSAPVirtualInstanceResult) SAPVirtualInstanceErrorResponse { return v.Errors }).(SAPVirtualInstanceErrorResponseOutput)
}

// Defines the SAP Instance health.
func (o LookupSAPVirtualInstanceResultOutput) Health() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSAPVirtualInstanceResult) string { return v.Health }).(pulumi.StringOutput)
}

// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
func (o LookupSAPVirtualInstanceResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSAPVirtualInstanceResult) string { return v.Id }).(pulumi.StringOutput)
}

// Managed service identity (user assigned identities)
func (o LookupSAPVirtualInstanceResultOutput) Identity() UserAssignedServiceIdentityResponsePtrOutput {
	return o.ApplyT(func(v LookupSAPVirtualInstanceResult) *UserAssignedServiceIdentityResponse { return v.Identity }).(UserAssignedServiceIdentityResponsePtrOutput)
}

// The geo-location where the resource lives
func (o LookupSAPVirtualInstanceResultOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSAPVirtualInstanceResult) string { return v.Location }).(pulumi.StringOutput)
}

// Managed resource group configuration
func (o LookupSAPVirtualInstanceResultOutput) ManagedResourceGroupConfiguration() ManagedRGConfigurationResponsePtrOutput {
	return o.ApplyT(func(v LookupSAPVirtualInstanceResult) *ManagedRGConfigurationResponse {
		return v.ManagedResourceGroupConfiguration
	}).(ManagedRGConfigurationResponsePtrOutput)
}

// The name of the resource
func (o LookupSAPVirtualInstanceResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSAPVirtualInstanceResult) string { return v.Name }).(pulumi.StringOutput)
}

// Defines the provisioning states.
func (o LookupSAPVirtualInstanceResultOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSAPVirtualInstanceResult) string { return v.ProvisioningState }).(pulumi.StringOutput)
}

// Defines the SAP Product type.
func (o LookupSAPVirtualInstanceResultOutput) SapProduct() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSAPVirtualInstanceResult) string { return v.SapProduct }).(pulumi.StringOutput)
}

// Defines the Virtual Instance for SAP state.
func (o LookupSAPVirtualInstanceResultOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSAPVirtualInstanceResult) string { return v.State }).(pulumi.StringOutput)
}

// Defines the SAP Instance status.
func (o LookupSAPVirtualInstanceResultOutput) Status() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSAPVirtualInstanceResult) string { return v.Status }).(pulumi.StringOutput)
}

// Azure Resource Manager metadata containing createdBy and modifiedBy information.
func (o LookupSAPVirtualInstanceResultOutput) SystemData() SystemDataResponseOutput {
	return o.ApplyT(func(v LookupSAPVirtualInstanceResult) SystemDataResponse { return v.SystemData }).(SystemDataResponseOutput)
}

// Resource tags.
func (o LookupSAPVirtualInstanceResultOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupSAPVirtualInstanceResult) map[string]string { return v.Tags }).(pulumi.StringMapOutput)
}

// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
func (o LookupSAPVirtualInstanceResultOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v LookupSAPVirtualInstanceResult) string { return v.Type }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupSAPVirtualInstanceResultOutput{})
}
