# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'ActionType',
    'AdditionalWorkspaceDataType',
    'AdditionalWorkspaceType',
    'ApplicationSourceResourceType',
    'AssessmentStatusCode',
    'AssessmentType',
    'AuthenticationType',
    'AutoProvision',
    'Categories',
    'CloudName',
    'DataSource',
    'EventSource',
    'ExportData',
    'ImplementationEffort',
    'MinimalSeverity',
    'OfferingType',
    'Operator',
    'OrganizationMembershipType',
    'PropertyType',
    'Protocol',
    'RecommendationConfigStatus',
    'RecommendationType',
    'Roles',
    'RuleState',
    'SecuritySolutionStatus',
    'Severity',
    'SeverityEnum',
    'Source',
    'StandardSupportedClouds',
    'State',
    'Status',
    'StatusReason',
    'SupportedCloudEnum',
    'Threats',
    'UnmaskedIpLoggingStatus',
    'UserImpact',
]


class ActionType(str, Enum):
    """
    The type of the action that will be triggered by the Automation
    """
    LOGIC_APP = "LogicApp"
    EVENT_HUB = "EventHub"
    WORKSPACE = "Workspace"


class AdditionalWorkspaceDataType(str, Enum):
    """
    Data types sent to workspace.
    """
    ALERTS = "Alerts"
    RAW_EVENTS = "RawEvents"


class AdditionalWorkspaceType(str, Enum):
    """
    Workspace type.
    """
    SENTINEL = "Sentinel"


class ApplicationSourceResourceType(str, Enum):
    """
    The application source, what it affects, e.g. Assessments
    """
    ASSESSMENTS = "Assessments"
    """
    The source of the application is assessments
    """


class AssessmentStatusCode(str, Enum):
    """
    Programmatic code for the status of the assessment
    """
    HEALTHY = "Healthy"
    """
    The resource is healthy
    """
    UNHEALTHY = "Unhealthy"
    """
    The resource has a security issue that needs to be addressed
    """
    NOT_APPLICABLE = "NotApplicable"
    """
    Assessment for this resource did not happen
    """


class AssessmentType(str, Enum):
    """
    BuiltIn if the assessment based on built-in Azure Policy definition, Custom if the assessment based on custom Azure Policy definition
    """
    BUILT_IN = "BuiltIn"
    """
    Microsoft Defender for Cloud managed assessments
    """
    CUSTOM_POLICY = "CustomPolicy"
    """
    User defined policies that are automatically ingested from Azure Policy to Microsoft Defender for Cloud
    """
    CUSTOMER_MANAGED = "CustomerManaged"
    """
    User assessments pushed directly by the user or other third party to Microsoft Defender for Cloud
    """
    VERIFIED_PARTNER = "VerifiedPartner"
    """
    An assessment that was created by a verified 3rd party if the user connected it to ASC
    """


class AuthenticationType(str, Enum):
    """
    Connect to your cloud account, for AWS use either account credentials or role-based authentication. For GCP use account organization credentials.
    """
    AWS_CREDS = "awsCreds"
    """
    AWS cloud account connector user credentials authentication
    """
    AWS_ASSUME_ROLE = "awsAssumeRole"
    """
    AWS account connector assume role authentication
    """
    GCP_CREDENTIALS = "gcpCredentials"
    """
    GCP account connector service to service authentication
    """


class AutoProvision(str, Enum):
    """
    Whether or not to automatically install Azure Arc (hybrid compute) agents on machines
    """
    ON = "On"
    """
    Install missing Azure Arc agents on machines automatically
    """
    OFF = "Off"
    """
    Do not install Azure Arc agent on the machines automatically
    """


class Categories(str, Enum):
    """
    The categories of resource that is at risk when the assessment is unhealthy
    """
    COMPUTE = "Compute"
    NETWORKING = "Networking"
    DATA = "Data"
    IDENTITY_AND_ACCESS = "IdentityAndAccess"
    IO_T = "IoT"


class CloudName(str, Enum):
    """
    The multi cloud resource's cloud name.
    """
    AZURE = "Azure"
    AWS = "AWS"
    GCP = "GCP"


class DataSource(str, Enum):
    TWIN_DATA = "TwinData"
    """
    Devices twin data
    """


class EventSource(str, Enum):
    """
    A valid event source type.
    """
    ASSESSMENTS = "Assessments"
    ASSESSMENTS_SNAPSHOT = "AssessmentsSnapshot"
    SUB_ASSESSMENTS = "SubAssessments"
    SUB_ASSESSMENTS_SNAPSHOT = "SubAssessmentsSnapshot"
    ALERTS = "Alerts"
    SECURE_SCORES = "SecureScores"
    SECURE_SCORES_SNAPSHOT = "SecureScoresSnapshot"
    SECURE_SCORE_CONTROLS = "SecureScoreControls"
    SECURE_SCORE_CONTROLS_SNAPSHOT = "SecureScoreControlsSnapshot"
    REGULATORY_COMPLIANCE_ASSESSMENT = "RegulatoryComplianceAssessment"
    REGULATORY_COMPLIANCE_ASSESSMENT_SNAPSHOT = "RegulatoryComplianceAssessmentSnapshot"


