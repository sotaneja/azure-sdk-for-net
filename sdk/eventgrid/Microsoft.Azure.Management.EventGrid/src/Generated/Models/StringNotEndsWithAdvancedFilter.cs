// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventGrid.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// StringNotEndsWith Advanced Filter.
    /// </summary>
    [Newtonsoft.Json.JsonObject("StringNotEndsWith")]
    public partial class StringNotEndsWithAdvancedFilter : AdvancedFilter
    {
        /// <summary>
        /// Initializes a new instance of the StringNotEndsWithAdvancedFilter
        /// class.
        /// </summary>
        public StringNotEndsWithAdvancedFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the StringNotEndsWithAdvancedFilter
        /// class.
        /// </summary>
        /// <param name="key">The field/property in the event based on which
        /// you want to filter.</param>
        /// <param name="values">The set of filter values.</param>
        public StringNotEndsWithAdvancedFilter(string key = default(string), IList<string> values = default(IList<string>))
            : base(key)
        {
            Values = values;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the set of filter values.
        /// </summary>
        [JsonProperty(PropertyName = "values")]
        public IList<string> Values { get; set; }

    }
}
