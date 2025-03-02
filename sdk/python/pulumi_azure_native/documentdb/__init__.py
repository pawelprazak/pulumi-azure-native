# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from .. import _utilities
import typing
# Export this package's modules as members:
from ._enums import *
from .cassandra_cluster import *
from .cassandra_data_center import *
from .cassandra_resource_cassandra_keyspace import *
from .cassandra_resource_cassandra_table import *
from .cassandra_resource_cassandra_view import *
from .database_account import *
from .get_cassandra_cluster import *
from .get_cassandra_data_center import *
from .get_cassandra_resource_cassandra_keyspace import *
from .get_cassandra_resource_cassandra_table import *
from .get_cassandra_resource_cassandra_view import *
from .get_database_account import *
from .get_graph_resource_graph import *
from .get_gremlin_resource_gremlin_database import *
from .get_gremlin_resource_gremlin_graph import *
from .get_mongo_db_resource_mongo_db_collection import *
from .get_mongo_db_resource_mongo_db_database import *
from .get_mongo_db_resource_mongo_role_definition import *
from .get_mongo_db_resource_mongo_user_definition import *
from .get_notebook_workspace import *
from .get_private_endpoint_connection import *
from .get_service import *
from .get_sql_resource_sql_container import *
from .get_sql_resource_sql_database import *
from .get_sql_resource_sql_role_assignment import *
from .get_sql_resource_sql_role_definition import *
from .get_sql_resource_sql_stored_procedure import *
from .get_sql_resource_sql_trigger import *
from .get_sql_resource_sql_user_defined_function import *
from .get_table_resource_table import *
from .graph_resource_graph import *
from .gremlin_resource_gremlin_database import *
from .gremlin_resource_gremlin_graph import *
from .list_database_account_connection_strings import *
from .list_database_account_keys import *
from .list_notebook_workspace_connection_info import *
from .mongo_db_resource_mongo_db_collection import *
from .mongo_db_resource_mongo_db_database import *
from .mongo_db_resource_mongo_role_definition import *
from .mongo_db_resource_mongo_user_definition import *
from .notebook_workspace import *
from .private_endpoint_connection import *
from .service import *
from .sql_resource_sql_container import *
from .sql_resource_sql_database import *
from .sql_resource_sql_role_assignment import *
from .sql_resource_sql_role_definition import *
from .sql_resource_sql_stored_procedure import *
from .sql_resource_sql_trigger import *
from .sql_resource_sql_user_defined_function import *
from .table_resource_table import *
from ._inputs import *
from . import outputs

# Make subpackages available:
if typing.TYPE_CHECKING:
    import pulumi_azure_native.documentdb.v20150401 as __v20150401
    v20150401 = __v20150401
    import pulumi_azure_native.documentdb.v20150408 as __v20150408
    v20150408 = __v20150408
    import pulumi_azure_native.documentdb.v20151106 as __v20151106
    v20151106 = __v20151106
    import pulumi_azure_native.documentdb.v20160319 as __v20160319
    v20160319 = __v20160319
    import pulumi_azure_native.documentdb.v20160331 as __v20160331
    v20160331 = __v20160331
    import pulumi_azure_native.documentdb.v20190801 as __v20190801
    v20190801 = __v20190801
    import pulumi_azure_native.documentdb.v20190801preview as __v20190801preview
    v20190801preview = __v20190801preview
    import pulumi_azure_native.documentdb.v20191212 as __v20191212
    v20191212 = __v20191212
    import pulumi_azure_native.documentdb.v20200301 as __v20200301
    v20200301 = __v20200301
    import pulumi_azure_native.documentdb.v20200401 as __v20200401
    v20200401 = __v20200401
    import pulumi_azure_native.documentdb.v20200601preview as __v20200601preview
    v20200601preview = __v20200601preview
    import pulumi_azure_native.documentdb.v20200901 as __v20200901
    v20200901 = __v20200901
    import pulumi_azure_native.documentdb.v20210115 as __v20210115
    v20210115 = __v20210115
    import pulumi_azure_native.documentdb.v20210301preview as __v20210301preview
    v20210301preview = __v20210301preview
    import pulumi_azure_native.documentdb.v20210315 as __v20210315
    v20210315 = __v20210315
    import pulumi_azure_native.documentdb.v20210401preview as __v20210401preview
    v20210401preview = __v20210401preview
    import pulumi_azure_native.documentdb.v20210415 as __v20210415
    v20210415 = __v20210415
    import pulumi_azure_native.documentdb.v20210515 as __v20210515
    v20210515 = __v20210515
    import pulumi_azure_native.documentdb.v20210615 as __v20210615
    v20210615 = __v20210615
    import pulumi_azure_native.documentdb.v20210701preview as __v20210701preview
    v20210701preview = __v20210701preview
    import pulumi_azure_native.documentdb.v20211015 as __v20211015
    v20211015 = __v20211015
    import pulumi_azure_native.documentdb.v20211015preview as __v20211015preview
    v20211015preview = __v20211015preview
    import pulumi_azure_native.documentdb.v20211115preview as __v20211115preview
    v20211115preview = __v20211115preview
    import pulumi_azure_native.documentdb.v20220215preview as __v20220215preview
    v20220215preview = __v20220215preview
    import pulumi_azure_native.documentdb.v20220515 as __v20220515
    v20220515 = __v20220515
    import pulumi_azure_native.documentdb.v20220515preview as __v20220515preview
    v20220515preview = __v20220515preview
else:
    v20150401 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20150401')
    v20150408 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20150408')
    v20151106 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20151106')
    v20160319 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20160319')
    v20160331 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20160331')
    v20190801 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20190801')
    v20190801preview = _utilities.lazy_import('pulumi_azure_native.documentdb.v20190801preview')
    v20191212 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20191212')
    v20200301 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20200301')
    v20200401 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20200401')
    v20200601preview = _utilities.lazy_import('pulumi_azure_native.documentdb.v20200601preview')
    v20200901 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20200901')
    v20210115 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20210115')
    v20210301preview = _utilities.lazy_import('pulumi_azure_native.documentdb.v20210301preview')
    v20210315 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20210315')
    v20210401preview = _utilities.lazy_import('pulumi_azure_native.documentdb.v20210401preview')
    v20210415 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20210415')
    v20210515 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20210515')
    v20210615 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20210615')
    v20210701preview = _utilities.lazy_import('pulumi_azure_native.documentdb.v20210701preview')
    v20211015 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20211015')
    v20211015preview = _utilities.lazy_import('pulumi_azure_native.documentdb.v20211015preview')
    v20211115preview = _utilities.lazy_import('pulumi_azure_native.documentdb.v20211115preview')
    v20220215preview = _utilities.lazy_import('pulumi_azure_native.documentdb.v20220215preview')
    v20220515 = _utilities.lazy_import('pulumi_azure_native.documentdb.v20220515')
    v20220515preview = _utilities.lazy_import('pulumi_azure_native.documentdb.v20220515preview')

