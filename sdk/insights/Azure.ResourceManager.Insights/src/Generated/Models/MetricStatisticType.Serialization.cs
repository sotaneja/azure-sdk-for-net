// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Insights.Models
{
    internal static partial class MetricStatisticTypeExtensions
    {
        public static string ToSerialString(this MetricStatisticType value) => value switch
        {
            MetricStatisticType.Average => "Average",
            MetricStatisticType.Min => "Min",
            MetricStatisticType.Max => "Max",
            MetricStatisticType.Sum => "Sum",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MetricStatisticType value.")
        };

        public static MetricStatisticType ToMetricStatisticType(this string value)
        {
            if (string.Equals(value, "Average", StringComparison.InvariantCultureIgnoreCase)) return MetricStatisticType.Average;
            if (string.Equals(value, "Min", StringComparison.InvariantCultureIgnoreCase)) return MetricStatisticType.Min;
            if (string.Equals(value, "Max", StringComparison.InvariantCultureIgnoreCase)) return MetricStatisticType.Max;
            if (string.Equals(value, "Sum", StringComparison.InvariantCultureIgnoreCase)) return MetricStatisticType.Sum;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MetricStatisticType value.");
        }
    }
}
