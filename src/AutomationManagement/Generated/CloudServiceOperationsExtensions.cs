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
using Microsoft.Azure.Management.Automation;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation
{
    public static partial class CloudServiceOperationsExtensions
    {
        /// <summary>
        /// Create a cloud service.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICloudServiceOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create cloud Service operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static LongRunningOperationStatusResponse BeginCreate(this ICloudServiceOperations operations, CloudServiceCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICloudServiceOperations)s).BeginCreateAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a cloud service.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICloudServiceOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create cloud Service operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static Task<LongRunningOperationStatusResponse> BeginCreateAsync(this ICloudServiceOperations operations, CloudServiceCreateParameters parameters)
        {
            return operations.BeginCreateAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Create a cloud service.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICloudServiceOperations.
        /// </param>
        /// <param name='clouldServiceName'>
        /// Required. Cloud service name.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static LongRunningOperationStatusResponse BeginDelete(this ICloudServiceOperations operations, string clouldServiceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICloudServiceOperations)s).BeginDeleteAsync(clouldServiceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a cloud service.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICloudServiceOperations.
        /// </param>
        /// <param name='clouldServiceName'>
        /// Required. Cloud service name.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static Task<LongRunningOperationStatusResponse> BeginDeleteAsync(this ICloudServiceOperations operations, string clouldServiceName)
        {
            return operations.BeginDeleteAsync(clouldServiceName, CancellationToken.None);
        }
        
        /// <summary>
        /// Create a cloud service.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICloudServiceOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create cloud service operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static LongRunningOperationStatusResponse Create(this ICloudServiceOperations operations, CloudServiceCreateParameters parameters)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICloudServiceOperations)s).CreateAsync(parameters);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a cloud service.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICloudServiceOperations.
        /// </param>
        /// <param name='parameters'>
        /// Required. Parameters supplied to the Create cloud service operation.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static Task<LongRunningOperationStatusResponse> CreateAsync(this ICloudServiceOperations operations, CloudServiceCreateParameters parameters)
        {
            return operations.CreateAsync(parameters, CancellationToken.None);
        }
        
        /// <summary>
        /// Create a cloud service.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICloudServiceOperations.
        /// </param>
        /// <param name='clouldServiceName'>
        /// Required. Cloud service name.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static LongRunningOperationStatusResponse Delete(this ICloudServiceOperations operations, string clouldServiceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICloudServiceOperations)s).DeleteAsync(clouldServiceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Create a cloud service.
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICloudServiceOperations.
        /// </param>
        /// <param name='clouldServiceName'>
        /// Required. Cloud service name.
        /// </param>
        /// <returns>
        /// The response body contains the status of the specified asynchronous
        /// operation, indicating whether it has succeeded, is inprogress, or
        /// has failed. Note that this status is distinct from the HTTP status
        /// code returned for the Get Operation Status operation itself.  If
        /// the asynchronous operation succeeded, the response body includes
        /// the HTTP status code for the successful request.  If the
        /// asynchronous operation failed, the response body includes the HTTP
        /// status code for the failed request, and also includes error
        /// information regarding the failure.
        /// </returns>
        public static Task<LongRunningOperationStatusResponse> DeleteAsync(this ICloudServiceOperations operations, string clouldServiceName)
        {
            return operations.DeleteAsync(clouldServiceName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a  Cloud services  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICloudServiceOperations.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Required. Cloud service name.
        /// </param>
        /// <returns>
        /// The response model for the get cloud service operation.
        /// </returns>
        public static CloudServiceGetResponse Get(this ICloudServiceOperations operations, string cloudServiceName)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICloudServiceOperations)s).GetAsync(cloudServiceName);
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a  Cloud services  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICloudServiceOperations.
        /// </param>
        /// <param name='cloudServiceName'>
        /// Required. Cloud service name.
        /// </param>
        /// <returns>
        /// The response model for the get cloud service operation.
        /// </returns>
        public static Task<CloudServiceGetResponse> GetAsync(this ICloudServiceOperations operations, string cloudServiceName)
        {
            return operations.GetAsync(cloudServiceName, CancellationToken.None);
        }
        
        /// <summary>
        /// Retrieve a list of Cloud services  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICloudServiceOperations.
        /// </param>
        /// <returns>
        /// The response model for the list cloud service operation.
        /// </returns>
        public static CloudServiceListResponse List(this ICloudServiceOperations operations)
        {
            return Task.Factory.StartNew((object s) => 
            {
                return ((ICloudServiceOperations)s).ListAsync();
            }
            , operations, CancellationToken.None, TaskCreationOptions.None, TaskScheduler.Default).Unwrap().GetAwaiter().GetResult();
        }
        
        /// <summary>
        /// Retrieve a list of Cloud services  (see
        /// http://msdn.microsoft.com/en-us/library/windowsazure/XXXXXXX.aspx
        /// for more information)
        /// </summary>
        /// <param name='operations'>
        /// Reference to the
        /// Microsoft.Azure.Management.Automation.ICloudServiceOperations.
        /// </param>
        /// <returns>
        /// The response model for the list cloud service operation.
        /// </returns>
        public static Task<CloudServiceListResponse> ListAsync(this ICloudServiceOperations operations)
        {
            return operations.ListAsync(CancellationToken.None);
        }
    }
}
