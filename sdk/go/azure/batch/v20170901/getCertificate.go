// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20170901

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Contains information about a certificate.
//
// Deprecated: Version 2017-09-01 will be removed in v2 of the provider.
func LookupCertificate(ctx *pulumi.Context, args *LookupCertificateArgs, opts ...pulumi.InvokeOption) (*LookupCertificateResult, error) {
	var rv LookupCertificateResult
	err := ctx.Invoke("azure-native:batch/v20170901:getCertificate", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

type LookupCertificateArgs struct {
	// The name of the Batch account.
	AccountName string `pulumi:"accountName"`
	// The identifier for the certificate. This must be made up of algorithm and thumbprint separated by a dash, and must match the certificate data in the request. For example SHA1-a3d1c5.
	CertificateName string `pulumi:"certificateName"`
	// The name of the resource group that contains the Batch account.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// Contains information about a certificate.
type LookupCertificateResult struct {
	// This is only returned when the certificate provisioningState is 'Failed'.
	DeleteCertificateError DeleteCertificateErrorResponse `pulumi:"deleteCertificateError"`
	// The ETag of the resource, used for concurrency statements.
	Etag string `pulumi:"etag"`
	// The format of the certificate - either Pfx or Cer. If omitted, the default is Pfx.
	Format *string `pulumi:"format"`
	// The ID of the resource.
	Id string `pulumi:"id"`
	// The name of the resource.
	Name string `pulumi:"name"`
	// The previous provisioned state of the resource
	PreviousProvisioningState               string `pulumi:"previousProvisioningState"`
	PreviousProvisioningStateTransitionTime string `pulumi:"previousProvisioningStateTransitionTime"`
	// Values are:
	//
	//  Succeeded - The certificate is available for use in pools.
	//  Deleting - The user has requested that the certificate be deleted, but the delete operation has not yet completed. You may not reference the certificate when creating or updating pools.
	//  Failed - The user requested that the certificate be deleted, but there are pools that still have references to the certificate, or it is still installed on one or more compute nodes. (The latter can occur if the certificate has been removed from the pool, but the node has not yet restarted. Nodes refresh their certificates only when they restart.) You may use the cancel certificate delete operation to cancel the delete, or the delete certificate operation to retry the delete.
	ProvisioningState               string `pulumi:"provisioningState"`
	ProvisioningStateTransitionTime string `pulumi:"provisioningStateTransitionTime"`
	// The public key of the certificate.
	PublicData string `pulumi:"publicData"`
	// This must match the thumbprint from the name.
	Thumbprint *string `pulumi:"thumbprint"`
	// This must match the first portion of the certificate name. Currently required to be 'SHA1'.
	ThumbprintAlgorithm *string `pulumi:"thumbprintAlgorithm"`
	// The type of the resource.
	Type string `pulumi:"type"`
}

func LookupCertificateOutput(ctx *pulumi.Context, args LookupCertificateOutputArgs, opts ...pulumi.InvokeOption) LookupCertificateResultOutput {
	return pulumi.ToOutputWithContext(context.Background(), args).
		ApplyT(func(v interface{}) (LookupCertificateResult, error) {
			args := v.(LookupCertificateArgs)
			r, err := LookupCertificate(ctx, &args, opts...)
			var s LookupCertificateResult
			if r != nil {
				s = *r
			}
			return s, err
		}).(LookupCertificateResultOutput)
}

type LookupCertificateOutputArgs struct {
	// The name of the Batch account.
	AccountName pulumi.StringInput `pulumi:"accountName"`
	// The identifier for the certificate. This must be made up of algorithm and thumbprint separated by a dash, and must match the certificate data in the request. For example SHA1-a3d1c5.
	CertificateName pulumi.StringInput `pulumi:"certificateName"`
	// The name of the resource group that contains the Batch account.
	ResourceGroupName pulumi.StringInput `pulumi:"resourceGroupName"`
}

func (LookupCertificateOutputArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupCertificateArgs)(nil)).Elem()
}

// Contains information about a certificate.
type LookupCertificateResultOutput struct{ *pulumi.OutputState }

func (LookupCertificateResultOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*LookupCertificateResult)(nil)).Elem()
}

func (o LookupCertificateResultOutput) ToLookupCertificateResultOutput() LookupCertificateResultOutput {
	return o
}

func (o LookupCertificateResultOutput) ToLookupCertificateResultOutputWithContext(ctx context.Context) LookupCertificateResultOutput {
	return o
}

// This is only returned when the certificate provisioningState is 'Failed'.
func (o LookupCertificateResultOutput) DeleteCertificateError() DeleteCertificateErrorResponseOutput {
	return o.ApplyT(func(v LookupCertificateResult) DeleteCertificateErrorResponse { return v.DeleteCertificateError }).(DeleteCertificateErrorResponseOutput)
}

// The ETag of the resource, used for concurrency statements.
func (o LookupCertificateResultOutput) Etag() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCertificateResult) string { return v.Etag }).(pulumi.StringOutput)
}

// The format of the certificate - either Pfx or Cer. If omitted, the default is Pfx.
func (o LookupCertificateResultOutput) Format() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupCertificateResult) *string { return v.Format }).(pulumi.StringPtrOutput)
}

// The ID of the resource.
func (o LookupCertificateResultOutput) Id() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCertificateResult) string { return v.Id }).(pulumi.StringOutput)
}

// The name of the resource.
func (o LookupCertificateResultOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCertificateResult) string { return v.Name }).(pulumi.StringOutput)
}

// The previous provisioned state of the resource
func (o LookupCertificateResultOutput) PreviousProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCertificateResult) string { return v.PreviousProvisioningState }).(pulumi.StringOutput)
}

func (o LookupCertificateResultOutput) PreviousProvisioningStateTransitionTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCertificateResult) string { return v.PreviousProvisioningStateTransitionTime }).(pulumi.StringOutput)
}

// Values are:
//
//  Succeeded - The certificate is available for use in pools.
//  Deleting - The user has requested that the certificate be deleted, but the delete operation has not yet completed. You may not reference the certificate when creating or updating pools.
//  Failed - The user requested that the certificate be deleted, but there are pools that still have references to the certificate, or it is still installed on one or more compute nodes. (The latter can occur if the certificate has been removed from the pool, but the node has not yet restarted. Nodes refresh their certificates only when they restart.) You may use the cancel certificate delete operation to cancel the delete, or the delete certificate operation to retry the delete.
func (o LookupCertificateResultOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCertificateResult) string { return v.ProvisioningState }).(pulumi.StringOutput)
}

func (o LookupCertificateResultOutput) ProvisioningStateTransitionTime() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCertificateResult) string { return v.ProvisioningStateTransitionTime }).(pulumi.StringOutput)
}

// The public key of the certificate.
func (o LookupCertificateResultOutput) PublicData() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCertificateResult) string { return v.PublicData }).(pulumi.StringOutput)
}

// This must match the thumbprint from the name.
func (o LookupCertificateResultOutput) Thumbprint() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupCertificateResult) *string { return v.Thumbprint }).(pulumi.StringPtrOutput)
}

// This must match the first portion of the certificate name. Currently required to be 'SHA1'.
func (o LookupCertificateResultOutput) ThumbprintAlgorithm() pulumi.StringPtrOutput {
	return o.ApplyT(func(v LookupCertificateResult) *string { return v.ThumbprintAlgorithm }).(pulumi.StringPtrOutput)
}

// The type of the resource.
func (o LookupCertificateResultOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v LookupCertificateResult) string { return v.Type }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(LookupCertificateResultOutput{})
}
