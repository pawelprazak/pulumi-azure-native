// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20200501preview

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
	case "azure-native:databoxedge/v20200501preview:BandwidthSchedule":
		r = &BandwidthSchedule{}
	case "azure-native:databoxedge/v20200501preview:Container":
		r = &Container{}
	case "azure-native:databoxedge/v20200501preview:Device":
		r = &Device{}
	case "azure-native:databoxedge/v20200501preview:FileEventTrigger":
		r = &FileEventTrigger{}
	case "azure-native:databoxedge/v20200501preview:IoTRole":
		r = &IoTRole{}
	case "azure-native:databoxedge/v20200501preview:Order":
		r = &Order{}
	case "azure-native:databoxedge/v20200501preview:PeriodicTimerEventTrigger":
		r = &PeriodicTimerEventTrigger{}
	case "azure-native:databoxedge/v20200501preview:Role":
		r = &Role{}
	case "azure-native:databoxedge/v20200501preview:Share":
		r = &Share{}
	case "azure-native:databoxedge/v20200501preview:StorageAccount":
		r = &StorageAccount{}
	case "azure-native:databoxedge/v20200501preview:StorageAccountCredential":
		r = &StorageAccountCredential{}
	case "azure-native:databoxedge/v20200501preview:Trigger":
		r = &Trigger{}
	case "azure-native:databoxedge/v20200501preview:User":
		r = &User{}
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
		"databoxedge/v20200501preview",
		&module{version},
	)
}
