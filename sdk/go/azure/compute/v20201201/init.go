// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20201201

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
	case "azure-native:compute/v20201201:AvailabilitySet":
		r = &AvailabilitySet{}
	case "azure-native:compute/v20201201:DedicatedHost":
		r = &DedicatedHost{}
	case "azure-native:compute/v20201201:DedicatedHostGroup":
		r = &DedicatedHostGroup{}
	case "azure-native:compute/v20201201:Disk":
		r = &Disk{}
	case "azure-native:compute/v20201201:DiskAccess":
		r = &DiskAccess{}
	case "azure-native:compute/v20201201:DiskAccessAPrivateEndpointConnection":
		r = &DiskAccessAPrivateEndpointConnection{}
	case "azure-native:compute/v20201201:DiskEncryptionSet":
		r = &DiskEncryptionSet{}
	case "azure-native:compute/v20201201:Image":
		r = &Image{}
	case "azure-native:compute/v20201201:ProximityPlacementGroup":
		r = &ProximityPlacementGroup{}
	case "azure-native:compute/v20201201:Snapshot":
		r = &Snapshot{}
	case "azure-native:compute/v20201201:SshPublicKey":
		r = &SshPublicKey{}
	case "azure-native:compute/v20201201:VirtualMachine":
		r = &VirtualMachine{}
	case "azure-native:compute/v20201201:VirtualMachineExtension":
		r = &VirtualMachineExtension{}
	case "azure-native:compute/v20201201:VirtualMachineRunCommandByVirtualMachine":
		r = &VirtualMachineRunCommandByVirtualMachine{}
	case "azure-native:compute/v20201201:VirtualMachineScaleSet":
		r = &VirtualMachineScaleSet{}
	case "azure-native:compute/v20201201:VirtualMachineScaleSetExtension":
		r = &VirtualMachineScaleSetExtension{}
	case "azure-native:compute/v20201201:VirtualMachineScaleSetVM":
		r = &VirtualMachineScaleSetVM{}
	case "azure-native:compute/v20201201:VirtualMachineScaleSetVMExtension":
		r = &VirtualMachineScaleSetVMExtension{}
	case "azure-native:compute/v20201201:VirtualMachineScaleSetVMRunCommand":
		r = &VirtualMachineScaleSetVMRunCommand{}
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
		"compute/v20201201",
		&module{version},
	)
}
