// <copyright file="ITransfersController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using MundiAPI.Standard;
    using MundiAPI.Standard.Http.Client;
    using MundiAPI.Standard.Http.Request;
    using MundiAPI.Standard.Http.Response;
    using MundiAPI.Standard.Utilities;

    /// <summary>
    /// ITransfersController.
    /// </summary>
    public interface ITransfersController
    {
        /// <summary>
        /// CreateTransfer EndPoint.
        /// </summary>
        /// <param name="request">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetTransfer response from the API call.</returns>
        Models.GetTransfer CreateTransfer(
                Models.CreateTransfer request);

        /// <summary>
        /// CreateTransfer EndPoint.
        /// </summary>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTransfer response from the API call.</returns>
        Task<Models.GetTransfer> CreateTransferAsync(
                Models.CreateTransfer request,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// GetTransferById EndPoint.
        /// </summary>
        /// <param name="transferId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetTransfer response from the API call.</returns>
        Models.GetTransfer GetTransferById(
                string transferId);

        /// <summary>
        /// GetTransferById EndPoint.
        /// </summary>
        /// <param name="transferId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTransfer response from the API call.</returns>
        Task<Models.GetTransfer> GetTransferByIdAsync(
                string transferId,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets all transfers.
        /// </summary>
        /// <returns>Returns the Models.ListTransfers response from the API call.</returns>
        Models.ListTransfers GetTransfers();

        /// <summary>
        /// Gets all transfers.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListTransfers response from the API call.</returns>
        Task<Models.ListTransfers> GetTransfersAsync(CancellationToken cancellationToken = default);
    }
}