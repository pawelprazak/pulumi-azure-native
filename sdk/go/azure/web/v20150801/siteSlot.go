// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20150801

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Represents a web app
//
// Deprecated: Version 2015-08-01 will be removed in v2 of the provider.
type SiteSlot struct {
	pulumi.CustomResourceState

	// Management information availability state for the web app. Possible values are Normal or Limited.
	//             Normal means that the site is running correctly and that management information for the site is available.
	//             Limited means that only partial management information for the site is available and that detailed site information is unavailable.
	AvailabilityState pulumi.StringOutput `pulumi:"availabilityState"`
	// Specifies if the client affinity is enabled when load balancing http request for multiple instances of the web app
	ClientAffinityEnabled pulumi.BoolPtrOutput `pulumi:"clientAffinityEnabled"`
	// Specifies if the client certificate is enabled for the web app
	ClientCertEnabled pulumi.BoolPtrOutput `pulumi:"clientCertEnabled"`
	// This is only valid for web app creation. If specified, web app is cloned from
	//             a source web app
	CloningInfo CloningInfoResponsePtrOutput `pulumi:"cloningInfo"`
	// Size of a function container
	ContainerSize pulumi.IntPtrOutput `pulumi:"containerSize"`
	// Default hostname of the web app
	DefaultHostName pulumi.StringOutput `pulumi:"defaultHostName"`
	// True if the site is enabled; otherwise, false. Setting this  value to false disables the site (takes the site off line).
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
	// Hostnames for the web app that are enabled. Hostnames need to be assigned and enabled. If some hostnames are assigned but not enabled
	//             the app is not served on those hostnames
	EnabledHostNames pulumi.StringArrayOutput `pulumi:"enabledHostNames"`
	// Name of gateway app associated with web app
	GatewaySiteName pulumi.StringPtrOutput `pulumi:"gatewaySiteName"`
	// Hostname SSL states are  used to manage the SSL bindings for site's hostnames.
	HostNameSslStates HostNameSslStateResponseArrayOutput `pulumi:"hostNameSslStates"`
	// Hostnames associated with web app
	HostNames pulumi.StringArrayOutput `pulumi:"hostNames"`
	// Specifies if the public hostnames are disabled the web app.
	//             If set to true the app is only accessible via API Management process
	HostNamesDisabled pulumi.BoolPtrOutput `pulumi:"hostNamesDisabled"`
	// Specification for the hosting environment (App Service Environment) to use for the web app
	HostingEnvironmentProfile HostingEnvironmentProfileResponsePtrOutput `pulumi:"hostingEnvironmentProfile"`
	// Site is a default container
	IsDefaultContainer pulumi.BoolOutput `pulumi:"isDefaultContainer"`
	// Kind of resource
	Kind pulumi.StringPtrOutput `pulumi:"kind"`
	// Last time web app was modified in UTC
	LastModifiedTimeUtc pulumi.StringOutput `pulumi:"lastModifiedTimeUtc"`
	// Resource Location
	Location pulumi.StringOutput `pulumi:"location"`
	// Maximum number of workers
	//             This only applies to function container
	MaxNumberOfWorkers pulumi.IntPtrOutput    `pulumi:"maxNumberOfWorkers"`
	MicroService       pulumi.StringPtrOutput `pulumi:"microService"`
	// Resource Name
	Name pulumi.StringPtrOutput `pulumi:"name"`
	// List of comma separated IP addresses that this web app uses for outbound connections. Those can be used when configuring firewall rules for databases accessed by this web app.
	OutboundIpAddresses pulumi.StringOutput `pulumi:"outboundIpAddresses"`
	// If set indicates whether web app is deployed as a premium app
	PremiumAppDeployed pulumi.BoolOutput `pulumi:"premiumAppDeployed"`
	// Name of repository site
	RepositorySiteName pulumi.StringOutput `pulumi:"repositorySiteName"`
	// Resource group web app belongs to
	ResourceGroup pulumi.StringOutput `pulumi:"resourceGroup"`
	// If set indicates whether to stop SCM (KUDU) site when the web app is stopped. Default is false.
	ScmSiteAlsoStopped pulumi.BoolPtrOutput   `pulumi:"scmSiteAlsoStopped"`
	ServerFarmId       pulumi.StringPtrOutput `pulumi:"serverFarmId"`
	// Configuration of web app
	SiteConfig SiteConfigResponsePtrOutput `pulumi:"siteConfig"`
	// State of the web app
	State pulumi.StringOutput `pulumi:"state"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Read-only property that specifies which slot this app will swap into
	TargetSwapSlot pulumi.StringOutput `pulumi:"targetSwapSlot"`
	// Read-only list of Azure Traffic manager hostnames associated with web app
	TrafficManagerHostNames pulumi.StringArrayOutput `pulumi:"trafficManagerHostNames"`
	// Resource type
	Type pulumi.StringPtrOutput `pulumi:"type"`
	// State indicating whether web app has exceeded its quota usage
	UsageState pulumi.StringOutput `pulumi:"usageState"`
}

// NewSiteSlot registers a new resource with the given unique name, arguments, and options.
func NewSiteSlot(ctx *pulumi.Context,
	name string, args *SiteSlotArgs, opts ...pulumi.ResourceOption) (*SiteSlot, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Name == nil {
		return nil, errors.New("invalid value for required argument 'Name'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-native:web:SiteSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20160801:SiteSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20180201:SiteSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20181101:SiteSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20190801:SiteSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20200601:SiteSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20200901:SiteSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20201001:SiteSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20201201:SiteSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20210101:SiteSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20210115:SiteSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20210201:SiteSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20210301:SiteSlot"),
		},
		{
			Type: pulumi.String("azure-native:web/v20220301:SiteSlot"),
		},
	})
	opts = append(opts, aliases)
	var resource SiteSlot
	err := ctx.RegisterResource("azure-native:web/v20150801:SiteSlot", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSiteSlot gets an existing SiteSlot resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSiteSlot(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SiteSlotState, opts ...pulumi.ResourceOption) (*SiteSlot, error) {
	var resource SiteSlot
	err := ctx.ReadResource("azure-native:web/v20150801:SiteSlot", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SiteSlot resources.
type siteSlotState struct {
}

type SiteSlotState struct {
}

func (SiteSlotState) ElementType() reflect.Type {
	return reflect.TypeOf((*siteSlotState)(nil)).Elem()
}

type siteSlotArgs struct {
	// Specifies if the client affinity is enabled when load balancing http request for multiple instances of the web app
	ClientAffinityEnabled *bool `pulumi:"clientAffinityEnabled"`
	// Specifies if the client certificate is enabled for the web app
	ClientCertEnabled *bool `pulumi:"clientCertEnabled"`
	// This is only valid for web app creation. If specified, web app is cloned from
	//             a source web app
	CloningInfo *CloningInfo `pulumi:"cloningInfo"`
	// Size of a function container
	ContainerSize *int `pulumi:"containerSize"`
	// True if the site is enabled; otherwise, false. Setting this  value to false disables the site (takes the site off line).
	Enabled *bool `pulumi:"enabled"`
	// If true, web app hostname is force registered with DNS
	ForceDnsRegistration *string `pulumi:"forceDnsRegistration"`
	// Name of gateway app associated with web app
	GatewaySiteName *string `pulumi:"gatewaySiteName"`
	// Hostname SSL states are  used to manage the SSL bindings for site's hostnames.
	HostNameSslStates []HostNameSslState `pulumi:"hostNameSslStates"`
	// Specifies if the public hostnames are disabled the web app.
	//             If set to true the app is only accessible via API Management process
	HostNamesDisabled *bool `pulumi:"hostNamesDisabled"`
	// Specification for the hosting environment (App Service Environment) to use for the web app
	HostingEnvironmentProfile *HostingEnvironmentProfile `pulumi:"hostingEnvironmentProfile"`
	// Resource Id
	Id *string `pulumi:"id"`
	// Kind of resource
	Kind *string `pulumi:"kind"`
	// Resource Location
	Location *string `pulumi:"location"`
	// Maximum number of workers
	//             This only applies to function container
	MaxNumberOfWorkers *int    `pulumi:"maxNumberOfWorkers"`
	MicroService       *string `pulumi:"microService"`
	// Resource Name
	Name string `pulumi:"name"`
	// Name of the resource group
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// If set indicates whether to stop SCM (KUDU) site when the web app is stopped. Default is false.
	ScmSiteAlsoStopped *bool   `pulumi:"scmSiteAlsoStopped"`
	ServerFarmId       *string `pulumi:"serverFarmId"`
	// Configuration of web app
	SiteConfig *SiteConfig `pulumi:"siteConfig"`
	// If true, custom (non *.azurewebsites.net) domains associated with web app are not verified.
	SkipCustomDomainVerification *string `pulumi:"skipCustomDomainVerification"`
	// If true web app hostname is not registered with DNS on creation. This parameter is
	//             only used for app creation
	SkipDnsRegistration *string `pulumi:"skipDnsRegistration"`
	// Name of web app slot. If not specified then will default to production slot.
	Slot *string `pulumi:"slot"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// Time to live in seconds for web app's default domain name
	TtlInSeconds *string `pulumi:"ttlInSeconds"`
	// Resource type
	Type *string `pulumi:"type"`
}

