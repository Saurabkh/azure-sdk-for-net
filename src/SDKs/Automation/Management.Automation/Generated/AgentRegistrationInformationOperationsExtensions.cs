// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AgentRegistrationInformationOperations.
    /// </summary>
    public static partial class AgentRegistrationInformationOperationsExtensions
    {
            /// <summary>
            /// Retrieve the automation agent registration information.
            /// <see href="http://aka.ms/azureautomationsdk/agentregistrationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            public static AgentRegistration Get(this IAgentRegistrationInformationOperations operations, string resourceGroupName, string automationAccountName)
            {
                return operations.GetAsync(resourceGroupName, automationAccountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Retrieve the automation agent registration information.
            /// <see href="http://aka.ms/azureautomationsdk/agentregistrationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgentRegistration> GetAsync(this IAgentRegistrationInformationOperations operations, string resourceGroupName, string automationAccountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, automationAccountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Regenerate a primary or secondary agent registration key
            /// <see href="http://aka.ms/azureautomationsdk/agentregistrationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='parameters'>
            /// The name of the agent registration key to be regenerated
            /// </param>
            public static AgentRegistration RegenerateKey(this IAgentRegistrationInformationOperations operations, string resourceGroupName, string automationAccountName, AgentRegistrationRegenerateKeyParameter parameters)
            {
                return operations.RegenerateKeyAsync(resourceGroupName, automationAccountName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Regenerate a primary or secondary agent registration key
            /// <see href="http://aka.ms/azureautomationsdk/agentregistrationoperations" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='automationAccountName'>
            /// The automation account name.
            /// </param>
            /// <param name='parameters'>
            /// The name of the agent registration key to be regenerated
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<AgentRegistration> RegenerateKeyAsync(this IAgentRegistrationInformationOperations operations, string resourceGroupName, string automationAccountName, AgentRegistrationRegenerateKeyParameter parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.RegenerateKeyWithHttpMessagesAsync(resourceGroupName, automationAccountName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
