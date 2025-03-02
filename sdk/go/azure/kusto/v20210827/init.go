// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20210827

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
	case "azure-native:kusto/v20210827:AttachedDatabaseConfiguration":
		r = &AttachedDatabaseConfiguration{}
	case "azure-native:kusto/v20210827:Cluster":
		r = &Cluster{}
	case "azure-native:kusto/v20210827:ClusterPrincipalAssignment":
		r = &ClusterPrincipalAssignment{}
	case "azure-native:kusto/v20210827:DataConnection":
		r = &DataConnection{}
	case "azure-native:kusto/v20210827:Database":
		r = &Database{}
	case "azure-native:kusto/v20210827:DatabasePrincipalAssignment":
		r = &DatabasePrincipalAssignment{}
	case "azure-native:kusto/v20210827:EventGridDataConnection":
		r = &EventGridDataConnection{}
	case "azure-native:kusto/v20210827:EventHubDataConnection":
		r = &EventHubDataConnection{}
	case "azure-native:kusto/v20210827:IotHubDataConnection":
		r = &IotHubDataConnection{}
	case "azure-native:kusto/v20210827:ManagedPrivateEndpoint":
		r = &ManagedPrivateEndpoint{}
	case "azure-native:kusto/v20210827:PrivateEndpointConnection":
		r = &PrivateEndpointConnection{}
	case "azure-native:kusto/v20210827:ReadOnlyFollowingDatabase":
		r = &ReadOnlyFollowingDatabase{}
	case "azure-native:kusto/v20210827:ReadWriteDatabase":
		r = &ReadWriteDatabase{}
	case "azure-native:kusto/v20210827:Script":
		r = &Script{}
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
		"kusto/v20210827",
		&module{version},
	)
}
