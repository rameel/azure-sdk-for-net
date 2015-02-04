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

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Information about the cloud service settings.
    /// </summary>
    public partial class CloudServiceSettings
    {
        private string _geoRegion;
        
        /// <summary>
        /// Required. Gets or sets the region for the account.
        /// </summary>
        public string GeoRegion
        {
            get { return this._geoRegion; }
            set { this._geoRegion = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the CloudServiceSettings class.
        /// </summary>
        public CloudServiceSettings()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the CloudServiceSettings class with
        /// required arguments.
        /// </summary>
        public CloudServiceSettings(string geoRegion)
            : this()
        {
            if (geoRegion == null)
            {
                throw new ArgumentNullException("geoRegion");
            }
            this.GeoRegion = geoRegion;
        }
    }
}
