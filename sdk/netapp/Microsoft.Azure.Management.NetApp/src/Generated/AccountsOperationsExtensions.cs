// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.NetApp
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for AccountsOperations.
    /// </summary>
    public static partial class AccountsOperationsExtensions
    {
            /// <summary>
            /// Describe all NetApp Accounts in a resource group
            /// </summary>
            /// <remarks>
            /// List and describe all NetApp accounts in the resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            public static IPage<NetAppAccount> List(this IAccountsOperations operations, string resourceGroupName)
            {
                return operations.ListAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Describe all NetApp Accounts in a resource group
            /// </summary>
            /// <remarks>
            /// List and describe all NetApp accounts in the resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetAppAccount>> ListAsync(this IAccountsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Describe a NetApp Account
            /// </summary>
            /// <remarks>
            /// Get the NetApp account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            public static NetAppAccount Get(this IAccountsOperations operations, string resourceGroupName, string accountName)
            {
                return operations.GetAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Describe a NetApp Account
            /// </summary>
            /// <remarks>
            /// Get the NetApp account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetAppAccount> GetAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a NetApp account
            /// </summary>
            /// <remarks>
            /// Create or update the specified NetApp account within the resource group
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// NetApp Account object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            public static NetAppAccount CreateOrUpdate(this IAccountsOperations operations, NetAppAccount body, string resourceGroupName, string accountName)
            {
                return operations.CreateOrUpdateAsync(body, resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a NetApp account
            /// </summary>
            /// <remarks>
            /// Create or update the specified NetApp account within the resource group
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// NetApp Account object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetAppAccount> CreateOrUpdateAsync(this IAccountsOperations operations, NetAppAccount body, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(body, resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a NetApp account
            /// </summary>
            /// <remarks>
            /// Delete the specified NetApp account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            public static void Delete(this IAccountsOperations operations, string resourceGroupName, string accountName)
            {
                operations.DeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a NetApp account
            /// </summary>
            /// <remarks>
            /// Delete the specified NetApp account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update a NetApp account
            /// </summary>
            /// <remarks>
            /// Patch the specified NetApp account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// NetApp Account object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            public static NetAppAccount Update(this IAccountsOperations operations, NetAppAccountPatch body, string resourceGroupName, string accountName)
            {
                return operations.UpdateAsync(body, resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a NetApp account
            /// </summary>
            /// <remarks>
            /// Patch the specified NetApp account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// NetApp Account object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetAppAccount> UpdateAsync(this IAccountsOperations operations, NetAppAccountPatch body, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateWithHttpMessagesAsync(body, resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create or update a NetApp account
            /// </summary>
            /// <remarks>
            /// Create or update the specified NetApp account within the resource group
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// NetApp Account object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            public static NetAppAccount BeginCreateOrUpdate(this IAccountsOperations operations, NetAppAccount body, string resourceGroupName, string accountName)
            {
                return operations.BeginCreateOrUpdateAsync(body, resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create or update a NetApp account
            /// </summary>
            /// <remarks>
            /// Create or update the specified NetApp account within the resource group
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// NetApp Account object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetAppAccount> BeginCreateOrUpdateAsync(this IAccountsOperations operations, NetAppAccount body, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateOrUpdateWithHttpMessagesAsync(body, resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a NetApp account
            /// </summary>
            /// <remarks>
            /// Delete the specified NetApp account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            public static void BeginDelete(this IAccountsOperations operations, string resourceGroupName, string accountName)
            {
                operations.BeginDeleteAsync(resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a NetApp account
            /// </summary>
            /// <remarks>
            /// Delete the specified NetApp account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task BeginDeleteAsync(this IAccountsOperations operations, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Update a NetApp account
            /// </summary>
            /// <remarks>
            /// Patch the specified NetApp account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// NetApp Account object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            public static NetAppAccount BeginUpdate(this IAccountsOperations operations, NetAppAccountPatch body, string resourceGroupName, string accountName)
            {
                return operations.BeginUpdateAsync(body, resourceGroupName, accountName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update a NetApp account
            /// </summary>
            /// <remarks>
            /// Patch the specified NetApp account
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// NetApp Account object supplied in the body of the operation.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group.
            /// </param>
            /// <param name='accountName'>
            /// The name of the NetApp account
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<NetAppAccount> BeginUpdateAsync(this IAccountsOperations operations, NetAppAccountPatch body, string resourceGroupName, string accountName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginUpdateWithHttpMessagesAsync(body, resourceGroupName, accountName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Describe all NetApp Accounts in a resource group
            /// </summary>
            /// <remarks>
            /// List and describe all NetApp accounts in the resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<NetAppAccount> ListNext(this IAccountsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Describe all NetApp Accounts in a resource group
            /// </summary>
            /// <remarks>
            /// List and describe all NetApp accounts in the resource group.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NetAppAccount>> ListNextAsync(this IAccountsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
