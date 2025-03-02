// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package webpubsub

// Default action when no other rule matches
type ACLAction string

const (
	ACLActionAllow = ACLAction("Allow")
	ACLActionDeny  = ACLAction("Deny")
)

// FeatureFlags is the supported features of Azure SignalR service.
//  - EnableConnectivityLogs: "true"/"false", to enable/disable the connectivity log category respectively.
//  - EnableMessagingLogs: "true"/"false", to enable/disable the connectivity log category respectively.
//  - EnableLiveTrace: Live Trace allows you to know what's happening inside Azure SignalR service, it will give you live traces in real time, it will be helpful when you developing your own Azure SignalR based web application or self-troubleshooting some issues. Please note that live traces are counted as outbound messages that will be charged. Values allowed: "true"/"false", to enable/disable live trace feature.
type FeatureFlags string

const (
	FeatureFlagsEnableConnectivityLogs = FeatureFlags("EnableConnectivityLogs")
	FeatureFlagsEnableMessagingLogs    = FeatureFlags("EnableMessagingLogs")
	FeatureFlagsEnableLiveTrace        = FeatureFlags("EnableLiveTrace")
)

// Represent the identity type: systemAssigned, userAssigned, None
type ManagedIdentityType string

const (
	ManagedIdentityTypeNone           = ManagedIdentityType("None")
	ManagedIdentityTypeSystemAssigned = ManagedIdentityType("SystemAssigned")
	ManagedIdentityTypeUserAssigned   = ManagedIdentityType("UserAssigned")
)

// Indicates whether the connection has been Approved/Rejected/Removed by the owner of the service.
type PrivateLinkServiceConnectionStatus string

const (
	PrivateLinkServiceConnectionStatusPending      = PrivateLinkServiceConnectionStatus("Pending")
	PrivateLinkServiceConnectionStatusApproved     = PrivateLinkServiceConnectionStatus("Approved")
	PrivateLinkServiceConnectionStatusRejected     = PrivateLinkServiceConnectionStatus("Rejected")
	PrivateLinkServiceConnectionStatusDisconnected = PrivateLinkServiceConnectionStatus("Disconnected")
)

// Upstream auth type enum.
type UpstreamAuthType string

const (
	UpstreamAuthTypeNone            = UpstreamAuthType("None")
	UpstreamAuthTypeManagedIdentity = UpstreamAuthType("ManagedIdentity")
)

// Allowed request types. The value can be one or more of: ClientConnection, ServerConnection, RESTAPI.
type WebPubSubRequestType string

const (
	WebPubSubRequestTypeClientConnection = WebPubSubRequestType("ClientConnection")
	WebPubSubRequestTypeServerConnection = WebPubSubRequestType("ServerConnection")
	WebPubSubRequestTypeRESTAPI          = WebPubSubRequestType("RESTAPI")
	WebPubSubRequestTypeTrace            = WebPubSubRequestType("Trace")
)

// Optional tier of this particular SKU. 'Standard' or 'Free'.
//
// `Basic` is deprecated, use `Standard` instead.
type WebPubSubSkuTier string

const (
	WebPubSubSkuTierFree     = WebPubSubSkuTier("Free")
	WebPubSubSkuTierBasic    = WebPubSubSkuTier("Basic")
	WebPubSubSkuTierStandard = WebPubSubSkuTier("Standard")
	WebPubSubSkuTierPremium  = WebPubSubSkuTier("Premium")
)

func init() {
}
