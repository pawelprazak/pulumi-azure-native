// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20220301

// Whether storage account lock is to be acquired for this container or not.
type AcquireStorageAccountLock string

const (
	AcquireStorageAccountLockAcquire    = AcquireStorageAccountLock("Acquire")
	AcquireStorageAccountLockNotAcquire = AcquireStorageAccountLock("NotAcquire")
)

// A value indicating whether the auto update is enabled.
type AgentAutoUpdateStatus string

const (
	AgentAutoUpdateStatusDisabled = AgentAutoUpdateStatus("Disabled")
	AgentAutoUpdateStatusEnabled  = AgentAutoUpdateStatus("Enabled")
)

type AlertsState string

const (
	AlertsStateEnabled  = AlertsState("Enabled")
	AlertsStateDisabled = AlertsState("Disabled")
)

// A value indicating the type authentication to use for automation Account.
type AutomationAccountAuthenticationType string

const (
	AutomationAccountAuthenticationTypeRunAsAccount           = AutomationAccountAuthenticationType("RunAsAccount")
	AutomationAccountAuthenticationTypeSystemAssignedIdentity = AutomationAccountAuthenticationType("SystemAssignedIdentity")
)

// Type of backup items associated with this container.
type BackupItemType string

const (
	BackupItemTypeInvalid           = BackupItemType("Invalid")
	BackupItemTypeVM                = BackupItemType("VM")
	BackupItemTypeFileFolder        = BackupItemType("FileFolder")
	BackupItemTypeAzureSqlDb        = BackupItemType("AzureSqlDb")
	BackupItemTypeSQLDB             = BackupItemType("SQLDB")
	BackupItemTypeExchange          = BackupItemType("Exchange")
	BackupItemTypeSharepoint        = BackupItemType("Sharepoint")
	BackupItemTypeVMwareVM          = BackupItemType("VMwareVM")
	BackupItemTypeSystemState       = BackupItemType("SystemState")
	BackupItemTypeClient            = BackupItemType("Client")
	BackupItemTypeGenericDataSource = BackupItemType("GenericDataSource")
	BackupItemTypeSQLDataBase       = BackupItemType("SQLDataBase")
	BackupItemTypeAzureFileShare    = BackupItemType("AzureFileShare")
	BackupItemTypeSAPHanaDatabase   = BackupItemType("SAPHanaDatabase")
	BackupItemTypeSAPAseDatabase    = BackupItemType("SAPAseDatabase")
)

// Type of backup management for the backed up item.
type BackupManagementType string

const (
	BackupManagementTypeInvalid           = BackupManagementType("Invalid")
	BackupManagementTypeAzureIaasVM       = BackupManagementType("AzureIaasVM")
	BackupManagementTypeMAB               = BackupManagementType("MAB")
	BackupManagementTypeDPM               = BackupManagementType("DPM")
	BackupManagementTypeAzureBackupServer = BackupManagementType("AzureBackupServer")
	BackupManagementTypeAzureSql          = BackupManagementType("AzureSql")
	BackupManagementTypeAzureStorage      = BackupManagementType("AzureStorage")
	BackupManagementTypeAzureWorkload     = BackupManagementType("AzureWorkload")
	BackupManagementTypeDefaultBackup     = BackupManagementType("DefaultBackup")
)

// Type of the container. The value of this property for: 1. Compute Azure VM is Microsoft.Compute/virtualMachines 2.
// Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines 3. Windows machines (like MAB, DPM etc) is
// Windows 4. Azure SQL instance is AzureSqlContainer. 5. Storage containers is StorageContainer. 6. Azure workload
// Backup is VMAppContainer
type ContainerType string

