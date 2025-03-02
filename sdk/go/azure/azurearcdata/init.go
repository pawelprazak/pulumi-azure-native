// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package azurearcdata

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
	case "azure-native:azurearcdata:ActiveDirectoryConnector":
		r = &ActiveDirectoryConnector{}
	case "azure-native:azurearcdata:DataController":
		r = &DataController{}
	case "azure-native:azurearcdata:PostgresInstance":
		r = &PostgresInstance{}
	case "azure-native:azurearcdata:SqlManagedInstance":
		r = &SqlManagedInstance{}
	case "azure-native:azurearcdata:SqlServerInstance":
		r = &SqlServerInstance{}
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
		"azurearcdata",
		&module{version},
	)
}