// The set of arguments for constructing a SiteSlot resource.
type SiteSlotArgs struct {
	// Specifies if the client affinity is enabled when load balancing http request for multiple instances of the web app
	ClientAffinityEnabled pulumi.BoolPtrInput
	// Specifies if the client certificate is enabled for the web app
	ClientCertEnabled pulumi.BoolPtrInput
	// This is only valid for web app creation. If specified, web app is cloned from
	//             a source web app
	CloningInfo CloningInfoPtrInput
	// Size of a function container
	ContainerSize pulumi.IntPtrInput
	// True if the site is enabled; otherwise, false. Setting this  value to false disables the site (takes the site off line).
	Enabled pulumi.BoolPtrInput
	// If true, web app hostname is force registered with DNS
	ForceDnsRegistration pulumi.StringPtrInput
	// Name of gateway app associated with web app
	GatewaySiteName pulumi.StringPtrInput
	// Hostname SSL states are  used to manage the SSL bindings for site's hostnames.
	HostNameSslStates HostNameSslStateArrayInput
	// Specifies if the public hostnames are disabled the web app.
	//             If set to true the app is only accessible via API Management process
	HostNamesDisabled pulumi.BoolPtrInput
	// Specification for the hosting environment (App Service Environment) to use for the web app
	HostingEnvironmentProfile HostingEnvironmentProfilePtrInput
	// Resource Id
	Id pulumi.StringPtrInput
	// Kind of resource
	Kind pulumi.StringPtrInput
	// Resource Location
	Location pulumi.StringPtrInput
	// Maximum number of workers
	//             This only applies to function container
	MaxNumberOfWorkers pulumi.IntPtrInput
	MicroService       pulumi.StringPtrInput
	// Resource Name
	Name pulumi.StringInput
	// Name of the resource group
	ResourceGroupName pulumi.StringInput
	// If set indicates whether to stop SCM (KUDU) site when the web app is stopped. Default is false.
	ScmSiteAlsoStopped pulumi.BoolPtrInput
	ServerFarmId       pulumi.StringPtrInput
	// Configuration of web app
	SiteConfig SiteConfigPtrInput
	// If true, custom (non *.azurewebsites.net) domains associated with web app are not verified.
	SkipCustomDomainVerification pulumi.StringPtrInput
	// If true web app hostname is not registered with DNS on creation. This parameter is
	//             only used for app creation
	SkipDnsRegistration pulumi.StringPtrInput
	// Name of web app slot. If not specified then will default to production slot.
	Slot pulumi.StringPtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// Time to live in seconds for web app's default domain name
	TtlInSeconds pulumi.StringPtrInput
	// Resource type
	Type pulumi.StringPtrInput
}

