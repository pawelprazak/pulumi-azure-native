# Contributing to the Azure native provider

## Building

### Dependencies

- Go 1.15
- NodeJS 10.X.X or later
- Python 3.6 or later
- .NET Core 3.1

Please refer to [Contributing to Pulumi](https://github.com/pulumi/pulumi/blob/master/CONTRIBUTING.md) for installation
guidance.

### Building locally

Run the following commands to install Go modules, generate all SDKs, and build the provider:

```bash
make ensure
make build
```

Add the `bin` folder to your `$PATH` or copy the `bin/pulumi-resource-azurerm` file to another location in your `$PATH`.

### Running a nodejs example

Navigate to one of the `examples` and run Pulumi:

```bash
cd ./examples/simple
yarn link @pulumi/azure-native
pulumi up
```

## Azure Versions

Key facts about Azure Versions:

- Azure's REST API has many versions of each service which are published per-service on their own schedule.
- Service versions are in the form of an ISO date (e.g. `2020-01-01`) followed by an optional suffix (e.g. `-preview` or `-privatepreview`).
- Not all versions of the service contain all resources. Some services will only publish the parts of their API which have changed since the previous version.
- Some services haven't had a stable (non-suffixed) release for a number of years - and the 'preview' versions are generally considered stable for every-day use.
- New specification versions are sometimes release before the updated service is deployed.

### Terminology

Azure's API specifications are organised into "Resource Providers" (or "Services"), Namespaces and API Versions. We use the term **"API Version"** in this doc to refer to Azure's Resource Provider API Versions.

### Version Sources

1. `spec.json`: the `azure-rest-api-specs` are checked out as a sub-module and include all OpenAPI specifications (for every Resource Provider API Version). The `spec.json` is a simplified report of versions in the spec - each version and the resources within.

   Run `pulumi-versioner-azure-native spec` to generate. This also outputs `spec-resources.json` which is the same information but with versions grouped by resource rather than resources grouped by version.

2. `active.json` lists the 'active' API versions - the versions of each API which are actually deployed into Azure's data centers. It is generated by running `az provider list`, stripping excess information (which is written to `provider_list.json`) then gets summarised into `active.json`.

    Run `pulumi-versioner-azure-native active` to generate from the cached `provider_list.json`

### Default Version Locks

The default version is calculated and written to a 'lock' file which list every resource (or invoke) at a specific API version. This file is read in during the schema and SDK generation. Currently there is a `v1.json` and `v2.json` lock file. These lock files should not be edited directly, but should be calculated by the versioner tool using a specific algorithm.

### Additional Reports

- `deprecated.json` is a list of API versions which are older than the versions included in the default version **and** at least 2 years old. These will be removed in the next major version of the provider.

    This is generated by running `pulumi-versioner-azure-native deprecated --version v[x].json`

- `pending.json` is a list of new API versions which aren't yet included in the default version. These should be included in the default version at the next major release of the provider.

    This is generated by running `pulumi-versioner-azure-native pending --version v[x].json`

### Default Versions

To provide simpler discovery and usability, the Pulumi Azure Native provider adds a single 'default' version for each API which is the combination of one or more API versions. The aim is to include all resources, at the latest available version, where possible.

#### Provider v1

In version 1 of the provider, the default version was recalculated every time a new API version was released. This led to frequent breaking changes which had to be fixed before release of an update.

#### Provider v2

In version 2 of the provider we aim to specify more precisely the versions to combine into the 'default version' to avoid SDK instability. This is specified in the [`v2-config.yaml`](./v2-config.yaml). For each API the config can specify a `Tracking` version and `Additions`.

- `Tracking` specifies a single version of the API to fetch all resources from.
- `Additions` specified a map of specific resource (or invoke) name to API version to include in the default version.

Both `Tracking` and `Additions` can be specified together but if the set of resources overlaps (the same resource exists) in both the tracking version and the additions, then the versioning program will fail with an error.

#### Next default version config

Generated by running `pulumi-versioner-azure-native vnext-config` then edited by hand.

Overview of the process:

1. Read full spec
2. Remove currently deprecated APIs (as these will be remove next version)
3. Find candidate versions - prefer stable versions if we have recent stable versions (i.e. within 1 year of a preview)
4. Find minimal set of API versions which can provide all resources
5. Pick latest version for each resource

### Versioner Tool

The versioner tool has been added to break apart the process of reporting and computing default version into smaller steps.

### Type Compatibility

Supporting every version of every API causes the SDK size to be very large. One method we've used to reduce the required size is to only have a single set of types for each API which are re-used across all versions. However, not all the types are compatible and therefore a type with the same name might be incompatible in the next version. This incompatibility is currently detected but ignored on a case-by-case basis for now.

Ideally, at the point a new incompatible version of the type is added, it should then be created with a unique, stable name. Alternatively, we could create a union of the two possible types
