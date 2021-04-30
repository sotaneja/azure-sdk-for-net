// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> Set value to &apos;ResultAccount&apos;. </summary>
    public readonly partial struct QueryType : IEquatable<QueryType>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="QueryType"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public QueryType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ResultCountValue = "ResultCount";

        /// <summary> ResultCount. </summary>
        public static QueryType ResultCount { get; } = new QueryType(ResultCountValue);
        /// <summary> Determines if two <see cref="QueryType"/> values are the same. </summary>
        public static bool operator ==(QueryType left, QueryType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="QueryType"/> values are not the same. </summary>
        public static bool operator !=(QueryType left, QueryType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="QueryType"/>. </summary>
        public static implicit operator QueryType(string value) => new QueryType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is QueryType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(QueryType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
