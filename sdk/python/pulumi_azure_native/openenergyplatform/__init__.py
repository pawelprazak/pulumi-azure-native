# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from .. import _utilities
import typing
# Export this package's modules as members:
from .energy_service import *
from .get_energy_service import *
from .list_energy_service_partitions import *
from ._inputs import *
from . import outputs

# Make subpackages available:
if typing.TYPE_CHECKING:
    import pulumi_azure_native.openenergyplatform.v20210601preview as __v20210601preview
    v20210601preview = __v20210601preview
    import pulumi_azure_native.openenergyplatform.v20220404preview as __v20220404preview
    v20220404preview = __v20220404preview
else:
    v20210601preview = _utilities.lazy_import('pulumi_azure_native.openenergyplatform.v20210601preview')
    v20220404preview = _utilities.lazy_import('pulumi_azure_native.openenergyplatform.v20220404preview')

