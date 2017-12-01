// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Automation.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Automation;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The parameters supplied to the create or update connection type
    /// operation.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ConnectionTypeCreateOrUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ConnectionTypeCreateOrUpdateParameters class.
        /// </summary>
        public ConnectionTypeCreateOrUpdateParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ConnectionTypeCreateOrUpdateParameters class.
        /// </summary>
        /// <param name="name">Gets or sets the name of the connection
        /// type.</param>
        /// <param name="fieldDefinitions">Gets or sets the field definitions
        /// of the connection type.</param>
        /// <param name="isGlobal">Gets or sets a Boolean value to indicate if
        /// the connection type is global.</param>
        public ConnectionTypeCreateOrUpdateParameters(string name, IDictionary<string, FieldDefinition> fieldDefinitions, bool? isGlobal = default(bool?))
        {
            Name = name;
            IsGlobal = isGlobal;
            FieldDefinitions = fieldDefinitions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the connection type.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets a Boolean value to indicate if the connection type is
        /// global.
        /// </summary>
        [JsonProperty(PropertyName = "properties.isGlobal")]
        public bool? IsGlobal { get; set; }

        /// <summary>
        /// Gets or sets the field definitions of the connection type.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fieldDefinitions")]
        public IDictionary<string, FieldDefinition> FieldDefinitions { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
            if (FieldDefinitions == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "FieldDefinitions");
            }
            if (FieldDefinitions != null)
            {
                foreach (var valueElement in FieldDefinitions.Values)
                {
                    if (valueElement != null)
                    {
                        valueElement.Validate();
                    }
                }
            }
        }
    }
}
