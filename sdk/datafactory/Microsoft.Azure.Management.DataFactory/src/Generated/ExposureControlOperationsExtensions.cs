// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ExposureControlOperations.
    /// </summary>
    public static partial class ExposureControlOperationsExtensions
    {
            /// <summary>
            /// Get exposure control feature for specific location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationId'>
            /// The location identifier.
            /// </param>
            /// <param name='exposureControlRequest'>
            /// The exposure control request.
            /// </param>
            public static ExposureControlResponse GetFeatureValue(this IExposureControlOperations operations, string locationId, ExposureControlRequest exposureControlRequest)
            {
                return operations.GetFeatureValueAsync(locationId, exposureControlRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get exposure control feature for specific location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='locationId'>
            /// The location identifier.
            /// </param>
            /// <param name='exposureControlRequest'>
            /// The exposure control request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExposureControlResponse> GetFeatureValueAsync(this IExposureControlOperations operations, string locationId, ExposureControlRequest exposureControlRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFeatureValueWithHttpMessagesAsync(locationId, exposureControlRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get exposure control feature for specific factory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='exposureControlRequest'>
            /// The exposure control request.
            /// </param>
            public static ExposureControlResponse GetFeatureValueByFactory(this IExposureControlOperations operations, string resourceGroupName, string factoryName, ExposureControlRequest exposureControlRequest)
            {
                return operations.GetFeatureValueByFactoryAsync(resourceGroupName, factoryName, exposureControlRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get exposure control feature for specific factory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='exposureControlRequest'>
            /// The exposure control request.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExposureControlResponse> GetFeatureValueByFactoryAsync(this IExposureControlOperations operations, string resourceGroupName, string factoryName, ExposureControlRequest exposureControlRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetFeatureValueByFactoryWithHttpMessagesAsync(resourceGroupName, factoryName, exposureControlRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Get list of exposure control features for specific factory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='exposureControlBatchRequest'>
            /// The exposure control request for list of features.
            /// </param>
            public static ExposureControlBatchResponse QueryFeatureValuesByFactory(this IExposureControlOperations operations, string resourceGroupName, string factoryName, ExposureControlBatchRequest exposureControlBatchRequest)
            {
                return operations.QueryFeatureValuesByFactoryAsync(resourceGroupName, factoryName, exposureControlBatchRequest).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get list of exposure control features for specific factory.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The resource group name.
            /// </param>
            /// <param name='factoryName'>
            /// The factory name.
            /// </param>
            /// <param name='exposureControlBatchRequest'>
            /// The exposure control request for list of features.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<ExposureControlBatchResponse> QueryFeatureValuesByFactoryAsync(this IExposureControlOperations operations, string resourceGroupName, string factoryName, ExposureControlBatchRequest exposureControlBatchRequest, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.QueryFeatureValuesByFactoryWithHttpMessagesAsync(resourceGroupName, factoryName, exposureControlBatchRequest, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
