// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateSsisTaskOutputMigrationLevel. </summary>
    public partial class MigrateSsisTaskOutputMigrationLevel : MigrateSsisTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="MigrateSsisTaskOutputMigrationLevel"/>. </summary>
        internal MigrateSsisTaskOutputMigrationLevel()
        {
            ExceptionsAndWarnings = new ChangeTrackingList<ReportableException>();
            ResultType = "MigrationLevelOutput";
        }

        /// <summary> Initializes a new instance of <see cref="MigrateSsisTaskOutputMigrationLevel"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="startedOn"> Migration start time. </param>
        /// <param name="endedOn"> Migration end time. </param>
        /// <param name="status"> Current status of migration. </param>
        /// <param name="message"> Migration progress message. </param>
        /// <param name="sourceServerVersion"> Source server version. </param>
        /// <param name="sourceServerBrandVersion"> Source server brand version. </param>
        /// <param name="targetServerVersion"> Target server version. </param>
        /// <param name="targetServerBrandVersion"> Target server brand version. </param>
        /// <param name="exceptionsAndWarnings"> Migration exceptions and warnings. </param>
        /// <param name="stage"> Stage of SSIS migration. </param>
        internal MigrateSsisTaskOutputMigrationLevel(string id, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData, DateTimeOffset? startedOn, DateTimeOffset? endedOn, MigrationStatus? status, string message, string sourceServerVersion, string sourceServerBrandVersion, string targetServerVersion, string targetServerBrandVersion, IReadOnlyList<ReportableException> exceptionsAndWarnings, SsisMigrationStage? stage) : base(id, resultType, serializedAdditionalRawData)
        {
            StartedOn = startedOn;
            EndedOn = endedOn;
            Status = status;
            Message = message;
            SourceServerVersion = sourceServerVersion;
            SourceServerBrandVersion = sourceServerBrandVersion;
            TargetServerVersion = targetServerVersion;
            TargetServerBrandVersion = targetServerBrandVersion;
            ExceptionsAndWarnings = exceptionsAndWarnings;
            Stage = stage;
            ResultType = resultType ?? "MigrationLevelOutput";
        }

        /// <summary> Migration start time. </summary>
        public DateTimeOffset? StartedOn { get; }
        /// <summary> Migration end time. </summary>
        public DateTimeOffset? EndedOn { get; }
        /// <summary> Current status of migration. </summary>
        public MigrationStatus? Status { get; }
        /// <summary> Migration progress message. </summary>
        public string Message { get; }
        /// <summary> Source server version. </summary>
        public string SourceServerVersion { get; }
        /// <summary> Source server brand version. </summary>
        public string SourceServerBrandVersion { get; }
        /// <summary> Target server version. </summary>
        public string TargetServerVersion { get; }
        /// <summary> Target server brand version. </summary>
        public string TargetServerBrandVersion { get; }
        /// <summary> Migration exceptions and warnings. </summary>
        public IReadOnlyList<ReportableException> ExceptionsAndWarnings { get; }
        /// <summary> Stage of SSIS migration. </summary>
        public SsisMigrationStage? Stage { get; }
    }
}
