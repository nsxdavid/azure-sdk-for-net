// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    internal partial class ShortCodes
    {
        internal static ShortCodes DeserializeShortCodes(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ShortCode> shortCodes = default;
            string nextLink = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shortCodes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ShortCode> array = new List<ShortCode>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ShortCode.DeserializeShortCode(item));
                    }
                    shortCodes = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
            }
            return new ShortCodes(shortCodes ?? new ChangeTrackingList<ShortCode>(), nextLink);
        }
    }
}
