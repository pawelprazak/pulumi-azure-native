// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20150601

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// CDN endpoint is the entity within a CDN profile containing configuration information regarding caching behaviors and origins. The CDN endpoint is exposed using the URL format <endpointname>.azureedge.net by default, but custom domains can also be created.
//
// Deprecated: Version 2015-06-01 will be removed in v2 of the provider.
type Endpoint struct {
	pulumi.CustomResourceState

	// List of content types on which compression will be applied. The value for the elements should be a valid MIME type.
	ContentTypesToCompress pulumi.StringArrayOutput `pulumi:"contentTypesToCompress"`
	// The host name of the endpoint {endpointName}.{DNSZone}
	HostName pulumi.StringOutput `pulumi:"hostName"`
	// Indicates whether the compression is enabled. Default value is false. If compression is enabled, the content transferred from cdn endpoint to end user will be compressed. The requested content must be larger than 1 byte and smaller than 1 MB.
	IsCompressionEnabled pulumi.BoolPtrOutput `pulumi:"isCompressionEnabled"`
	// Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
	IsHttpAllowed pulumi.BoolPtrOutput `pulumi:"isHttpAllowed"`
	// Indicates whether https traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
	IsHttpsAllowed pulumi.BoolPtrOutput `pulumi:"isHttpsAllowed"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// The host header the CDN provider will send along with content requests to origins. The default value is the host name of the origin.
	OriginHostHeader pulumi.StringPtrOutput `pulumi:"originHostHeader"`
	// The path used for origin requests.
	OriginPath pulumi.StringPtrOutput `pulumi:"originPath"`
	// The set of origins for the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options.
	Origins DeepCreatedOriginResponseArrayOutput `pulumi:"origins"`
	// Provisioning status of the endpoint.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Defines the query string caching behavior.
	QueryStringCachingBehavior pulumi.StringPtrOutput `pulumi:"queryStringCachingBehavior"`
	// Resource status of the endpoint.
	ResourceState pulumi.StringOutput `pulumi:"resourceState"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewEndpoint registers a new resource with the given unique name, arguments, and options.
func NewEndpoint(ctx *pulumi.Context,
	name string, args *EndpointArgs, opts ...pulumi.ResourceOption) (*Endpoint, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.Origins == nil {
		return nil, errors.New("invalid value for required argument 'Origins'")
	}
	if args.ProfileName == nil {
		return nil, errors.New("invalid value for required argument 'ProfileName'")
	}
	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-native:cdn:Endpoint"),
		},
		{
			Type: pulumi.String("azure-native:cdn/v20160402:Endpoint"),
		},
		{
			Type: pulumi.String("azure-native:cdn/v20161002:Endpoint"),
		},
		{
			Type: pulumi.String("azure-native:cdn/v20170402:Endpoint"),
		},
		{
			Type: pulumi.String("azure-native:cdn/v20171012:Endpoint"),
		},
		{
			Type: pulumi.String("azure-native:cdn/v20190415:Endpoint"),
		},
		{
			Type: pulumi.String("azure-native:cdn/v20190615:Endpoint"),
		},
		{
			Type: pulumi.String("azure-native:cdn/v20190615preview:Endpoint"),
		},
		{
			Type: pulumi.String("azure-native:cdn/v20191231:Endpoint"),
		},
		{
			Type: pulumi.String("azure-native:cdn/v20200331:Endpoint"),
		},
		{
			Type: pulumi.String("azure-native:cdn/v20200415:Endpoint"),
		},
		{
			Type: pulumi.String("azure-native:cdn/v20200901:Endpoint"),
		},
		{
			Type: pulumi.String("azure-native:cdn/v20210601:Endpoint"),
		},
	})
	opts = append(opts, aliases)
	var resource Endpoint
	err := ctx.RegisterResource("azure-native:cdn/v20150601:Endpoint", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEndpoint gets an existing Endpoint resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEndpoint(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EndpointState, opts ...pulumi.ResourceOption) (*Endpoint, error) {
	var resource Endpoint
	err := ctx.ReadResource("azure-native:cdn/v20150601:Endpoint", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Endpoint resources.
type endpointState struct {
}

type EndpointState struct {
}

func (EndpointState) ElementType() reflect.Type {
	return reflect.TypeOf((*endpointState)(nil)).Elem()
}

type endpointArgs struct {
	// List of content types on which compression will be applied. The value for the elements should be a valid MIME type.
	ContentTypesToCompress []string `pulumi:"contentTypesToCompress"`
	// Name of the endpoint within the CDN profile.
	EndpointName *string `pulumi:"endpointName"`
	// Indicates whether content compression is enabled. Default value is false. If compression is enabled, the content transferred from the CDN endpoint to the end user will be compressed. The requested content must be larger than 1 byte and smaller than 1 MB.
	IsCompressionEnabled *bool `pulumi:"isCompressionEnabled"`
	// Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
	IsHttpAllowed *bool `pulumi:"isHttpAllowed"`
	// Indicates whether https traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
	IsHttpsAllowed *bool `pulumi:"isHttpsAllowed"`
	// Endpoint location
	Location *string `pulumi:"location"`
	// The host header CDN provider will send along with content requests to origins. The default value is the host name of the origin.
	OriginHostHeader *string `pulumi:"originHostHeader"`
	// The path used for origin requests.
	OriginPath *string `pulumi:"originPath"`
	// The set of origins for the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options.
	Origins []DeepCreatedOrigin `pulumi:"origins"`
	// Name of the CDN profile within the resource group.
	ProfileName string `pulumi:"profileName"`
	// Defines the query string caching behavior.
	QueryStringCachingBehavior *QueryStringCachingBehavior `pulumi:"queryStringCachingBehavior"`
	// Name of the resource group within the Azure subscription.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Endpoint tags
	Tags map[string]string `pulumi:"tags"`
}

// The set of arguments for constructing a Endpoint resource.
type EndpointArgs struct {
	// List of content types on which compression will be applied. The value for the elements should be a valid MIME type.
	ContentTypesToCompress pulumi.StringArrayInput
	// Name of the endpoint within the CDN profile.
	EndpointName pulumi.StringPtrInput
	// Indicates whether content compression is enabled. Default value is false. If compression is enabled, the content transferred from the CDN endpoint to the end user will be compressed. The requested content must be larger than 1 byte and smaller than 1 MB.
	IsCompressionEnabled pulumi.BoolPtrInput
	// Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
	IsHttpAllowed pulumi.BoolPtrInput
	// Indicates whether https traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
	IsHttpsAllowed pulumi.BoolPtrInput
	// Endpoint location
	Location pulumi.StringPtrInput
	// The host header CDN provider will send along with content requests to origins. The default value is the host name of the origin.
	OriginHostHeader pulumi.StringPtrInput
	// The path used for origin requests.
	OriginPath pulumi.StringPtrInput
	// The set of origins for the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options.
	Origins DeepCreatedOriginArrayInput
	// Name of the CDN profile within the resource group.
	ProfileName pulumi.StringInput
	// Defines the query string caching behavior.
	QueryStringCachingBehavior QueryStringCachingBehaviorPtrInput
	// Name of the resource group within the Azure subscription.
	ResourceGroupName pulumi.StringInput
	// Endpoint tags
	Tags pulumi.StringMapInput
}

func (EndpointArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*endpointArgs)(nil)).Elem()
}

type EndpointInput interface {
	pulumi.Input

	ToEndpointOutput() EndpointOutput
	ToEndpointOutputWithContext(ctx context.Context) EndpointOutput
}

func (*Endpoint) ElementType() reflect.Type {
	return reflect.TypeOf((**Endpoint)(nil)).Elem()
}

func (i *Endpoint) ToEndpointOutput() EndpointOutput {
	return i.ToEndpointOutputWithContext(context.Background())
}

func (i *Endpoint) ToEndpointOutputWithContext(ctx context.Context) EndpointOutput {
	return pulumi.ToOutputWithContext(ctx, i).(EndpointOutput)
}

type EndpointOutput struct{ *pulumi.OutputState }

func (EndpointOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**Endpoint)(nil)).Elem()
}

