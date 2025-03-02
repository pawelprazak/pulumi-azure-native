// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package dbforpostgresql

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// The type of administrator.
type AdministratorType string

const (
	AdministratorTypeActiveDirectory = AdministratorType("ActiveDirectory")
)

// The mode to create a new server.
type CreateMode string

const (
	CreateModeDefault            = CreateMode("Default")
	CreateModePointInTimeRestore = CreateMode("PointInTimeRestore")
	CreateModeGeoRestore         = CreateMode("GeoRestore")
	CreateModeReplica            = CreateMode("Replica")
)

// Enable Geo-redundant or not for server backup.
type GeoRedundantBackup string

const (
	GeoRedundantBackupEnabled  = GeoRedundantBackup("Enabled")
	GeoRedundantBackupDisabled = GeoRedundantBackup("Disabled")
)

// The identity type. Set this to 'SystemAssigned' in order to automatically create and assign an Azure Active Directory principal for the resource.
type IdentityType string

const (
	IdentityTypeSystemAssigned = IdentityType("SystemAssigned")
)

// Status showing whether the server enabled infrastructure encryption.
type InfrastructureEncryption string

const (
	// Default value for single layer of encryption for data at rest.
	InfrastructureEncryptionEnabled = InfrastructureEncryption("Enabled")
	// Additional (2nd) layer of encryption for data at rest
	InfrastructureEncryptionDisabled = InfrastructureEncryption("Disabled")
)

// Enforce a minimal Tls version for the server.
type MinimalTlsVersionEnum string

const (
	MinimalTlsVersionEnum_TLS1_0                = MinimalTlsVersionEnum("TLS1_0")
	MinimalTlsVersionEnum_TLS1_1                = MinimalTlsVersionEnum("TLS1_1")
	MinimalTlsVersionEnum_TLS1_2                = MinimalTlsVersionEnum("TLS1_2")
	MinimalTlsVersionEnumTLSEnforcementDisabled = MinimalTlsVersionEnum("TLSEnforcementDisabled")
)

// Whether or not public network access is allowed for this server. Value is optional but if passed in, must be 'Enabled' or 'Disabled'
type PublicNetworkAccessEnum string

const (
	PublicNetworkAccessEnumEnabled  = PublicNetworkAccessEnum("Enabled")
	PublicNetworkAccessEnumDisabled = PublicNetworkAccessEnum("Disabled")
)

// The key type like 'AzureKeyVault'.
type ServerKeyType string

const (
	ServerKeyTypeAzureKeyVault = ServerKeyType("AzureKeyVault")
)

// Specifies the state of the policy, whether it is enabled or disabled.
type ServerSecurityAlertPolicyStateEnum string

const (
	ServerSecurityAlertPolicyStateEnumEnabled  = ServerSecurityAlertPolicyStateEnum("Enabled")
	ServerSecurityAlertPolicyStateEnumDisabled = ServerSecurityAlertPolicyStateEnum("Disabled")
)

func (ServerSecurityAlertPolicyStateEnum) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerSecurityAlertPolicyStateEnum)(nil)).Elem()
}

func (e ServerSecurityAlertPolicyStateEnum) ToServerSecurityAlertPolicyStateEnumOutput() ServerSecurityAlertPolicyStateEnumOutput {
	return pulumi.ToOutput(e).(ServerSecurityAlertPolicyStateEnumOutput)
}

func (e ServerSecurityAlertPolicyStateEnum) ToServerSecurityAlertPolicyStateEnumOutputWithContext(ctx context.Context) ServerSecurityAlertPolicyStateEnumOutput {
	return pulumi.ToOutputWithContext(ctx, e).(ServerSecurityAlertPolicyStateEnumOutput)
}

func (e ServerSecurityAlertPolicyStateEnum) ToServerSecurityAlertPolicyStateEnumPtrOutput() ServerSecurityAlertPolicyStateEnumPtrOutput {
	return e.ToServerSecurityAlertPolicyStateEnumPtrOutputWithContext(context.Background())
}

func (e ServerSecurityAlertPolicyStateEnum) ToServerSecurityAlertPolicyStateEnumPtrOutputWithContext(ctx context.Context) ServerSecurityAlertPolicyStateEnumPtrOutput {
	return ServerSecurityAlertPolicyStateEnum(e).ToServerSecurityAlertPolicyStateEnumOutputWithContext(ctx).ToServerSecurityAlertPolicyStateEnumPtrOutputWithContext(ctx)
}

