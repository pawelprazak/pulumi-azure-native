// Code generated by the Pulumi SDK Generator DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package v20210401

import (
	"context"
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
)

// Describes a Virtual Machine run command.
type VirtualMachineRunCommandByVirtualMachine struct {
	pulumi.CustomResourceState

	// Optional. If set to true, provisioning will complete as soon as the script starts and will not wait for script to complete.
	AsyncExecution pulumi.BoolPtrOutput `pulumi:"asyncExecution"`
	// Specifies the Azure storage blob where script error stream will be uploaded.
	ErrorBlobUri pulumi.StringPtrOutput `pulumi:"errorBlobUri"`
	// The virtual machine run command instance view.
	InstanceView VirtualMachineRunCommandInstanceViewResponseOutput `pulumi:"instanceView"`
	// Resource location
	Location pulumi.StringOutput `pulumi:"location"`
	// Resource name
	Name pulumi.StringOutput `pulumi:"name"`
	// Specifies the Azure storage blob where script output stream will be uploaded.
	OutputBlobUri pulumi.StringPtrOutput `pulumi:"outputBlobUri"`
	// The parameters used by the script.
	Parameters RunCommandInputParameterResponseArrayOutput `pulumi:"parameters"`
	// The parameters used by the script.
	ProtectedParameters RunCommandInputParameterResponseArrayOutput `pulumi:"protectedParameters"`
	// The provisioning state, which only appears in the response.
	ProvisioningState pulumi.StringOutput `pulumi:"provisioningState"`
	// Specifies the user account password on the VM when executing the run command.
	RunAsPassword pulumi.StringPtrOutput `pulumi:"runAsPassword"`
	// Specifies the user account on the VM when executing the run command.
	RunAsUser pulumi.StringPtrOutput `pulumi:"runAsUser"`
	// The source of the run command script.
	Source VirtualMachineRunCommandScriptSourceResponsePtrOutput `pulumi:"source"`
	// Resource tags
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// The timeout in seconds to execute the run command.
	TimeoutInSeconds pulumi.IntPtrOutput `pulumi:"timeoutInSeconds"`
	// Resource type
	Type pulumi.StringOutput `pulumi:"type"`
}