const (
	ContainerTypeInvalid                                   = ContainerType("Invalid")
	ContainerTypeUnknown                                   = ContainerType("Unknown")
	ContainerTypeIaasVMContainer                           = ContainerType("IaasVMContainer")
	ContainerTypeIaasVMServiceContainer                    = ContainerType("IaasVMServiceContainer")
	ContainerTypeDPMContainer                              = ContainerType("DPMContainer")
	ContainerTypeAzureBackupServerContainer                = ContainerType("AzureBackupServerContainer")
	ContainerTypeMABContainer                              = ContainerType("MABContainer")
	ContainerTypeCluster                                   = ContainerType("Cluster")
	ContainerTypeAzureSqlContainer                         = ContainerType("AzureSqlContainer")
	ContainerTypeWindows                                   = ContainerType("Windows")
	ContainerTypeVCenter                                   = ContainerType("VCenter")
	ContainerTypeVMAppContainer                            = ContainerType("VMAppContainer")
	ContainerTypeSQLAGWorkLoadContainer                    = ContainerType("SQLAGWorkLoadContainer")
	ContainerTypeStorageContainer                          = ContainerType("StorageContainer")
	ContainerTypeGenericContainer                          = ContainerType("GenericContainer")
	ContainerType_Microsoft_ClassicCompute_virtualMachines = ContainerType("Microsoft.ClassicCompute/virtualMachines")
	ContainerType_Microsoft_Compute_virtualMachines        = ContainerType("Microsoft.Compute/virtualMachines")
	ContainerTypeAzureWorkloadContainer                    = ContainerType("AzureWorkloadContainer")
)

// Create mode to indicate recovery of existing soft deleted data source or creation of new data source.
type CreateMode string

const (
	CreateModeInvalid = CreateMode("Invalid")
	CreateModeDefault = CreateMode("Default")
	CreateModeRecover = CreateMode("Recover")
)

// Type of workload this item represents.
type DataSourceType string

const (
	DataSourceTypeInvalid           = DataSourceType("Invalid")
	DataSourceTypeVM                = DataSourceType("VM")
	DataSourceTypeFileFolder        = DataSourceType("FileFolder")
	DataSourceTypeAzureSqlDb        = DataSourceType("AzureSqlDb")
	DataSourceTypeSQLDB             = DataSourceType("SQLDB")
	DataSourceTypeExchange          = DataSourceType("Exchange")
	DataSourceTypeSharepoint        = DataSourceType("Sharepoint")
	DataSourceTypeVMwareVM          = DataSourceType("VMwareVM")
	DataSourceTypeSystemState       = DataSourceType("SystemState")
	DataSourceTypeClient            = DataSourceType("Client")
	DataSourceTypeGenericDataSource = DataSourceType("GenericDataSource")
	DataSourceTypeSQLDataBase       = DataSourceType("SQLDataBase")
	DataSourceTypeAzureFileShare    = DataSourceType("AzureFileShare")
	DataSourceTypeSAPHanaDatabase   = DataSourceType("SAPHanaDatabase")
	DataSourceTypeSAPAseDatabase    = DataSourceType("SAPAseDatabase")
)

type DayOfWeek string

const (
	DayOfWeekSunday    = DayOfWeek("Sunday")
	DayOfWeekMonday    = DayOfWeek("Monday")
	DayOfWeekTuesday   = DayOfWeek("Tuesday")
	DayOfWeekWednesday = DayOfWeek("Wednesday")
	DayOfWeekThursday  = DayOfWeek("Thursday")
	DayOfWeekFriday    = DayOfWeek("Friday")
	DayOfWeekSaturday  = DayOfWeek("Saturday")
)

// The disk type.
type DiskAccountType string

const (
	DiskAccountType_Standard_LRS    = DiskAccountType("Standard_LRS")
	DiskAccountType_Premium_LRS     = DiskAccountType("Premium_LRS")
	DiskAccountType_StandardSSD_LRS = DiskAccountType("StandardSSD_LRS")
)

// The extended location type.
type ExtendedLocationType string

const (
	ExtendedLocationTypeEdgeZone = ExtendedLocationType("EdgeZone")
)

// The failover deployment model.
type FailoverDeploymentModel string

const (
	FailoverDeploymentModelNotApplicable   = FailoverDeploymentModel("NotApplicable")
	FailoverDeploymentModelClassic         = FailoverDeploymentModel("Classic")
	FailoverDeploymentModelResourceManager = FailoverDeploymentModel("ResourceManager")
)

