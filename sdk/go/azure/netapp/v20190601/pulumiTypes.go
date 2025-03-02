// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20190601

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Active Directory
type ActiveDirectory struct {
	// Id of the Active Directory
	ActiveDirectoryId *string `pulumi:"activeDirectoryId"`
	// Comma separated list of DNS server IP addresses for the Active Directory domain
	Dns *string `pulumi:"dns"`
	// Name of the Active Directory domain
	Domain *string `pulumi:"domain"`
	// The Organizational Unit (OU) within the Windows Active Directory
	OrganizationalUnit *string `pulumi:"organizationalUnit"`
	// Plain text password of Active Directory domain administrator
	Password *string `pulumi:"password"`
	// NetBIOS name of the SMB server. This name will be registered as a computer account in the AD and used to mount volumes
	SmbServerName *string `pulumi:"smbServerName"`
	// Status of the Active Directory
	Status *string `pulumi:"status"`
	// Username of Active Directory domain administrator
	Username *string `pulumi:"username"`
}

// ActiveDirectoryInput is an input type that accepts ActiveDirectoryArgs and ActiveDirectoryOutput values.
// You can construct a concrete instance of `ActiveDirectoryInput` via:
//
//          ActiveDirectoryArgs{...}
type ActiveDirectoryInput interface {
	pulumi.Input

	ToActiveDirectoryOutput() ActiveDirectoryOutput
	ToActiveDirectoryOutputWithContext(context.Context) ActiveDirectoryOutput
}

// Active Directory
type ActiveDirectoryArgs struct {
	// Id of the Active Directory
	ActiveDirectoryId pulumi.StringPtrInput `pulumi:"activeDirectoryId"`
	// Comma separated list of DNS server IP addresses for the Active Directory domain
	Dns pulumi.StringPtrInput `pulumi:"dns"`
	// Name of the Active Directory domain
	Domain pulumi.StringPtrInput `pulumi:"domain"`
	// The Organizational Unit (OU) within the Windows Active Directory
	OrganizationalUnit pulumi.StringPtrInput `pulumi:"organizationalUnit"`
	// Plain text password of Active Directory domain administrator
	Password pulumi.StringPtrInput `pulumi:"password"`
	// NetBIOS name of the SMB server. This name will be registered as a computer account in the AD and used to mount volumes
	SmbServerName pulumi.StringPtrInput `pulumi:"smbServerName"`
	// Status of the Active Directory
	Status pulumi.StringPtrInput `pulumi:"status"`
	// Username of Active Directory domain administrator
	Username pulumi.StringPtrInput `pulumi:"username"`
}

func (ActiveDirectoryArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ActiveDirectory)(nil)).Elem()
}

func (i ActiveDirectoryArgs) ToActiveDirectoryOutput() ActiveDirectoryOutput {
	return i.ToActiveDirectoryOutputWithContext(context.Background())
}

func (i ActiveDirectoryArgs) ToActiveDirectoryOutputWithContext(ctx context.Context) ActiveDirectoryOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ActiveDirectoryOutput)
}

// ActiveDirectoryArrayInput is an input type that accepts ActiveDirectoryArray and ActiveDirectoryArrayOutput values.
// You can construct a concrete instance of `ActiveDirectoryArrayInput` via:
//
//          ActiveDirectoryArray{ ActiveDirectoryArgs{...} }
type ActiveDirectoryArrayInput interface {
	pulumi.Input

	ToActiveDirectoryArrayOutput() ActiveDirectoryArrayOutput
	ToActiveDirectoryArrayOutputWithContext(context.Context) ActiveDirectoryArrayOutput
}

type ActiveDirectoryArray []ActiveDirectoryInput

func (ActiveDirectoryArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ActiveDirectory)(nil)).Elem()
}

func (i ActiveDirectoryArray) ToActiveDirectoryArrayOutput() ActiveDirectoryArrayOutput {
	return i.ToActiveDirectoryArrayOutputWithContext(context.Background())
}

func (i ActiveDirectoryArray) ToActiveDirectoryArrayOutputWithContext(ctx context.Context) ActiveDirectoryArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ActiveDirectoryArrayOutput)
}

// Active Directory
type ActiveDirectoryOutput struct{ *pulumi.OutputState }

func (ActiveDirectoryOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ActiveDirectory)(nil)).Elem()
}

func (o ActiveDirectoryOutput) ToActiveDirectoryOutput() ActiveDirectoryOutput {
	return o
}

func (o ActiveDirectoryOutput) ToActiveDirectoryOutputWithContext(ctx context.Context) ActiveDirectoryOutput {
	return o
}

// Id of the Active Directory
func (o ActiveDirectoryOutput) ActiveDirectoryId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ActiveDirectory) *string { return v.ActiveDirectoryId }).(pulumi.StringPtrOutput)
}

