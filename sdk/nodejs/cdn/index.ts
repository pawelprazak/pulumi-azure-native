// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./afdcustomDomain";
export * from "./afdendpoint";
export * from "./afdorigin";
export * from "./afdoriginGroup";
export * from "./customDomain";
export * from "./endpoint";
export * from "./getAFDCustomDomain";
export * from "./getAFDEndpoint";
export * from "./getAFDOrigin";
export * from "./getAFDOriginGroup";
export * from "./getCustomDomain";
export * from "./getEndpoint";
export * from "./getOrigin";
export * from "./getOriginGroup";
export * from "./getPolicy";
export * from "./getProfile";
export * from "./getProfileSupportedOptimizationTypes";
export * from "./getRoute";
export * from "./getRule";
export * from "./getRuleSet";
export * from "./getSecret";
export * from "./getSecurityPolicy";
export * from "./origin";
export * from "./originGroup";
export * from "./policy";
export * from "./profile";
export * from "./route";
export * from "./rule";
export * from "./ruleSet";
export * from "./secret";
export * from "./securityPolicy";

// Export enums:
export * from "../types/enums/cdn";

// Export sub-modules:
import * as v20150601 from "./v20150601";
import * as v20160402 from "./v20160402";
import * as v20161002 from "./v20161002";
import * as v20170402 from "./v20170402";
import * as v20171012 from "./v20171012";
import * as v20190415 from "./v20190415";
import * as v20190615 from "./v20190615";
import * as v20190615preview from "./v20190615preview";
import * as v20191231 from "./v20191231";
import * as v20200331 from "./v20200331";
import * as v20200415 from "./v20200415";
import * as v20200901 from "./v20200901";
import * as v20210601 from "./v20210601";

export {
    v20150601,
    v20160402,
    v20161002,
    v20170402,
    v20171012,
    v20190415,
    v20190615,
    v20190615preview,
    v20191231,
    v20200331,
    v20200415,
    v20200901,
    v20210601,
};

// Import resources to register:
import { AFDCustomDomain } from "./afdcustomDomain";
import { AFDEndpoint } from "./afdendpoint";
import { AFDOrigin } from "./afdorigin";
import { AFDOriginGroup } from "./afdoriginGroup";
import { CustomDomain } from "./customDomain";
import { Endpoint } from "./endpoint";
import { Origin } from "./origin";
import { OriginGroup } from "./originGroup";
import { Policy } from "./policy";
import { Profile } from "./profile";
import { Route } from "./route";
import { Rule } from "./rule";
import { RuleSet } from "./ruleSet";
import { Secret } from "./secret";
import { SecurityPolicy } from "./securityPolicy";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:cdn:AFDCustomDomain":
                return new AFDCustomDomain(name, <any>undefined, { urn })
            case "azure-native:cdn:AFDEndpoint":
                return new AFDEndpoint(name, <any>undefined, { urn })
            case "azure-native:cdn:AFDOrigin":
                return new AFDOrigin(name, <any>undefined, { urn })
            case "azure-native:cdn:AFDOriginGroup":
                return new AFDOriginGroup(name, <any>undefined, { urn })
            case "azure-native:cdn:CustomDomain":
                return new CustomDomain(name, <any>undefined, { urn })
            case "azure-native:cdn:Endpoint":
                return new Endpoint(name, <any>undefined, { urn })
            case "azure-native:cdn:Origin":
                return new Origin(name, <any>undefined, { urn })
            case "azure-native:cdn:OriginGroup":
                return new OriginGroup(name, <any>undefined, { urn })
            case "azure-native:cdn:Policy":
                return new Policy(name, <any>undefined, { urn })
            case "azure-native:cdn:Profile":
                return new Profile(name, <any>undefined, { urn })
            case "azure-native:cdn:Route":
                return new Route(name, <any>undefined, { urn })
            case "azure-native:cdn:Rule":
                return new Rule(name, <any>undefined, { urn })
            case "azure-native:cdn:RuleSet":
                return new RuleSet(name, <any>undefined, { urn })
            case "azure-native:cdn:Secret":
                return new Secret(name, <any>undefined, { urn })
            case "azure-native:cdn:SecurityPolicy":
                return new SecurityPolicy(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "cdn", _module)