// Health status of protected item.
type HealthStatus string

const (
	HealthStatusPassed          = HealthStatus("Passed")
	HealthStatusActionRequired  = HealthStatus("ActionRequired")
	HealthStatusActionSuggested = HealthStatus("ActionSuggested")
	HealthStatusInvalid         = HealthStatus("Invalid")
)

type IAASVMPolicyType string

const (
	IAASVMPolicyTypeInvalid = IAASVMPolicyType("Invalid")
	IAASVMPolicyTypeV1      = IAASVMPolicyType("V1")
	IAASVMPolicyTypeV2      = IAASVMPolicyType("V2")
)

// Enabling/Disabling the Double Encryption state
type InfrastructureEncryptionState string

const (
	InfrastructureEncryptionStateEnabled  = InfrastructureEncryptionState("Enabled")
	InfrastructureEncryptionStateDisabled = InfrastructureEncryptionState("Disabled")
)

// Last backup operation status. Possible values: Healthy, Unhealthy.
type LastBackupStatus string

const (
	LastBackupStatusInvalid   = LastBackupStatus("Invalid")
	LastBackupStatusHealthy   = LastBackupStatus("Healthy")
	LastBackupStatusUnhealthy = LastBackupStatus("Unhealthy")
	LastBackupStatusIRPending = LastBackupStatus("IRPending")
)

// The license type.
type LicenseType string

const (
	LicenseTypeNotSpecified  = LicenseType("NotSpecified")
	LicenseTypeNoLicenseType = LicenseType("NoLicenseType")
	LicenseTypeWindowsServer = LicenseType("WindowsServer")
)

type MonthOfYear string

const (
	MonthOfYearInvalid   = MonthOfYear("Invalid")
	MonthOfYearJanuary   = MonthOfYear("January")
	MonthOfYearFebruary  = MonthOfYear("February")
	MonthOfYearMarch     = MonthOfYear("March")
	MonthOfYearApril     = MonthOfYear("April")
	MonthOfYearMay       = MonthOfYear("May")
	MonthOfYearJune      = MonthOfYear("June")
	MonthOfYearJuly      = MonthOfYear("July")
	MonthOfYearAugust    = MonthOfYear("August")
	MonthOfYearSeptember = MonthOfYear("September")
	MonthOfYearOctober   = MonthOfYear("October")
	MonthOfYearNovember  = MonthOfYear("November")
	MonthOfYearDecember  = MonthOfYear("December")
)

// Re-Do Operation
type OperationType string

const (
	OperationTypeInvalid    = OperationType("Invalid")
	OperationTypeRegister   = OperationType("Register")
	OperationTypeReregister = OperationType("Reregister")
)

// Type of backup policy type
type PolicyType string

const (
	PolicyTypeInvalid      = PolicyType("Invalid")
	PolicyTypeFull         = PolicyType("Full")
	PolicyTypeDifferential = PolicyType("Differential")
	PolicyTypeLog          = PolicyType("Log")
	PolicyTypeCopyOnlyFull = PolicyType("CopyOnlyFull")
	PolicyTypeIncremental  = PolicyType("Incremental")
)

type PossibleOperationsDirections string

const (
	PossibleOperationsDirectionsPrimaryToRecovery = PossibleOperationsDirections("PrimaryToRecovery")
	PossibleOperationsDirectionsRecoveryToPrimary = PossibleOperationsDirections("RecoveryToPrimary")
)

// Gets or sets the status
type PrivateEndpointConnectionStatus string

const (
	PrivateEndpointConnectionStatusPending      = PrivateEndpointConnectionStatus("Pending")
	PrivateEndpointConnectionStatusApproved     = PrivateEndpointConnectionStatus("Approved")
	PrivateEndpointConnectionStatusRejected     = PrivateEndpointConnectionStatus("Rejected")
	PrivateEndpointConnectionStatusDisconnected = PrivateEndpointConnectionStatus("Disconnected")
)