func (SiteSlotArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*siteSlotArgs)(nil)).Elem()
}

type SiteSlotInput interface {
	pulumi.Input

	ToSiteSlotOutput() SiteSlotOutput
	ToSiteSlotOutputWithContext(ctx context.Context) SiteSlotOutput
}

func (*SiteSlot) ElementType() reflect.Type {
	return reflect.TypeOf((**SiteSlot)(nil)).Elem()
}

func (i *SiteSlot) ToSiteSlotOutput() SiteSlotOutput {
	return i.ToSiteSlotOutputWithContext(context.Background())
}

func (i *SiteSlot) ToSiteSlotOutputWithContext(ctx context.Context) SiteSlotOutput {
	return pulumi.ToOutputWithContext(ctx, i).(SiteSlotOutput)
}

type SiteSlotOutput struct{ *pulumi.OutputState }

func (SiteSlotOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**SiteSlot)(nil)).Elem()
}

func (o SiteSlotOutput) ToSiteSlotOutput() SiteSlotOutput {
	return o
}

func (o SiteSlotOutput) ToSiteSlotOutputWithContext(ctx context.Context) SiteSlotOutput {
	return o
}

// Management information availability state for the web app. Possible values are Normal or Limited.
//             Normal means that the site is running correctly and that management information for the site is available.
//             Limited means that only partial management information for the site is available and that detailed site information is unavailable.
func (o SiteSlotOutput) AvailabilityState() pulumi.StringOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringOutput { return v.AvailabilityState }).(pulumi.StringOutput)
}