// Comma separated list of DNS server IP addresses for the Active Directory domain
func (o ActiveDirectoryOutput) Dns() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ActiveDirectory) *string { return v.Dns }).(pulumi.StringPtrOutput)
}

// Name of the Active Directory domain
func (o ActiveDirectoryOutput) Domain() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ActiveDirectory) *string { return v.Domain }).(pulumi.StringPtrOutput)
}

// The Organizational Unit (OU) within the Windows Active Directory
func (o ActiveDirectoryOutput) OrganizationalUnit() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ActiveDirectory) *string { return v.OrganizationalUnit }).(pulumi.StringPtrOutput)
}

// Plain text password of Active Directory domain administrator
func (o ActiveDirectoryOutput) Password() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ActiveDirectory) *string { return v.Password }).(pulumi.StringPtrOutput)
}

// NetBIOS name of the SMB server. This name will be registered as a computer account in the AD and used to mount volumes
func (o ActiveDirectoryOutput) SmbServerName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ActiveDirectory) *string { return v.SmbServerName }).(pulumi.StringPtrOutput)
}

// Status of the Active Directory
func (o ActiveDirectoryOutput) Status() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ActiveDirectory) *string { return v.Status }).(pulumi.StringPtrOutput)
}

// Username of Active Directory domain administrator
func (o ActiveDirectoryOutput) Username() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ActiveDirectory) *string { return v.Username }).(pulumi.StringPtrOutput)
}

type ActiveDirectoryArrayOutput struct{ *pulumi.OutputState }

func (ActiveDirectoryArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ActiveDirectory)(nil)).Elem()
}

func (o ActiveDirectoryArrayOutput) ToActiveDirectoryArrayOutput() ActiveDirectoryArrayOutput {
	return o
}

func (o ActiveDirectoryArrayOutput) ToActiveDirectoryArrayOutputWithContext(ctx context.Context) ActiveDirectoryArrayOutput {
	return o
}

func (o ActiveDirectoryArrayOutput) Index(i pulumi.IntInput) ActiveDirectoryOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ActiveDirectory {
		return vs[0].([]ActiveDirectory)[vs[1].(int)]
	}).(ActiveDirectoryOutput)
}

// Active Directory
type ActiveDirectoryResponse struct {
	// Id of the Active Directory
	ActiveDirectoryId *string `pulumi:"activeDirectoryId"`
	// Comma separated list of DNS server IP addresses for the Active Directory domain
	Dns *string `pulumi:"dns"`
	// Name of the Active Directory domain
	Domain *string `pulumi:"domain"`
	// The Organizational Unit (OU) within the Windows Active Directory
	OrganizationalUnit *string `pulumi:"organizationalUnit"`
	// Plain text password of Active Directory domain administrator
	Password *string `pulumi:"password"`
	// NetBIOS name of the SMB server. This name will be registered as a computer account in the AD and used to mount volumes
	SmbServerName *string `pulumi:"smbServerName"`
	// Status of the Active Directory
	Status *string `pulumi:"status"`
	// Username of Active Directory domain administrator
	Username *string `pulumi:"username"`
}

// Active Directory
type ActiveDirectoryResponseOutput struct{ *pulumi.OutputState }

func (ActiveDirectoryResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ActiveDirectoryResponse)(nil)).Elem()
}

func (o ActiveDirectoryResponseOutput) ToActiveDirectoryResponseOutput() ActiveDirectoryResponseOutput {
	return o
}

func (o ActiveDirectoryResponseOutput) ToActiveDirectoryResponseOutputWithContext(ctx context.Context) ActiveDirectoryResponseOutput {
	return o
}

// Id of the Active Directory
func (o ActiveDirectoryResponseOutput) ActiveDirectoryId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ActiveDirectoryResponse) *string { return v.ActiveDirectoryId }).(pulumi.StringPtrOutput)
}

// Comma separated list of DNS server IP addresses for the Active Directory domain
func (o ActiveDirectoryResponseOutput) Dns() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ActiveDirectoryResponse) *string { return v.Dns }).(pulumi.StringPtrOutput)
}

// Name of the Active Directory domain
func (o ActiveDirectoryResponseOutput) Domain() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ActiveDirectoryResponse) *string { return v.Domain }).(pulumi.StringPtrOutput)
}

// The Organizational Unit (OU) within the Windows Active Directory
func (o ActiveDirectoryResponseOutput) OrganizationalUnit() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ActiveDirectoryResponse) *string { return v.OrganizationalUnit }).(pulumi.StringPtrOutput)
}

// Plain text password of Active Directory domain administrator
func (o ActiveDirectoryResponseOutput) Password() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ActiveDirectoryResponse) *string { return v.Password }).(pulumi.StringPtrOutput)
}

