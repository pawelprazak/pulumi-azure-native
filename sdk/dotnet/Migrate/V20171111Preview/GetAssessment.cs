// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.AzureNative.Migrate.V20171111Preview
{
    [Obsolete(@"Version 2017-11-11-preview will be removed in v2 of the provider.")]
    public static class GetAssessment
    {
        /// <summary>
        /// An assessment created for a group in the Migration project.
        /// </summary>
        public static Task<GetAssessmentResult> InvokeAsync(GetAssessmentArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAssessmentResult>("azure-native:migrate/v20171111preview:getAssessment", args ?? new GetAssessmentArgs(), options.WithDefaults());

        /// <summary>
        /// An assessment created for a group in the Migration project.
        /// </summary>
        public static Output<GetAssessmentResult> Invoke(GetAssessmentInvokeArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.Invoke<GetAssessmentResult>("azure-native:migrate/v20171111preview:getAssessment", args ?? new GetAssessmentInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAssessmentArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique name of an assessment within a project.
        /// </summary>
        [Input("assessmentName", required: true)]
        public string AssessmentName { get; set; } = null!;

        /// <summary>
        /// Unique name of a group within a project.
        /// </summary>
        [Input("groupName", required: true)]
        public string GroupName { get; set; } = null!;

        /// <summary>
        /// Name of the Azure Migrate project.
        /// </summary>
        [Input("projectName", required: true)]
        public string ProjectName { get; set; } = null!;

        /// <summary>
        /// Name of the Azure Resource Group that project is part of.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetAssessmentArgs()
        {
        }
    }

    public sealed class GetAssessmentInvokeArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Unique name of an assessment within a project.
        /// </summary>
        [Input("assessmentName", required: true)]
        public Input<string> AssessmentName { get; set; } = null!;

        /// <summary>
        /// Unique name of a group within a project.
        /// </summary>
        [Input("groupName", required: true)]
        public Input<string> GroupName { get; set; } = null!;

        /// <summary>
        /// Name of the Azure Migrate project.
        /// </summary>
        [Input("projectName", required: true)]
        public Input<string> ProjectName { get; set; } = null!;

        /// <summary>
        /// Name of the Azure Resource Group that project is part of.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetAssessmentInvokeArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetAssessmentResult
    {
        /// <summary>
        /// AHUB discount on windows virtual machines.
        /// </summary>
        public readonly string AzureHybridUseBenefit;
        /// <summary>
        /// Target Azure location for which the machines should be assessed. These enums are the same as used by Compute API.
        /// </summary>
        public readonly string AzureLocation;
        /// <summary>
        /// Offer code according to which cost estimation is done.
        /// </summary>
        public readonly string AzureOfferCode;
        /// <summary>
        /// Pricing tier for Size evaluation.
        /// </summary>
        public readonly string AzurePricingTier;
        /// <summary>
        /// Storage Redundancy type offered by Azure.
        /// </summary>
        public readonly string AzureStorageRedundancy;
        /// <summary>
        /// Time when this project was created. Date-Time represented in ISO-8601 format.
        /// </summary>
        public readonly string CreatedTimestamp;
        /// <summary>
        /// Currency to report prices in.
        /// </summary>
        public readonly string Currency;
        /// <summary>
        /// Custom discount percentage to be applied on final costs. Can be in the range [0, 100].
        /// </summary>
        public readonly double DiscountPercentage;
        /// <summary>
        /// For optimistic concurrency control.
        /// </summary>
        public readonly string? ETag;
        /// <summary>
        /// Path reference to this assessment. /subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.Migrate/projects/{projectName}/groups/{groupName}/assessment/{assessmentName}
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Monthly network cost estimate for the machines that are part of this assessment as a group, for a 31-day month.
        /// </summary>
        public readonly double MonthlyBandwidthCost;
        /// <summary>
        /// Monthly compute cost estimate for the machines that are part of this assessment as a group, for a 31-day month.
        /// </summary>
        public readonly double MonthlyComputeCost;
        /// <summary>
        /// Monthly storage cost estimate for the machines that are part of this assessment as a group, for a 31-day month.
        /// </summary>
        public readonly double MonthlyStorageCost;
        /// <summary>
        /// Unique name of an assessment.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Number of assessed machines part of this assessment.
        /// </summary>
        public readonly int NumberOfMachines;
        /// <summary>
        /// Percentile of performance data used to recommend Azure size.
        /// </summary>
        public readonly string Percentile;
        /// <summary>
        /// Time when the Azure Prices were queried. Date-Time represented in ISO-8601 format.
        /// </summary>
        public readonly string PricesTimestamp;
        /// <summary>
        /// Scaling factor used over utilization data to add a performance buffer for new machines to be created in Azure. Min Value = 1.0, Max value = 1.9, Default = 1.3.
        /// </summary>
        public readonly double ScalingFactor;
        /// <summary>
        /// User configurable setting that describes the status of the assessment.
        /// </summary>
        public readonly string Stage;
        /// <summary>
        /// Whether the assessment has been created and is valid.
        /// </summary>
        public readonly string Status;
        /// <summary>
        /// Time range of performance data used to recommend a size.
        /// </summary>
        public readonly string TimeRange;
        /// <summary>
        /// Type of the object = [Microsoft.Migrate/projects/groups/assessments].
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// Time when this project was last updated. Date-Time represented in ISO-8601 format.
        /// </summary>
        public readonly string UpdatedTimestamp;

        [OutputConstructor]
        private GetAssessmentResult(
            string azureHybridUseBenefit,

            string azureLocation,

            string azureOfferCode,

            string azurePricingTier,

            string azureStorageRedundancy,

            string createdTimestamp,

            string currency,

            double discountPercentage,

            string? eTag,

            string id,

            double monthlyBandwidthCost,

            double monthlyComputeCost,

            double monthlyStorageCost,

            string name,

            int numberOfMachines,

            string percentile,

            string pricesTimestamp,

            double scalingFactor,

            string stage,

            string status,

            string timeRange,

            string type,

            string updatedTimestamp)
        {
            AzureHybridUseBenefit = azureHybridUseBenefit;
            AzureLocation = azureLocation;
            AzureOfferCode = azureOfferCode;
            AzurePricingTier = azurePricingTier;
            AzureStorageRedundancy = azureStorageRedundancy;
            CreatedTimestamp = createdTimestamp;
            Currency = currency;
            DiscountPercentage = discountPercentage;
            ETag = eTag;
            Id = id;
            MonthlyBandwidthCost = monthlyBandwidthCost;
            MonthlyComputeCost = monthlyComputeCost;
            MonthlyStorageCost = monthlyStorageCost;
            Name = name;
            NumberOfMachines = numberOfMachines;
            Percentile = percentile;
            PricesTimestamp = pricesTimestamp;
            ScalingFactor = scalingFactor;
            Stage = stage;
            Status = status;
            TimeRange = timeRange;
            Type = type;
            UpdatedTimestamp = updatedTimestamp;
        }
    }
}
