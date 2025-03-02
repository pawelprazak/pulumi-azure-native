# coding=utf-8
# *** WARNING: this file was generated by the Pulumi SDK Generator. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

from enum import Enum

__all__ = [
    'ApplicationSourceResourceType',
]


class ApplicationSourceResourceType(str, Enum):
    """
    The application source, what it affects, e.g. Assessments
    """
    ASSESSMENTS = "Assessments"
    """
    The source of the application is assessments
    """
