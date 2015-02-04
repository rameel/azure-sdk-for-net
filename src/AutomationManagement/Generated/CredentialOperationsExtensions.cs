// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public static partial class CredentialOperationsExtensions
    {
        /// <summary>
        /// Create a credential.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the create credential
        /// operation.
        /// </param>
        /// <returns>
        /// The response model for the create credential operation.
        /// </returns>
        public static CredentialCreateResponse Create(this ICredentialOperations operations, string automationAccount, CredentialCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICredentialOperations)s).CreateAsync(automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a credential.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the create credential
        /// operation.
        /// </param>
        /// <returns>
        /// The response model for the create credential operation.
        /// </returns>
        public static Task<CredentialCreateResponse> CreateAsync(this ICredentialOperations operations, string automationAccount, CredentialCreateParameters parameters)
        {
            return operations.CreateAsync(automationAccount, parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Delete the credential.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='credentialName'>
        /// Required. The name of credential.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Delete(this ICredentialOperations operations, string automationAccount, string credentialName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICredentialOperations)s).DeleteAsync(automationAccount, credentialName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Delete the credential.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='credentialName'>
        /// Required. The name of credential.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> DeleteAsync(this ICredentialOperations operations, string automationAccount, string credentialName)
        {
            return operations.DeleteAsync(automationAccount, credentialName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve the credential identified by credential name.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='credentialName'>
        /// Required. The name of credential.
        /// </param>
        /// <returns>
        /// The response model for the get credential operation.
        /// </returns>
        public static CredentialGetResponse Get(this ICredentialOperations operations, string automationAccount, string credentialName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICredentialOperations)s).GetAsync(automationAccount, credentialName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve the credential identified by credential name.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='credentialName'>
        /// Required. The name of credential.
        /// </param>
        /// <returns>
        /// The response model for the get credential operation.
        /// </returns>
        public static Task<CredentialGetResponse> GetAsync(this ICredentialOperations operations, string automationAccount, string credentialName)
        {
            return operations.GetAsync(automationAccount, credentialName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of credentials.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list credential operation.
        /// </returns>
        public static CredentialListResponse List(this ICredentialOperations operations, string automationAccount)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICredentialOperations)s).ListAsync(automationAccount);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of credentials.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <returns>
        /// The response model for the list credential operation.
        /// </returns>
        public static Task<CredentialListResponse> ListAsync(this ICredentialOperations operations, string automationAccount)
        {
            return operations.ListAsync(automationAccount, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve next list of credentials.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list credential operation.
        /// </returns>
        public static CredentialListResponse ListNext(this ICredentialOperations operations, string nextLink)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICredentialOperations)s).ListNextAsync(nextLink);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve next list of credentials.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='nextLink'>
        /// Required. The link to retrieve next set of items.
        /// </param>
        /// <returns>
        /// The response model for the list credential operation.
        /// </returns>
        public static Task<CredentialListResponse> ListNextAsync(this ICredentialOperations operations, string nextLink)
        {
            return operations.ListNextAsync(nextLink, CancellationToken.None);
        }
        
        /// <summary>
        /// Update a credential.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the update credential
        /// operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static AzureOperationResponse Update(this ICredentialOperations operations, string automationAccount, CredentialUpdateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICredentialOperations)s).UpdateAsync(automationAccount, parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Update a credential.  (see
        /// http://aka.ms/azureautomationsdk/credentialoperations for more
        /// information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICredentialOperations.
        /// </param>
        /// <param name='automationAccount'>
        /// Required. The automation account name.
        /// </param>
        /// <param name='parameters'>
        /// Required. The parameters supplied to the update credential
        /// operation.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        public static Task<AzureOperationResponse> UpdateAsync(this ICredentialOperations operations, string automationAccount, CredentialUpdateParameters parameters)
        {
            return operations.UpdateAsync(automationAccount, parameters, CancellationToken.None);
        }
    }
}