// NetBIOS name of the SMB server. This name will be registered as a computer account in the AD and used to mount volumes
func (o ActiveDirectoryResponseOutput) SmbServerName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ActiveDirectoryResponse) *string { return v.SmbServerName }).(pulumi.StringPtrOutput)
}

// Status of the Active Directory
func (o ActiveDirectoryResponseOutput) Status() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ActiveDirectoryResponse) *string { return v.Status }).(pulumi.StringPtrOutput)
}

// Username of Active Directory domain administrator
func (o ActiveDirectoryResponseOutput) Username() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ActiveDirectoryResponse) *string { return v.Username }).(pulumi.StringPtrOutput)
}

type ActiveDirectoryResponseArrayOutput struct{ *pulumi.OutputState }

func (ActiveDirectoryResponseArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ActiveDirectoryResponse)(nil)).Elem()
}

func (o ActiveDirectoryResponseArrayOutput) ToActiveDirectoryResponseArrayOutput() ActiveDirectoryResponseArrayOutput {
	return o
}

func (o ActiveDirectoryResponseArrayOutput) ToActiveDirectoryResponseArrayOutputWithContext(ctx context.Context) ActiveDirectoryResponseArrayOutput {
	return o
}

func (o ActiveDirectoryResponseArrayOutput) Index(i pulumi.IntInput) ActiveDirectoryResponseOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ActiveDirectoryResponse {
		return vs[0].([]ActiveDirectoryResponse)[vs[1].(int)]
	}).(ActiveDirectoryResponseOutput)
}

// Volume Export Policy Rule
type ExportPolicyRule struct {
	// Client ingress specification as comma separated string with IPv4 CIDRs, IPv4 host addresses and host names
	AllowedClients *string `pulumi:"allowedClients"`
	// Allows CIFS protocol
	Cifs *bool `pulumi:"cifs"`
	// Allows NFSv3 protocol
	Nfsv3 *bool `pulumi:"nfsv3"`
	// Deprecated: Will use the NFSv4.1 protocol, please use swagger version 2019-07-01 or later
	Nfsv4 *bool `pulumi:"nfsv4"`
	// Order index
	RuleIndex *int `pulumi:"ruleIndex"`
	// Read only access
	UnixReadOnly *bool `pulumi:"unixReadOnly"`
	// Read and write access
	UnixReadWrite *bool `pulumi:"unixReadWrite"`
}

// ExportPolicyRuleInput is an input type that accepts ExportPolicyRuleArgs and ExportPolicyRuleOutput values.
// You can construct a concrete instance of `ExportPolicyRuleInput` via:
//
//          ExportPolicyRuleArgs{...}
type ExportPolicyRuleInput interface {
	pulumi.Input

	ToExportPolicyRuleOutput() ExportPolicyRuleOutput
	ToExportPolicyRuleOutputWithContext(context.Context) ExportPolicyRuleOutput
}

// Volume Export Policy Rule
type ExportPolicyRuleArgs struct {
	// Client ingress specification as comma separated string with IPv4 CIDRs, IPv4 host addresses and host names
	AllowedClients pulumi.StringPtrInput `pulumi:"allowedClients"`
	// Allows CIFS protocol
	Cifs pulumi.BoolPtrInput `pulumi:"cifs"`
	// Allows NFSv3 protocol
	Nfsv3 pulumi.BoolPtrInput `pulumi:"nfsv3"`
	// Deprecated: Will use the NFSv4.1 protocol, please use swagger version 2019-07-01 or later
	Nfsv4 pulumi.BoolPtrInput `pulumi:"nfsv4"`
	// Order index
	RuleIndex pulumi.IntPtrInput `pulumi:"ruleIndex"`
	// Read only access
	UnixReadOnly pulumi.BoolPtrInput `pulumi:"unixReadOnly"`
	// Read and write access
	UnixReadWrite pulumi.BoolPtrInput `pulumi:"unixReadWrite"`
}

func (ExportPolicyRuleArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*ExportPolicyRule)(nil)).Elem()
}

func (i ExportPolicyRuleArgs) ToExportPolicyRuleOutput() ExportPolicyRuleOutput {
	return i.ToExportPolicyRuleOutputWithContext(context.Background())
}

func (i ExportPolicyRuleArgs) ToExportPolicyRuleOutputWithContext(ctx context.Context) ExportPolicyRuleOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExportPolicyRuleOutput)
}

// ExportPolicyRuleArrayInput is an input type that accepts ExportPolicyRuleArray and ExportPolicyRuleArrayOutput values.
// You can construct a concrete instance of `ExportPolicyRuleArrayInput` via:
//
//          ExportPolicyRuleArray{ ExportPolicyRuleArgs{...} }
type ExportPolicyRuleArrayInput interface {
	pulumi.Input

	ToExportPolicyRuleArrayOutput() ExportPolicyRuleArrayOutput
	ToExportPolicyRuleArrayOutputWithContext(context.Context) ExportPolicyRuleArrayOutput
}