// Health status of the backup item, evaluated based on last heartbeat received
type ProtectedItemHealthStatus string

const (
	ProtectedItemHealthStatusInvalid      = ProtectedItemHealthStatus("Invalid")
	ProtectedItemHealthStatusHealthy      = ProtectedItemHealthStatus("Healthy")
	ProtectedItemHealthStatusUnhealthy    = ProtectedItemHealthStatus("Unhealthy")
	ProtectedItemHealthStatusNotReachable = ProtectedItemHealthStatus("NotReachable")
	ProtectedItemHealthStatusIRPending    = ProtectedItemHealthStatus("IRPending")
)

// Protection state of the backup engine
type ProtectedItemStateEnum string

const (
	ProtectedItemStateEnumInvalid           = ProtectedItemStateEnum("Invalid")
	ProtectedItemStateEnumIRPending         = ProtectedItemStateEnum("IRPending")
	ProtectedItemStateEnumProtected         = ProtectedItemStateEnum("Protected")
	ProtectedItemStateEnumProtectionError   = ProtectedItemStateEnum("ProtectionError")
	ProtectedItemStateEnumProtectionStopped = ProtectedItemStateEnum("ProtectionStopped")
	ProtectedItemStateEnumProtectionPaused  = ProtectedItemStateEnum("ProtectionPaused")
)

// backup protectionIntent type.
type ProtectionIntentItemType string

const (
	ProtectionIntentItemTypeInvalid                                    = ProtectionIntentItemType("Invalid")
	ProtectionIntentItemTypeAzureResourceItem                          = ProtectionIntentItemType("AzureResourceItem")
	ProtectionIntentItemTypeRecoveryServiceVaultItem                   = ProtectionIntentItemType("RecoveryServiceVaultItem")
	ProtectionIntentItemTypeAzureWorkloadContainerAutoProtectionIntent = ProtectionIntentItemType("AzureWorkloadContainerAutoProtectionIntent")
	ProtectionIntentItemTypeAzureWorkloadAutoProtectionIntent          = ProtectionIntentItemType("AzureWorkloadAutoProtectionIntent")
	ProtectionIntentItemTypeAzureWorkloadSQLAutoProtectionIntent       = ProtectionIntentItemType("AzureWorkloadSQLAutoProtectionIntent")
)

// Backup state of this backup item.
type ProtectionState string

const (
	ProtectionStateInvalid           = ProtectionState("Invalid")
	ProtectionStateIRPending         = ProtectionState("IRPending")
	ProtectionStateProtected         = ProtectionState("Protected")
	ProtectionStateProtectionError   = ProtectionState("ProtectionError")
	ProtectionStateProtectionStopped = ProtectionState("ProtectionStopped")
	ProtectionStateProtectionPaused  = ProtectionState("ProtectionPaused")
)

// Backup state of this backup item.
type ProtectionStatus string

const (
	ProtectionStatusInvalid          = ProtectionStatus("Invalid")
	ProtectionStatusNotProtected     = ProtectionStatus("NotProtected")
	ProtectionStatusProtecting       = ProtectionStatus("Protecting")
	ProtectionStatusProtected        = ProtectionStatus("Protected")
	ProtectionStatusProtectionFailed = ProtectionStatus("ProtectionFailed")
)

// Gets or sets provisioning state of the private endpoint connection
type ProvisioningState string

const (
	ProvisioningStateSucceeded = ProvisioningState("Succeeded")
	ProvisioningStateDeleting  = ProvisioningState("Deleting")
	ProvisioningStateFailed    = ProvisioningState("Failed")
	ProvisioningStatePending   = ProvisioningState("Pending")
)

// The fabric location.
type RecoveryPlanActionLocation string

const (
	RecoveryPlanActionLocationPrimary  = RecoveryPlanActionLocation("Primary")
	RecoveryPlanActionLocationRecovery = RecoveryPlanActionLocation("Recovery")
)

// The group type.
type RecoveryPlanGroupType string

