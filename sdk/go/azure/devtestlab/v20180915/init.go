// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20180915

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
	case "azure-native:devtestlab/v20180915:ArtifactSource":
		r = &ArtifactSource{}
	case "azure-native:devtestlab/v20180915:CustomImage":
		r = &CustomImage{}
	case "azure-native:devtestlab/v20180915:Disk":
		r = &Disk{}
	case "azure-native:devtestlab/v20180915:Environment":
		r = &Environment{}
	case "azure-native:devtestlab/v20180915:Formula":
		r = &Formula{}
	case "azure-native:devtestlab/v20180915:GlobalSchedule":
		r = &GlobalSchedule{}
	case "azure-native:devtestlab/v20180915:Lab":
		r = &Lab{}
	case "azure-native:devtestlab/v20180915:NotificationChannel":
		r = &NotificationChannel{}
	case "azure-native:devtestlab/v20180915:Policy":
		r = &Policy{}
	case "azure-native:devtestlab/v20180915:Schedule":
		r = &Schedule{}
	case "azure-native:devtestlab/v20180915:Secret":
		r = &Secret{}
	case "azure-native:devtestlab/v20180915:ServiceFabric":
		r = &ServiceFabric{}
	case "azure-native:devtestlab/v20180915:ServiceFabricSchedule":
		r = &ServiceFabricSchedule{}
	case "azure-native:devtestlab/v20180915:ServiceRunner":
		r = &ServiceRunner{}
	case "azure-native:devtestlab/v20180915:User":
		r = &User{}
	case "azure-native:devtestlab/v20180915:VirtualMachine":
		r = &VirtualMachine{}
	case "azure-native:devtestlab/v20180915:VirtualMachineSchedule":
		r = &VirtualMachineSchedule{}
	case "azure-native:devtestlab/v20180915:VirtualNetwork":
		r = &VirtualNetwork{}
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
		"devtestlab/v20180915",
		&module{version},
	)
}