type ExportPolicyRuleArray []ExportPolicyRuleInput

func (ExportPolicyRuleArray) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ExportPolicyRule)(nil)).Elem()
}

func (i ExportPolicyRuleArray) ToExportPolicyRuleArrayOutput() ExportPolicyRuleArrayOutput {
	return i.ToExportPolicyRuleArrayOutputWithContext(context.Background())
}

func (i ExportPolicyRuleArray) ToExportPolicyRuleArrayOutputWithContext(ctx context.Context) ExportPolicyRuleArrayOutput {
	return pulumi.ToOutputWithContext(ctx, i).(ExportPolicyRuleArrayOutput)
}

// Volume Export Policy Rule
type ExportPolicyRuleOutput struct{ *pulumi.OutputState }

func (ExportPolicyRuleOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ExportPolicyRule)(nil)).Elem()
}

func (o ExportPolicyRuleOutput) ToExportPolicyRuleOutput() ExportPolicyRuleOutput {
	return o
}

func (o ExportPolicyRuleOutput) ToExportPolicyRuleOutputWithContext(ctx context.Context) ExportPolicyRuleOutput {
	return o
}

// Client ingress specification as comma separated string with IPv4 CIDRs, IPv4 host addresses and host names
func (o ExportPolicyRuleOutput) AllowedClients() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ExportPolicyRule) *string { return v.AllowedClients }).(pulumi.StringPtrOutput)
}

// Allows CIFS protocol
func (o ExportPolicyRuleOutput) Cifs() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v ExportPolicyRule) *bool { return v.Cifs }).(pulumi.BoolPtrOutput)
}

// Allows NFSv3 protocol
func (o ExportPolicyRuleOutput) Nfsv3() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v ExportPolicyRule) *bool { return v.Nfsv3 }).(pulumi.BoolPtrOutput)
}

// Deprecated: Will use the NFSv4.1 protocol, please use swagger version 2019-07-01 or later
func (o ExportPolicyRuleOutput) Nfsv4() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v ExportPolicyRule) *bool { return v.Nfsv4 }).(pulumi.BoolPtrOutput)
}

// Order index
func (o ExportPolicyRuleOutput) RuleIndex() pulumi.IntPtrOutput {
	return o.ApplyT(func(v ExportPolicyRule) *int { return v.RuleIndex }).(pulumi.IntPtrOutput)
}

// Read only access
func (o ExportPolicyRuleOutput) UnixReadOnly() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v ExportPolicyRule) *bool { return v.UnixReadOnly }).(pulumi.BoolPtrOutput)
}

// Read and write access
func (o ExportPolicyRuleOutput) UnixReadWrite() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v ExportPolicyRule) *bool { return v.UnixReadWrite }).(pulumi.BoolPtrOutput)
}

type ExportPolicyRuleArrayOutput struct{ *pulumi.OutputState }

func (ExportPolicyRuleArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ExportPolicyRule)(nil)).Elem()
}

func (o ExportPolicyRuleArrayOutput) ToExportPolicyRuleArrayOutput() ExportPolicyRuleArrayOutput {
	return o
}

func (o ExportPolicyRuleArrayOutput) ToExportPolicyRuleArrayOutputWithContext(ctx context.Context) ExportPolicyRuleArrayOutput {
	return o
}

func (o ExportPolicyRuleArrayOutput) Index(i pulumi.IntInput) ExportPolicyRuleOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ExportPolicyRule {
		return vs[0].([]ExportPolicyRule)[vs[1].(int)]
	}).(ExportPolicyRuleOutput)
}

// Volume Export Policy Rule
type ExportPolicyRuleResponse struct {
	// Client ingress specification as comma separated string with IPv4 CIDRs, IPv4 host addresses and host names
	AllowedClients *string `pulumi:"allowedClients"`
	// Allows CIFS protocol
	Cifs *bool `pulumi:"cifs"`
	// Allows NFSv3 protocol
	Nfsv3 *bool `pulumi:"nfsv3"`
	// Deprecated: Will use the NFSv4.1 protocol, please use swagger version 2019-07-01 or later
	Nfsv4 *bool `pulumi:"nfsv4"`
	// Order index
	RuleIndex *int `pulumi:"ruleIndex"`
	// Read only access
	UnixReadOnly *bool `pulumi:"unixReadOnly"`
	// Read and write access
	UnixReadWrite *bool `pulumi:"unixReadWrite"`
}

// Volume Export Policy Rule
type ExportPolicyRuleResponseOutput struct{ *pulumi.OutputState }

func (ExportPolicyRuleResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*ExportPolicyRuleResponse)(nil)).Elem()
}

