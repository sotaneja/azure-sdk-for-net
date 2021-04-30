// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Monitor.Query.Models
{
    /// <summary> Describes the format of Error response. </summary>
    internal partial class ErrorResponseAutoGenerated
    {
        /// <summary> Initializes a new instance of ErrorResponseAutoGenerated. </summary>
        internal ErrorResponseAutoGenerated()
        {
        }

        /// <summary> Initializes a new instance of ErrorResponseAutoGenerated. </summary>
        /// <param name="code"> Error code. </param>
        /// <param name="message"> Error message indicating why the operation failed. </param>
        internal ErrorResponseAutoGenerated(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> Error code. </summary>
        public string Code { get; }
        /// <summary> Error message indicating why the operation failed. </summary>
        public string Message { get; }
    }
}
