// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    public partial class NumericVariable : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("value");
            writer.WriteObjectValue(Value);
            if (Optional.IsDefined(Interpolation))
            {
                writer.WritePropertyName("interpolation");
                writer.WriteObjectValue(Interpolation);
            }
            writer.WritePropertyName("aggregation");
            writer.WriteObjectValue(Aggregation);
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind);
            if (Optional.IsDefined(Filter))
            {
                writer.WritePropertyName("filter");
                writer.WriteObjectValue(Filter);
            }
            writer.WriteEndObject();
        }

        internal static NumericVariable DeserializeNumericVariable(JsonElement element)
        {
            TimeSeriesExpression value = default;
            Optional<InterpolationOperation> interpolation = default;
            TimeSeriesExpression aggregation = default;
            string kind = default;
            Optional<TimeSeriesExpression> filter = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = TimeSeriesExpression.DeserializeTimeSeriesExpression(property.Value);
                    continue;
                }
                if (property.NameEquals("interpolation"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    interpolation = InterpolationOperation.DeserializeInterpolationOperation(property.Value);
                    continue;
                }
                if (property.NameEquals("aggregation"))
                {
                    aggregation = TimeSeriesExpression.DeserializeTimeSeriesExpression(property.Value);
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filter"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    filter = TimeSeriesExpression.DeserializeTimeSeriesExpression(property.Value);
                    continue;
                }
            }
            return new NumericVariable(kind, filter.Value, value, interpolation.Value, aggregation);
        }
    }
}
