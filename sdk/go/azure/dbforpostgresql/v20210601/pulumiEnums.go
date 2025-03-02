// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20210601

// The mode to create a new PostgreSQL server.
type CreateMode string

const (
	CreateModeDefault            = CreateMode("Default")
	CreateModeCreate             = CreateMode("Create")
	CreateModeUpdate             = CreateMode("Update")
	CreateModePointInTimeRestore = CreateMode("PointInTimeRestore")
)

// A value indicating whether Geo-Redundant backup is enabled on the server.
type GeoRedundantBackupEnum string

const (
	GeoRedundantBackupEnumEnabled  = GeoRedundantBackupEnum("Enabled")
	GeoRedundantBackupEnumDisabled = GeoRedundantBackupEnum("Disabled")
)

// The HA mode for the server.
type HighAvailabilityMode string

const (
	HighAvailabilityModeDisabled      = HighAvailabilityMode("Disabled")
	HighAvailabilityModeZoneRedundant = HighAvailabilityMode("ZoneRedundant")
)

// PostgreSQL Server version.
type ServerVersion string

const (
	ServerVersion_13 = ServerVersion("13")
	ServerVersion_12 = ServerVersion("12")
	ServerVersion_11 = ServerVersion("11")
)

// The tier of the particular SKU, e.g. Burstable.
type SkuTier string

const (
	SkuTierBurstable       = SkuTier("Burstable")
	SkuTierGeneralPurpose  = SkuTier("GeneralPurpose")
	SkuTierMemoryOptimized = SkuTier("MemoryOptimized")
)

func init() {
}
