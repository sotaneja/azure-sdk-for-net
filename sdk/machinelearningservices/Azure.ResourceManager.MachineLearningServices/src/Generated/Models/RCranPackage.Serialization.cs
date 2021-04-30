// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class RCranPackage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Repository))
            {
                writer.WritePropertyName("repository");
                writer.WriteStringValue(Repository);
            }
            writer.WriteEndObject();
        }

        internal static RCranPackage DeserializeRCranPackage(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> repository = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("repository"))
                {
                    repository = property.Value.GetString();
                    continue;
                }
            }
            return new RCranPackage(name.Value, repository.Value);
        }
    }
}
