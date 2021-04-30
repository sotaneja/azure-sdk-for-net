// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices.Models
{
    public partial class PersonalComputeInstanceSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AssignedUser))
            {
                writer.WritePropertyName("assignedUser");
                writer.WriteObjectValue(AssignedUser);
            }
            writer.WriteEndObject();
        }

        internal static PersonalComputeInstanceSettings DeserializePersonalComputeInstanceSettings(JsonElement element)
        {
            Optional<AssignedUser> assignedUser = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("assignedUser"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    assignedUser = AssignedUser.DeserializeAssignedUser(property.Value);
                    continue;
                }
            }
            return new PersonalComputeInstanceSettings(assignedUser.Value);
        }
    }
}
