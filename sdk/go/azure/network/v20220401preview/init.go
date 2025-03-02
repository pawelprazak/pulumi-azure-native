// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20220401preview

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
	case "azure-native:network/v20220401preview:AdminRule":
		r = &AdminRule{}
	case "azure-native:network/v20220401preview:AdminRuleCollection":
		r = &AdminRuleCollection{}
	case "azure-native:network/v20220401preview:ConnectivityConfiguration":
		r = &ConnectivityConfiguration{}
	case "azure-native:network/v20220401preview:DefaultAdminRule":
		r = &DefaultAdminRule{}
	case "azure-native:network/v20220401preview:DefaultUserRule":
		r = &DefaultUserRule{}
	case "azure-native:network/v20220401preview:ManagementGroupNetworkManagerConnection":
		r = &ManagementGroupNetworkManagerConnection{}
	case "azure-native:network/v20220401preview:NetworkGroup":
		r = &NetworkGroup{}
	case "azure-native:network/v20220401preview:NetworkManager":
		r = &NetworkManager{}
	case "azure-native:network/v20220401preview:ScopeConnection":
		r = &ScopeConnection{}
	case "azure-native:network/v20220401preview:SecurityAdminConfiguration":
		r = &SecurityAdminConfiguration{}
	case "azure-native:network/v20220401preview:SecurityUserConfiguration":
		r = &SecurityUserConfiguration{}
	case "azure-native:network/v20220401preview:StaticMember":
		r = &StaticMember{}
	case "azure-native:network/v20220401preview:SubscriptionNetworkManagerConnection":
		r = &SubscriptionNetworkManagerConnection{}
	case "azure-native:network/v20220401preview:UserRule":
		r = &UserRule{}
	case "azure-native:network/v20220401preview:UserRuleCollection":
		r = &UserRuleCollection{}
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
		"network/v20220401preview",
		&module{version},
	)
}