func (o ExportPolicyRuleResponseOutput) ToExportPolicyRuleResponseOutput() ExportPolicyRuleResponseOutput {
	return o
}

func (o ExportPolicyRuleResponseOutput) ToExportPolicyRuleResponseOutputWithContext(ctx context.Context) ExportPolicyRuleResponseOutput {
	return o
}

// Client ingress specification as comma separated string with IPv4 CIDRs, IPv4 host addresses and host names
func (o ExportPolicyRuleResponseOutput) AllowedClients() pulumi.StringPtrOutput {
	return o.ApplyT(func(v ExportPolicyRuleResponse) *string { return v.AllowedClients }).(pulumi.StringPtrOutput)
}

// Allows CIFS protocol
func (o ExportPolicyRuleResponseOutput) Cifs() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v ExportPolicyRuleResponse) *bool { return v.Cifs }).(pulumi.BoolPtrOutput)
}

// Allows NFSv3 protocol
func (o ExportPolicyRuleResponseOutput) Nfsv3() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v ExportPolicyRuleResponse) *bool { return v.Nfsv3 }).(pulumi.BoolPtrOutput)
}

// Deprecated: Will use the NFSv4.1 protocol, please use swagger version 2019-07-01 or later
func (o ExportPolicyRuleResponseOutput) Nfsv4() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v ExportPolicyRuleResponse) *bool { return v.Nfsv4 }).(pulumi.BoolPtrOutput)
}

// Order index
func (o ExportPolicyRuleResponseOutput) RuleIndex() pulumi.IntPtrOutput {
	return o.ApplyT(func(v ExportPolicyRuleResponse) *int { return v.RuleIndex }).(pulumi.IntPtrOutput)
}

// Read only access
func (o ExportPolicyRuleResponseOutput) UnixReadOnly() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v ExportPolicyRuleResponse) *bool { return v.UnixReadOnly }).(pulumi.BoolPtrOutput)
}

// Read and write access
func (o ExportPolicyRuleResponseOutput) UnixReadWrite() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v ExportPolicyRuleResponse) *bool { return v.UnixReadWrite }).(pulumi.BoolPtrOutput)
}

type ExportPolicyRuleResponseArrayOutput struct{ *pulumi.OutputState }

func (ExportPolicyRuleResponseArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]ExportPolicyRuleResponse)(nil)).Elem()
}

func (o ExportPolicyRuleResponseArrayOutput) ToExportPolicyRuleResponseArrayOutput() ExportPolicyRuleResponseArrayOutput {
	return o
}

func (o ExportPolicyRuleResponseArrayOutput) ToExportPolicyRuleResponseArrayOutputWithContext(ctx context.Context) ExportPolicyRuleResponseArrayOutput {
	return o
}

func (o ExportPolicyRuleResponseArrayOutput) Index(i pulumi.IntInput) ExportPolicyRuleResponseOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) ExportPolicyRuleResponse {
		return vs[0].([]ExportPolicyRuleResponse)[vs[1].(int)]
	}).(ExportPolicyRuleResponseOutput)
}

// Mount target properties
type MountTargetPropertiesResponse struct {
	// The end of IPv4 address range to use when creating a new mount target
	EndIp *string `pulumi:"endIp"`
	// UUID v4 used to identify the MountTarget
	FileSystemId string `pulumi:"fileSystemId"`
	// The gateway of the IPv4 address range to use when creating a new mount target
	Gateway *string `pulumi:"gateway"`
	// The mount target's IPv4 address
	IpAddress string `pulumi:"ipAddress"`
	// UUID v4 used to identify the MountTarget
	MountTargetId string `pulumi:"mountTargetId"`
	// The netmask of the IPv4 address range to use when creating a new mount target
	Netmask *string `pulumi:"netmask"`
	// Azure lifecycle management
	ProvisioningState string `pulumi:"provisioningState"`
	// The SMB server's Fully Qualified Domain Name, FQDN
	SmbServerFqdn *string `pulumi:"smbServerFqdn"`
	// The start of IPv4 address range to use when creating a new mount target
	StartIp *string `pulumi:"startIp"`
	// The subnet
	Subnet *string `pulumi:"subnet"`
}

// Mount target properties
type MountTargetPropertiesResponseOutput struct{ *pulumi.OutputState }

func (MountTargetPropertiesResponseOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*MountTargetPropertiesResponse)(nil)).Elem()
}

func (o MountTargetPropertiesResponseOutput) ToMountTargetPropertiesResponseOutput() MountTargetPropertiesResponseOutput {
	return o
}

func (o MountTargetPropertiesResponseOutput) ToMountTargetPropertiesResponseOutputWithContext(ctx context.Context) MountTargetPropertiesResponseOutput {
	return o
}

