// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20201015preview

import (
	"fmt"

	"github.com/blang/semver"
	"github.com/pulumi/pulumi-azure-native/sdk/go/azure"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

type module struct {
	version semver.Version
}

func (m *module) Version() semver.Version {
	return m.version
}

func (m *module) Construct(ctx *pulumi.Context, name, typ, urn string) (r pulumi.Resource, err error) {
	switch typ {
	case "azure-native:eventgrid/v20201015preview:Domain":
		r = &Domain{}
	case "azure-native:eventgrid/v20201015preview:DomainTopic":
		r = &DomainTopic{}
	case "azure-native:eventgrid/v20201015preview:EventChannel":
		r = &EventChannel{}
	case "azure-native:eventgrid/v20201015preview:EventSubscription":
		r = &EventSubscription{}
	case "azure-native:eventgrid/v20201015preview:PartnerNamespace":
		r = &PartnerNamespace{}
	case "azure-native:eventgrid/v20201015preview:PartnerRegistration":
		r = &PartnerRegistration{}
	case "azure-native:eventgrid/v20201015preview:PartnerTopicEventSubscription":
		r = &PartnerTopicEventSubscription{}
	case "azure-native:eventgrid/v20201015preview:PrivateEndpointConnection":
		r = &PrivateEndpointConnection{}
	case "azure-native:eventgrid/v20201015preview:SystemTopic":
		r = &SystemTopic{}
	case "azure-native:eventgrid/v20201015preview:SystemTopicEventSubscription":
		r = &SystemTopicEventSubscription{}
	case "azure-native:eventgrid/v20201015preview:Topic":
		r = &Topic{}
	default:
		return nil, fmt.Errorf("unknown resource type: %s", typ)
	}

	err = ctx.RegisterResource(typ, name, nil, r, pulumi.URN_(urn))
	return
}

func init() {
	version, err := azure.PkgVersion()
	if err != nil {
		version = semver.Version{Major: 1}
	}
	pulumi.RegisterResourceModule(
		"azure-native",
		"eventgrid/v20201015preview",
		&module{version},
	)
}
