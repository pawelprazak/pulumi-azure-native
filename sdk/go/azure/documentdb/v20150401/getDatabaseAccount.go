// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20150401

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// An Azure Cosmos DB database account.
//
// Deprecated: Version 2015-04-01 will be removed in v2 of the provider.
func LookupDatabaseAccount(ctx *pulumi.Context, args *LookupDatabaseAccountArgs, opts ...pulumi.InvokeOption) (*LookupDatabaseAccountResult, error) {
	var rv LookupDatabaseAccountResult
	err := ctx.Invoke("azure-native:documentdb/v20150401:getDatabaseAccount", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return rv.Defaults(), nil
}

type LookupDatabaseAccountArgs struct {
	// Cosmos DB database account name.
	AccountName string `pulumi:"accountName"`
	// Name of an Azure resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// An Azure Cosmos DB database account.
type LookupDatabaseAccountResult struct {
	// List of Cosmos DB capabilities for the account
	Capabilities []CapabilityResponse `pulumi:"capabilities"`
	// The cassandra connector offer type for the Cosmos DB database C* account.
	ConnectorOffer *string `pulumi:"connectorOffer"`
	// The consistency policy for the Cosmos DB database account.
	ConsistencyPolicy *ConsistencyPolicyResponse `pulumi:"consistencyPolicy"`
	// The offer type for the Cosmos DB database account. Default value: Standard.
	DatabaseAccountOfferType string `pulumi:"databaseAccountOfferType"`
	// The connection endpoint for the Cosmos DB database account.
	DocumentEndpoint string `pulumi:"documentEndpoint"`
	// Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.
	EnableAutomaticFailover *bool `pulumi:"enableAutomaticFailover"`
	// Enables the cassandra connector on the Cosmos DB C* account
	EnableCassandraConnector *bool `pulumi:"enableCassandraConnector"`
	// Enables the account to write in multiple locations
	EnableMultipleWriteLocations *bool `pulumi:"enableMultipleWriteLocations"`
	// An array that contains the regions ordered by their failover priorities.
	FailoverPolicies []FailoverPolicyResponse `pulumi:"failoverPolicies"`
	// The unique resource identifier of the database account.
	Id string `pulumi:"id"`
	// Cosmos DB Firewall Support: This value specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma separated and must not contain any spaces.
	IpRangeFilter *string `pulumi:"ipRangeFilter"`
	// Flag to indicate whether to enable/disable Virtual Network ACL rules.
	IsVirtualNetworkFilterEnabled *bool `pulumi:"isVirtualNetworkFilterEnabled"`
	// Indicates the type of database account. This can only be set at database account creation.
	Kind *string `pulumi:"kind"`
	// The location of the resource group to which the resource belongs.
	Location *string `pulumi:"location"`
	// The name of the database account.
	Name string `pulumi:"name"`
	// The status of the Cosmos DB account at the time the operation was called. The status can be one of following. 'Creating' – the Cosmos DB account is being created. When an account is in Creating state, only properties that are specified as input for the Create Cosmos DB account operation are returned. 'Succeeded' – the Cosmos DB account is active for use. 'Updating' – the Cosmos DB account is being updated. 'Deleting' – the Cosmos DB account is being deleted. 'Failed' – the Cosmos DB account failed creation. 'Offline' - the Cosmos DB account is not active. 'DeletionFailed' – the Cosmos DB account deletion failed.
	ProvisioningState string `pulumi:"provisioningState"`
	// An array that contains of the read locations enabled for the Cosmos DB account.
	ReadLocations []LocationResponse `pulumi:"readLocations"`
	// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
	Tags map[string]string `pulumi:"tags"`
	// The type of Azure resource.
	Type string `pulumi:"type"`
	// List of Virtual Network ACL rules configured for the Cosmos DB account.
	VirtualNetworkRules []VirtualNetworkRuleResponse `pulumi:"virtualNetworkRules"`
	// An array that contains the write location for the Cosmos DB account.
	WriteLocations []LocationResponse `pulumi:"writeLocations"`
}

// Defaults sets the appropriate defaults for LookupDatabaseAccountResult
func (val *LookupDatabaseAccountResult) Defaults() *LookupDatabaseAccountResult {
	if val == nil {
		return nil
	}
	tmp := *val
	if isZero(tmp.Kind) {
		kind_ := "GlobalDocumentDB"
		tmp.Kind = &kind_
	}
	return &tmp
}

func LookupDatabaseAccountOutput(ctx *pulumi.Context, args LookupDatabaseAccountOutputArgs, opts ...pulumi.InvokeOption) LookupDatabaseAccountResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupDatabaseAccountResult, error) {
			args := v.(LookupDatabaseAccountArgs)
			r, err := LookupDatabaseAccount(ctx, &args, opts...)
			var s LookupDatabaseAccountResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupDatabaseAccountResultOutput)
}

type LookupDatabaseAccountOutputArgs struct {
	// Cosmos DB database account name.
	AccountName pulumi.StringInput `pulumi:"accountName"`
	// Name of an Azure resource group.
	ResourceGroupName pulumi.StringInput `pulumi:"resourceGroupName"`
}

func (LookupDatabaseAccountOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupDatabaseAccountArgs)(nil)).Elem()
}

// An Azure Cosmos DB database account.
type LookupDatabaseAccountResultOutput struct{ *pulumi.OutputState }

func (LookupDatabaseAccountResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupDatabaseAccountResult)(nil)).Elem()
}

func (o LookupDatabaseAccountResultOutput) ToLookupDatabaseAccountResultOutput() LookupDatabaseAccountResultOutput {
	return o
}