// The end of IPv4 address range to use when creating a new mount target
func (o MountTargetPropertiesResponseOutput) EndIp() pulumi.StringPtrOutput {
	return o.ApplyT(func(v MountTargetPropertiesResponse) *string { return v.EndIp }).(pulumi.StringPtrOutput)
}

// UUID v4 used to identify the MountTarget
func (o MountTargetPropertiesResponseOutput) FileSystemId() pulumi.StringOutput {
	return o.ApplyT(func(v MountTargetPropertiesResponse) string { return v.FileSystemId }).(pulumi.StringOutput)
}

// The gateway of the IPv4 address range to use when creating a new mount target
func (o MountTargetPropertiesResponseOutput) Gateway() pulumi.StringPtrOutput {
	return o.ApplyT(func(v MountTargetPropertiesResponse) *string { return v.Gateway }).(pulumi.StringPtrOutput)
}

// The mount target's IPv4 address
func (o MountTargetPropertiesResponseOutput) IpAddress() pulumi.StringOutput {
	return o.ApplyT(func(v MountTargetPropertiesResponse) string { return v.IpAddress }).(pulumi.StringOutput)
}

// UUID v4 used to identify the MountTarget
func (o MountTargetPropertiesResponseOutput) MountTargetId() pulumi.StringOutput {
	return o.ApplyT(func(v MountTargetPropertiesResponse) string { return v.MountTargetId }).(pulumi.StringOutput)
}

// The netmask of the IPv4 address range to use when creating a new mount target
func (o MountTargetPropertiesResponseOutput) Netmask() pulumi.StringPtrOutput {
	return o.ApplyT(func(v MountTargetPropertiesResponse) *string { return v.Netmask }).(pulumi.StringPtrOutput)
}

// Azure lifecycle management
func (o MountTargetPropertiesResponseOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v MountTargetPropertiesResponse) string { return v.ProvisioningState }).(pulumi.StringOutput)
}

// The SMB server's Fully Qualified Domain Name, FQDN
func (o MountTargetPropertiesResponseOutput) SmbServerFqdn() pulumi.StringPtrOutput {
	return o.ApplyT(func(v MountTargetPropertiesResponse) *string { return v.SmbServerFqdn }).(pulumi.StringPtrOutput)
}

// The start of IPv4 address range to use when creating a new mount target
func (o MountTargetPropertiesResponseOutput) StartIp() pulumi.StringPtrOutput {
	return o.ApplyT(func(v MountTargetPropertiesResponse) *string { return v.StartIp }).(pulumi.StringPtrOutput)
}

// The subnet
func (o MountTargetPropertiesResponseOutput) Subnet() pulumi.StringPtrOutput {
	return o.ApplyT(func(v MountTargetPropertiesResponse) *string { return v.Subnet }).(pulumi.StringPtrOutput)
}

type MountTargetPropertiesResponseArrayOutput struct{ *pulumi.OutputState }

func (MountTargetPropertiesResponseArrayOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*[]MountTargetPropertiesResponse)(nil)).Elem()
}

func (o MountTargetPropertiesResponseArrayOutput) ToMountTargetPropertiesResponseArrayOutput() MountTargetPropertiesResponseArrayOutput {
	return o
}

func (o MountTargetPropertiesResponseArrayOutput) ToMountTargetPropertiesResponseArrayOutputWithContext(ctx context.Context) MountTargetPropertiesResponseArrayOutput {
	return o
}

func (o MountTargetPropertiesResponseArrayOutput) Index(i pulumi.IntInput) MountTargetPropertiesResponseOutput {
	return pulumi.All(o, i).ApplyT(func(vs []interface{}) MountTargetPropertiesResponse {
		return vs[0].([]MountTargetPropertiesResponse)[vs[1].(int)]
	}).(MountTargetPropertiesResponseOutput)
}

// Set of export policy rules
type VolumePropertiesExportPolicy struct {
	// Export policy rule
	Rules []ExportPolicyRule `pulumi:"rules"`
}

// VolumePropertiesExportPolicyInput is an input type that accepts VolumePropertiesExportPolicyArgs and VolumePropertiesExportPolicyOutput values.
// You can construct a concrete instance of `VolumePropertiesExportPolicyInput` via:
//
//          VolumePropertiesExportPolicyArgs{...}
type VolumePropertiesExportPolicyInput interface {
	pulumi.Input

	ToVolumePropertiesExportPolicyOutput() VolumePropertiesExportPolicyOutput
	ToVolumePropertiesExportPolicyOutputWithContext(context.Context) VolumePropertiesExportPolicyOutput
}

// Set of export policy rules
type VolumePropertiesExportPolicyArgs struct {
	// Export policy rule
	Rules ExportPolicyRuleArrayInput `pulumi:"rules"`
}

func (VolumePropertiesExportPolicyArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*VolumePropertiesExportPolicy)(nil)).Elem()
}

