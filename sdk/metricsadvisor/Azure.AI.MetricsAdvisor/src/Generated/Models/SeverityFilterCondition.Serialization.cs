// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class SeverityFilterCondition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("min");
            writer.WriteStringValue(Min.ToString());
            writer.WritePropertyName("max");
            writer.WriteStringValue(Max.ToString());
            writer.WriteEndObject();
        }
    }
}