const (
	RecoveryPlanGroupTypeShutdown = RecoveryPlanGroupType("Shutdown")
	RecoveryPlanGroupTypeBoot     = RecoveryPlanGroupType("Boot")
	RecoveryPlanGroupTypeFailover = RecoveryPlanGroupType("Failover")
)

type ReplicationProtectedItemOperation string

const (
	ReplicationProtectedItemOperationReverseReplicate    = ReplicationProtectedItemOperation("ReverseReplicate")
	ReplicationProtectedItemOperationCommit              = ReplicationProtectedItemOperation("Commit")
	ReplicationProtectedItemOperationPlannedFailover     = ReplicationProtectedItemOperation("PlannedFailover")
	ReplicationProtectedItemOperationUnplannedFailover   = ReplicationProtectedItemOperation("UnplannedFailover")
	ReplicationProtectedItemOperationDisableProtection   = ReplicationProtectedItemOperation("DisableProtection")
	ReplicationProtectedItemOperationTestFailover        = ReplicationProtectedItemOperation("TestFailover")
	ReplicationProtectedItemOperationTestFailoverCleanup = ReplicationProtectedItemOperation("TestFailoverCleanup")
	ReplicationProtectedItemOperationFailback            = ReplicationProtectedItemOperation("Failback")
	ReplicationProtectedItemOperationFinalizeFailback    = ReplicationProtectedItemOperation("FinalizeFailback")
	ReplicationProtectedItemOperationCancelFailover      = ReplicationProtectedItemOperation("CancelFailover")
	ReplicationProtectedItemOperationChangePit           = ReplicationProtectedItemOperation("ChangePit")
	ReplicationProtectedItemOperationRepairReplication   = ReplicationProtectedItemOperation("RepairReplication")
	ReplicationProtectedItemOperationSwitchProtection    = ReplicationProtectedItemOperation("SwitchProtection")
	ReplicationProtectedItemOperationCompleteMigration   = ReplicationProtectedItemOperation("CompleteMigration")
)

// Resource Health Status
type ResourceHealthStatus string

const (
	ResourceHealthStatusHealthy             = ResourceHealthStatus("Healthy")
	ResourceHealthStatusTransientDegraded   = ResourceHealthStatus("TransientDegraded")
	ResourceHealthStatusPersistentDegraded  = ResourceHealthStatus("PersistentDegraded")
	ResourceHealthStatusTransientUnhealthy  = ResourceHealthStatus("TransientUnhealthy")
	ResourceHealthStatusPersistentUnhealthy = ResourceHealthStatus("PersistentUnhealthy")
	ResourceHealthStatusInvalid             = ResourceHealthStatus("Invalid")
)

// The type of managed identity used. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user-assigned identities. The type 'None' will remove any identities.
type ResourceIdentityType string

const (
	ResourceIdentityTypeSystemAssigned               = ResourceIdentityType("SystemAssigned")
	ResourceIdentityTypeNone                         = ResourceIdentityType("None")
	ResourceIdentityTypeUserAssigned                 = ResourceIdentityType("UserAssigned")
	ResourceIdentityType_SystemAssigned_UserAssigned = ResourceIdentityType("SystemAssigned, UserAssigned")
)

// Retention duration type of retention policy.
type RetentionDurationType string

const (
	RetentionDurationTypeInvalid = RetentionDurationType("Invalid")
	RetentionDurationTypeDays    = RetentionDurationType("Days")
	RetentionDurationTypeWeeks   = RetentionDurationType("Weeks")
	RetentionDurationTypeMonths  = RetentionDurationType("Months")
	RetentionDurationTypeYears   = RetentionDurationType("Years")
)

// Retention schedule format for yearly retention policy.
type RetentionScheduleFormat string

const (
	RetentionScheduleFormatInvalid = RetentionScheduleFormat("Invalid")
	RetentionScheduleFormatDaily   = RetentionScheduleFormat("Daily")
	RetentionScheduleFormatWeekly  = RetentionScheduleFormat("Weekly")
)