// NewVirtualMachineRunCommandByVirtualMachine registers a new resource with the given unique name, arguments, and options.
func NewVirtualMachineRunCommandByVirtualMachine(ctx *pulumi.Context,
	name string, args *VirtualMachineRunCommandByVirtualMachineArgs, opts ...pulumi.ResourceOption) (*VirtualMachineRunCommandByVirtualMachine, error) {
	if args == nil {
		return nil, errors.New("missing one or more required arguments")
	}

	if args.ResourceGroupName == nil {
		return nil, errors.New("invalid value for required argument 'ResourceGroupName'")
	}
	if args.VmName == nil {
		return nil, errors.New("invalid value for required argument 'VmName'")
	}
	if isZero(args.AsyncExecution) {
		args.AsyncExecution = pulumi.BoolPtr(false)
	}
	aliases := pulumi.Aliases([]pulumi.Alias{
		{
			Type: pulumi.String("azure-native:compute:VirtualMachineRunCommandByVirtualMachine"),
		},
		{
			Type: pulumi.String("azure-native:compute/v20200601:VirtualMachineRunCommandByVirtualMachine"),
		},
		{
			Type: pulumi.String("azure-native:compute/v20201201:VirtualMachineRunCommandByVirtualMachine"),
		},
		{
			Type: pulumi.String("azure-native:compute/v20210301:VirtualMachineRunCommandByVirtualMachine"),
		},
		{
			Type: pulumi.String("azure-native:compute/v20210701:VirtualMachineRunCommandByVirtualMachine"),
		},
		{
			Type: pulumi.String("azure-native:compute/v20211101:VirtualMachineRunCommandByVirtualMachine"),
		},
	})
	opts = append(opts, aliases)
	var resource VirtualMachineRunCommandByVirtualMachine
	err := ctx.RegisterResource("azure-native:compute/v20210401:VirtualMachineRunCommandByVirtualMachine", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetVirtualMachineRunCommandByVirtualMachine gets an existing VirtualMachineRunCommandByVirtualMachine resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetVirtualMachineRunCommandByVirtualMachine(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *VirtualMachineRunCommandByVirtualMachineState, opts ...pulumi.ResourceOption) (*VirtualMachineRunCommandByVirtualMachine, error) {
	var resource VirtualMachineRunCommandByVirtualMachine
	err := ctx.ReadResource("azure-native:compute/v20210401:VirtualMachineRunCommandByVirtualMachine", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering VirtualMachineRunCommandByVirtualMachine resources.
type virtualMachineRunCommandByVirtualMachineState struct {
}

type VirtualMachineRunCommandByVirtualMachineState struct {
}

func (VirtualMachineRunCommandByVirtualMachineState) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualMachineRunCommandByVirtualMachineState)(nil)).Elem()
}

type virtualMachineRunCommandByVirtualMachineArgs struct {
	// Optional. If set to true, provisioning will complete as soon as the script starts and will not wait for script to complete.
	AsyncExecution *bool `pulumi:"asyncExecution"`
	// Specifies the Azure storage blob where script error stream will be uploaded.
	ErrorBlobUri *string `pulumi:"errorBlobUri"`
	// Resource location
	Location *string `pulumi:"location"`
	// Specifies the Azure storage blob where script output stream will be uploaded.
	OutputBlobUri *string `pulumi:"outputBlobUri"`
	// The parameters used by the script.
	Parameters []RunCommandInputParameter `pulumi:"parameters"`
	// The parameters used by the script.
	ProtectedParameters []RunCommandInputParameter `pulumi:"protectedParameters"`
	// The name of the resource group.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// Specifies the user account password on the VM when executing the run command.
	RunAsPassword *string `pulumi:"runAsPassword"`
	// Specifies the user account on the VM when executing the run command.
	RunAsUser *string `pulumi:"runAsUser"`
	// The name of the virtual machine run command.
	RunCommandName *string `pulumi:"runCommandName"`
	// The source of the run command script.
	Source *VirtualMachineRunCommandScriptSource `pulumi:"source"`
	// Resource tags
	Tags map[string]string `pulumi:"tags"`
	// The timeout in seconds to execute the run command.
	TimeoutInSeconds *int `pulumi:"timeoutInSeconds"`
	// The name of the virtual machine where the run command should be created or updated.
	VmName string `pulumi:"vmName"`
}

// The set of arguments for constructing a VirtualMachineRunCommandByVirtualMachine resource.
type VirtualMachineRunCommandByVirtualMachineArgs struct {
	// Optional. If set to true, provisioning will complete as soon as the script starts and will not wait for script to complete.
	AsyncExecution pulumi.BoolPtrInput
	// Specifies the Azure storage blob where script error stream will be uploaded.
	ErrorBlobUri pulumi.StringPtrInput
	// Resource location
	Location pulumi.StringPtrInput
	// Specifies the Azure storage blob where script output stream will be uploaded.
	OutputBlobUri pulumi.StringPtrInput
	// The parameters used by the script.
	Parameters RunCommandInputParameterArrayInput
	// The parameters used by the script.
	ProtectedParameters RunCommandInputParameterArrayInput
	// The name of the resource group.
	ResourceGroupName pulumi.StringInput
	// Specifies the user account password on the VM when executing the run command.
	RunAsPassword pulumi.StringPtrInput
	// Specifies the user account on the VM when executing the run command.
	RunAsUser pulumi.StringPtrInput
	// The name of the virtual machine run command.
	RunCommandName pulumi.StringPtrInput
	// The source of the run command script.
	Source VirtualMachineRunCommandScriptSourcePtrInput
	// Resource tags
	Tags pulumi.StringMapInput
	// The timeout in seconds to execute the run command.
	TimeoutInSeconds pulumi.IntPtrInput
	// The name of the virtual machine where the run command should be created or updated.
	VmName pulumi.StringInput
}

func (VirtualMachineRunCommandByVirtualMachineArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*virtualMachineRunCommandByVirtualMachineArgs)(nil)).Elem()
}

type VirtualMachineRunCommandByVirtualMachineInput interface {
	pulumi.Input

	ToVirtualMachineRunCommandByVirtualMachineOutput() VirtualMachineRunCommandByVirtualMachineOutput
	ToVirtualMachineRunCommandByVirtualMachineOutputWithContext(ctx context.Context) VirtualMachineRunCommandByVirtualMachineOutput
}

func (*VirtualMachineRunCommandByVirtualMachine) ElementType() reflect.Type {
	return reflect.TypeOf((**VirtualMachineRunCommandByVirtualMachine)(nil)).Elem()
}

func (i *VirtualMachineRunCommandByVirtualMachine) ToVirtualMachineRunCommandByVirtualMachineOutput() VirtualMachineRunCommandByVirtualMachineOutput {
	return i.ToVirtualMachineRunCommandByVirtualMachineOutputWithContext(context.Background())
}

func (i *VirtualMachineRunCommandByVirtualMachine) ToVirtualMachineRunCommandByVirtualMachineOutputWithContext(ctx context.Context) VirtualMachineRunCommandByVirtualMachineOutput {
	return pulumi.ToOutputWithContext(ctx, i).(VirtualMachineRunCommandByVirtualMachineOutput)
}

type VirtualMachineRunCommandByVirtualMachineOutput struct{ *pulumi.OutputState }

func (VirtualMachineRunCommandByVirtualMachineOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**VirtualMachineRunCommandByVirtualMachine)(nil)).Elem()
}

func (o VirtualMachineRunCommandByVirtualMachineOutput) ToVirtualMachineRunCommandByVirtualMachineOutput() VirtualMachineRunCommandByVirtualMachineOutput {
	return o
}

func (o VirtualMachineRunCommandByVirtualMachineOutput) ToVirtualMachineRunCommandByVirtualMachineOutputWithContext(ctx context.Context) VirtualMachineRunCommandByVirtualMachineOutput {
	return o
}

