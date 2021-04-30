// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Represents percentile metrics values. </summary>
    public partial class PercentileMetricValue : MetricValue
    {
        /// <summary> Initializes a new instance of PercentileMetricValue. </summary>
        internal PercentileMetricValue()
        {
        }

        /// <summary> Initializes a new instance of PercentileMetricValue. </summary>
        /// <param name="count"> The number of values for the metric. </param>
        /// <param name="average"> The average value of the metric. </param>
        /// <param name="maximum"> The max value of the metric. </param>
        /// <param name="minimum"> The min value of the metric. </param>
        /// <param name="timestamp"> The metric timestamp (ISO-8601 format). </param>
        /// <param name="total"> The total value of the metric. </param>
        /// <param name="p10"> The 10th percentile value for the metric. </param>
        /// <param name="p25"> The 25th percentile value for the metric. </param>
        /// <param name="p50"> The 50th percentile value for the metric. </param>
        /// <param name="p75"> The 75th percentile value for the metric. </param>
        /// <param name="p90"> The 90th percentile value for the metric. </param>
        /// <param name="p95"> The 95th percentile value for the metric. </param>
        /// <param name="p99"> The 99th percentile value for the metric. </param>
        internal PercentileMetricValue(int? count, double? average, double? maximum, double? minimum, DateTimeOffset? timestamp, double? total, double? p10, double? p25, double? p50, double? p75, double? p90, double? p95, double? p99) : base(count, average, maximum, minimum, timestamp, total)
        {
            P10 = p10;
            P25 = p25;
            P50 = p50;
            P75 = p75;
            P90 = p90;
            P95 = p95;
            P99 = p99;
        }

        /// <summary> The 10th percentile value for the metric. </summary>
        public double? P10 { get; }
        /// <summary> The 25th percentile value for the metric. </summary>
        public double? P25 { get; }
        /// <summary> The 50th percentile value for the metric. </summary>
        public double? P50 { get; }
        /// <summary> The 75th percentile value for the metric. </summary>
        public double? P75 { get; }
        /// <summary> The 90th percentile value for the metric. </summary>
        public double? P90 { get; }
        /// <summary> The 95th percentile value for the metric. </summary>
        public double? P95 { get; }
        /// <summary> The 99th percentile value for the metric. </summary>
        public double? P99 { get; }
    }
}
