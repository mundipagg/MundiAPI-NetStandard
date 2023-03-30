// <copyright file="TokensController.cs" company="APIMatic">
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
    /// TokensController.
    /// </summary>
    internal class TokensController : BaseController, ITokensController
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokensController"/> class.
        /// </summary>
        internal TokensController(GlobalConfiguration globalConfiguration) : base(globalConfiguration) { }

        /// <summary>
        /// CreateToken EndPoint.
        /// </summary>
        /// <param name="publicKey">Required parameter: Public key.</param>
        /// <param name="request">Required parameter: Request for creating a token.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetTokenResponse response from the API call.</returns>
        public Models.GetTokenResponse CreateToken(
                string publicKey,
                Models.CreateTokenRequest request,
                string idempotencyKey = null)
            => CoreHelper.RunTask(CreateTokenAsync(publicKey, request, idempotencyKey));

        /// <summary>
        /// CreateToken EndPoint.
        /// </summary>
        /// <param name="publicKey">Required parameter: Public key.</param>
        /// <param name="request">Required parameter: Request for creating a token.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTokenResponse response from the API call.</returns>
        public async Task<Models.GetTokenResponse> CreateTokenAsync(
                string publicKey,
                Models.CreateTokenRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetTokenResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Post, "/tokens?appId={public_key}")
                  .Parameters(_parameters => _parameters
                      .Body(_bodyParameter => _bodyParameter.Setup(request))
                      .Template(_template => _template.Setup("public_key", publicKey))
                      .Header(_header => _header.Setup("idempotency-key", idempotencyKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetTokenResponse>(_response)))
              .ExecuteAsync(cancellationToken);

        /// <summary>
        /// Gets a token from its id.
        /// </summary>
        /// <param name="id">Required parameter: Token id.</param>
        /// <param name="publicKey">Required parameter: Public key.</param>
        /// <returns>Returns the Models.GetTokenResponse response from the API call.</returns>
        public Models.GetTokenResponse GetToken(
                string id,
                string publicKey)
            => CoreHelper.RunTask(GetTokenAsync(id, publicKey));

        /// <summary>
        /// Gets a token from its id.
        /// </summary>
        /// <param name="id">Required parameter: Token id.</param>
        /// <param name="publicKey">Required parameter: Public key.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTokenResponse response from the API call.</returns>
        public async Task<Models.GetTokenResponse> GetTokenAsync(
                string id,
                string publicKey,
                CancellationToken cancellationToken = default)
            => await CreateApiCall<Models.GetTokenResponse>()
              .RequestBuilder(_requestBuilder => _requestBuilder
                  .Setup(HttpMethod.Get, "/tokens/{id}?appId={public_key}")
                  .Parameters(_parameters => _parameters
                      .Template(_template => _template.Setup("id", id))
                      .Template(_template => _template.Setup("public_key", publicKey))))
              .ResponseHandler(_responseHandler => _responseHandler
                  .Deserializer(_response => ApiHelper.JsonDeserialize<Models.GetTokenResponse>(_response)))
              .ExecuteAsync(cancellationToken);
    }
}