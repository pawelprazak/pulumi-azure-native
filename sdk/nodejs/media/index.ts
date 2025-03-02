// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

// Export members:
export * from "./accountFilter";
export * from "./asset";
export * from "./assetFilter";
export * from "./contentKeyPolicy";
export * from "./getAccountFilter";
export * from "./getAsset";
export * from "./getAssetEncryptionKey";
export * from "./getAssetFilter";
export * from "./getContentKeyPolicy";
export * from "./getContentKeyPolicyPropertiesWithSecrets";
export * from "./getJob";
export * from "./getLiveEvent";
export * from "./getLiveOutput";
export * from "./getMediaGraph";
export * from "./getMediaService";
export * from "./getPrivateEndpointConnection";
export * from "./getStreamingEndpoint";
export * from "./getStreamingLocator";
export * from "./getStreamingPolicy";
export * from "./getTrack";
export * from "./getTransform";
export * from "./job";
export * from "./listAssetContainerSas";
export * from "./listAssetStreamingLocators";
export * from "./listMediaServiceEdgePolicies";
export * from "./listMediaServiceKeys";
export * from "./listStreamingLocatorContentKeys";
export * from "./listStreamingLocatorPaths";
export * from "./liveEvent";
export * from "./liveOutput";
export * from "./mediaGraph";
export * from "./mediaService";
export * from "./privateEndpointConnection";
export * from "./streamingEndpoint";
export * from "./streamingLocator";
export * from "./streamingPolicy";
export * from "./track";
export * from "./transform";

// Export enums:
export * from "../types/enums/media";

// Export sub-modules:
import * as v20151001 from "./v20151001";
import * as v20180330preview from "./v20180330preview";
import * as v20180601preview from "./v20180601preview";
import * as v20180701 from "./v20180701";
import * as v20190501preview from "./v20190501preview";
import * as v20190901preview from "./v20190901preview";
import * as v20200201preview from "./v20200201preview";
import * as v20200501 from "./v20200501";
import * as v20210501 from "./v20210501";
import * as v20210601 from "./v20210601";
import * as v20211101 from "./v20211101";

export {
    v20151001,
    v20180330preview,
    v20180601preview,
    v20180701,
    v20190501preview,
    v20190901preview,
    v20200201preview,
    v20200501,
    v20210501,
    v20210601,
    v20211101,
};

// Import resources to register:
import { AccountFilter } from "./accountFilter";
import { Asset } from "./asset";
import { AssetFilter } from "./assetFilter";
import { ContentKeyPolicy } from "./contentKeyPolicy";
import { Job } from "./job";
import { LiveEvent } from "./liveEvent";
import { LiveOutput } from "./liveOutput";
import { MediaGraph } from "./mediaGraph";
import { MediaService } from "./mediaService";
import { PrivateEndpointConnection } from "./privateEndpointConnection";
import { StreamingEndpoint } from "./streamingEndpoint";
import { StreamingLocator } from "./streamingLocator";
import { StreamingPolicy } from "./streamingPolicy";
import { Track } from "./track";
import { Transform } from "./transform";

const _module = {
    version: utilities.getVersion(),
    construct: (name: string, type: string, urn: string): pulumi.Resource => {
        switch (type) {
            case "azure-native:media:AccountFilter":
                return new AccountFilter(name, <any>undefined, { urn })
            case "azure-native:media:Asset":
                return new Asset(name, <any>undefined, { urn })
            case "azure-native:media:AssetFilter":
                return new AssetFilter(name, <any>undefined, { urn })
            case "azure-native:media:ContentKeyPolicy":
                return new ContentKeyPolicy(name, <any>undefined, { urn })
            case "azure-native:media:Job":
                return new Job(name, <any>undefined, { urn })
            case "azure-native:media:LiveEvent":
                return new LiveEvent(name, <any>undefined, { urn })
            case "azure-native:media:LiveOutput":
                return new LiveOutput(name, <any>undefined, { urn })
            case "azure-native:media:MediaGraph":
                return new MediaGraph(name, <any>undefined, { urn })
            case "azure-native:media:MediaService":
                return new MediaService(name, <any>undefined, { urn })
            case "azure-native:media:PrivateEndpointConnection":
                return new PrivateEndpointConnection(name, <any>undefined, { urn })
            case "azure-native:media:StreamingEndpoint":
                return new StreamingEndpoint(name, <any>undefined, { urn })
            case "azure-native:media:StreamingLocator":
                return new StreamingLocator(name, <any>undefined, { urn })
            case "azure-native:media:StreamingPolicy":
                return new StreamingPolicy(name, <any>undefined, { urn })
            case "azure-native:media:Track":
                return new Track(name, <any>undefined, { urn })
            case "azure-native:media:Transform":
                return new Transform(name, <any>undefined, { urn })
            default:
                throw new Error(`unknown resource type ${type}`);
        }
    },
};
pulumi.runtime.registerResourceModule("azure-native", "media", _module)