func (e ServerSecurityAlertPolicyStateEnum) ToStringOutput() pulumi.StringOutput {
	return pulumi.ToOutput(pulumi.String(e)).(pulumi.StringOutput)
}

func (e ServerSecurityAlertPolicyStateEnum) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return pulumi.ToOutputWithContext(ctx, pulumi.String(e)).(pulumi.StringOutput)
}

func (e ServerSecurityAlertPolicyStateEnum) ToStringPtrOutput() pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringPtrOutputWithContext(context.Background())
}

func (e ServerSecurityAlertPolicyStateEnum) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return pulumi.String(e).ToStringOutputWithContext(ctx).ToStringPtrOutputWithContext(ctx)
}

type ServerSecurityAlertPolicyStateEnumOutput struct{ *pulumi.OutputState }

func (ServerSecurityAlertPolicyStateEnumOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ServerSecurityAlertPolicyStateEnum)(nil)).Elem()
}

func (o ServerSecurityAlertPolicyStateEnumOutput) ToServerSecurityAlertPolicyStateEnumOutput() ServerSecurityAlertPolicyStateEnumOutput {
	return o
}

func (o ServerSecurityAlertPolicyStateEnumOutput) ToServerSecurityAlertPolicyStateEnumOutputWithContext(ctx context.Context) ServerSecurityAlertPolicyStateEnumOutput {
	return o
}

func (o ServerSecurityAlertPolicyStateEnumOutput) ToServerSecurityAlertPolicyStateEnumPtrOutput() ServerSecurityAlertPolicyStateEnumPtrOutput {
	return o.ToServerSecurityAlertPolicyStateEnumPtrOutputWithContext(context.Background())
}

func (o ServerSecurityAlertPolicyStateEnumOutput) ToServerSecurityAlertPolicyStateEnumPtrOutputWithContext(ctx context.Context) ServerSecurityAlertPolicyStateEnumPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v ServerSecurityAlertPolicyStateEnum) *ServerSecurityAlertPolicyStateEnum {
		return &v
	}).(ServerSecurityAlertPolicyStateEnumPtrOutput)
}

func (o ServerSecurityAlertPolicyStateEnumOutput) ToStringOutput() pulumi.StringOutput {
	return o.ToStringOutputWithContext(context.Background())
}

func (o ServerSecurityAlertPolicyStateEnumOutput) ToStringOutputWithContext(ctx context.Context) pulumi.StringOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e ServerSecurityAlertPolicyStateEnum) string {
		return string(e)
	}).(pulumi.StringOutput)
}

func (o ServerSecurityAlertPolicyStateEnumOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o ServerSecurityAlertPolicyStateEnumOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e ServerSecurityAlertPolicyStateEnum) *string {
		v := string(e)
		return &v
	}).(pulumi.StringPtrOutput)
}

type ServerSecurityAlertPolicyStateEnumPtrOutput struct{ *pulumi.OutputState }

func (ServerSecurityAlertPolicyStateEnumPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**ServerSecurityAlertPolicyStateEnum)(nil)).Elem()
}

func (o ServerSecurityAlertPolicyStateEnumPtrOutput) ToServerSecurityAlertPolicyStateEnumPtrOutput() ServerSecurityAlertPolicyStateEnumPtrOutput {
	return o
}

func (o ServerSecurityAlertPolicyStateEnumPtrOutput) ToServerSecurityAlertPolicyStateEnumPtrOutputWithContext(ctx context.Context) ServerSecurityAlertPolicyStateEnumPtrOutput {
	return o
}

func (o ServerSecurityAlertPolicyStateEnumPtrOutput) Elem() ServerSecurityAlertPolicyStateEnumOutput {
	return o.ApplyT(func(v *ServerSecurityAlertPolicyStateEnum) ServerSecurityAlertPolicyStateEnum {
		if v != nil {
			return *v
		}
		var ret ServerSecurityAlertPolicyStateEnum
		return ret
	}).(ServerSecurityAlertPolicyStateEnumOutput)
}

