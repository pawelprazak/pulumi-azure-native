# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from .. import _utilities
import typing
# Export this package's modules as members:
from ._enums import *
from .b2_c_tenant import *
from .get_b2_c_tenant import *
from .get_guest_usage import *
from .guest_usage import *
from ._inputs import *
from . import outputs

# Make subpackages available:
if typing.TYPE_CHECKING:
    import pulumi_azure_native.azureactivedirectory.v20190101preview as __v20190101preview
    v20190101preview = __v20190101preview
    import pulumi_azure_native.azureactivedirectory.v20200501preview as __v20200501preview
    v20200501preview = __v20200501preview
    import pulumi_azure_native.azureactivedirectory.v20210401 as __v20210401
    v20210401 = __v20210401
else:
    v20190101preview = _utilities.lazy_import('pulumi_azure_native.azureactivedirectory.v20190101preview')
    v20200501preview = _utilities.lazy_import('pulumi_azure_native.azureactivedirectory.v20200501preview')
    v20210401 = _utilities.lazy_import('pulumi_azure_native.azureactivedirectory.v20210401')

