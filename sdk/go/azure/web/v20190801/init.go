// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20190801

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
	case "azure-native:web/v20190801:AppServiceEnvironment":
		r = &AppServiceEnvironment{}
	case "azure-native:web/v20190801:AppServicePlan":
		r = &AppServicePlan{}
	case "azure-native:web/v20190801:AppServicePlanRouteForVnet":
		r = &AppServicePlanRouteForVnet{}
	case "azure-native:web/v20190801:Certificate":
		r = &Certificate{}
	case "azure-native:web/v20190801:StaticSite":
		r = &StaticSite{}
	case "azure-native:web/v20190801:WebApp":
		r = &WebApp{}
	case "azure-native:web/v20190801:WebAppApplicationSettings":
		r = &WebAppApplicationSettings{}
	case "azure-native:web/v20190801:WebAppApplicationSettingsSlot":
		r = &WebAppApplicationSettingsSlot{}
	case "azure-native:web/v20190801:WebAppAuthSettings":
		r = &WebAppAuthSettings{}
	case "azure-native:web/v20190801:WebAppAuthSettingsSlot":
		r = &WebAppAuthSettingsSlot{}
	case "azure-native:web/v20190801:WebAppAzureStorageAccounts":
		r = &WebAppAzureStorageAccounts{}
	case "azure-native:web/v20190801:WebAppAzureStorageAccountsSlot":
		r = &WebAppAzureStorageAccountsSlot{}
	case "azure-native:web/v20190801:WebAppBackupConfiguration":
		r = &WebAppBackupConfiguration{}
	case "azure-native:web/v20190801:WebAppBackupConfigurationSlot":
		r = &WebAppBackupConfigurationSlot{}
	case "azure-native:web/v20190801:WebAppConnectionStrings":
		r = &WebAppConnectionStrings{}
	case "azure-native:web/v20190801:WebAppConnectionStringsSlot":
		r = &WebAppConnectionStringsSlot{}
	case "azure-native:web/v20190801:WebAppDeployment":
		r = &WebAppDeployment{}
	case "azure-native:web/v20190801:WebAppDeploymentSlot":
		r = &WebAppDeploymentSlot{}
	case "azure-native:web/v20190801:WebAppDiagnosticLogsConfiguration":
		r = &WebAppDiagnosticLogsConfiguration{}
	case "azure-native:web/v20190801:WebAppDomainOwnershipIdentifier":
		r = &WebAppDomainOwnershipIdentifier{}
	case "azure-native:web/v20190801:WebAppDomainOwnershipIdentifierSlot":
		r = &WebAppDomainOwnershipIdentifierSlot{}
	case "azure-native:web/v20190801:WebAppFunction":
		r = &WebAppFunction{}
	case "azure-native:web/v20190801:WebAppHostNameBinding":
		r = &WebAppHostNameBinding{}
	case "azure-native:web/v20190801:WebAppHostNameBindingSlot":
		r = &WebAppHostNameBindingSlot{}
	case "azure-native:web/v20190801:WebAppHybridConnection":
		r = &WebAppHybridConnection{}
	case "azure-native:web/v20190801:WebAppHybridConnectionSlot":
		r = &WebAppHybridConnectionSlot{}
	case "azure-native:web/v20190801:WebAppInstanceFunctionSlot":
		r = &WebAppInstanceFunctionSlot{}
	case "azure-native:web/v20190801:WebAppMetadata":
		r = &WebAppMetadata{}
	case "azure-native:web/v20190801:WebAppMetadataSlot":
		r = &WebAppMetadataSlot{}
	case "azure-native:web/v20190801:WebAppPremierAddOn":
		r = &WebAppPremierAddOn{}
	case "azure-native:web/v20190801:WebAppPremierAddOnSlot":
		r = &WebAppPremierAddOnSlot{}
	case "azure-native:web/v20190801:WebAppPrivateEndpointConnection":
		r = &WebAppPrivateEndpointConnection{}
	case "azure-native:web/v20190801:WebAppPublicCertificate":
		r = &WebAppPublicCertificate{}
	case "azure-native:web/v20190801:WebAppPublicCertificateSlot":
		r = &WebAppPublicCertificateSlot{}
	case "azure-native:web/v20190801:WebAppRelayServiceConnection":
		r = &WebAppRelayServiceConnection{}
	case "azure-native:web/v20190801:WebAppRelayServiceConnectionSlot":
		r = &WebAppRelayServiceConnectionSlot{}
	case "azure-native:web/v20190801:WebAppSiteExtension":
		r = &WebAppSiteExtension{}
	case "azure-native:web/v20190801:WebAppSiteExtensionSlot":
		r = &WebAppSiteExtensionSlot{}
	case "azure-native:web/v20190801:WebAppSitePushSettings":
		r = &WebAppSitePushSettings{}
	case "azure-native:web/v20190801:WebAppSitePushSettingsSlot":
		r = &WebAppSitePushSettingsSlot{}
	case "azure-native:web/v20190801:WebAppSlot":
		r = &WebAppSlot{}
	case "azure-native:web/v20190801:WebAppSlotConfigurationNames":
		r = &WebAppSlotConfigurationNames{}
	case "azure-native:web/v20190801:WebAppSourceControl":
		r = &WebAppSourceControl{}
	case "azure-native:web/v20190801:WebAppSourceControlSlot":
		r = &WebAppSourceControlSlot{}
	case "azure-native:web/v20190801:WebAppSwiftVirtualNetworkConnection":
		r = &WebAppSwiftVirtualNetworkConnection{}
	case "azure-native:web/v20190801:WebAppSwiftVirtualNetworkConnectionSlot":
		r = &WebAppSwiftVirtualNetworkConnectionSlot{}
	case "azure-native:web/v20190801:WebAppVnetConnection":
		r = &WebAppVnetConnection{}
	case "azure-native:web/v20190801:WebAppVnetConnectionSlot":
		r = &WebAppVnetConnectionSlot{}
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
		"web/v20190801",
		&module{version},
	)
}