func (i VolumePropertiesExportPolicyArgs) ToVolumePropertiesExportPolicyOutput() VolumePropertiesExportPolicyOutput {
	return i.ToVolumePropertiesExportPolicyOutputWithContext(context.Background())
}

func (i VolumePropertiesExportPolicyArgs) ToVolumePropertiesExportPolicyOutputWithContext(ctx context.Context) VolumePropertiesExportPolicyOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VolumePropertiesExportPolicyOutput)
}

func (i VolumePropertiesExportPolicyArgs) ToVolumePropertiesExportPolicyPtrOutput() VolumePropertiesExportPolicyPtrOutput {
	return i.ToVolumePropertiesExportPolicyPtrOutputWithContext(context.Background())
}

func (i VolumePropertiesExportPolicyArgs) ToVolumePropertiesExportPolicyPtrOutputWithContext(ctx context.Context) VolumePropertiesExportPolicyPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VolumePropertiesExportPolicyOutput).ToVolumePropertiesExportPolicyPtrOutputWithContext(ctx)
}

// VolumePropertiesExportPolicyPtrInput is an input type that accepts VolumePropertiesExportPolicyArgs, VolumePropertiesExportPolicyPtr and VolumePropertiesExportPolicyPtrOutput values.
// You can construct a concrete instance of `VolumePropertiesExportPolicyPtrInput` via:
//
//          VolumePropertiesExportPolicyArgs{...}
//
//  or:
//
//          nil
type VolumePropertiesExportPolicyPtrInput interface {
	pulumi.Input

	ToVolumePropertiesExportPolicyPtrOutput() VolumePropertiesExportPolicyPtrOutput
	ToVolumePropertiesExportPolicyPtrOutputWithContext(context.Context) VolumePropertiesExportPolicyPtrOutput
}

type volumePropertiesExportPolicyPtrType VolumePropertiesExportPolicyArgs

func VolumePropertiesExportPolicyPtr(v *VolumePropertiesExportPolicyArgs) VolumePropertiesExportPolicyPtrInput {
	return (*volumePropertiesExportPolicyPtrType)(v)
}

func (*volumePropertiesExportPolicyPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**VolumePropertiesExportPolicy)(nil)).Elem()
}

func (i *volumePropertiesExportPolicyPtrType) ToVolumePropertiesExportPolicyPtrOutput() VolumePropertiesExportPolicyPtrOutput {
	return i.ToVolumePropertiesExportPolicyPtrOutputWithContext(context.Background())
}

func (i *volumePropertiesExportPolicyPtrType) ToVolumePropertiesExportPolicyPtrOutputWithContext(ctx context.Context) VolumePropertiesExportPolicyPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VolumePropertiesExportPolicyPtrOutput)
}

// Set of export policy rules
type VolumePropertiesExportPolicyOutput struct{ *pulumi.OutputState }

func (VolumePropertiesExportPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VolumePropertiesExportPolicy)(nil)).Elem()
}

func (o VolumePropertiesExportPolicyOutput) ToVolumePropertiesExportPolicyOutput() VolumePropertiesExportPolicyOutput {
	return o
}

func (o VolumePropertiesExportPolicyOutput) ToVolumePropertiesExportPolicyOutputWithContext(ctx context.Context) VolumePropertiesExportPolicyOutput {
	return o
}

func (o VolumePropertiesExportPolicyOutput) ToVolumePropertiesExportPolicyPtrOutput() VolumePropertiesExportPolicyPtrOutput {
	return o.ToVolumePropertiesExportPolicyPtrOutputWithContext(context.Background())
}

func (o VolumePropertiesExportPolicyOutput) ToVolumePropertiesExportPolicyPtrOutputWithContext(ctx context.Context) VolumePropertiesExportPolicyPtrOutput {
	return o.ApplyTWithContext(ctx, func(_ context.Context, v VolumePropertiesExportPolicy) *VolumePropertiesExportPolicy {
		return &v
	}).(VolumePropertiesExportPolicyPtrOutput)
}

// Export policy rule
func (o VolumePropertiesExportPolicyOutput) Rules() ExportPolicyRuleArrayOutput {
	return o.ApplyT(func(v VolumePropertiesExportPolicy) []ExportPolicyRule { return v.Rules }).(ExportPolicyRuleArrayOutput)
}

type VolumePropertiesExportPolicyPtrOutput struct{ *pulumi.OutputState }

func (VolumePropertiesExportPolicyPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**VolumePropertiesExportPolicy)(nil)).Elem()
}

func (o VolumePropertiesExportPolicyPtrOutput) ToVolumePropertiesExportPolicyPtrOutput() VolumePropertiesExportPolicyPtrOutput {
	return o
}

func (o VolumePropertiesExportPolicyPtrOutput) ToVolumePropertiesExportPolicyPtrOutputWithContext(ctx context.Context) VolumePropertiesExportPolicyPtrOutput {
	return o
}

