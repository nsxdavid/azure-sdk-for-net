// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class SearchIndexerStatus
    {
        internal static SearchIndexerStatus DeserializeSearchIndexerStatus(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IndexerStatus status = default;
            IndexerExecutionResult lastResult = default;
            IReadOnlyList<IndexerExecutionResult> executionHistory = default;
            SearchIndexerLimits limits = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString().ToIndexerStatus();
                    continue;
                }
                if (property.NameEquals("lastResult"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        lastResult = null;
                        continue;
                    }
                    lastResult = IndexerExecutionResult.DeserializeIndexerExecutionResult(property.Value);
                    continue;
                }
                if (property.NameEquals("executionHistory"u8))
                {
                    List<IndexerExecutionResult> array = new List<IndexerExecutionResult>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(IndexerExecutionResult.DeserializeIndexerExecutionResult(item));
                    }
                    executionHistory = array;
                    continue;
                }
                if (property.NameEquals("limits"u8))
                {
                    limits = SearchIndexerLimits.DeserializeSearchIndexerLimits(property.Value);
                    continue;
                }
            }
            return new SearchIndexerStatus(status, lastResult, executionHistory, limits);
        }
    }
}
