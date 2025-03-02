# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities

__all__ = [
    'ConfigurationProfileAssignmentPropertiesArgs',
    'ConfigurationProfilePropertiesArgs',
]

@pulumi.input_type
class ConfigurationProfileAssignmentPropertiesArgs:
    def __init__(__self__, *,
                 configuration_profile: Optional[pulumi.Input[str]] = None,
                 profile_overrides: Optional[pulumi.Input[Mapping[str, Any]]] = None):
        """
        Automanage configuration profile assignment properties.
        :param pulumi.Input[str] configuration_profile: The Automanage configurationProfile ARM Resource URI.
        :param pulumi.Input[Mapping[str, Any]] profile_overrides: The profileOverrides setting for the configuration profile assignment.
        """
        if configuration_profile is not None:
            pulumi.set(__self__, "configuration_profile", configuration_profile)
        if profile_overrides is not None:
            pulumi.set(__self__, "profile_overrides", profile_overrides)

    @property
    @pulumi.getter(name="configurationProfile")
    def configuration_profile(self) -> Optional[pulumi.Input[str]]:
        """
        The Automanage configurationProfile ARM Resource URI.
        """
        return pulumi.get(self, "configuration_profile")

    @configuration_profile.setter
    def configuration_profile(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "configuration_profile", value)

    @property
    @pulumi.getter(name="profileOverrides")
    def profile_overrides(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        The profileOverrides setting for the configuration profile assignment.
        """
        return pulumi.get(self, "profile_overrides")

    @profile_overrides.setter
    def profile_overrides(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "profile_overrides", value)


@pulumi.input_type
class ConfigurationProfilePropertiesArgs:
    def __init__(__self__, *,
                 configuration: Optional[Any] = None,
                 overrides: Optional[pulumi.Input[Sequence[Any]]] = None):
        """
        Automanage configuration profile properties.
        :param Any configuration: configuration dictionary of the configuration profile.
        :param pulumi.Input[Sequence[Any]] overrides: overrides of the configuration profile.
        """
        if configuration is not None:
            pulumi.set(__self__, "configuration", configuration)
        if overrides is not None:
            pulumi.set(__self__, "overrides", overrides)

    @property
    @pulumi.getter
    def configuration(self) -> Optional[Any]:
        """
        configuration dictionary of the configuration profile.
        """
        return pulumi.get(self, "configuration")

    @configuration.setter
    def configuration(self, value: Optional[Any]):
        pulumi.set(self, "configuration", value)

    @property
    @pulumi.getter
    def overrides(self) -> Optional[pulumi.Input[Sequence[Any]]]:
        """
        overrides of the configuration profile.
        """
        return pulumi.get(self, "overrides")

    @overrides.setter
    def overrides(self, value: Optional[pulumi.Input[Sequence[Any]]]):
        pulumi.set(self, "overrides", value)