func (o LookupDatabaseAccountResultOutput) ToLookupDatabaseAccountResultOutputWithContext(ctx context.Context) LookupDatabaseAccountResultOutput {
	return o
}

// List of Cosmos DB capabilities for the account
func (o LookupDatabaseAccountResultOutput) Capabilities() CapabilityResponseArrayOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) []CapabilityResponse { return v.Capabilities }).(CapabilityResponseArrayOutput)
}

// The cassandra connector offer type for the Cosmos DB database C* account.
func (o LookupDatabaseAccountResultOutput) ConnectorOffer() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) *string { return v.ConnectorOffer }).(pulumi.StringPtrOutput)
}

// The consistency policy for the Cosmos DB database account.
func (o LookupDatabaseAccountResultOutput) ConsistencyPolicy() ConsistencyPolicyResponsePtrOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) *ConsistencyPolicyResponse { return v.ConsistencyPolicy }).(ConsistencyPolicyResponsePtrOutput)
}

// The offer type for the Cosmos DB database account. Default value: Standard.
func (o LookupDatabaseAccountResultOutput) DatabaseAccountOfferType() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) string { return v.DatabaseAccountOfferType }).(pulumi.StringOutput)
}

// The connection endpoint for the Cosmos DB database account.
func (o LookupDatabaseAccountResultOutput) DocumentEndpoint() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) string { return v.DocumentEndpoint }).(pulumi.StringOutput)
}

// Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account.
func (o LookupDatabaseAccountResultOutput) EnableAutomaticFailover() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) *bool { return v.EnableAutomaticFailover }).(pulumi.BoolPtrOutput)
}

// Enables the cassandra connector on the Cosmos DB C* account
func (o LookupDatabaseAccountResultOutput) EnableCassandraConnector() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) *bool { return v.EnableCassandraConnector }).(pulumi.BoolPtrOutput)
}

// Enables the account to write in multiple locations
func (o LookupDatabaseAccountResultOutput) EnableMultipleWriteLocations() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) *bool { return v.EnableMultipleWriteLocations }).(pulumi.BoolPtrOutput)
}

// An array that contains the regions ordered by their failover priorities.
func (o LookupDatabaseAccountResultOutput) FailoverPolicies() FailoverPolicyResponseArrayOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) []FailoverPolicyResponse { return v.FailoverPolicies }).(FailoverPolicyResponseArrayOutput)
}

// The unique resource identifier of the database account.
func (o LookupDatabaseAccountResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) string { return v.Id }).(pulumi.StringOutput)
}

// Cosmos DB Firewall Support: This value specifies the set of IP addresses or IP address ranges in CIDR form to be included as the allowed list of client IPs for a given database account. IP addresses/ranges must be comma separated and must not contain any spaces.
func (o LookupDatabaseAccountResultOutput) IpRangeFilter() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) *string { return v.IpRangeFilter }).(pulumi.StringPtrOutput)
}

// Flag to indicate whether to enable/disable Virtual Network ACL rules.
func (o LookupDatabaseAccountResultOutput) IsVirtualNetworkFilterEnabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) *bool { return v.IsVirtualNetworkFilterEnabled }).(pulumi.BoolPtrOutput)
}

// Indicates the type of database account. This can only be set at database account creation.
func (o LookupDatabaseAccountResultOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) *string { return v.Kind }).(pulumi.StringPtrOutput)
}

// The location of the resource group to which the resource belongs.
func (o LookupDatabaseAccountResultOutput) Location() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) *string { return v.Location }).(pulumi.StringPtrOutput)
}

// The name of the database account.
func (o LookupDatabaseAccountResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) string { return v.Name }).(pulumi.StringOutput)
}

// The status of the Cosmos DB account at the time the operation was called. The status can be one of following. 'Creating' – the Cosmos DB account is being created. When an account is in Creating state, only properties that are specified as input for the Create Cosmos DB account operation are returned. 'Succeeded' – the Cosmos DB account is active for use. 'Updating' – the Cosmos DB account is being updated. 'Deleting' – the Cosmos DB account is being deleted. 'Failed' – the Cosmos DB account failed creation. 'Offline' - the Cosmos DB account is not active. 'DeletionFailed' – the Cosmos DB account deletion failed.
func (o LookupDatabaseAccountResultOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) string { return v.ProvisioningState }).(pulumi.StringOutput)
}

// An array that contains of the read locations enabled for the Cosmos DB account.
func (o LookupDatabaseAccountResultOutput) ReadLocations() LocationResponseArrayOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) []LocationResponse { return v.ReadLocations }).(LocationResponseArrayOutput)
}

// Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB".
func (o LookupDatabaseAccountResultOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) map[string]string { return v.Tags }).(pulumi.StringMapOutput)
}

// The type of Azure resource.
func (o LookupDatabaseAccountResultOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) string { return v.Type }).(pulumi.StringOutput)
}

// List of Virtual Network ACL rules configured for the Cosmos DB account.
func (o LookupDatabaseAccountResultOutput) VirtualNetworkRules() VirtualNetworkRuleResponseArrayOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) []VirtualNetworkRuleResponse { return v.VirtualNetworkRules }).(VirtualNetworkRuleResponseArrayOutput)
}

// An array that contains the write location for the Cosmos DB account.
func (o LookupDatabaseAccountResultOutput) WriteLocations() LocationResponseArrayOutput {
	return o.ApplyT(func(v LookupDatabaseAccountResult) []LocationResponse { return v.WriteLocations }).(LocationResponseArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupDatabaseAccountResultOutput{})
}
