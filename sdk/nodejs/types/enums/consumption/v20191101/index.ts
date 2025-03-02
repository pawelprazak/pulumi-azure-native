// *** WARNING: this file was generated by the Pulumi SDK Generator. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***


export const BudgetOperatorType = {
    In: "In",
} as const;

/**
 * The operator to use for comparison.
 */
export type BudgetOperatorType = (typeof BudgetOperatorType)[keyof typeof BudgetOperatorType];

export const CategoryType = {
    Cost: "Cost",
} as const;

/**
 * The category of the budget, whether the budget tracks cost or usage.
 */
export type CategoryType = (typeof CategoryType)[keyof typeof CategoryType];

export const OperatorType = {
    EqualTo: "EqualTo",
    GreaterThan: "GreaterThan",
    GreaterThanOrEqualTo: "GreaterThanOrEqualTo",
} as const;

/**
 * The comparison operator.
 */
export type OperatorType = (typeof OperatorType)[keyof typeof OperatorType];

export const ThresholdType = {
    Actual: "Actual",
    Forecasted: "Forecasted",
} as const;

/**
 * The type of threshold
 */
export type ThresholdType = (typeof ThresholdType)[keyof typeof ThresholdType];

export const TimeGrainType = {
    Monthly: "Monthly",
    Quarterly: "Quarterly",
    Annually: "Annually",
    BillingMonth: "BillingMonth",
    BillingQuarter: "BillingQuarter",
    BillingAnnual: "BillingAnnual",
} as const;

/**
 * The time covered by a budget. Tracking of the amount will be reset based on the time grain. BillingMonth, BillingQuarter, and BillingAnnual are only supported by WD customers
 */
export type TimeGrainType = (typeof TimeGrainType)[keyof typeof TimeGrainType];
