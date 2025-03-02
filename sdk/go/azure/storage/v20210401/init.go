// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20210401

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
	case "azure-native:storage/v20210401:BlobContainer":
		r = &BlobContainer{}
	case "azure-native:storage/v20210401:BlobContainerImmutabilityPolicy":
		r = &BlobContainerImmutabilityPolicy{}
	case "azure-native:storage/v20210401:BlobInventoryPolicy":
		r = &BlobInventoryPolicy{}
	case "azure-native:storage/v20210401:BlobServiceProperties":
		r = &BlobServiceProperties{}
	case "azure-native:storage/v20210401:EncryptionScope":
		r = &EncryptionScope{}
	case "azure-native:storage/v20210401:FileServiceProperties":
		r = &FileServiceProperties{}
	case "azure-native:storage/v20210401:FileShare":
		r = &FileShare{}
	case "azure-native:storage/v20210401:ManagementPolicy":
		r = &ManagementPolicy{}
	case "azure-native:storage/v20210401:ObjectReplicationPolicy":
		r = &ObjectReplicationPolicy{}
	case "azure-native:storage/v20210401:PrivateEndpointConnection":
		r = &PrivateEndpointConnection{}
	case "azure-native:storage/v20210401:Queue":
		r = &Queue{}
	case "azure-native:storage/v20210401:QueueServiceProperties":
		r = &QueueServiceProperties{}
	case "azure-native:storage/v20210401:StorageAccount":
		r = &StorageAccount{}
	case "azure-native:storage/v20210401:Table":
		r = &Table{}
	case "azure-native:storage/v20210401:TableServiceProperties":
		r = &TableServiceProperties{}
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
		"storage/v20210401",
		&module{version},
	)
}
