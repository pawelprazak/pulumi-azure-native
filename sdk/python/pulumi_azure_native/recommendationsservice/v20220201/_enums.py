# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'AccountConfiguration',
    'ModelingFeatures',
    'ModelingFrequency',
    'ModelingSize',
    'PrincipalType',
]


class AccountConfiguration(str, Enum):
    """
    Account configuration. This can only be set at RecommendationsService Account creation.
    """
    FREE = "Free"
    CAPACITY = "Capacity"


class ModelingFeatures(str, Enum):
    """
    Modeling features controls the set of supported scenarios\models being computed. This can only be set at Modeling creation.
    """
    BASIC = "Basic"
    STANDARD = "Standard"
    PREMIUM = "Premium"


class ModelingFrequency(str, Enum):
    """
    Modeling frequency controls the modeling compute frequency.
    """
    LOW = "Low"
    MEDIUM = "Medium"
    HIGH = "High"


class ModelingSize(str, Enum):
    """
    Modeling size controls the maximum supported input data size.
    """
    SMALL = "Small"
    MEDIUM = "Medium"
    LARGE = "Large"


class PrincipalType(str, Enum):
    """
    AAD principal type.
    """
    APPLICATION = "Application"
    USER = "User"