class ExportData(str, Enum):
    RAW_EVENTS = "RawEvents"
    """
    Agent raw events
    """


class ImplementationEffort(str, Enum):
    """
    The implementation effort required to remediate this assessment
    """
    LOW = "Low"
    MODERATE = "Moderate"
    HIGH = "High"


class MinimalSeverity(str, Enum):
    """
    Defines the minimal alert severity which will be sent as email notifications
    """
    HIGH = "High"
    """
    Get notifications on new alerts with High severity
    """
    MEDIUM = "Medium"
    """
    Get notifications on new alerts with medium or high severity
    """
    LOW = "Low"
    """
    Don't get notifications on new alerts with low, medium or high severity
    """


class OfferingType(str, Enum):
    """
    The type of the security offering.
    """
    CSPM_MONITOR_AWS = "CspmMonitorAws"
    DEFENDER_FOR_CONTAINERS_AWS = "DefenderForContainersAws"
    DEFENDER_FOR_SERVERS_AWS = "DefenderForServersAws"
    INFORMATION_PROTECTION_AWS = "InformationProtectionAws"


class Operator(str, Enum):
    """
    A valid comparer operator to use. A case-insensitive comparison will be applied for String PropertyType.
    """
    EQUALS = "Equals"
    """
    Applies for decimal and non-decimal operands
    """
    GREATER_THAN = "GreaterThan"
    """
    Applies only for decimal operands
    """
    GREATER_THAN_OR_EQUAL_TO = "GreaterThanOrEqualTo"
    """
    Applies only for decimal operands
    """
    LESSER_THAN = "LesserThan"
    """
    Applies only for decimal operands
    """
    LESSER_THAN_OR_EQUAL_TO = "LesserThanOrEqualTo"
    """
    Applies only for decimal operands
    """
    NOT_EQUALS = "NotEquals"
    """
    Applies  for decimal and non-decimal operands
    """
    CONTAINS = "Contains"
    """
    Applies only for non-decimal operands
    """
    STARTS_WITH = "StartsWith"
    """
    Applies only for non-decimal operands
    """
    ENDS_WITH = "EndsWith"
    """
    Applies only for non-decimal operands
    """


class OrganizationMembershipType(str, Enum):
    """
    The multi cloud account's membership type in the organization
    """
    MEMBER = "Member"
    ORGANIZATION = "Organization"


class PropertyType(str, Enum):
    """
    The data type of the compared operands (string, integer, floating point number or a boolean [true/false]]
    """
    STRING = "String"
    INTEGER = "Integer"
    NUMBER = "Number"
    BOOLEAN = "Boolean"


class Protocol(str, Enum):
    TCP = "TCP"
    UDP = "UDP"
    ALL = "*"


class RecommendationConfigStatus(str, Enum):
    """
    Recommendation status. When the recommendation status is disabled recommendations are not generated.
    """
    DISABLED = "Disabled"
    ENABLED = "Enabled"


class RecommendationType(str, Enum):
    """
    The type of IoT Security recommendation.
    """
    IO_T_ACR_AUTHENTICATION = "IoT_ACRAuthentication"
    """
    Authentication schema used for pull an edge module from an ACR repository does not use Service Principal Authentication.
    """
    IO_T_AGENT_SENDS_UNUTILIZED_MESSAGES = "IoT_AgentSendsUnutilizedMessages"
    """
    IoT agent message size capacity is currently underutilized, causing an increase in the number of sent messages. Adjust message intervals for better utilization.
    """
    IO_T_BASELINE = "IoT_Baseline"
    """
    Identified security related system configuration issues.
    """
    IO_T_EDGE_HUB_MEM_OPTIMIZE = "IoT_EdgeHubMemOptimize"
    """
    You can optimize Edge Hub memory usage by turning off protocol heads for any protocols not used by Edge modules in your solution.
    """
    IO_T_EDGE_LOGGING_OPTIONS = "IoT_EdgeLoggingOptions"
    """
    Logging is disabled for this edge module.
    """
    IO_T_INCONSISTENT_MODULE_SETTINGS = "IoT_InconsistentModuleSettings"
    """
    A minority within a device security group has inconsistent Edge Module settings with the rest of their group.
    """
    IO_T_INSTALL_AGENT = "IoT_InstallAgent"
    """
    Install the Azure Security of Things Agent.
    """
    IO_T_IP_FILTER_DENY_ALL = "IoT_IPFilter_DenyAll"
    """
    IP Filter Configuration should have rules defined for allowed traffic and should deny all other traffic by default.
    """
    IO_T_IP_FILTER_PERMISSIVE_RULE = "IoT_IPFilter_PermissiveRule"
    """
    An Allow IP Filter rules source IP range is too large. Overly permissive rules might expose your IoT hub to malicious intenders.
    """
    IO_T_OPEN_PORTS = "IoT_OpenPorts"
    """
    A listening endpoint was found on the device.
    """
    IO_T_PERMISSIVE_FIREWALL_POLICY = "IoT_PermissiveFirewallPolicy"
    """
    An Allowed firewall policy was found (INPUT/OUTPUT). The policy should Deny all traffic by default and define rules to allow necessary communication to/from the device.
    """
    IO_T_PERMISSIVE_INPUT_FIREWALL_RULES = "IoT_PermissiveInputFirewallRules"
    """
    A rule in the firewall has been found that contains a permissive pattern for a wide range of IP addresses or Ports.
    """
    IO_T_PERMISSIVE_OUTPUT_FIREWALL_RULES = "IoT_PermissiveOutputFirewallRules"
    """
    A rule in the firewall has been found that contains a permissive pattern for a wide range of IP addresses or Ports.
    """
    IO_T_PRIVILEGED_DOCKER_OPTIONS = "IoT_PrivilegedDockerOptions"
    """
    Edge module is configured to run in privileged mode, with extensive Linux capabilities or with host-level network access (send/receive data to host machine).
    """
    IO_T_SHARED_CREDENTIALS = "IoT_SharedCredentials"
    """
    Same authentication credentials to the IoT Hub used by multiple devices. This could indicate an illegitimate device impersonating a legitimate device. It also exposes the risk of device impersonation by an attacker.
    """
    IO_T_VULNERABLE_TLS_CIPHER_SUITE = "IoT_VulnerableTLSCipherSuite"
    """
    Insecure TLS configurations detected. Immediate upgrade recommended.
    """