// Frequency of the schedule operation of this policy.
type ScheduleRunType string

const (
	ScheduleRunTypeInvalid = ScheduleRunType("Invalid")
	ScheduleRunTypeDaily   = ScheduleRunType("Daily")
	ScheduleRunTypeWeekly  = ScheduleRunType("Weekly")
	ScheduleRunTypeHourly  = ScheduleRunType("Hourly")
)

// A value indicating whether multi-VM sync has to be enabled. Value should be 'Enabled' or 'Disabled'.
type SetMultiVmSyncStatus string

const (
	SetMultiVmSyncStatusEnable  = SetMultiVmSyncStatus("Enable")
	SetMultiVmSyncStatusDisable = SetMultiVmSyncStatus("Disable")
)

// Name of SKU is RS0 (Recovery Services 0th version) and the tier is standard tier. They do not have affect on backend storage redundancy or any other vault settings. To manage storage redundancy, use the 'backupstorageconfig
type SkuName string

const (
	SkuNameStandard = SkuName("Standard")
	SkuNameRS0      = SkuName("RS0")
)

// The SQL Server license type.
type SqlServerLicenseType string

const (
	SqlServerLicenseTypeNotSpecified  = SqlServerLicenseType("NotSpecified")
	SqlServerLicenseTypeNoLicenseType = SqlServerLicenseType("NoLicenseType")
	SqlServerLicenseTypePAYG          = SqlServerLicenseType("PAYG")
	SqlServerLicenseTypeAHUB          = SqlServerLicenseType("AHUB")
)

type WeekOfMonth string

const (
	WeekOfMonthFirst   = WeekOfMonth("First")
	WeekOfMonthSecond  = WeekOfMonth("Second")
	WeekOfMonthThird   = WeekOfMonth("Third")
	WeekOfMonthFourth  = WeekOfMonth("Fourth")
	WeekOfMonthLast    = WeekOfMonth("Last")
	WeekOfMonthInvalid = WeekOfMonth("Invalid")
)

// Workload item type of the item for which intent is to be set
type WorkloadItemType string

const (
	WorkloadItemTypeInvalid         = WorkloadItemType("Invalid")
	WorkloadItemTypeSQLInstance     = WorkloadItemType("SQLInstance")
	WorkloadItemTypeSQLDataBase     = WorkloadItemType("SQLDataBase")
	WorkloadItemTypeSAPHanaSystem   = WorkloadItemType("SAPHanaSystem")
	WorkloadItemTypeSAPHanaDatabase = WorkloadItemType("SAPHanaDatabase")
	WorkloadItemTypeSAPAseSystem    = WorkloadItemType("SAPAseSystem")
	WorkloadItemTypeSAPAseDatabase  = WorkloadItemType("SAPAseDatabase")
)

// Type of workload for the backup management
type WorkloadType string

const (
	WorkloadTypeInvalid           = WorkloadType("Invalid")
	WorkloadTypeVM                = WorkloadType("VM")
	WorkloadTypeFileFolder        = WorkloadType("FileFolder")
	WorkloadTypeAzureSqlDb        = WorkloadType("AzureSqlDb")
	WorkloadTypeSQLDB             = WorkloadType("SQLDB")
	WorkloadTypeExchange          = WorkloadType("Exchange")
	WorkloadTypeSharepoint        = WorkloadType("Sharepoint")
	WorkloadTypeVMwareVM          = WorkloadType("VMwareVM")
	WorkloadTypeSystemState       = WorkloadType("SystemState")
	WorkloadTypeClient            = WorkloadType("Client")
	WorkloadTypeGenericDataSource = WorkloadType("GenericDataSource")
	WorkloadTypeSQLDataBase       = WorkloadType("SQLDataBase")
	WorkloadTypeAzureFileShare    = WorkloadType("AzureFileShare")
	WorkloadTypeSAPHanaDatabase   = WorkloadType("SAPHanaDatabase")
	WorkloadTypeSAPAseDatabase    = WorkloadType("SAPAseDatabase")
)

func init() {
}