func (o ServerSecurityAlertPolicyStateEnumPtrOutput) ToStringPtrOutput() pulumi.StringPtrOutput {
	return o.ToStringPtrOutputWithContext(context.Background())
}

func (o ServerSecurityAlertPolicyStateEnumPtrOutput) ToStringPtrOutputWithContext(ctx context.Context) pulumi.StringPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, e *ServerSecurityAlertPolicyStateEnum) *string {
		if e == nil {
			return nil
		}
		v := string(*e)
		return &v
	}).(pulumi.StringPtrOutput)
}

// ServerSecurityAlertPolicyStateEnumInput is an input type that accepts ServerSecurityAlertPolicyStateEnumArgs and ServerSecurityAlertPolicyStateEnumOutput values.
// You can construct a concrete instance of `ServerSecurityAlertPolicyStateEnumInput` via:
//
//          ServerSecurityAlertPolicyStateEnumArgs{...}
type ServerSecurityAlertPolicyStateEnumInput interface {
	pulumi.Input

	ToServerSecurityAlertPolicyStateEnumOutput() ServerSecurityAlertPolicyStateEnumOutput
	ToServerSecurityAlertPolicyStateEnumOutputWithContext(context.Context) ServerSecurityAlertPolicyStateEnumOutput
}

var serverSecurityAlertPolicyStateEnumPtrType = reflect.TypeOf((**ServerSecurityAlertPolicyStateEnum)(nil)).Elem()

type ServerSecurityAlertPolicyStateEnumPtrInput interface {
	pulumi.Input

	ToServerSecurityAlertPolicyStateEnumPtrOutput() ServerSecurityAlertPolicyStateEnumPtrOutput
	ToServerSecurityAlertPolicyStateEnumPtrOutputWithContext(context.Context) ServerSecurityAlertPolicyStateEnumPtrOutput
}

type serverSecurityAlertPolicyStateEnumPtr string

func ServerSecurityAlertPolicyStateEnumPtr(v string) ServerSecurityAlertPolicyStateEnumPtrInput {
	return (*serverSecurityAlertPolicyStateEnumPtr)(&v)
}

func (*serverSecurityAlertPolicyStateEnumPtr) ElementType() reflect.Type {
	return serverSecurityAlertPolicyStateEnumPtrType
}

func (in *serverSecurityAlertPolicyStateEnumPtr) ToServerSecurityAlertPolicyStateEnumPtrOutput() ServerSecurityAlertPolicyStateEnumPtrOutput {
	return pulumi.ToOutput(in).(ServerSecurityAlertPolicyStateEnumPtrOutput)
}

func (in *serverSecurityAlertPolicyStateEnumPtr) ToServerSecurityAlertPolicyStateEnumPtrOutputWithContext(ctx context.Context) ServerSecurityAlertPolicyStateEnumPtrOutput {
	return pulumi.ToOutputWithContext(ctx, in).(ServerSecurityAlertPolicyStateEnumPtrOutput)
}

// Server version.
type ServerVersion string

const (
	ServerVersion_9_5  = ServerVersion("9.5")
	ServerVersion_9_6  = ServerVersion("9.6")
	ServerVersion_10   = ServerVersion("10")
	ServerVersion_10_0 = ServerVersion("10.0")
	ServerVersion_10_2 = ServerVersion("10.2")
	ServerVersion_11   = ServerVersion("11")
)

// The tier of the particular SKU, e.g. Basic.
type SkuTier string

const (
	SkuTierBasic           = SkuTier("Basic")
	SkuTierGeneralPurpose  = SkuTier("GeneralPurpose")
	SkuTierMemoryOptimized = SkuTier("MemoryOptimized")
)

// Enable ssl enforcement or not when connect to server.
type SslEnforcementEnum string

const (
	SslEnforcementEnumEnabled  = SslEnforcementEnum("Enabled")
	SslEnforcementEnumDisabled = SslEnforcementEnum("Disabled")
)

// Enable Storage Auto Grow.
type StorageAutogrow string

const (
	StorageAutogrowEnabled  = StorageAutogrow("Enabled")
	StorageAutogrowDisabled = StorageAutogrow("Disabled")
)

func init() {
	pulumi.RegisterOutputType(ServerSecurityAlertPolicyStateEnumOutput{})
	pulumi.RegisterOutputType(ServerSecurityAlertPolicyStateEnumPtrOutput{})
}
