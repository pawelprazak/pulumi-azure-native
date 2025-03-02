// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package mobilenetwork

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Data network resource.
// API Version: 2022-01-01-preview.
func LookupDataNetwork(ctx *pulumi.Context, args *LookupDataNetworkArgs, opts ...pulumi.InvokeOption) (*LookupDataNetworkResult, error) {
	var rv LookupDataNetworkResult
	err := ctx.Invoke("azure-native:mobilenetwork:getDataNetwork", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupDataNetworkArgs struct {
	// The name of the mobile network dataNetwork.
	DataNetworkName string `pulumi:"dataNetworkName"`
	// The name of the mobile network.
	MobileNetworkName string `pulumi:"mobileNetworkName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Data network resource.
type LookupDataNetworkResult struct {
	// The timestamp of resource creation (UTC).
	CreatedAt *string `pulumi:"createdAt"`
	// The identity that created the resource.
	CreatedBy *string `pulumi:"createdBy"`
	// The type of identity that created the resource.
	CreatedByType *string `pulumi:"createdByType"`
	// An optional description for this data network.
	Description *string `pulumi:"description"`
	// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
	Id string `pulumi:"id"`
	// The timestamp of resource last modification (UTC)
	LastModifiedAt *string `pulumi:"lastModifiedAt"`
	// The identity that last modified the resource.
	LastModifiedBy *string `pulumi:"lastModifiedBy"`
	// The type of identity that last modified the resource.
	LastModifiedByType *string `pulumi:"lastModifiedByType"`
	// The geo-location where the resource lives
	Location string `pulumi:"location"`
	// The name of the resource
	Name string `pulumi:"name"`
	// The provisioning state of the data network resource.
	ProvisioningState string `pulumi:"provisioningState"`
	// Resource tags.
	Tags map[string]string `pulumi:"tags"`
	// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
	Type string `pulumi:"type"`
}

func LookupDataNetworkOutput(ctx *pulumi.Context, args LookupDataNetworkOutputArgs, opts ...pulumi.InvokeOption) LookupDataNetworkResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupDataNetworkResult, error) {
			args := v.(LookupDataNetworkArgs)
			r, err := LookupDataNetwork(ctx, &args, opts...)
			var s LookupDataNetworkResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupDataNetworkResultOutput)
}

type LookupDataNetworkOutputArgs struct {
	// The name of the mobile network dataNetwork.
	DataNetworkName pulumi.StringInput `pulumi:"dataNetworkName"`
	// The name of the mobile network.
	MobileNetworkName pulumi.StringInput `pulumi:"mobileNetworkName"`
	// The name of the resource group. The name is case insensitive.
	ResourceGroupName pulumi.StringInput `pulumi:"resourceGroupName"`
}

func (LookupDataNetworkOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupDataNetworkArgs)(nil)).Elem()
}

// Data network resource.
type LookupDataNetworkResultOutput struct{ *pulumi.OutputState }

func (LookupDataNetworkResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupDataNetworkResult)(nil)).Elem()
}

func (o LookupDataNetworkResultOutput) ToLookupDataNetworkResultOutput() LookupDataNetworkResultOutput {
	return o
}

func (o LookupDataNetworkResultOutput) ToLookupDataNetworkResultOutputWithContext(ctx context.Context) LookupDataNetworkResultOutput {
	return o
}

// The timestamp of resource creation (UTC).
func (o LookupDataNetworkResultOutput) CreatedAt() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupDataNetworkResult) *string { return v.CreatedAt }).(pulumi.StringPtrOutput)
}

// The identity that created the resource.
func (o LookupDataNetworkResultOutput) CreatedBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupDataNetworkResult) *string { return v.CreatedBy }).(pulumi.StringPtrOutput)
}

// The type of identity that created the resource.
func (o LookupDataNetworkResultOutput) CreatedByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupDataNetworkResult) *string { return v.CreatedByType }).(pulumi.StringPtrOutput)
}

// An optional description for this data network.
func (o LookupDataNetworkResultOutput) Description() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupDataNetworkResult) *string { return v.Description }).(pulumi.StringPtrOutput)
}

// Fully qualified resource ID for the resource. Ex - /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/{resourceProviderNamespace}/{resourceType}/{resourceName}
func (o LookupDataNetworkResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDataNetworkResult) string { return v.Id }).(pulumi.StringOutput)
}

// The timestamp of resource last modification (UTC)
func (o LookupDataNetworkResultOutput) LastModifiedAt() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupDataNetworkResult) *string { return v.LastModifiedAt }).(pulumi.StringPtrOutput)
}

// The identity that last modified the resource.
func (o LookupDataNetworkResultOutput) LastModifiedBy() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupDataNetworkResult) *string { return v.LastModifiedBy }).(pulumi.StringPtrOutput)
}

// The type of identity that last modified the resource.
func (o LookupDataNetworkResultOutput) LastModifiedByType() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupDataNetworkResult) *string { return v.LastModifiedByType }).(pulumi.StringPtrOutput)
}

// The geo-location where the resource lives
func (o LookupDataNetworkResultOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDataNetworkResult) string { return v.Location }).(pulumi.StringOutput)
}

// The name of the resource
func (o LookupDataNetworkResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDataNetworkResult) string { return v.Name }).(pulumi.StringOutput)
}

// The provisioning state of the data network resource.
func (o LookupDataNetworkResultOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDataNetworkResult) string { return v.ProvisioningState }).(pulumi.StringOutput)
}

// Resource tags.
func (o LookupDataNetworkResultOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupDataNetworkResult) map[string]string { return v.Tags }).(pulumi.StringMapOutput)
}

// The type of the resource. E.g. "Microsoft.Compute/virtualMachines" or "Microsoft.Storage/storageAccounts"
func (o LookupDataNetworkResultOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDataNetworkResult) string { return v.Type }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupDataNetworkResultOutput{})
}
