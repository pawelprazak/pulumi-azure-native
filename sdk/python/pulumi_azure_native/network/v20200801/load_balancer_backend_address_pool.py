# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from ... import _utilities
from . import outputs
from ._inputs import *

__all__ = ['LoadBalancerBackendAddressPoolArgs', 'LoadBalancerBackendAddressPool']

@pulumi.input_type
class LoadBalancerBackendAddressPoolArgs:
    def __init__(__self__, *,
                 load_balancer_name: pulumi.Input[str],
                 resource_group_name: pulumi.Input[str],
                 backend_address_pool_name: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 load_balancer_backend_addresses: Optional[pulumi.Input[Sequence[pulumi.Input['LoadBalancerBackendAddressArgs']]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a LoadBalancerBackendAddressPool resource.
        :param pulumi.Input[str] load_balancer_name: The name of the load balancer.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        :param pulumi.Input[str] backend_address_pool_name: The name of the backend address pool.
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[Sequence[pulumi.Input['LoadBalancerBackendAddressArgs']]] load_balancer_backend_addresses: An array of backend addresses.
        :param pulumi.Input[str] location: The location of the backend address pool.
        :param pulumi.Input[str] name: The name of the resource that is unique within the set of backend address pools used by the load balancer. This name can be used to access the resource.
        """
        pulumi.set(__self__, "load_balancer_name", load_balancer_name)
        pulumi.set(__self__, "resource_group_name", resource_group_name)
        if backend_address_pool_name is not None:
            pulumi.set(__self__, "backend_address_pool_name", backend_address_pool_name)
        if id is not None:
            pulumi.set(__self__, "id", id)
        if load_balancer_backend_addresses is not None:
            pulumi.set(__self__, "load_balancer_backend_addresses", load_balancer_backend_addresses)
        if location is not None:
            pulumi.set(__self__, "location", location)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="loadBalancerName")
    def load_balancer_name(self) -> pulumi.Input[str]:
        """
        The name of the load balancer.
        """
        return pulumi.get(self, "load_balancer_name")

    @load_balancer_name.setter
    def load_balancer_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "load_balancer_name", value)

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Input[str]:
        """
        The name of the resource group.
        """
        return pulumi.get(self, "resource_group_name")

    @resource_group_name.setter
    def resource_group_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_group_name", value)

    @property
    @pulumi.getter(name="backendAddressPoolName")
    def backend_address_pool_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the backend address pool.
        """
        return pulumi.get(self, "backend_address_pool_name")

    @backend_address_pool_name.setter
    def backend_address_pool_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "backend_address_pool_name", value)

    @property
    @pulumi.getter
    def id(self) -> Optional[pulumi.Input[str]]:
        """
        Resource ID.
        """
        return pulumi.get(self, "id")

    @id.setter
    def id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "id", value)

    @property
    @pulumi.getter(name="loadBalancerBackendAddresses")
    def load_balancer_backend_addresses(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['LoadBalancerBackendAddressArgs']]]]:
        """
        An array of backend addresses.
        """
        return pulumi.get(self, "load_balancer_backend_addresses")

    @load_balancer_backend_addresses.setter
    def load_balancer_backend_addresses(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['LoadBalancerBackendAddressArgs']]]]):
        pulumi.set(self, "load_balancer_backend_addresses", value)

    @property
    @pulumi.getter
    def location(self) -> Optional[pulumi.Input[str]]:
        """
        The location of the backend address pool.
        """
        return pulumi.get(self, "location")

    @location.setter
    def location(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "location", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the resource that is unique within the set of backend address pools used by the load balancer. This name can be used to access the resource.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


class LoadBalancerBackendAddressPool(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 backend_address_pool_name: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 load_balancer_backend_addresses: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LoadBalancerBackendAddressArgs']]]]] = None,
                 load_balancer_name: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Pool of backend IP addresses.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] backend_address_pool_name: The name of the backend address pool.
        :param pulumi.Input[str] id: Resource ID.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LoadBalancerBackendAddressArgs']]]] load_balancer_backend_addresses: An array of backend addresses.
        :param pulumi.Input[str] load_balancer_name: The name of the load balancer.
        :param pulumi.Input[str] location: The location of the backend address pool.
        :param pulumi.Input[str] name: The name of the resource that is unique within the set of backend address pools used by the load balancer. This name can be used to access the resource.
        :param pulumi.Input[str] resource_group_name: The name of the resource group.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: LoadBalancerBackendAddressPoolArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Pool of backend IP addresses.

        :param str resource_name: The name of the resource.
        :param LoadBalancerBackendAddressPoolArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(LoadBalancerBackendAddressPoolArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 backend_address_pool_name: Optional[pulumi.Input[str]] = None,
                 id: Optional[pulumi.Input[str]] = None,
                 load_balancer_backend_addresses: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['LoadBalancerBackendAddressArgs']]]]] = None,
                 load_balancer_name: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = LoadBalancerBackendAddressPoolArgs.__new__(LoadBalancerBackendAddressPoolArgs)

            __props__.__dict__["backend_address_pool_name"] = backend_address_pool_name
            __props__.__dict__["id"] = id
            __props__.__dict__["load_balancer_backend_addresses"] = load_balancer_backend_addresses
            if load_balancer_name is None and not opts.urn:
                raise TypeError("Missing required property 'load_balancer_name'")
            __props__.__dict__["load_balancer_name"] = load_balancer_name
            __props__.__dict__["location"] = location
            __props__.__dict__["name"] = name
            if resource_group_name is None and not opts.urn:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__.__dict__["resource_group_name"] = resource_group_name
            __props__.__dict__["backend_ip_configurations"] = None
            __props__.__dict__["etag"] = None
            __props__.__dict__["load_balancing_rules"] = None
            __props__.__dict__["outbound_rule"] = None
            __props__.__dict__["outbound_rules"] = None
            __props__.__dict__["provisioning_state"] = None
            __props__.__dict__["type"] = None
        alias_opts = pulumi.ResourceOptions(aliases=[pulumi.Alias(type_="azure-native:network:LoadBalancerBackendAddressPool"), pulumi.Alias(type_="azure-native:network/v20200401:LoadBalancerBackendAddressPool"), pulumi.Alias(type_="azure-native:network/v20200501:LoadBalancerBackendAddressPool"), pulumi.Alias(type_="azure-native:network/v20200601:LoadBalancerBackendAddressPool"), pulumi.Alias(type_="azure-native:network/v20200701:LoadBalancerBackendAddressPool"), pulumi.Alias(type_="azure-native:network/v20201101:LoadBalancerBackendAddressPool"), pulumi.Alias(type_="azure-native:network/v20210201:LoadBalancerBackendAddressPool"), pulumi.Alias(type_="azure-native:network/v20210301:LoadBalancerBackendAddressPool"), pulumi.Alias(type_="azure-native:network/v20210501:LoadBalancerBackendAddressPool"), pulumi.Alias(type_="azure-native:network/v20210801:LoadBalancerBackendAddressPool"), pulumi.Alias(type_="azure-native:network/v20220101:LoadBalancerBackendAddressPool")])
        opts = pulumi.ResourceOptions.merge(opts, alias_opts)
        super(LoadBalancerBackendAddressPool, __self__).__init__(
            'azure-native:network/v20200801:LoadBalancerBackendAddressPool',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None) -> 'LoadBalancerBackendAddressPool':
        """
        Get an existing LoadBalancerBackendAddressPool resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = LoadBalancerBackendAddressPoolArgs.__new__(LoadBalancerBackendAddressPoolArgs)

        __props__.__dict__["backend_ip_configurations"] = None
        __props__.__dict__["etag"] = None
        __props__.__dict__["load_balancer_backend_addresses"] = None
        __props__.__dict__["load_balancing_rules"] = None
        __props__.__dict__["location"] = None
        __props__.__dict__["name"] = None
        __props__.__dict__["outbound_rule"] = None
        __props__.__dict__["outbound_rules"] = None
        __props__.__dict__["provisioning_state"] = None
        __props__.__dict__["type"] = None
        return LoadBalancerBackendAddressPool(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="backendIPConfigurations")
    def backend_ip_configurations(self) -> pulumi.Output[Sequence['outputs.NetworkInterfaceIPConfigurationResponse']]:
        """
        An array of references to IP addresses defined in network interfaces.
        """
        return pulumi.get(self, "backend_ip_configurations")

    @property
    @pulumi.getter
    def etag(self) -> pulumi.Output[str]:
        """
        A unique read-only string that changes whenever the resource is updated.
        """
        return pulumi.get(self, "etag")

    @property
    @pulumi.getter(name="loadBalancerBackendAddresses")
    def load_balancer_backend_addresses(self) -> pulumi.Output[Optional[Sequence['outputs.LoadBalancerBackendAddressResponse']]]:
        """
        An array of backend addresses.
        """
        return pulumi.get(self, "load_balancer_backend_addresses")

    @property
    @pulumi.getter(name="loadBalancingRules")
    def load_balancing_rules(self) -> pulumi.Output[Sequence['outputs.SubResourceResponse']]:
        """
        An array of references to load balancing rules that use this backend address pool.
        """
        return pulumi.get(self, "load_balancing_rules")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[Optional[str]]:
        """
        The location of the backend address pool.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[Optional[str]]:
        """
        The name of the resource that is unique within the set of backend address pools used by the load balancer. This name can be used to access the resource.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="outboundRule")
    def outbound_rule(self) -> pulumi.Output['outputs.SubResourceResponse']:
        """
        A reference to an outbound rule that uses this backend address pool.
        """
        return pulumi.get(self, "outbound_rule")

    @property
    @pulumi.getter(name="outboundRules")
    def outbound_rules(self) -> pulumi.Output[Sequence['outputs.SubResourceResponse']]:
        """
        An array of references to outbound rules that use this backend address pool.
        """
        return pulumi.get(self, "outbound_rules")

    @property
    @pulumi.getter(name="provisioningState")
    def provisioning_state(self) -> pulumi.Output[str]:
        """
        The provisioning state of the backend address pool resource.
        """
        return pulumi.get(self, "provisioning_state")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[str]:
        """
        Type of the resource.
        """
        return pulumi.get(self, "type")