class Roles(str, Enum):
    """
    A possible role to configure sending security notification alerts to
    """
    ACCOUNT_ADMIN = "AccountAdmin"
    """
    If enabled, send notification on new alerts to the account admins
    """
    SERVICE_ADMIN = "ServiceAdmin"
    """
    If enabled, send notification on new alerts to the service admins
    """
    OWNER = "Owner"
    """
    If enabled, send notification on new alerts to the subscription owners
    """
    CONTRIBUTOR = "Contributor"
    """
    If enabled, send notification on new alerts to the subscription contributors
    """


class RuleState(str, Enum):
    """
    Possible states of the rule
    """
    ENABLED = "Enabled"
    DISABLED = "Disabled"
    EXPIRED = "Expired"


class SecuritySolutionStatus(str, Enum):
    """
    Status of the IoT Security solution.
    """
    ENABLED = "Enabled"
    DISABLED = "Disabled"


class Severity(str, Enum):
    """
    The severity level of the assessment
    """
    LOW = "Low"
    MEDIUM = "Medium"
    HIGH = "High"


class SeverityEnum(str, Enum):
    """
    The severity to relate to the assessments generated by this assessment automation.
    """
    HIGH = "High"
    MEDIUM = "Medium"
    LOW = "Low"


class Source(str, Enum):
    """
    The platform where the assessed resource resides
    """
    AZURE = "Azure"
    """
    Resource is in Azure
    """
    ON_PREMISE = "OnPremise"
    """
    Resource in an on premise machine connected to Azure cloud
    """
    ON_PREMISE_SQL = "OnPremiseSql"
    """
    SQL Resource in an on premise machine connected to Azure cloud
    """


class StandardSupportedClouds(str, Enum):
    """
    The cloud that the standard is supported on.
    """
    AWS = "AWS"
    GCP = "GCP"


class State(str, Enum):
    """
    Defines whether to send email notifications from AMicrosoft Defender for Cloud to persons with specific RBAC roles on the subscription.
    """
    ON = "On"
    """
    Send notification on new alerts to the subscription's admins
    """
    OFF = "Off"
    """
    Don't send notification on new alerts to the subscription's admins
    """


class Status(str, Enum):
    """
    The status of the port
    """
    REVOKED = "Revoked"
    INITIATED = "Initiated"


class StatusReason(str, Enum):
    """
    A description of why the `status` has its value
    """
    EXPIRED = "Expired"
    USER_REQUESTED = "UserRequested"
    NEWER_REQUEST_INITIATED = "NewerRequestInitiated"


class SupportedCloudEnum(str, Enum):
    """
    Relevant cloud for the custom assessment automation.
    """
    AWS = "AWS"
    GCP = "GCP"


class Threats(str, Enum):
    """
    Threats impact of the assessment
    """
    ACCOUNT_BREACH = "accountBreach"
    DATA_EXFILTRATION = "dataExfiltration"
    DATA_SPILLAGE = "dataSpillage"
    MALICIOUS_INSIDER = "maliciousInsider"
    ELEVATION_OF_PRIVILEGE = "elevationOfPrivilege"
    THREAT_RESISTANCE = "threatResistance"
    MISSING_COVERAGE = "missingCoverage"
    DENIAL_OF_SERVICE = "denialOfService"


class UnmaskedIpLoggingStatus(str, Enum):
    """
    Unmasked IP address logging status
    """
    DISABLED = "Disabled"
    """
    Unmasked IP logging is disabled
    """
    ENABLED = "Enabled"
    """
    Unmasked IP logging is enabled
    """


class UserImpact(str, Enum):
    """
    The user impact of the assessment
    """
    LOW = "Low"
    MODERATE = "Moderate"
    HIGH = "High"