// Specifies if the client affinity is enabled when load balancing http request for multiple instances of the web app
func (o SiteSlotOutput) ClientAffinityEnabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.BoolPtrOutput { return v.ClientAffinityEnabled }).(pulumi.BoolPtrOutput)
}

// Specifies if the client certificate is enabled for the web app
func (o SiteSlotOutput) ClientCertEnabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.BoolPtrOutput { return v.ClientCertEnabled }).(pulumi.BoolPtrOutput)
}

// This is only valid for web app creation. If specified, web app is cloned from
//             a source web app
func (o SiteSlotOutput) CloningInfo() CloningInfoResponsePtrOutput {
	return o.ApplyT(func(v *SiteSlot) CloningInfoResponsePtrOutput { return v.CloningInfo }).(CloningInfoResponsePtrOutput)
}

// Size of a function container
func (o SiteSlotOutput) ContainerSize() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.IntPtrOutput { return v.ContainerSize }).(pulumi.IntPtrOutput)
}

// Default hostname of the web app
func (o SiteSlotOutput) DefaultHostName() pulumi.StringOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringOutput { return v.DefaultHostName }).(pulumi.StringOutput)
}

// True if the site is enabled; otherwise, false. Setting this  value to false disables the site (takes the site off line).
func (o SiteSlotOutput) Enabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.BoolPtrOutput { return v.Enabled }).(pulumi.BoolPtrOutput)
}

// Hostnames for the web app that are enabled. Hostnames need to be assigned and enabled. If some hostnames are assigned but not enabled
//             the app is not served on those hostnames
func (o SiteSlotOutput) EnabledHostNames() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringArrayOutput { return v.EnabledHostNames }).(pulumi.StringArrayOutput)
}

// Name of gateway app associated with web app
func (o SiteSlotOutput) GatewaySiteName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringPtrOutput { return v.GatewaySiteName }).(pulumi.StringPtrOutput)
}

// Hostname SSL states are  used to manage the SSL bindings for site's hostnames.
func (o SiteSlotOutput) HostNameSslStates() HostNameSslStateResponseArrayOutput {
	return o.ApplyT(func(v *SiteSlot) HostNameSslStateResponseArrayOutput { return v.HostNameSslStates }).(HostNameSslStateResponseArrayOutput)
}

// Hostnames associated with web app
func (o SiteSlotOutput) HostNames() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringArrayOutput { return v.HostNames }).(pulumi.StringArrayOutput)
}

// Specifies if the public hostnames are disabled the web app.
//             If set to true the app is only accessible via API Management process
func (o SiteSlotOutput) HostNamesDisabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.BoolPtrOutput { return v.HostNamesDisabled }).(pulumi.BoolPtrOutput)
}

