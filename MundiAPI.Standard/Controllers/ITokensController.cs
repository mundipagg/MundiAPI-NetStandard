// <copyright file="ITokensController.cs" company="APIMatic">
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
    /// ITokensController.
    /// </summary>
    public interface ITokensController
    {
        /// <summary>
        /// CreateToken EndPoint.
        /// </summary>
        /// <param name="publicKey">Required parameter: Public key.</param>
        /// <param name="request">Required parameter: Request for creating a token.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <returns>Returns the Models.GetTokenResponse response from the API call.</returns>
        Models.GetTokenResponse CreateToken(
                string publicKey,
                Models.CreateTokenRequest request,
                string idempotencyKey = null);

        /// <summary>
        /// CreateToken EndPoint.
        /// </summary>
        /// <param name="publicKey">Required parameter: Public key.</param>
        /// <param name="request">Required parameter: Request for creating a token.</param>
        /// <param name="idempotencyKey">Optional parameter: Example: .</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTokenResponse response from the API call.</returns>
        Task<Models.GetTokenResponse> CreateTokenAsync(
                string publicKey,
                Models.CreateTokenRequest request,
                string idempotencyKey = null,
                CancellationToken cancellationToken = default);

        /// <summary>
        /// Gets a token from its id.
        /// </summary>
        /// <param name="id">Required parameter: Token id.</param>
        /// <param name="publicKey">Required parameter: Public key.</param>
        /// <returns>Returns the Models.GetTokenResponse response from the API call.</returns>
        Models.GetTokenResponse GetToken(
                string id,
                string publicKey);

        /// <summary>
        /// Gets a token from its id.
        /// </summary>
        /// <param name="id">Required parameter: Token id.</param>
        /// <param name="publicKey">Required parameter: Public key.</param>
        /// <param name="cancellationToken"> cancellationToken. </param>
        /// <returns>Returns the Models.GetTokenResponse response from the API call.</returns>
        Task<Models.GetTokenResponse> GetTokenAsync(
                string id,
                string publicKey,
                CancellationToken cancellationToken = default);
    }
}