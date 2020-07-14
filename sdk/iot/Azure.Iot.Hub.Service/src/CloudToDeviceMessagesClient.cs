// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.Iot.Hub.Service
{
    /// <summary>
    /// C2D Messages Client place holder
    /// </summary>
    public class CloudToDeviceMessagesClient
    {
        private readonly ServiceRestClient _serviceRestClient;

        protected CloudToDeviceMessagesClient()
        {
        }

        internal CloudToDeviceMessagesClient(ServiceRestClient serviceRestClient)
        {
            Argument.AssertNotNull(serviceRestClient, nameof(serviceRestClient));

            _serviceRestClient = serviceRestClient;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Task<Response> SendDeviceCommandAsync(CancellationToken cancellationToken = default)
        {
            return _serviceRestClient.SendDeviceCommandAsync(cancellationToken);
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        public virtual Response SendDeviceCommand(CancellationToken cancellationToken = default)
        {
            return _serviceRestClient.SendDeviceCommand(cancellationToken);
        }
    }
}