func (o EndpointOutput) ToEndpointOutput() EndpointOutput {
	return o
}

func (o EndpointOutput) ToEndpointOutputWithContext(ctx context.Context) EndpointOutput {
	return o
}

// List of content types on which compression will be applied. The value for the elements should be a valid MIME type.
func (o EndpointOutput) ContentTypesToCompress() pulumi.StringArrayOutput {
	return o.ApplyT(func(v *Endpoint) pulumi.StringArrayOutput { return v.ContentTypesToCompress }).(pulumi.StringArrayOutput)
}

// The host name of the endpoint {endpointName}.{DNSZone}
func (o EndpointOutput) HostName() pulumi.StringOutput {
	return o.ApplyT(func(v *Endpoint) pulumi.StringOutput { return v.HostName }).(pulumi.StringOutput)
}

// Indicates whether the compression is enabled. Default value is false. If compression is enabled, the content transferred from cdn endpoint to end user will be compressed. The requested content must be larger than 1 byte and smaller than 1 MB.
func (o EndpointOutput) IsCompressionEnabled() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *Endpoint) pulumi.BoolPtrOutput { return v.IsCompressionEnabled }).(pulumi.BoolPtrOutput)
}

// Indicates whether HTTP traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
func (o EndpointOutput) IsHttpAllowed() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *Endpoint) pulumi.BoolPtrOutput { return v.IsHttpAllowed }).(pulumi.BoolPtrOutput)
}