func (o VolumePropertiesExportPolicyPtrOutput) Elem() VolumePropertiesExportPolicyOutput {
	return o.ApplyT(func(v *VolumePropertiesExportPolicy) VolumePropertiesExportPolicy {
		if v != nil {
			return *v
		}
		var ret VolumePropertiesExportPolicy
		return ret
	}).(VolumePropertiesExportPolicyOutput)
}

// Export policy rule
func (o VolumePropertiesExportPolicyPtrOutput) Rules() ExportPolicyRuleArrayOutput {
	return o.ApplyT(func(v *VolumePropertiesExportPolicy) []ExportPolicyRule {
		if v == nil {
			return nil
		}
		return v.Rules
	}).(ExportPolicyRuleArrayOutput)
}

// Set of export policy rules
type VolumePropertiesResponseExportPolicy struct {
	// Export policy rule
	Rules []ExportPolicyRuleResponse `pulumi:"rules"`
}

// Set of export policy rules
type VolumePropertiesResponseExportPolicyOutput struct{ *pulumi.OutputState }

func (VolumePropertiesResponseExportPolicyOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*VolumePropertiesResponseExportPolicy)(nil)).Elem()
}

func (o VolumePropertiesResponseExportPolicyOutput) ToVolumePropertiesResponseExportPolicyOutput() VolumePropertiesResponseExportPolicyOutput {
	return o
}

func (o VolumePropertiesResponseExportPolicyOutput) ToVolumePropertiesResponseExportPolicyOutputWithContext(ctx context.Context) VolumePropertiesResponseExportPolicyOutput {
	return o
}

// Export policy rule
func (o VolumePropertiesResponseExportPolicyOutput) Rules() ExportPolicyRuleResponseArrayOutput {
	return o.ApplyT(func(v VolumePropertiesResponseExportPolicy) []ExportPolicyRuleResponse { return v.Rules }).(ExportPolicyRuleResponseArrayOutput)
}

type VolumePropertiesResponseExportPolicyPtrOutput struct{ *pulumi.OutputState }

func (VolumePropertiesResponseExportPolicyPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**VolumePropertiesResponseExportPolicy)(nil)).Elem()
}

func (o VolumePropertiesResponseExportPolicyPtrOutput) ToVolumePropertiesResponseExportPolicyPtrOutput() VolumePropertiesResponseExportPolicyPtrOutput {
	return o
}

func (o VolumePropertiesResponseExportPolicyPtrOutput) ToVolumePropertiesResponseExportPolicyPtrOutputWithContext(ctx context.Context) VolumePropertiesResponseExportPolicyPtrOutput {
	return o
}

func (o VolumePropertiesResponseExportPolicyPtrOutput) Elem() VolumePropertiesResponseExportPolicyOutput {
	return o.ApplyT(func(v *VolumePropertiesResponseExportPolicy) VolumePropertiesResponseExportPolicy {
		if v != nil {
			return *v
		}
		var ret VolumePropertiesResponseExportPolicy
		return ret
	}).(VolumePropertiesResponseExportPolicyOutput)
}

// Export policy rule
func (o VolumePropertiesResponseExportPolicyPtrOutput) Rules() ExportPolicyRuleResponseArrayOutput {
	return o.ApplyT(func(v *VolumePropertiesResponseExportPolicy) []ExportPolicyRuleResponse {
		if v == nil {
			return nil
		}
		return v.Rules
	}).(ExportPolicyRuleResponseArrayOutput)
}

func init() {
	pulumi.RegisterOutputType(ActiveDirectoryOutput{})
	pulumi.RegisterOutputType(ActiveDirectoryArrayOutput{})
	pulumi.RegisterOutputType(ActiveDirectoryResponseOutput{})
	pulumi.RegisterOutputType(ActiveDirectoryResponseArrayOutput{})
	pulumi.RegisterOutputType(ExportPolicyRuleOutput{})
	pulumi.RegisterOutputType(ExportPolicyRuleArrayOutput{})
	pulumi.RegisterOutputType(ExportPolicyRuleResponseOutput{})
	pulumi.RegisterOutputType(ExportPolicyRuleResponseArrayOutput{})
	pulumi.RegisterOutputType(MountTargetPropertiesResponseOutput{})
	pulumi.RegisterOutputType(MountTargetPropertiesResponseArrayOutput{})
	pulumi.RegisterOutputType(VolumePropertiesExportPolicyOutput{})
	pulumi.RegisterOutputType(VolumePropertiesExportPolicyPtrOutput{})
	pulumi.RegisterOutputType(VolumePropertiesResponseExportPolicyOutput{})
	pulumi.RegisterOutputType(VolumePropertiesResponseExportPolicyPtrOutput{})
}
