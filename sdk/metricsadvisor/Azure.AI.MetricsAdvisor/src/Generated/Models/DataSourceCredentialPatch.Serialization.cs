// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.AI.MetricsAdvisor.Models
{
    internal partial class DataSourceCredentialPatch : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("dataSourceCredentialType");
            writer.WriteStringValue(DataSourceCredentialType.ToString());
            if (Optional.IsDefined(DataSourceCredentialName))
            {
                writer.WritePropertyName("dataSourceCredentialName");
                writer.WriteStringValue(DataSourceCredentialName);
            }
            if (Optional.IsDefined(DataSourceCredentialDescription))
            {
                writer.WritePropertyName("dataSourceCredentialDescription");
                writer.WriteStringValue(DataSourceCredentialDescription);
            }
            writer.WriteEndObject();
        }
    }
}
