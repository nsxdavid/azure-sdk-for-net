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
    /// Definition of the job stream.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class JobStream
    {
        /// <summary>
        /// Initializes a new instance of the JobStream class.
        /// </summary>
        public JobStream()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobStream class.
        /// </summary>
        /// <param name="id">Gets or sets the id of the resource.</param>
        /// <param name="jobStreamId">Gets or sets the id of the job
        /// stream.</param>
        /// <param name="time">Gets or sets the creation time of the
        /// job.</param>
        /// <param name="streamType">Gets or sets the stream type. Possible
        /// values include: 'Progress', 'Output', 'Warning', 'Error', 'Debug',
        /// 'Verbose', 'Any'</param>
        /// <param name="streamText">Gets or sets the stream text.</param>
        /// <param name="summary">Gets or sets the summary.</param>
        /// <param name="value">Gets or sets the values of the job
        /// stream.</param>
        public JobStream(string id = default(string), string jobStreamId = default(string), System.DateTime? time = default(System.DateTime?), string streamType = default(string), string streamText = default(string), string summary = default(string), IDictionary<string, object> value = default(IDictionary<string, object>))
        {
            Id = id;
            JobStreamId = jobStreamId;
            Time = time;
            StreamType = streamType;
            StreamText = streamText;
            Summary = summary;
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the id of the resource.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the id of the job stream.
        /// </summary>
        [JsonProperty(PropertyName = "properties.jobStreamId")]
        public string JobStreamId { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the job.
        /// </summary>
        [JsonProperty(PropertyName = "properties.time")]
        public System.DateTime? Time { get; set; }

        /// <summary>
        /// Gets or sets the stream type. Possible values include: 'Progress',
        /// 'Output', 'Warning', 'Error', 'Debug', 'Verbose', 'Any'
        /// </summary>
        [JsonProperty(PropertyName = "properties.streamType")]
        public string StreamType { get; set; }

        /// <summary>
        /// Gets or sets the stream text.
        /// </summary>
        [JsonProperty(PropertyName = "properties.streamText")]
        public string StreamText { get; set; }

        /// <summary>
        /// Gets or sets the summary.
        /// </summary>
        [JsonProperty(PropertyName = "properties.summary")]
        public string Summary { get; set; }

        /// <summary>
        /// Gets or sets the values of the job stream.
        /// </summary>
        [JsonProperty(PropertyName = "properties.value")]
        public IDictionary<string, object> Value { get; set; }

    }
}
