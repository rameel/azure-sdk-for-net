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
using System.Collections.Generic;
using System.Linq;
using Hyak.Common;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// The properties of the create connection properties
    /// </summary>
    public partial class ConnectionCreateProperties
    {
        private ConnectionTypeAssociationProperty _connectionType;
        
        /// <summary>
        /// Required. Gets or sets the connectionType of the connection.
        /// </summary>
        public ConnectionTypeAssociationProperty ConnectionType
        {
            get { return this._connectionType; }
            set { this._connectionType = value; }
        }
        
        private string _description;
        
        /// <summary>
        /// Optional. Gets or sets the description of the connection.
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }
        
        private IDictionary<string, string> _fieldDefinitionValues;
        
        /// <summary>
        /// Optional. Gets or sets the field definition properties of the
        /// connection.
        /// </summary>
        public IDictionary<string, string> FieldDefinitionValues
        {
            get { return this._fieldDefinitionValues; }
            set { this._fieldDefinitionValues = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the ConnectionCreateProperties class.
        /// </summary>
        public ConnectionCreateProperties()
        {
            this.FieldDefinitionValues = new LazyDictionary<string, string>();
        }
        
        /// <summary>
        /// Initializes a new instance of the ConnectionCreateProperties class
        /// with required arguments.
        /// </summary>
        public ConnectionCreateProperties(ConnectionTypeAssociationProperty connectionType)
            : this()
        {
            if (connectionType == null)
            {
                throw new ArgumentNullException("connectionType");
            }
            this.ConnectionType = connectionType;
        }
    }
}
