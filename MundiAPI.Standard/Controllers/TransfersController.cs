// <copyright file="TransfersController.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace MundiAPI.Standard.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Globalization;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;
    using APIMatic.Core;
    using APIMatic.Core.Types;
    using APIMatic.Core.Utilities;
    using APIMatic.Core.Utilities.Date.Xml;
    using MundiAPI.Standard;
    using MundiAPI.Standard.Authentication;
    using MundiAPI.Standard.Http.Client;
    using MundiAPI.Standard.Utilities;
    using Newtonsoft.Json.Converters;
    using System.Net.Http;

    /// <summary>
    /// TransfersController.
    /// </summary>
    internal class TransfersController : BaseController, ITransfersController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransfersController"/> class.
        /// </summary>
        internal TransfersController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// CreateTransfer EndPoint.
        /// </summary>
        /// <param name="request">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetTransfer response from the API call.</returns>
        public Models.GetTransfer CreateTransfer(
                Models.CreateTransfer request)
            => CoreHelper.RunTask(CreateTransferAsync(request));

        /// <summary>
        /// CreateTransfer EndPoint.
        /// </summary>
        /// <param name="request">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTransfer response from the API call.</returns>
        public async Task<Models.GetTransfer> CreateTransferAsync(
                Models.CreateTransfer request,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetTransfer>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/transfers/recipients")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetTransfer>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// GetTransferById EndPoint.
        /// </summary>
        /// <param name="transferId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetTransfer response from the API call.</returns>
        public Models.GetTransfer GetTransferById(
                string transferId)
            => CoreHelper.RunTask(GetTransferByIdAsync(transferId));

        /// <summary>
        /// GetTransferById EndPoint.
        /// </summary>
        /// <param name="transferId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTransfer response from the API call.</returns>
        public async Task<Models.GetTransfer> GetTransferByIdAsync(
                string transferId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetTransfer>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transfers/{transfer_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("transfer_id", transferId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetTransfer>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Gets all transfers.
        /// </summary>
        /// <returns>Returns the Models.ListTransfers response from the API call.</returns>
        public Models.ListTransfers GetTransfers()
            => CoreHelper.RunTask(GetTransfersAsync());

        /// <summary>
        /// Gets all transfers.
        /// </summary>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.ListTransfers response from the API call.</returns>
        public async Task<Models.ListTransfers> GetTransfersAsync(CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.ListTransfers>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transfers")
                  .WithAuth("global"))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.ListTransfers>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}