// Optional. If set to true, provisioning will complete as soon as the script starts and will not wait for script to complete.
func (o VirtualMachineRunCommandByVirtualMachineOutput) AsyncExecution() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *VirtualMachineRunCommandByVirtualMachine) pulumi.BoolPtrOutput { return v.AsyncExecution }).(pulumi.BoolPtrOutput)
}

// Specifies the Azure storage blob where script error stream will be uploaded.
func (o VirtualMachineRunCommandByVirtualMachineOutput) ErrorBlobUri() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *VirtualMachineRunCommandByVirtualMachine) pulumi.StringPtrOutput { return v.ErrorBlobUri }).(pulumi.StringPtrOutput)
}

// The virtual machine run command instance view.
func (o VirtualMachineRunCommandByVirtualMachineOutput) InstanceView() VirtualMachineRunCommandInstanceViewResponseOutput {
	return o.ApplyT(func(v *VirtualMachineRunCommandByVirtualMachine) VirtualMachineRunCommandInstanceViewResponseOutput {
		return v.InstanceView
	}).(VirtualMachineRunCommandInstanceViewResponseOutput)
}

// Resource location
func (o VirtualMachineRunCommandByVirtualMachineOutput) Location() pulumi.StringOutput {
	return o.ApplyT(func(v *VirtualMachineRunCommandByVirtualMachine) pulumi.StringOutput { return v.Location }).(pulumi.StringOutput)
}

// Resource name
func (o VirtualMachineRunCommandByVirtualMachineOutput) Name() pulumi.StringOutput {
	return o.ApplyT(func(v *VirtualMachineRunCommandByVirtualMachine) pulumi.StringOutput { return v.Name }).(pulumi.StringOutput)
}

// Specifies the Azure storage blob where script output stream will be uploaded.
func (o VirtualMachineRunCommandByVirtualMachineOutput) OutputBlobUri() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *VirtualMachineRunCommandByVirtualMachine) pulumi.StringPtrOutput { return v.OutputBlobUri }).(pulumi.StringPtrOutput)
}

// The parameters used by the script.
func (o VirtualMachineRunCommandByVirtualMachineOutput) Parameters() RunCommandInputParameterResponseArrayOutput {
	return o.ApplyT(func(v *VirtualMachineRunCommandByVirtualMachine) RunCommandInputParameterResponseArrayOutput {
		return v.Parameters
	}).(RunCommandInputParameterResponseArrayOutput)
}

// The parameters used by the script.
func (o VirtualMachineRunCommandByVirtualMachineOutput) ProtectedParameters() RunCommandInputParameterResponseArrayOutput {
	return o.ApplyT(func(v *VirtualMachineRunCommandByVirtualMachine) RunCommandInputParameterResponseArrayOutput {
		return v.ProtectedParameters
	}).(RunCommandInputParameterResponseArrayOutput)
}

// The provisioning state, which only appears in the response.
func (o VirtualMachineRunCommandByVirtualMachineOutput) ProvisioningState() pulumi.StringOutput {
	return o.ApplyT(func(v *VirtualMachineRunCommandByVirtualMachine) pulumi.StringOutput { return v.ProvisioningState }).(pulumi.StringOutput)
}

// Specifies the user account password on the VM when executing the run command.
func (o VirtualMachineRunCommandByVirtualMachineOutput) RunAsPassword() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *VirtualMachineRunCommandByVirtualMachine) pulumi.StringPtrOutput { return v.RunAsPassword }).(pulumi.StringPtrOutput)
}

// Specifies the user account on the VM when executing the run command.
func (o VirtualMachineRunCommandByVirtualMachineOutput) RunAsUser() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *VirtualMachineRunCommandByVirtualMachine) pulumi.StringPtrOutput { return v.RunAsUser }).(pulumi.StringPtrOutput)
}

// The source of the run command script.
func (o VirtualMachineRunCommandByVirtualMachineOutput) Source() VirtualMachineRunCommandScriptSourceResponsePtrOutput {
	return o.ApplyT(func(v *VirtualMachineRunCommandByVirtualMachine) VirtualMachineRunCommandScriptSourceResponsePtrOutput {
		return v.Source
	}).(VirtualMachineRunCommandScriptSourceResponsePtrOutput)
}

// Resource tags
func (o VirtualMachineRunCommandByVirtualMachineOutput) Tags() pulumi.StringMapOutput {
	return o.ApplyT(func(v *VirtualMachineRunCommandByVirtualMachine) pulumi.StringMapOutput { return v.Tags }).(pulumi.StringMapOutput)
}

// The timeout in seconds to execute the run command.
func (o VirtualMachineRunCommandByVirtualMachineOutput) TimeoutInSeconds() pulumi.IntPtrOutput {
	return o.ApplyT(func(v *VirtualMachineRunCommandByVirtualMachine) pulumi.IntPtrOutput { return v.TimeoutInSeconds }).(pulumi.IntPtrOutput)
}

// Resource type
func (o VirtualMachineRunCommandByVirtualMachineOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v *VirtualMachineRunCommandByVirtualMachine) pulumi.StringOutput { return v.Type }).(pulumi.StringOutput)
}

func init() {
	pulumi.RegisterOutputType(VirtualMachineRunCommandByVirtualMachineOutput{})
}
