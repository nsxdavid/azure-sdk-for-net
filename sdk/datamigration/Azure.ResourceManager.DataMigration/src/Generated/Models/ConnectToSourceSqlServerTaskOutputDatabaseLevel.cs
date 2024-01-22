// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Database level output for the task that validates connection to SQL Server and also validates source server requirements. </summary>
    public partial class ConnectToSourceSqlServerTaskOutputDatabaseLevel : ConnectToSourceSqlServerTaskOutput
    {
        /// <summary> Initializes a new instance of <see cref="ConnectToSourceSqlServerTaskOutputDatabaseLevel"/>. </summary>
        internal ConnectToSourceSqlServerTaskOutputDatabaseLevel()
        {
            DatabaseFiles = new ChangeTrackingList<DatabaseFileInfo>();
            ResultType = "DatabaseLevelOutput";
        }

        /// <summary> Initializes a new instance of <see cref="ConnectToSourceSqlServerTaskOutputDatabaseLevel"/>. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Type of result - database level or task level. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="name"> Database name. </param>
        /// <param name="sizeMB"> Size of the file in megabytes. </param>
        /// <param name="databaseFiles"> The list of database files. </param>
        /// <param name="compatibilityLevel"> SQL Server compatibility level of database. </param>
        /// <param name="databaseState"> State of the database. </param>
        internal ConnectToSourceSqlServerTaskOutputDatabaseLevel(string id, string resultType, IDictionary<string, BinaryData> serializedAdditionalRawData, string name, double? sizeMB, IReadOnlyList<DatabaseFileInfo> databaseFiles, DatabaseCompatLevel? compatibilityLevel, DatabaseState? databaseState) : base(id, resultType, serializedAdditionalRawData)
        {
            Name = name;
            SizeMB = sizeMB;
            DatabaseFiles = databaseFiles;
            CompatibilityLevel = compatibilityLevel;
            DatabaseState = databaseState;
            ResultType = resultType ?? "DatabaseLevelOutput";
        }

        /// <summary> Database name. </summary>
        public string Name { get; }
        /// <summary> Size of the file in megabytes. </summary>
        public double? SizeMB { get; }
        /// <summary> The list of database files. </summary>
        public IReadOnlyList<DatabaseFileInfo> DatabaseFiles { get; }
        /// <summary> SQL Server compatibility level of database. </summary>
        public DatabaseCompatLevel? CompatibilityLevel { get; }
        /// <summary> State of the database. </summary>
        public DatabaseState? DatabaseState { get; }
    }
}