// Specification for the hosting environment (App Service Environment) to use for the web app
func (o SiteSlotOutput) HostingEnvironmentProfile() HostingEnvironmentProfileResponsePtrOutput {
	return o.ApplyT(func(v *SiteSlot) HostingEnvironmentProfileResponsePtrOutput { return v.HostingEnvironmentProfile }).(HostingEnvironmentProfileResponsePtrOutput)
}

// Site is a default container
func (o SiteSlotOutput) IsDefaultContainer() pulumi.BoolOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.BoolOutput { return v.IsDefaultContainer }).(pulumi.BoolOutput)
}

// Kind of resource
func (o SiteSlotOutput) Kind() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringPtrOutput { return v.Kind }).(pulumi.StringPtrOutput)
}

// Last time web app was modified in UTC
func (o SiteSlotOutput) LastModifiedTimeUtc() pulumi.StringOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringOutput { return v.LastModifiedTimeUtc }).(pulumi.StringOutput)
}

// Resource Location
func (o SiteSlotOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringOutput { return v.Location }).(pulumi.StringOutput)
}

// Maximum number of workers
//             This only applies to function container
func (o SiteSlotOutput) MaxNumberOfWorkers() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.IntPtrOutput { return v.MaxNumberOfWorkers }).(pulumi.IntPtrOutput)
}

func (o SiteSlotOutput) MicroService() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringPtrOutput { return v.MicroService }).(pulumi.StringPtrOutput)
}

// Resource Name
func (o SiteSlotOutput) Name() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringPtrOutput { return v.Name }).(pulumi.StringPtrOutput)
}

// List of comma separated IP addresses that this web app uses for outbound connections. Those can be used when configuring firewall rules for databases accessed by this web app.
func (o SiteSlotOutput) OutboundIpAddresses() pulumi.StringOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringOutput { return v.OutboundIpAddresses }).(pulumi.StringOutput)
}

// If set indicates whether web app is deployed as a premium app
func (o SiteSlotOutput) PremiumAppDeployed() pulumi.BoolOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.BoolOutput { return v.PremiumAppDeployed }).(pulumi.BoolOutput)
}

// Name of repository site
func (o SiteSlotOutput) RepositorySiteName() pulumi.StringOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringOutput { return v.RepositorySiteName }).(pulumi.StringOutput)
}

// Resource group web app belongs to
func (o SiteSlotOutput) ResourceGroup() pulumi.StringOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringOutput { return v.ResourceGroup }).(pulumi.StringOutput)
}

// If set indicates whether to stop SCM (KUDU) site when the web app is stopped. Default is false.
func (o SiteSlotOutput) ScmSiteAlsoStopped() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.BoolPtrOutput { return v.ScmSiteAlsoStopped }).(pulumi.BoolPtrOutput)
}

func (o SiteSlotOutput) ServerFarmId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringPtrOutput { return v.ServerFarmId }).(pulumi.StringPtrOutput)
}

// Configuration of web app
func (o SiteSlotOutput) SiteConfig() SiteConfigResponsePtrOutput {
	return o.ApplyT(func(v *SiteSlot) SiteConfigResponsePtrOutput { return v.SiteConfig }).(SiteConfigResponsePtrOutput)
}

// State of the web app
func (o SiteSlotOutput) State() pulumi.StringOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringOutput { return v.State }).(pulumi.StringOutput)
}

// Resource tags
func (o SiteSlotOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

// Read-only property that specifies which slot this app will swap into
func (o SiteSlotOutput) TargetSwapSlot() pulumi.StringOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringOutput { return v.TargetSwapSlot }).(pulumi.StringOutput)
}

// Read-only list of Azure Traffic manager hostnames associated with web app
func (o SiteSlotOutput) TrafficManagerHostNames() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringArrayOutput { return v.TrafficManagerHostNames }).(pulumi.StringArrayOutput)
}

// Resource type
func (o SiteSlotOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringPtrOutput { return v.Type }).(pulumi.StringPtrOutput)
}

// State indicating whether web app has exceeded its quota usage
func (o SiteSlotOutput) UsageState() pulumi.StringOutput {
	return o.ApplyT(func(v *SiteSlot) pulumi.StringOutput { return v.UsageState }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(SiteSlotOutput{})
}
