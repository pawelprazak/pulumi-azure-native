// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20151101preview

// The kind of the DataSource.
type DataSourceKind string

const (
	DataSourceKindAzureActivityLog              = DataSourceKind("AzureActivityLog")
	DataSourceKindChangeTrackingPath            = DataSourceKind("ChangeTrackingPath")
	DataSourceKindChangeTrackingDefaultPath     = DataSourceKind("ChangeTrackingDefaultPath")
	DataSourceKindChangeTrackingDefaultRegistry = DataSourceKind("ChangeTrackingDefaultRegistry")
	DataSourceKindChangeTrackingCustomRegistry  = DataSourceKind("ChangeTrackingCustomRegistry")
	DataSourceKindCustomLog                     = DataSourceKind("CustomLog")
	DataSourceKindCustomLogCollection           = DataSourceKind("CustomLogCollection")
	DataSourceKindGenericDataSource             = DataSourceKind("GenericDataSource")
	DataSourceKindIISLogs                       = DataSourceKind("IISLogs")
	DataSourceKindLinuxPerformanceObject        = DataSourceKind("LinuxPerformanceObject")
	DataSourceKindLinuxPerformanceCollection    = DataSourceKind("LinuxPerformanceCollection")
	DataSourceKindLinuxSyslog                   = DataSourceKind("LinuxSyslog")
	DataSourceKindLinuxSyslogCollection         = DataSourceKind("LinuxSyslogCollection")
	DataSourceKindWindowsEvent                  = DataSourceKind("WindowsEvent")
	DataSourceKindWindowsPerformanceCounter     = DataSourceKind("WindowsPerformanceCounter")
)

// The provisioning state of the workspace.
type EntityStatus string

const (
	EntityStatusCreating            = EntityStatus("Creating")
	EntityStatusSucceeded           = EntityStatus("Succeeded")
	EntityStatusFailed              = EntityStatus("Failed")
	EntityStatusCanceled            = EntityStatus("Canceled")
	EntityStatusDeleting            = EntityStatus("Deleting")
	EntityStatusProvisioningAccount = EntityStatus("ProvisioningAccount")
)

// Type of the machine group
type MachineGroupType string

const (
	MachineGroupTypeUnknown      = MachineGroupType("unknown")
	MachineGroupType_Azure_cs    = MachineGroupType("azure-cs")
	MachineGroupType_Azure_sf    = MachineGroupType("azure-sf")
	MachineGroupType_Azure_vmss  = MachineGroupType("azure-vmss")
	MachineGroupType_User_static = MachineGroupType("user-static")
)

// The name of the SKU.
type SkuNameEnum string

const (
	SkuNameEnumFree                = SkuNameEnum("Free")
	SkuNameEnumStandard            = SkuNameEnum("Standard")
	SkuNameEnumPremium             = SkuNameEnum("Premium")
	SkuNameEnumPerNode             = SkuNameEnum("PerNode")
	SkuNameEnumPerGB2018           = SkuNameEnum("PerGB2018")
	SkuNameEnumStandalone          = SkuNameEnum("Standalone")
	SkuNameEnumCapacityReservation = SkuNameEnum("CapacityReservation")
)

func init() {
}
