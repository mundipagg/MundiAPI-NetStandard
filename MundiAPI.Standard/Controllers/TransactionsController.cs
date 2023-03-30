// <copyright file="TransactionsController.cs" company="APIMatic">
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
    /// TransactionsController.
    /// </summary>
    internal class TransactionsController : BaseController, ITransactionsController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionsController"/> class.
        /// </summary>
        internal TransactionsController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// GetTransaction EndPoint.
        /// </summary>
        /// <param name="transactionId">Required parameter: Example: .</param>
        /// <returns>Returns the Models.GetTransactionResponse response from the API call.</returns>
        public Models.GetTransactionResponse GetTransaction(
                string transactionId)
            => CoreHelper.RunTask(GetTransactionAsync(transactionId));

        /// <summary>
        /// GetTransaction EndPoint.
        /// </summary>
        /// <param name="transactionId">Required parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTransactionResponse response from the API call.</returns>
        public async Task<Models.GetTransactionResponse> GetTransactionAsync(
                string transactionId,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetTransactionResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/transactions/{transaction_id}")
                  .WithAuth("global")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("transaction_id", transactionId))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetTransactionResponse>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}