// Indicates whether https traffic is allowed on the endpoint. Default value is true. At least one protocol (HTTP or HTTPS) must be allowed.
func (o EndpointOutput) IsHttpsAllowed() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *Endpoint) pulumi.BoolPtrOutput { return v.IsHttpsAllowed }).(pulumi.BoolPtrOutput)
}

// Resource location
func (o EndpointOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v *Endpoint) pulumi.StringOutput { return v.Location }).(pulumi.StringOutput)
}

// Resource name
func (o EndpointOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *Endpoint) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// The host header the CDN provider will send along with content requests to origins. The default value is the host name of the origin.
func (o EndpointOutput) OriginHostHeader() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Endpoint) pulumi.StringPtrOutput { return v.OriginHostHeader }).(pulumi.StringPtrOutput)
}

// The path used for origin requests.
func (o EndpointOutput) OriginPath() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Endpoint) pulumi.StringPtrOutput { return v.OriginPath }).(pulumi.StringPtrOutput)
}

// The set of origins for the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options.
func (o EndpointOutput) Origins() DeepCreatedOriginResponseArrayOutput {
	return o.ApplyT(func(v *Endpoint) DeepCreatedOriginResponseArrayOutput { return v.Origins }).(DeepCreatedOriginResponseArrayOutput)
}

// Provisioning status of the endpoint.
func (o EndpointOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v *Endpoint) pulumi.StringOutput { return v.ProvisioningState }).(pulumi.StringOutput)
}

// Defines the query string caching behavior.
func (o EndpointOutput) QueryStringCachingBehavior() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *Endpoint) pulumi.StringPtrOutput { return v.QueryStringCachingBehavior }).(pulumi.StringPtrOutput)
}

// Resource status of the endpoint.
func (o EndpointOutput) ResourceState() pulumi.StringOutput {
	return o.ApplyT(func(v *Endpoint) pulumi.StringOutput { return v.ResourceState }).(pulumi.StringOutput)
}

// Resource tags
func (o EndpointOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *Endpoint) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

// Resource type
func (o EndpointOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *Endpoint) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(EndpointOutput{})
}
